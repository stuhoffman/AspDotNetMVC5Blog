﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using AspNetBlog.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetBlog.Controllers
{
    public class PostsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        public class CreatePostRequest
        {
            public string Title { get; set; }
            public string Body { get; set; }
        }
        [HttpPost]
        public IActionResult Create(CreatePostRequest request)
        {
            var post = new Post();
            post.Title = request.Title;
            post.Body = request.Body;

            return View();
        }

        public IActionResult Post(long id)
        {
            var post = new Post();

            post.Title = "My Blog Post";
            post.PostedDate = DateTime.Now;
            post.Author = "Stu Hoffman";
            post.Body = "This is the first blog post about ASP.NET MVC 5";
            return View(post);
        }

    }
}