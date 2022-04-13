using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class FaturaKalem
    {
        [Key]
        public int faturakalemid { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string aciklama { get; set; }
        public int miktar { get; set; }
        public decimal birimfiyat { get; set; }
        public decimal tutar { get; set; }
        public Faturalar Faturalar { get; set; }
    }
}