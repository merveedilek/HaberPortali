using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haber.Entities.EF
{
    public class Kategori
    {
        public Kategori()
        {
            Haber = new List<Haber>();
        }
        public int Id { get; set; }
        public string KategoriAdi { get; set; }
        public virtual ICollection<Haber> Haber { get; set; }
    }
}
