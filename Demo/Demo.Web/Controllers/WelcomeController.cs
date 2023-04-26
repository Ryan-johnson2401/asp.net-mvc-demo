using Demo.Web.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Web.Controllers
{
    public class WelcomeController : Controller
    {
        // GET: Welcome
        public ActionResult Index(string name)
        {
            var model = new WelcomeViewModel();
            model.Name = name ?? "Player";
            model.Message = ConfigurationManager.AppSettings["message"];
            return View(model);
        }
    }
}