using Haber.DAL.Repositories;
using Haber.Entities.DTO;
using Haber.Entities.EF;
using Haber.Helpers.Extensions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haber.Services
{
   public class KategoriServices
    {
        private readonly KategoriRepository _kategoriRepository;
        private static int _rowNumber;

        public KategoriServices()
        {
            _kategoriRepository = new KategoriRepository();
            _rowNumber = Convert.ToInt32(ConfigurationManager.AppSettings["TopRowNumber"]);

        }
        public List<Kategori> GetKategories()
        {
            var kategoriler = _kategoriRepository.GetAllKategori();
            return kategoriler;
        }
        
        public List<KategoriDTO> GetKategorilerDTO()
        {
            List<Kategori> kategoriList = _kategoriRepository.GetAllKategori();
            List<KategoriDTO> KategoriDtoList = kategoriList.GetKategoriDto();
            return KategoriDtoList;
        }
       public Kategori GetKategori(int id)
        {
            if (id < 0)
                return null;
            var result = _kategoriRepository.GetKategori(id);
            return result;
        }
        public void EditKategori (Kategori kategori)
        {
            if (kategori == null)
                return;
            _kategoriRepository.EditKategori(kategori);
        }
    }
}
