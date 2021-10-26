using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BirEylulMarket.Models
{
    public class Kategori
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string KategoriAd { get; set; }


        public List<Urun> Urunler { get; set; }
    }
}
