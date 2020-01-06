using Haber.DAL.Repositories;
using Haber.Entities.DTO;
using Haber.Helpers.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haber.Services
{
   public class HaberServices
    {
        private readonly HaberRepository _haberRepository;
        public HaberServices()
        {
            _haberRepository = new HaberRepository();
        }
        public List<HaberDTO> GetHaberDTOs()
        {
            List<Entities.EF.Haber> haberList = _haberRepository.GetAllHaber();
            List<HaberDTO> HaberDtoList = haberList.GetHaberDTO();
            return HaberDtoList;
        }
    }
}
