﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class Gider
    {
        [Key]
        public int giderid { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string aciklama { get; set; }
        public DateTime tarih { get; set; }
        public decimal tutar { get; set; }

    }
}