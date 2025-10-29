using mvcProyect.Models;

namespace mvcProyect.Data
{
    public static class SeedData
    {
        public static void Initialize(ArtesaniasDBContext context)
        {
            if (!context.Usuarios.Any())
            {
                context.Usuarios.AddRange(
                    new Usuario
                    {
                        Nombre = "Admin",
                        Email = "admin@artesanias.com",
                        Password = "admin123", 
                        Rol = "Admin"
                    },
                    new Usuario
                    {
                        Nombre = "Usuario",
                        Email = "usuario@artesanias.com",
                        Password = "usuario123",
                        Rol = "Usuario"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}