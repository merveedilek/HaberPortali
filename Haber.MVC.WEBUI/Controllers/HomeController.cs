using Haber.Entities.DTO;
using Haber.Entities.EF;
using Haber.MVC.WEBUI.Models;
using Haber.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Haber.MVC.WEBUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly HaberServices _haberServices;
        private readonly KategoriServices _kategoriServices;
        public HomeController()
        {
            _haberServices = new HaberServices();
            _kategoriServices = new KategoriServices();
        }
        // GET: Home
        public ActionResult Index()
        {
            List<HaberDTO> haberList = _haberServices.GetHaberDTOs();
            List<KategoriDTO> kategoriList = _kategoriServices.GetKategorilerDTO();
            var model = new HomeIndexViewModel
            {
                Haberler = haberList,
                Kategoriler = kategoriList
            };
            return View(model);
        }
        public ActionResult Category()
        {
            return View();
        }
        public ActionResult SinglePost()
        {
            return View();
        }
    }
}