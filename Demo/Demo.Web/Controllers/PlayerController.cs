using Demo.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Web.Controllers
{
    public class PlayerController : Controller
    {
        private readonly IPlayerData db;

        public PlayerController(IPlayerData db)
        {
            this.db = db;
        }
        public ActionResult Index()
        {
            var model = db.GetPlayers();
            return View(model);
        }
        public ActionResult Details(int id)
        {
            var model = db.GetPlayerById(id);
            if (model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }
    }
}