using AutoMapper;
using MDC.Desafio.Domain.Entities;
using MDC.Desafio.Domain.Entities.ValueObjects;
using MDC.Desafio.Presentation.Models;

namespace MDC.Desafio.Presentation.Mappers
{
    public class ViewModelToDomain : Profile
    {
        public ViewModelToDomain()
        {
            CreateMap<PersonViewModel, Address>();
            CreateMap<PersonViewModel, Person>()
                .ForMember(dest => dest.Address, opt =>
                    opt.MapFrom(src => src));
            
        }
    }
}
