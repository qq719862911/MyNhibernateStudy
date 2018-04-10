using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppNHibernateTest.BLL.Service;

namespace WebAppNHibernateTest.Web.Controllers
{
    public class HostsController : Controller
    {
        // GET: Hosts
        public ActionResult Index()
        {
            HostsService catService = new HostsService();
            var hosts = catService.GetAll();
            return View(hosts);
        }
    }
}