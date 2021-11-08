using System.ComponentModel.DataAnnotations;

namespace Identity.ViewModel
{
    public class RegisterViewModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(nameof(DataType.Password))]
        public string Password { get; set; }

        [Required]
        [DataType(nameof(DataType.Password), ErrorMessage="Password and confirmation password do not match")]
        public string ConfirmPassword { get; set; }
    }
}
