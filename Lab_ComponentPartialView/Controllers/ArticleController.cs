﻿using Lab_ComponentPartialView.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab_ComponentPartialView.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Index()
        {
            PostViewModel model = new PostViewModel
            {
                Id = 1,
                Title = "What is asp.net core",
                Author = "kishore",
                Body = "ASP.NET Core is an open-source framework for building UI and API..."

            };
            return View(model);
        }
    }
}
