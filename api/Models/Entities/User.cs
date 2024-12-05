using System.ComponentModel.DataAnnotations;

namespace api.Models.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        /////[Required]
        //public byte[] PasswordHash { get; set; }

        /////[Required]
        //public byte[] PasswordSalt { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Username must be between 3 and 100 characters.")]
        public string UserName { get; set; }
    }
}