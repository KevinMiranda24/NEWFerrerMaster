using Microsoft.EntityFrameworkCore;

namespace ProyectodeferrerMaster.Modelos
{
	internal class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-GIGABYTE;Initial Catalog=TiendaOnline1;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }



        // Definición de DbSets para cada tabla
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Categoria> Categorias { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Definir claves primarias
            modelBuilder.Entity<Proveedor>().HasKey(p => p.IdProveedor);
            modelBuilder.Entity<Cliente>().HasKey(c => c.IdCliente);
            modelBuilder.Entity<Producto>().HasKey(pr => pr.IdProducto);
            modelBuilder.Entity<Venta>().HasKey(v => v.IdVenta);;
            modelBuilder.Entity<Usuario>().HasKey(u => u.Id);
            modelBuilder.Entity<Categoria>().HasKey(ct => ct.IdCategoria);


            // Especificar tipo de columna para propiedades decimales
            modelBuilder.Entity<Producto>()
                .Property(pr => pr.PrecioUnitario)
                .HasColumnType("decimal(10, 2)");

            modelBuilder.Entity<Venta>()
                .Property(v => v.Total)
                .HasColumnType("decimal(10, 2)");

            // Relación Productos -> Proveedores
            modelBuilder.Entity<Producto>()
                .HasOne(p => p.Proveedor)
                .WithMany()
                .HasForeignKey(p => p.ProveedorId)
                .OnDelete(DeleteBehavior.Restrict);

            // Relación Ventas -> Clientes
            modelBuilder.Entity<Venta>()
                .HasOne(v => v.Cliente) // Una venta tiene un cliente
                .WithMany() // Un cliente puede tener muchas ventas
                .HasForeignKey(v => v.IdCliente) // Usar ClienteId como clave foránea
                .OnDelete(DeleteBehavior.Restrict);

        }


    }
}
