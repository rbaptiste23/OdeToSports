using OdeToSports.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OdeToSports.API
{
    public class SportsController : ApiController
    {
        private readonly IBaseballData db;


        public SportsController(IBaseballData db)
        {
            this.db = db;
      
        }

        public IBaseballData Db { get; }

        public IEnumerable<BaseballPlayer> Get()
        {
            var model = db.GetAllInfo();
            return model;
        }
    }
}
