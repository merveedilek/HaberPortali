using Haber.Entities.DTO;
using Haber.Entities.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Haber.MVC.WEBUI.Models
{
    public class HomeIndexViewModel
    {
        public List<HaberDTO> Haberler{ get; set; }
        public List<KategoriDTO> Kategoriler { get; set; }
        public List<GaleriDTO> Galeriler { get; set; }
    }
}