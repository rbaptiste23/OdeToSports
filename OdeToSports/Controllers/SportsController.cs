using OdeToSports.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToSports.Controllers
{
    public class SportsController : Controller
    {
        private readonly IBaseballData db; 

        public SportsController(IBaseballData db)
        {
            this.db = db; 
        }

        [HttpGet]
        public ActionResult Index()
        {
            var model = db.GetAllInfo();
            return View(model);
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            var model = db.Get(id);
            if(model == null)
            {
                return View("NotFound");

            }
            return View(model);

        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


        [ValidateAntiForgeryToken]
        [HttpPost]
       
        public ActionResult Create(BaseballPlayer baseballPlayer)
        {
        

            if (ModelState.IsValid)
            {
                db.Add(baseballPlayer);
                return View();

            }

            return View();
           
        }


    }
}