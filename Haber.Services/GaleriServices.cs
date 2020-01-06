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
   public class GaleriServices
    {
        private readonly GaleriRepository _galeriRepository;
        public GaleriServices()
        {
            _galeriRepository = new GaleriRepository();
        }
        public List<GaleriDTO> GetGaleriDTOs()
        {
            List<Galeri> galeriList = _galeriRepository.GetAllGaleri();
            List<GaleriDTO> dtoGaleriList = galeriList.GetGaleriDto();
            return dtoGaleriList;
        }
    }
}
