using MDC.Desafio.Domain.Entities.ValueObjects;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace MDC.Desafio.Presentation.Models
{
    public class PersonViewModel : IValidatableObject
    {        
  
        public int? PersonId { get; set; }

        [Required]
        public string PersonName { get; set; }

        [Required]
        public string Cpf { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }
                
        public int? AddressId { get; set; }
        [Required]
        [StringLength(maximumLength: 8, MinimumLength = 8)]
        public string PostalCode { get; set; }
        [Required]
        public string City { get; set; }
        [StringLength(maximumLength: 2, MinimumLength = 2)]
        public string State { get; set; }
        [Required]
        public string District { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string Number { get; set; }

        public IFormFile PhotoFile { get; set; }
        public byte[] Photo64 { get; set; }

        
        private bool CpfIsValid()
        {
            var cpf = new Cpf(this.Cpf);
            return cpf.IsValid;
        }
        private bool FileSizeIsValid()
        {
            using (var memoryStream = new MemoryStream())
            {
                PhotoFile.CopyTo(memoryStream);

                // if less than 2 MB
                if (memoryStream.Length < 2097152)
                {
                    Photo64 = memoryStream.ToArray();
                    return true;
                }
                return false;
            }

        }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {            
            if(!CpfIsValid())
                yield return new ValidationResult("Invalid CPF", new List<string>() { "Cpf" });
            if(!FileSizeIsValid())
                yield return new ValidationResult("File must be less than 2MB", new List<string>() { "PhotoFile" });
        }       
    }
}
