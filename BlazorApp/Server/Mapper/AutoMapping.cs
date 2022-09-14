using AutoMapper;
using BlazorApp.Data.Entities;
using BlazorApp.Shared.DTO;
using System.Collections.ObjectModel;

namespace BlazorApp.Server.Mapper
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Firmalar, FirmaDto>()
                .ForMember(p => p.Eposta, c => c.MapFrom(s => s.Eposta.ToLower()));

            CreateMap<Personel, PersonelDto>()
                .ForMember(p => p.Eposta, c => c.MapFrom(s => s.Eposta.ToLower()))
                .ForMember(p => p.AdiSoyadi, c => c.MapFrom(s => s.Adi + " " + s.Soyadi));
        }
    }
}
