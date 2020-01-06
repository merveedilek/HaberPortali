using Haber.Entities.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haber.Entities.DTO
{
   public class HaberDTO
    {
        public int Id { get; set; }

        [Display(Name = "HABER BAŞLIĞI")]
        [Required(ErrorMessage = "HABER BAŞLIĞI BOŞ GEÇİLEMEZ")]
        public string Baslik { get; set; }

        [Display(Name = "HABER İÇERİĞİ")]
        [Required(ErrorMessage = "HABER İÇERİĞİ BOŞ GEÇİLEMEZ.")]
        public string İcerik { get; set; }

        [Display(Name = "OLUŞTURULMA TARİHİ")]
        [Required(ErrorMessage = "HABERİN OLUŞTURULMA TARİHİ BOŞ GEÇİLEMEZ.")]
        public DateTime OlusturulmaTarihi { get; set; }
        public string KategoriAdi { get; set; }
        public string ResimYolu { get; set; }

        [Display(Name = "YAZAR")]
        [Required(ErrorMessage = "YAZAR ADI BOŞ GEÇİLEMEZ.")]
        public string KullaniciAdi { get; set; }
    }
}
