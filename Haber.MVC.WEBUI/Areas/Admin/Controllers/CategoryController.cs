using Haber.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Haber.Helpers.Extensions;

namespace Haber.MVC.WEBUI.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        private readonly KategoriServices _kategoriServices;
        public CategoryController()
        {
            _kategoriServices = new KategoriServices();
        }
        public ActionResult Index()
        {
            var kategoriler = _kategoriServices.GetKategories();
            return View(kategoriler);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var kategori = _kategoriServices.GetKategori(id);
            if (kategori == null)
                return HttpNotFound();
            return View(kategori.GetKategoriDto());
        }
    }
}