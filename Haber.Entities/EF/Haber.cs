using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haber.Entities.EF
{
   public class Haber
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string İcerik { get; set; }
        public bool OnaylandiMi { get; set; }
        public int KategoriId { get; set; }
        public virtual Kategori Kategori { get; set; }
        public int KullaniciId { get; set; }
        public Kullanici Kullanici { get; set; }
        public DateTime OlusturulmaTarihi { get; set; }
        public DateTime GuncellenmeTarihi { get; set; }
        public virtual ICollection<Galeri> Galeri { get; set; }
        public virtual ICollection<Yorum> Yorum { get; set; }
    }
}
