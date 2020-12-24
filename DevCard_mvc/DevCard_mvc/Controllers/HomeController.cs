using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DevCard_mvc.Models;
using Microsoft.AspNetCore.Http;
using System;
using FormFactory;
using System.Collections.Generic;
using DocumentFormat.OpenXml.Office2010.Excel;
using Microsoft.AspNetCore.Mvc.Rendering;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.EMMA;

namespace DevCard_mvc.Controllers
{
    public class HomeController : Controller
    {


        private readonly List<Service> _services = new List<Service>()
        {
            new Service(id:1, name:"نقره ای"),
             new Service(id:2, name:"طلایی"),
              new Service(id:3, name:"پلاتین "),
               new Service(id:4, name:"الماس"),
        };
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact
            {
                Services = new SelectList(_services, dataValueField: "Id", dataTextField: "Name")
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Contact(Contact model)
        {

            model.Services = new SelectList(_services, dataValueField: "Id", dataTextField: "Name");

            if (!ModelState.IsValid)
            {
                ViewBag.error = "ارسال پیام شما به مشکل مواجه شد. لطفا دوباره تلاش کنید.";
                return View(model);
            }
            ModelState.Clear();
            model = new Contact
            {
                Services = new SelectList(_services, dataValueField: "Id", dataTextField: "Name")
            };
            ViewBag.success = "ایمیل شما با موفقیت ارسال شد. با تشکر.";
            return View(model);

        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
