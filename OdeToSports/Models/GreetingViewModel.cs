using OdeToSports.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OdeToSports.Models
{
    public class GreetingViewModel
    {

        public IEnumerable<BaseballPlayer> BaseballPlayers { get; set; }
        public string Message { get; set; }

        public string Name { get; set; }
    }
}