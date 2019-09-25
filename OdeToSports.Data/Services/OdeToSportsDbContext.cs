using OdeToSports.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToSports.Data.Services
{
    public class OdeToSportsDbContext : DbContext
    {
        public DbSet<BaseballPlayer> BaseballPlayers { get; set; }

    }
}
