using AutoMapper;
using MDC.Desafio.Domain.Entities;
using MDC.Desafio.Domain.Entities.ValueObjects;
using MDC.Desafio.Presentation.Models;

namespace MDC.Desafio.Presentation.Mappers
{
    public class DomainToViewModel : Profile
    {
        public DomainToViewModel()
        {
            CreateMap<Address, PersonViewModel>();
            CreateMap<Person, PersonViewModel>();                
        }
    }
}
