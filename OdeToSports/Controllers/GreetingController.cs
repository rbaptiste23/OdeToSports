﻿using OdeToSports.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToSports.Controllers
{
    public class GreetingController : Controller
    {
        // GET: Greeting
        public ActionResult Index(string name)
        {
            var model = new GreetingViewModel();
            model.Message = ConfigurationManager.AppSettings["message"];
            model.Name = name ?? "no name";
            return View(model);



        }
    }
}