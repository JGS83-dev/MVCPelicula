﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text.Encodings.Web;

namespace MVCPelicula.Controllers
{
    public class HelloWorldController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Welcome(string nombre,int numVeces = 1)
        {
            ViewData["nombre"] = "Hola " + nombre;
            ViewData["numVeces"] = numVeces;
            return View();
        }
    }
}