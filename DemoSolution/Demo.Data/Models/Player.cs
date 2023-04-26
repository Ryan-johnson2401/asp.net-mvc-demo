using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PlayerClass Class { get; set; }
    }
}
