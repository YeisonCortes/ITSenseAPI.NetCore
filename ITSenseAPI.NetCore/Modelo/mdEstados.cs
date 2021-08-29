using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ITSenseAPI.NetCore.Modelo
{
    [Table("Estados")]
    public class mdEstados
    {
        [Key]
        public int esCod { get; set; }

        [Required]
        [StringLength(50)]
        public string esDescripcion { get; set; }
    }
}
