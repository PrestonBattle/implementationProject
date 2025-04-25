using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThriveHavenMovies.Models.AccountStuff
{
    public class Payment
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        public string CardName { get; set; }

        [Required]
        public string CardNumber { get; set; }

        [Required]
        public string ExpirationDate { get; set; }

        [Required]
        public string Cvc { get; set; }

        public bool IsDefault { get; set; } = false;

        [Required]
        public string NameOnCard { get; set; }
        public Guid UserId { get; set; }

        [ForeignKey("UserId")]
        public Users User { get; set; }
    }
}
