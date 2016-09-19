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
        public DbSet<Factura> Factura { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //Aqui debemos checar lo de Pluralizacion

           
        }
    }
}