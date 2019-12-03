using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MDC.Desafio.Domain.Entities
{
    public sealed class PersonPhoto
    {
        public PersonPhoto(byte[] photo64)
        {
            Photo64 = photo64;
        }

        public PersonPhoto(int personId, byte[] photo64)
        {
            PersonId = personId;
            Photo64 = photo64;
        }

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonPhotoId { get; private set; }
        
        [Required]
        public int PersonId { get; private set; }
        
        [Required]
        public byte[] Photo64 { get; private set; }
        [ForeignKey("PersonId")]
        public Person Person { get; private set; }
    }
}
