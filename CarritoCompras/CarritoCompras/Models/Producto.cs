using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CarritoCompras.Models
{
    public class Producto
    {
        public Int32 IdProducto{ get; set; }

        public String CodigoProducto { get; set; }

        public String NombreProducto { get; set; }

        public String DescripcionProducto { get; set; }

        public Int32 IdTipoProducto { get; set; }

        public virtual TipoProducto TipoProducto { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public Decimal PrecioProducto { get; set; }



    }
}