using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirEylulMarket.Models
{
    public class UygulamaDbContext : DbContext
    {
        public UygulamaDbContext(DbContextOptions<UygulamaDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kategori>().HasData(
                new Kategori() { Id = 1, KategoriAd = "İçecekler" },
                new Kategori() { Id = 2, KategoriAd = "Süt Ürünleri" },
                new Kategori() { Id = 3, KategoriAd = "Hırdavat" },
                new Kategori() { Id = 4, KategoriAd = "Yiyecek" }
                );

            modelBuilder.Entity<Urun>().HasData(
                new Urun() { Id = 1, KategoriId = 1, UrunAd = "Kola", BirimFiyat = 4.50m },
                new Urun() { Id = 2, KategoriId = 1, UrunAd = "Soda", BirimFiyat = 2.50m },
                new Urun() { Id = 3, KategoriId = 2, UrunAd = "Ayran", BirimFiyat = 3.50m },
                new Urun() { Id = 4, KategoriId = 2, UrunAd = "Yoğurt", BirimFiyat = 7.50m },
                new Urun() { Id = 5, KategoriId = 3, UrunAd = "Çekiç", BirimFiyat = 12.50m },
                new Urun() { Id = 6, KategoriId = 3, UrunAd = "Çivi", BirimFiyat = 9.50m },
                new Urun() { Id = 7, KategoriId = 4, UrunAd = "Tavuk", BirimFiyat = 22.50m },
                new Urun() { Id = 8, KategoriId = 4, UrunAd = "Pizza", BirimFiyat = 24.99m }
                );
        }

        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Urun> Urunler { get; set; }
    }
}
