using DevCard_mvc.Data;
using DevCard_mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DevCard_mvc.ViewComponents
{
    public class ProjectsViewComponent: ViewComponent 
    {       

        public IViewComponentResult Invoke( string name)
        {
            var projects = ProjectStore.GetProjects();
            return View("_Projects", projects);
        }
    }
}
