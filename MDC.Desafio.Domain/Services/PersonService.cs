using MDC.Desafio.Domain.Entities;
using MDC.Desafio.Domain.Interfaces;
using System.Collections.Generic;

namespace MDC.Desafio.Domain.Services
{
    public sealed class PersonService
    {
        private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public void Add(Person person)
        {
            _personRepository.Add(person);
        }

        public void Edit(Person person)
        {
            _personRepository.Edit(person);
        }

        public void Remove(Person person)
        {
            person.Inactivate();
            _personRepository.Edit(person);
        }

        public IEnumerable<Person> List()
        {
            return _personRepository.Get();
        }

        public Person GetById(int personId)
        {
            return _personRepository.Get(personId);
        }
    }
}
