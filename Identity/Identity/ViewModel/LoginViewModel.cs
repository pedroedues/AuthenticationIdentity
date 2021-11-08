using System.ComponentModel.DataAnnotations;

namespace Identity.ViewModel
{
    public class LoginViewModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(nameof(DataType.Password))]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
