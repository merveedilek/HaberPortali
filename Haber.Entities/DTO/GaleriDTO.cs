using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haber.Entities.DTO
{
   public class GaleriDTO
    {
        public int Id { get; set; }

        [Display(Name = "RESİM YOLU")]
        [Required(ErrorMessage = "BU ALAN ZORUNLUDUR")]
        public string Yol { get; set; }
        public string HaberBasligi { get; set; }
    }
}
