using System;
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
            Post[] posts = {
                new Post
                {
                Title = "My Blog Post #1",
                PostedDate = DateTime.Now,
                Author = "Stu Hoffman",
                Body = "This is the first blog post about ASP.NET MVC 5",
                },
                new Post
                {
                    Title = "My Blog Post #2",
                    PostedDate = DateTime.Now,
                    Author = "Stu Hoffman",
                    Body = "This is the first blog post about ASP.NET MVC 5",
                },
                new Post
                {
                    Title = "My Blog Post #3",
                    PostedDate = DateTime.Now,
                    Author = "Stu Hoffman",
                    Body = "This is the first blog post about ASP.NET MVC 5",
                }

            };
            return View(posts);
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

        public string Echo(string id)
        {
            return id;
        }

    }

}
