using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MDC.Desafio.Domain.Entities.ValueObjects
{
    public sealed class Address
    {
        public Address(string postalCode, string city, string state, string district, string street, string addressNumber)
        {
            PostalCode = postalCode;
            City = city;
            State = state;
            District = district;
            Street = street;
            Number = addressNumber;
        }
        private Address(){}

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AddressId { get; private set; }
        [Required]
        [StringLength(maximumLength: 8, MinimumLength = 8)]
        public string PostalCode { get; private set; }
        [Required]
        public string City { get; private set; }
        [StringLength(maximumLength: 2, MinimumLength = 2)]
        public string State { get; private set; }
        [Required]
        public string District { get; private set; }
        [Required]
        public string Street { get; private set; }
        [Required]
        public string Number { get; private set; }


    }
}
