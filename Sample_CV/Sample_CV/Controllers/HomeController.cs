using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sample_CV.Models;
using System.Diagnostics;

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

        public IActionResult Contact()
        {
            Contact model = new Contact()
            {
                Services = new SelectList(_Services, "ServiceId", "ServiceName")
            };
        
        
            return View(model); 
        }

        [HttpPost]
        public IActionResult Contact(Contact model)
        {
            model.Services = new SelectList(_Services, "ServiceId", "ServiceName");


            if (!ModelState.IsValid)
            {
                ViewBag.Error = "اطلاعات وارد شده صحیح نیست دوباره تلاش کنید. "; 
            }
            else
            {
                ViewBag.Success = "عملیات با موفقیت انجام شد";
            }
            return View(model);
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