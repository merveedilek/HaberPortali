using Haber.DAL.Repositories;
using Haber.Entities.DTO;
using Haber.Entities.EF;
using Haber.Helpers.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haber.Services
{
   public class KullaniciServices
    {
        private readonly KullaniciRepository _kullaniciRepository;
        public KullaniciServices()
        {
            _kullaniciRepository = new KullaniciRepository();
        }
        public List<KullaniciDTO> GetKullaniciDTOs()
        {
            List<Kullanici> kullaniciList= _kullaniciRepository.GetAllKullanici();
            List<KullaniciDTO> dtoKullaniciList = kullaniciList.GetKullaniciDto();
            return dtoKullaniciList;
        }
    }
}
