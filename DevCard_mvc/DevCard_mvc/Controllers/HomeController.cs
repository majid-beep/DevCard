using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DevCard_mvc.Models;
using Microsoft.AspNetCore.Http;
using System;
using FormFactory;

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
        public IActionResult Contact(Contact model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.error = "ارسال پیام شما به مشکل مواجه شد. لطفا دوباره تلاش کنید.";
                return View(model);
            }
            ViewBag.success= "ایمیل شما با موفقیت ارسال شد. با تشکر.";
            return View();

        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
