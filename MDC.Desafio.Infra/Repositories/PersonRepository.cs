using MDC.Desafio.Domain.Entities;
using MDC.Desafio.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MDC.Desafio.Infra.Repositories
{
    public class PersonRepository : IPersonRepository, IDisposable
    {
        private readonly Context _context;

        public PersonRepository(Context context)
        {
            _context = context;
        }

        public void Add(Person person)
        {
            _context.People.Add(person);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Edit(Person person)
        {
            _context.People.Update(person);
            _context.SaveChanges();
        }

        public IEnumerable<Person> Get()
        {
            return _context.People
                .Include(x => x.Address)
                .Include(x => x.PersonPhotos)
                .Where(x => x.Active)
                .AsNoTracking()
                .ToList();
        }

        public Person Get(int personId)
        {
            return _context.People
                .Include(x => x.Address)
                .Include(x => x.PersonPhotos)
                .FirstOrDefault(x => x.PersonId == personId);
        }
    }
}
