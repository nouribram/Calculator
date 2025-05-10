﻿using Microsoft.AspNetCore.Mvc;
using myapp.Models;


namespace MyApp.Controllers
{
    public class ItemsController : Controller
    {
        public IActionResult Overview()
        {
            var item = new Item() { Name = "keyboard" };
            return View(item);
        }


        public IActionResult Edit(int itemId)
        {
            return Content("id= " + itemId);
        }
    }
}

