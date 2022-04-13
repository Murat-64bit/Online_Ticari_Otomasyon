using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class Urun
    {
        [Key]
        public int urunid { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string urunad { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string marka { get; set; }

        public short stok { get; set; }
        public decimal alisfiyat { get; set; }
        public decimal satisfiyat { get; set; }
        public bool durum { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string urungorsel { get; set; }
        public int kategoriid { get; set; }
        public virtual Kategori Kategori { get; set; }
        public ICollection<SatisHaraket> SatisHarakets { get; set; }


    }
}