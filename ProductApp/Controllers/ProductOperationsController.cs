﻿using Microsoft.AspNetCore.Mvc;
using ProductApp.Models;
using System.Linq;

namespace ProductApp.Controllers
{
    public class ProductOperationsController : Controller
    {
        Context c =new Context();
        public IActionResult Index()
        {
            return View();
        }
    }
}