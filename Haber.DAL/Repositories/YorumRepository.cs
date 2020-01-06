using Haber.Entities.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haber.DAL.Repositories
{
   public class YorumRepository
    {
        public List<Yorum> GetAllYorum()
        {
            List<Yorum> yorum;
            using (var database = new HaberContext()) 
            {
                yorum = database.Yorum.ToList();
            }
            return yorum;
        }
        public Yorum GetYorum(int id)
        {
            Yorum yorum;
            using (var databaseContext = new HaberContext())
            {

                yorum = databaseContext.Yorum.FirstOrDefault(i => i.Id.Equals(id));
            }
            return yorum;
        }
        public bool EditYorum(Yorum yorum)
        {
            using (var databaseContext = new HaberContext())
            {
                databaseContext.Entry(yorum).State = EntityState.Modified;
                return databaseContext.SaveChanges() > 0;
            }
        }

    }
}
