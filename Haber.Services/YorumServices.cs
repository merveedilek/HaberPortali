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
   public class YorumServices
    {
        private readonly YorumRepository _yorumRepository;
        public YorumServices()
        {
            _yorumRepository = new YorumRepository();
        }
        public List<YorumDTO> GetYorumDTOs()
        {
            List<Yorum> yorumList = _yorumRepository.GetAllYorum();
            List<YorumDTO> dtoYorumList = yorumList.GetYorumDto();
            return dtoYorumList;
        }
    }
}
