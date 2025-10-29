using Microsoft.EntityFrameworkCore;
using mvcProyect.Models;

namespace mvcProyect.Data
{
    public static class SeedData
    {
        public static void Initialize(ArtesaniasDBContext context)
        {
            // Aplicar migraciones pendientes
            context.Database.Migrate();

            // Seed para Usuarios
            if (!context.Usuario.Any())
            {
                context.Usuario.AddRange(
                    new Usuario { Nombre = "admin", Email = "admin@artesanias.com", Password = "admin123", Rol = "Administrador" }
                );
            }

            // Seed para Clientes
            if (!context.Clientes.Any())
            {
                context.Clientes.AddRange(
                    new ClienteModel { Nombre = "Juan Pérez", Email = "juan@correo.com", Telefono = "555-1234" }
                );
            }

            // Seed para Productos
            if (!context.Productos.Any())
            {
                context.Productos.AddRange(
                    new ProductoModel { Nombre = "Vasija de barro", Precio = 150.00M, Descripcion = "Vasija artesanal hecha a mano" }
                );
            }

            // Seed para Pedidos
            if (!context.Pedidos.Any())
            {
                context.Pedidos.AddRange(
                    new PedidoModel { ClienteId = 1, Fecha = DateTime.Now }
                );
            }

            // Seed para DetallePedidos
            if (!context.DetallePedidos.Any())
            {
                context.DetallePedidos.AddRange(
                    new DetallePedidoModel { PedidoId = 1, ProductoId = 1, Cantidad = 2, PrecioUnitario = 150.00M }
                );
            }

            context.SaveChanges();
        }
    }
}