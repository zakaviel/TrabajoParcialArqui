using CarritoCompras.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace CarritoCompras.DAL
{
    public class CarritoInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<CarritoContext>
    {
        protected override void Seed(CarritoContext context)
        {
            base.Seed(context);

            var tipoproducto = new List<TipoProducto>
            {
                new TipoProducto { IdTipoProducto=1,NombreTipo="Videos" },
                new TipoProducto { IdTipoProducto=2,NombreTipo="Drivers" },
                new TipoProducto { IdTipoProducto=3,NombreTipo="Juegos" }

            };
            tipoproducto.ForEach(s => context.TipoProducto.Add(s));
            context.SaveChanges();

            var productos = new List<Producto>
            {
                new Producto { IdProducto=1,IdTipoProducto=1,CodigoProducto="P1",DescripcionProducto="primer Producto",NombreProducto="Pornacho",PrecioProducto=(Decimal)12.5,},
            };

            productos.ForEach(s => context.Producto.Add(s));
            context.SaveChanges();

        }




    }

         
}
