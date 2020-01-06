using Haber.Entities.DTO;
using Haber.Entities.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haber.Helpers.Extensions
{
   public static class GaleriExtensions
    {
        public static GaleriDTO getGaleriDto(Galeri galeri)
        {
            GaleriDTO DTOGaleri = new GaleriDTO
            {
                Yol = galeri.ResimYolu,
            };
            return DTOGaleri;
        }
        public static List<GaleriDTO> GetGaleriDto(this ICollection<Galeri> galeri)
        {
            List<GaleriDTO> galeriList = galeri.Select(i => new GaleriDTO
            {
                Id=i.Id,
                Yol = i.ResimYolu,
                HaberBasligi = i.Haber.Baslik
            }).ToList();
            return galeriList;
        }
    }
}
