using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haber.Entities.EF
{
   public class Galeri
    {
        public int Id { get; set; }
        public string ResimYolu { get; set; }
        public int HaberId { get; set; }
        public virtual Haber Haber { get; set; }
    }
}
