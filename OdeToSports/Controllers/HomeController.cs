﻿using OdeToSports.Data.Models;
using OdeToSports.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToSports.Controllers
{
    public class HomeController : Controller
    {
        IBaseballData db;
       

        public HomeController(IBaseballData db)
        {
            this.db = db;

        }
        public ActionResult Index()
        {      
            
            //1. Build a model.
            var player = db.GetAllInfo();
         
            //2. Pass the model to the view.
            return View(player);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}