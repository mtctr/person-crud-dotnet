using MDC.Desafio.Domain.Entities;
using System.Collections.Generic;

namespace MDC.Desafio.Domain.Interfaces
{
    public interface IPersonRepository
    {
        IEnumerable<Person> Get();
        Person Get(int personId);
        void Add(Person person);
        void Edit(Person person);        
    }
}
