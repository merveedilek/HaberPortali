using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haber.Entities.DTO
{
   public class KullaniciDTO
    {
        public int Id { get; set; }

        [Display(Name = "KULLANICI ADI")]
        [Required(ErrorMessage = "KULLANICI ADI ZORUNLUDUR")]
        public string Adi { get; set; }

        [Display(Name = "KULLANICI SOYADI")]
        [Required(ErrorMessage = "KULLANICI SOYADI ZORUNLUDUR.")]
        public string Soyadi { get; set; }

        [Display(Name = "E-MAİL ADRESİ")]
        [Required(ErrorMessage = "E-MAİL GİRİLMESİ ZORUNLUDUR.")]
        public string Email { get; set; }

        [Display(Name = "ŞİFRE")]
        [Required(ErrorMessage = "ŞİFRE GİRİLMESİ ZORUNLUDUR")]
        public string Sifre { get; set; }
        public string Rol { get; set; }
    }
}
