using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public Nullable<DateTime> moFecha { get; set; }
    }
}
