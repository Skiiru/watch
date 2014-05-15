using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;
using watch.model;

namespace watch.Areas.Default.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            var roles = Repository.Roles.ToList();
            return View(roles);
        }

    }
}
