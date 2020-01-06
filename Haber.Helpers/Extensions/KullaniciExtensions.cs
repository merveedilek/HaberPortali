using Haber.Entities.DTO;
using Haber.Entities.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haber.Helpers.Extensions
{
   public static class KullaniciExtensions
    {
        public static KullaniciDTO GetKullaniciDto(Kullanici kullanici)
        {
            KullaniciDTO DTOKullanici = new KullaniciDTO
            {
                Adi = kullanici.Adi,
                Soyadi = kullanici.Soyadi,
                Email = kullanici.Email,
                Sifre=kullanici.Password,
                
            };
            return DTOKullanici;
        }
        public static List<KullaniciDTO> GetKullaniciDto(this IEnumerable<Kullanici> kullanici)
        {
            List<KullaniciDTO> kullaniciList = kullanici.Select(i => new KullaniciDTO
            {
                Id = i.Id,
                Adi = i.Adi,
                Soyadi = i.Soyadi,
                Email = i.Email,
                Sifre = i.Password

            }).ToList();
            return kullaniciList;
        }
    }
}
