using MDC.Desafio.Domain.Entities;
using MDC.Desafio.Domain.Entities.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace MDC.Desafio.Infra
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Person> People { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<PersonPhoto> PersonPhotos { get; set; }
        
    }
}
