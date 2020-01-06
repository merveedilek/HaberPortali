using Haber.Entities.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haber.DAL.Repositories
{
   public class KullaniciRepository
    {
        public List<Kullanici> GetAllKullanici()
        {
            List<Kullanici> kullanici;
            using (
                var database = new HaberContext())
            {
                kullanici = database.Kullanici.ToList();
            }
            return kullanici;
        }
        public Kullanici GetKullanici(int id)
        {
            Kullanici kullanici;
            using (var databaseContext = new HaberContext())
            {
                kullanici = databaseContext.Kullanici.FirstOrDefault(i => i.Id.Equals(id));
            }
            return kullanici;
        }
        public bool EditKullanici(Kullanici kullanici)
        {
            using (var databaseContext = new HaberContext())
            {
                databaseContext.Entry(kullanici).State = EntityState.Modified;
                return databaseContext.SaveChanges() > 0;
            }
        }
    }
}
