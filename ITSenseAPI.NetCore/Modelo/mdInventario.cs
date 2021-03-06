using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ITSenseAPI.NetCore.Modelo
{
    public class mdInventario
    {

        [Key]
        public int inCod { get; set; }

        [Required]
        public int inBodega { get; set; }

        [Required]
        [StringLength(50)]
        public string inNombre { get; set; }

        [Required]
        public int inEstado { get; set; }

        [Required]
        public int inStock { get; set; }

        [ForeignKey("inBodega")]
        public virtual mdBodegas Bodega { get; set; }

        [ForeignKey("inEstado")]
        public virtual mdEstados Estado { get; set; }

    }
}
