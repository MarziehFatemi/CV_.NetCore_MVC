﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sample_CV.Models;
using System.Diagnostics;
using Sample_CV.StoredData; 

namespace Sample_CV.Controllers
{
    public class HomeController : Controller
    {
        List<Service> _Services = new List<Service>()
            {
                new Service(1,"دعوت به کار"),
                new Service(2,"درخواست انجام پروژه"),
                new Service(3,"سایر سوالات"),

            };

        public HomeController()
        {
            
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProjectDetails(long id)
        {

            Project project = ProjectsData.GetPorjectBy(id); 

            return View(project); 
        }


        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact
            {
                Services = new SelectList(_Services, "Id", "Name")
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Contact(Contact model)
        {
            model.Services = new SelectList(_Services, "Id", "Name");
            //if(ModelState.IsValid == false)
            if (!ModelState.IsValid)
            {
                ViewBag.error = "اطلاعات وارد شده صحیح نیست. لطفا دوباره تلاش کنید";
                return View(model);
            }

            ModelState.Clear();

            model = new Contact
            {
                Services = new SelectList(_Services, "Id", "Name")
            };
            ViewBag.success = "پیغام شما با موفقیت ارسال شد. باتشکر";
            return View(model);
            //return RedirectToAction("Index");
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