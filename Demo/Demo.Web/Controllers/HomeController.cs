using Demo.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Web.Controllers
{
    public class HomeController : Controller
    {
        IPlayerData playerData;

        public HomeController(IPlayerData playerData)
        {
            this.playerData = playerData;
        }
        public ActionResult Index()
        {
            var model = playerData.GetPlayers();
            return View(model);
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