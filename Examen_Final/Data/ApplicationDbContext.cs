using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Examen_Final.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<Producto> productos { get; set; }
        public DbSet<Factura> facturas { get; set; }
        public DbSet<Cliente> clientes { get; set; }
        public DbSet<FacturaDetalle> facturaDetalles { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=tienda.db");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
