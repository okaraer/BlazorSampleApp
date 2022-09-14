using AutoMapper;
using BlazorApp.Data;
using BlazorApp.Shared.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Server.Controllers
{


    [ApiController]
    [Route("[controller]")]
    public class PersonelController : ControllerBase
    {

        private readonly BlazorAppDbContext _context;
        private readonly ILogger<PersonelController> _logger;
        private readonly IMapper _mapper;

        public PersonelController(BlazorAppDbContext context, ILogger<PersonelController> logger, IMapper mapper)
        {
            _context = context;
            _logger = logger;
            _mapper = mapper;
        }


        [HttpGet]
        public IEnumerable<PersonelDto> Get()
        {
            try
            {
                var ent = _context.Personel
                    .Include(p => p.Firmalar)
                    .AsEnumerable();


                return _mapper.Map<IEnumerable<PersonelDto>>(ent).ToList();
            }
            catch (Exception e)
            {
                _logger.LogError("Hata :", e);
                throw;
            }
        }
    }
}
