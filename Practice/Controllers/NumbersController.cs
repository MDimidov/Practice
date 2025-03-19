﻿using Microsoft.AspNetCore.Mvc;

namespace Practice.Controllers
{
    public class NumbersController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Nums 1 ... 50";

            return View(50);
        }

        [HttpGet]
        public IActionResult NumbersToN(int num)
        {
            if(num < 1)
            {
                return RedirectToAction(nameof(Index), 50);
            }

            ViewBag.Title = $"Nums 1 ... {num}";

            return View("Index", num);
        }

        [HttpPost]
        public IActionResult NumbersToN(int num, string test)
        {
            return View("Index", num);
        }
    }
}
