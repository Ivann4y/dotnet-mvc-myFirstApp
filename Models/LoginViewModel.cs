using System.ComponentModel.DataAnnotations;

namespace dotnet_mvc_first_app.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email wajib diisi")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password wajib diisi")]
        public string Password { get; set; } = string.Empty;
    }
}
