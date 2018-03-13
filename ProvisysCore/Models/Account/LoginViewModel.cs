using System.ComponentModel.DataAnnotations;

namespace ProvisysCore.Models.Account
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Usuario")]
        public int IdUser { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        [Display(Name = "¿Recordarme?")]
        public bool RememberMe { get; set; }
    }
}
