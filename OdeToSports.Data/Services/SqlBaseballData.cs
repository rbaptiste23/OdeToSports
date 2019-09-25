using OdeToSports.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToSports.Data.Services
{
    public class SqlBaseballData : IBaseballData
    {

        private readonly OdeToSportsDbContext db; 

        public SqlBaseballData(OdeToSportsDbContext db)
        {
            this.db = db; 
        }
        public void Add(BaseballPlayer baseballPlayer)
        {
            db.BaseballPlayers.Add(baseballPlayer);
            db.SaveChanges();
        }

        public BaseballPlayer Get(int id)
        {
            return db.BaseballPlayers.FirstOrDefault(r => r.ID == id);
            
        }

        public IEnumerable<BaseballPlayer> GetAllInfo()
        {
            return from r in db.BaseballPlayers
                   orderby r.PlayerName
                   select r;
        }

        public void Update(BaseballPlayer baseballPlayer)
        {
            //var r = Get(baseballPlayer.ID);
            //r.PlayerName = "";
            //db.SaveChanges();

            // This should already live in the database 
            // Tell you so you can keep track of it.
            // This will handle multiple users
            // OptimisicConcurrency
            var entry = db.Entry(baseballPlayer);
            entry.State = EntityState.Modified;
            db.SaveChanges();             
        }
    }
}
