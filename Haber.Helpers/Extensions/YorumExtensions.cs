using Haber.Entities.DTO;
using Haber.Entities.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haber.Helpers.Extensions
{
   public static class YorumExtensions
    {
        public static YorumDTO GetYorumDto(Yorum yorum )
        {
            YorumDTO DTOYorum = new YorumDTO
            {
                Adi = yorum.Adi,
                Soyadi = yorum.Soyadi,
                Mesaj = yorum.Mesaj
            };
            return DTOYorum;
        }
        public static List<YorumDTO> GetYorumDto(this IEnumerable<Yorum> yorum)
        {
            List<YorumDTO> yorumList = yorum.Select(i => new YorumDTO
            {
                Id = i.Id,
                Adi = i.Adi,
                Soyadi = i.Soyadi,
                Mesaj = i.Mesaj
            }).ToList();
            return yorumList;
        }
    }
}
