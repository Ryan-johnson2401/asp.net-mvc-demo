using Demo.Data.Models;
using Demo.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Demo.Web.API
{
    public class PlayerController : ApiController
    {
        private readonly IPlayerData db;

        public PlayerController(IPlayerData db)
        {
            this.db = db;
        }
        public IEnumerable<Player> Get()
        {
            var model = db.GetPlayers();
            return model;
        }

    }
}
