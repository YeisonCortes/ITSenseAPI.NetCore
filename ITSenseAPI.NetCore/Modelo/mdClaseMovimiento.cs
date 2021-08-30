using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ITSenseAPI.NetCore.Modelo
{
    [Table("Clase_Movimiento")]
    public class mdClaseMovimiento
    {
        [Key]
        public int cmCod { get; set; }

        [Required]
        [StringLength(50)]
        public string cmDescripcion { get; set; }
    }
}
