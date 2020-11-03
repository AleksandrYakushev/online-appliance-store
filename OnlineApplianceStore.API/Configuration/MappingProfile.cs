using AutoMapper;
using OnlineApplianceStore.Business.Models.Input;
using OnlineApplianceStore.Business.Models.Output;
using OnlineApplianceStore.Data.DTO;
using System;
using System.Globalization;

namespace OnlineApplianceStore.API.Configuration
{
    public class MappingProfile : Profile
    {
        private const string _shortDateFormat = "dd.MM.yyyy";
        private const string _longDateFormat = "dd.MM.yyyy HH:mm:ss";

        public MappingProfile()
        {
            CreateMap<CustomerInputModel, CustomerDto>()
                .ForPath(dest => dest.Birthday, o => o.MapFrom(src => DateTime.ParseExact(src.Birthday, _shortDateFormat, CultureInfo.InvariantCulture)))
                //.ForPath(dest => dest.Password, o => o.MapFrom(src => BCryptHashing.HashPassword(src.Password)))
                .ForPath(dest => dest.City, o => o.MapFrom(src => new CityDto() { Id = src.CityId }));

            CreateMap<CustomerDto, CustomerOutputModel>()
                .ForPath(dest => dest.Birthday, o => o.MapFrom(src => src.Birthday.ToString(_shortDateFormat)))
                .ForPath(dest => dest.RegistrationDate, o => o.MapFrom(src => src.RegistrationDate.ToString(_longDateFormat)))
                .ForPath(dest => dest.LastUpdateDate, o => o.MapFrom(src => src.LastUpdateDate.ToString(_longDateFormat)));
        }

    }
}
