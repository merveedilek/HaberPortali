using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haber.Entities.EF
{
   public class Yorum
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Email { get; set; }
        public string Mesaj { get; set; }
        public bool OnaylandiMi { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
        public int HaberId { get; set; }
        public virtual Haber Haber { get; set; }

    }
}
