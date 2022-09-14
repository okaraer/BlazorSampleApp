using AutoMapper;
using BlazorApp.Data;
using BlazorApp.Shared.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Server.Controllers
{


    [ApiController]
    [Route("[controller]")]
    public class FirmaController : ControllerBase
    {

        private readonly BlazorAppDbContext _context;
        private readonly ILogger<FirmaController> _logger;
        private readonly IMapper _mapper;

        public FirmaController(BlazorAppDbContext context, ILogger<FirmaController> logger, IMapper mapper)
        {
            _context = context;
            _logger = logger;
            _mapper = mapper;
        }


        [HttpPost("GetAll")]
        public async Task<PageResult<FirmaDto>> GetAll(InputDto input)
        {
            try
            {
                var queryable = (from firma in _context.Firmalar.AsNoTracking()
                                 orderby firma.FirmaAdi ascending
                                 where firma.IsDeleted == false
                                 select firma
                 ).AsQueryable();

                if (!string.IsNullOrEmpty(input.Search))
                {
                    queryable = queryable.Where(m => m.FirmaAdi.Contains(input.Search) || m.Telefon.Contains(input.Search) || m.Eposta.Contains(input.Search));
                }

                var result = await queryable.Skip((input.PageNumber - 1) * input.PageSize).Take(input.PageSize).ToListAsync();


                return new PageResult<FirmaDto>
                {
                    Items = _mapper.Map<IEnumerable<FirmaDto>>(result),
                    TotalCount = await queryable.CountAsync()

                };

            }
            catch (Exception e)
            {
                _logger.LogError("Hata :", e);
                throw;
            }
        }

        [HttpGet("Detay")]
        public async Task<FirmaDetayDto> GetDetay(int firmaId)
        {
            try
            {
                var dto = new FirmaDetayDto();
                var firma = await _context.Firmalar.FirstOrDefaultAsync(p => p.Id == firmaId);
                dto.Firma = _mapper.Map<FirmaDto>(firma);

                if (firma is not null)
                {
                    var personeller = _context.Personel.Where(p => p.fk_firma == firma.Id).OrderByDescending(p => p.IsFirmaYetkilisi).AsEnumerable();
                    dto.PersonelListesi = _mapper.Map<IEnumerable<PersonelDto>>(personeller);
                }

                return dto;

            }
            catch (Exception e)
            {
                _logger.LogError("Hata :", e);
                throw;
            }
        }



    }
}
