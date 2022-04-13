using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class Faturalar
    {
        [Key]
        public int faturaid { get; set; }

        [Column(TypeName = "Char")]
        [StringLength(1)]
        public string faturaserino { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(6)]
        public string faturasirano { get; set; }
       
        public DateTime tarih { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string vergidairesi { get; set; }

        public DateTime saat { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string teslimeden { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string teslimalan { get; set; }
        public ICollection<FaturaKalem> FaturaKalems { get; set; }
    }
}