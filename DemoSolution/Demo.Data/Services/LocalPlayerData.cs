using Demo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo.Data.Services
{
    public class LocalPlayerData : IPlayerData
    {
        List<Player> Players;

        public LocalPlayerData()
        {
            Players = new List<Player>()
            {
                new Player() {Id=1, Name="Ryan", Class=PlayerClass.Elf},
                new Player() {Id=2, Name="Stuart", Class = PlayerClass.Human}
            };
        }

        public IEnumerable<Player> GetPlayers()
        {
            return Players.OrderBy(p => p.Name);
        }
        public Player GetPlayerById(int id)
        {
            return Players.FirstOrDefault(p => p.Id == id);
        }
    }
}
