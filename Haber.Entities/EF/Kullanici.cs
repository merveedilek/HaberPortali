using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haber.Entities.EF
{
   public class Kullanici
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Roller Roller { get; set; }
        public bool OnaylandiMi { get; set; }
        public virtual ICollection<Haber> Haber { get; set; }
    }
}
