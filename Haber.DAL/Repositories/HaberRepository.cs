using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haber.DAL.Repositories
{
   public class HaberRepository
    {
        public List<Entities.EF.Haber> GetAllHaber()
        {
            List<Entities.EF.Haber> haber;
            using (HaberContext databaseContext = new HaberContext())
            {
          haber=databaseContext.Haber.Include("Kategori").ToList();
            }
            return haber;
        }
        public Entities.EF.Haber GetHaber(int id)
        {
            Entities.EF.Haber haber;
            using (var databaseContext = new HaberContext())
            {
                haber = databaseContext.Haber.FirstOrDefault(i => i.Id.Equals(id));
            }
            return haber;
        }
        public bool EditHaber(Entities.EF.Haber haber)
        {
            using (var databaseContext = new HaberContext())
            {
                databaseContext.Entry(haber).State = EntityState.Modified;
                return databaseContext.SaveChanges() > 0;
            }
        }
    }
}
