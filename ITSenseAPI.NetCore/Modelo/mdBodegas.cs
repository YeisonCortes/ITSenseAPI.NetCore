using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ITSenseAPI.NetCore.Modelo
{
    [Table("Bodegas")]
    public partial class mdBodegas
    {
        [Key]
        public int boCod { get; set; }

        [Required]
        [StringLength(30)]
        public string boNombre { get; set; }

        [Required]
        public Boolean boEstado { get; set; }

    }
}
