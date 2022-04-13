using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class Cariler
    {
        [Key]
        public int cariid { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string cariad { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string carisoyad { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string carisehir { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string carimail { get; set; }

        public ICollection<SatisHaraket> SatisHarakets { get; set; }

    }
}