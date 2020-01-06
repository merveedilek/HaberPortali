using Haber.Entities.DTO;
using Haber.Entities.EF;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haber.Helpers.Extensions
{
   public static class KategoriExtensions
    {
        public static List<KategoriDTO> GetKategoriDto(this ICollection<Kategori>kategoriler)
        {
            var kategoriDto = kategoriler.Select(kategori=> new KategoriDTO
            {
                Id=kategori.Id,
                KategoriAdi = kategori.KategoriAdi
               
        
            }).ToList();

            return kategoriDto;
        }
        public static KategoriDTO GetKategoriDto(this Kategori kategori)
        {
            var kategoriDto = new KategoriDTO
            {
                Id = kategori.Id,
                KategoriAdi = kategori.KategoriAdi
            };
            return kategoriDto;
        }
        public static Kategori GetKategori(this KategoriDTO kategoriDto)
        {
            var kategori = new Kategori
            {
                Id = kategoriDto.Id,
                KategoriAdi = kategoriDto.KategoriAdi,
                
            };

            return kategori;
        }
    }
}
