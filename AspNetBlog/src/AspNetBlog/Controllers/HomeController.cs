﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using AspNetBlog.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetBlog.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
             return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public string Echo(string id)
        {
            return id;
        }

        public IActionResult CauseAnError()
        {
            throw new Exception("Error!");
        }
    }

}
