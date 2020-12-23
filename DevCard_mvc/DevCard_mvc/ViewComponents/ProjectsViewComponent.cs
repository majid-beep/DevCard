using DevCard_mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DevCard_mvc.ViewComponents
{
    public class ProjectsViewComponent: ViewComponent 
    {
        

        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>
            {
                new Project(id:1, name:"Rimo", description:"the project for students",image:"project-1.jpg", client:"MSA" ),
                 new Project(id:2, name:"Rito", description:"the project for universities",image:"project-2.jpg", client:"MTO" ),
                  new Project(id:3, name:"Rico", description:"the project for schools", image:"project-3.jpg",client:"MRT" ),
                   new Project(id:4, name:"Riso", description:"the project for organisations",image:"project-4.jpg", client:"MCA" ),
            };
            return View("_Projects", projects);
        }
    }
}
