using Haber.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haber.Helpers.Extensions
{
   public static class HaberExtensions
    {
        public static HaberDTO GetHaberDto(Entities.EF.Haber haber)
        {
            HaberDTO DTOHaber = new HaberDTO
            {
                Baslik = haber.Baslik,
                İcerik = haber.İcerik,
                  OlusturulmaTarihi=haber.OlusturulmaTarihi
                 
                
            };
            return DTOHaber;
        }
        public static List<HaberDTO> GetHaberDTO(this ICollection<Entities.EF.Haber> haber)
        {
            List<HaberDTO> haberList = haber.Select(i => new HaberDTO
            {
                Id=i.Id,
                Baslik = i.Baslik,
                İcerik = i.İcerik,
                OlusturulmaTarihi=i.OlusturulmaTarihi,
                KategoriAdi = i.Kategori.KategoriAdi


            }).ToList();
            return haberList;
        }
    }
}
