using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class Departman
    {
        [Key]
        public int departmanid { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string departmanad { get; set; }
        public bool durum { get; set; }

        public ICollection<Personel> personels { get; set; }
    }
}