using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToSports.Data.Models
{
    public class BaseballPlayer
    {
        public int ID { get; set; }

        public string PlayerName { get; set; }

        public PlayerPosition Position { get; set; }
    }
}
