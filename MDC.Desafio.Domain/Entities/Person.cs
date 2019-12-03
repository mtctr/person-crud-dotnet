using MDC.Desafio.Domain.Entities.ValueObjects;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MDC.Desafio.Domain.Entities
{
    public sealed class Person
    {
        public Person(string personName, string cpf, string email, string phone, int addressId)
        {
            PersonName = personName;
            Cpf = cpf;
            Email = email;
            Phone = phone;            
            AddressId = addressId;
            Active = true;
            PersonPhotos = new List<PersonPhoto>();
        }

        private Person() { }

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonId { get; private set; }
        
        [Required]
        public string PersonName { get; private set; }
        
        [Required]
        public string Cpf { get; private set; }

        [Required]
        public string Email { get; private set; }

        [Required]
        public string Phone { get; private set; }

        [Required]
        public int AddressId { get; private set; }
        [Required]
        public bool Active { get; private set; }

        [Required]        
        [ForeignKey("AddressId")]
        public Address Address { get; private set; }        

        public List<PersonPhoto> PersonPhotos { get; private set; }

        public void AddPhoto(PersonPhoto personPhoto)
        {
            PersonPhotos.Add(personPhoto);
        }

        public void Inactivate()
        {
            Active = false;
        }

    }
}
