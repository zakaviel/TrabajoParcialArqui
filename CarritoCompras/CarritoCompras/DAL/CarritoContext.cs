using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CarritoCompras.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CarritoCompras.DAL
{
    public class CarritoContext : DbContext
    {
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<TipoProducto> TiposProducto { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //Aqui debemos checar lo de Pluralizacion

            modelBuilder.Entity<TipoProducto>().MapToStoredProcedures();
            modelBuilder.Entity<Usuario>().MapToStoredProcedures();
            modelBuilder.Entity<Producto>().HasMany(x => x.TiposProducto);
            modelBuilder.Entity<Factura>().HasMany(x=>x.Productos);


        }
    }
}