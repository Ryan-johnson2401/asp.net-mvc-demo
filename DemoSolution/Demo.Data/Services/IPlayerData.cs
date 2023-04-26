using Demo.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data.Services
{
    public interface IPlayerData
    {
        IEnumerable<Player> GetPlayers();
        Player GetPlayerById(int id);
    }
}
