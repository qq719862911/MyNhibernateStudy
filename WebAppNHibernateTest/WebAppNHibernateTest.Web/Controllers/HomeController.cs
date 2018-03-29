using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppNHibernateTest.BLL.Service;
using WebAppNHibernateTest.Model;

namespace WebAppNHibernateTest.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult CreateCat(Cat model)
        {
            Cat princess = new Cat();
            princess.Name = "Princess";
            princess.Sex = 'F';
            princess.Weight = 7.4f;
            CatService catService = new CatService();
            catService.Create(princess);
            return Content("ok");
        }
        public ActionResult Query(string sex)
        {
            CatService catService = new CatService();
           Cat c = catService.Query(sex).FirstOrDefault();
            if (c!=null)
            {
                return Content(c.Name);
            }
            return Content("no");
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}