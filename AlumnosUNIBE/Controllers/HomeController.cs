﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlumnosUNIBE.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Se realizarons los cambios en el controlador.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Vista de contacto";

            return View();
        }
    }
}
