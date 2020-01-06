using Haber.Entities.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haber.DAL.Repositories
{
   public class GaleriRepository
    {
        public List<Galeri> GetAllGaleri()
        {
            List<Galeri> galeri;
            using (var database = new HaberContext())
            {
                galeri = database.Galeri.ToList();
            }
            return galeri;
        }
        public Galeri GetGaleri(int id)
        {
            Galeri galeri;
            using (var databaseContext = new HaberContext())
            {
                galeri = databaseContext.Galeri.FirstOrDefault(i => i.Id.Equals(id));
            }
            return galeri;
        }
        public bool EditGaleri(Galeri galeri)
        {
            using (var databaseContext = new HaberContext())
            {
                databaseContext.Entry(galeri).State = EntityState.Modified;
                return databaseContext.SaveChanges() > 0;
            }
        }
    }
}
