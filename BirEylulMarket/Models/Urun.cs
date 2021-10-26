using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BirEylulMarket.Models
{
    public class Urun
    {
        public int Id { get; set; }

        [Required, MaxLength(200)]
        public string UrunAd { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal BirimFiyat { get; set; }

        public int KategoriId { get; set; }
        public Kategori Kategori { get; set; }
    }
}
