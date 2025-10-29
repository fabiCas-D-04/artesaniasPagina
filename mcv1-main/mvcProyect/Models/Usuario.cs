using System.ComponentModel.DataAnnotations;

namespace mvcProyect.Models
{
    public class Usuario
    {
        public int Id { get; set; }


        [Required]
        [EmailAddress]
        public string Email { get; set; }


        [Required]
        public string Password { get; set; }

        [Required]
        public string NombreCompleto { get; set; } = string.Empty;

        [Required]
        public DateTime Fecharegistro { get; set; } = DateTime.Now;

        [Required]
        public string Rol { get; set; } = "Usuario";

        public DateTime FechaNacimineto { get; set; }

        public bool Activo { get; set; } = true;


    }
}
