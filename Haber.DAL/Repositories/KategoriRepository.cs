using Haber.Entities.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haber.DAL.Repositories
{
    public class KategoriRepository
    {
        public List<Kategori> GetAllKategori()
        {
            List<Kategori> kategori;
            using (var database = new HaberContext())
            {
                kategori = database.Kategori.ToList();
            }
            return kategori;
        }
        public Kategori GetKategori(int id)
        {
            Kategori kategori;
            using (var databaseContext = new HaberContext())
            {
                kategori = databaseContext.Kategori.FirstOrDefault(i => i.Id.Equals(id));
            }
            return kategori;
        }
        public bool EditKategori(Kategori kategori)
        {
            using (var databaseContext = new HaberContext())
            {
                databaseContext.Entry(kategori).State = EntityState.Modified;
                return databaseContext.SaveChanges() > 0;
            }
        }
    }
}
