
using System.ComponentModel.DataAnnotations;

namespace ReceitasAPI.Models
{
    public class UserRequest
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string EmailTwo { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
        [Required]
        public string PasswordTwo { get; set; } = string.Empty;
        [Required]
        public string BirthdayDate { get; set; }
    }
}
