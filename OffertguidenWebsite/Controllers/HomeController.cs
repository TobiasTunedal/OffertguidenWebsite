﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OffertguidenWebsite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult OmOss()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult Bostadsrattsforening()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privatkund()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult Foretagskund()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult Blogg()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult Referenser()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Ref1()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Login()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult LoggedIn()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult CreateBlog()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }


    }
}
