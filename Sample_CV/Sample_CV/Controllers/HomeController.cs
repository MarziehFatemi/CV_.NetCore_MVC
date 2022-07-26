﻿using Microsoft.AspNetCore.Mvc;
using Sample_CV.Models;
using System.Diagnostics;

namespace Sample_CV.Controllers
{
    public class HomeController : Controller
    {
       
        public HomeController()
        {
            
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            Contact contact = new Contact(); 
            return View(contact); 
        }

        [HttpPost]
        public JsonResult Contact(IFormCollection form)
        {
            return Json(Ok());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}