using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public DbSet<Inventario> Inventarios { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<DetalleDeVenta> DetalleDeVenta { get; set; }
        public DbSet<Categoria> Categorias { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Definir claves primarias
            modelBuilder.Entity<Proveedor>().HasKey(p => p.IdProveedor);
            modelBuilder.Entity<Cliente>().HasKey(c => c.IdCliente);
            modelBuilder.Entity<Producto>().HasKey(pr => pr.IdProducto);
            modelBuilder.Entity<Venta>().HasKey(v => v.IdVenta);;
            modelBuilder.Entity<Inventario>().HasKey(i => i.IdInventario);
            modelBuilder.Entity<Usuario>().HasKey(u => u.Id);
            modelBuilder.Entity<DetalleDeVenta>().HasKey(dv => dv.IdDetalleDeVenta);
            modelBuilder.Entity<Categoria>().HasKey(ct => ct.IdCategoria);


            // Especificar tipo de columna para propiedades decimales
            modelBuilder.Entity<Producto>()
                .Property(pr => pr.PrecioUnitario)
                .HasColumnType("decimal(10, 2)");

            modelBuilder.Entity<Venta>()
                .Property(v => v.Total)
                .HasColumnType("decimal(10, 2)");

            modelBuilder.Entity<DetalleDeVenta>()
                .HasKey(d => d.IdDetalleDeVenta);

            modelBuilder.Entity<DetalleDeVenta>()
                .HasOne(d => d.Producto)
                .WithMany() // o `WithMany(p => p.DetallesDeVenta)` si tienes una lista en `Producto`
                .HasForeignKey(d => d.IdProducto);

            modelBuilder.Entity<DetalleDeVenta>()
                .HasOne(d => d.Venta)
                .WithMany() // o `WithMany(v => v.DetallesDeVenta)` si tienes una lista en `Venta`
                .HasForeignKey(d => d.IdVenta);

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

            // Relación Inventario -> Productos
            modelBuilder.Entity<Inventario>()
                .HasOne(i => i.Producto)
                .WithMany()
                .HasForeignKey(i => i.IdProducto)
                .OnDelete(DeleteBehavior.Restrict);
        }


    }
}
