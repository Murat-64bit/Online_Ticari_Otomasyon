﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class Kategori
    {
        [Key]
        public int id { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string kategoriad { get; set; }
        public ICollection<Urun> uruns { get; set; }

    }
}