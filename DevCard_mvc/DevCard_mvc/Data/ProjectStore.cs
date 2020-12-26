using DevCard_mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_mvc.Data
{
    public class ProjectStore
    {

        public static List<Project> GetProjects()
        {
            return new List<Project>
            {
                new Project(id:1, name:"Rimo", description:"the project for students",image:"project-1.jpg", client:"MSA" ),
                 new Project(id:2, name:"Rito", description:"the project for universities",image:"project-2.jpg", client:"MTO" ),
                  new Project(id:3, name:"Rico", description:"the project for schools", image:"project-3.jpg",client:"MRT" ),
                   new Project(id:4, name:"Riso", description:"the project for organisations",image:"project-4.jpg", client:"MCA" ),
            };
        }
        public static Project GetProjectBy(long id)
        {
            return GetProjects().FirstOrDefault(x => x.Id == id);
        }
    }
}
