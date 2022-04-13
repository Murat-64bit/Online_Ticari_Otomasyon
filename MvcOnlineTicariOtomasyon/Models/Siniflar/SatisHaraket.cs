using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class SatisHaraket
    {
        [Key]
        public int satisid { get; set; }
        //Ürün
        //Cari
        //personel
        public DateTime tarih { get; set; }
        public int adet { get; set; }
        public decimal fiyat { get; set; }
        public decimal toplamtutar { get; set; }
        public int urunid { get; set; }
        public int cariid { get; set; }
        public int personelid { get; set; }
        public virtual Urun Urun { get; set; }
        public virtual Cariler  Cariler { get; set; }
        public virtual Personel Personel { get; set; }
    }
}