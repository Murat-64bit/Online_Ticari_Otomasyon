using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class Personel
    {
        [Key]
        public int personelid { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string personelad { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string personelsoyad { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string personelgorsel { get; set; }

        public ICollection<SatisHaraket> SatisHarakets { get; set; }
        public int departmanid { get; set; }
        public virtual Departman Departman { get; set; }
    }
}