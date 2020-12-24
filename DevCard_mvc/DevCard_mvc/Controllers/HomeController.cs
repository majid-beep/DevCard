using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DevCard_mvc.Models;
using Microsoft.AspNetCore.Http;
using System;

namespace DevCard_mvc.Controllers
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

        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact();
            return View(model);
        }

        [HttpPost]
        public JsonResult Contact(Contact form)
        {
            Console.WriteLine(form.ToString());
            return Json(Ok());
        }
       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
