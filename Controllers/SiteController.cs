﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminLte_By_Vrilsoft.Controllers
{
    public class SiteController : Controller
    {
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
        public ActionResult Team()
        {
            return View();
        }
        public ActionResult EmailUs()
        {
            return View();
        }
        public ActionResult Privacy()
        {
            return View();
        }
    }
}