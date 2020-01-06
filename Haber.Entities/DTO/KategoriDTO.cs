using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haber.Entities.DTO
{
   public class KategoriDTO
    {
        public int Id { get; set; }

        [Display(Name = "KATEGORİ ADI")]
        [Required(ErrorMessage = "KATEGORİ ADI BOŞ GEÇİLEMEZ.")]
        public string KategoriAdi { get; set; }

     

    }
}
