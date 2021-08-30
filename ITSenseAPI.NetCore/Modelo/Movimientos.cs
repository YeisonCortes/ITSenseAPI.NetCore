using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ITSenseAPI.NetCore.Modelo
{
    public class Movimientos
    {
        [Key]
        public int moCod { get; set; }

        [Required]
        public int moProducto { get; set; }

        [Required]
        public int moClaseMvto { get; set; }

        [Required]
        public int moCantidad { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public System.DateTime moFecha { get; set; }

        [ForeignKey("moProducto")]
        public virtual mdInventario Producto { get; set; }

        [ForeignKey("moClaseMvto")]
        public virtual mdClaseMovimiento Clase { get; set; }
    }
}
