using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CarritoCompras.Models
{
    public class Factura
    {

        public Int32 IdFactura { get; set; }
        public String CodigoFactura { get; set; }
        public List<Producto> Productos { get; set; }

        public String DescripcionFactura { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public Decimal TotalFactura { get; set; }

        public Int32 IdUsuario { get; set; }

        public virtual Usuario Usuario { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de Creacion de Factura")]
        public DateTime FechaFactura { get; set; }

        public Boolean EstadoFacura { get; set; }
    }
}