using DevCard_mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DevCard_mvc.ViewComponents
{
    public class LatestArticlesViewComponent: ViewComponent
    {
       public IViewComponentResult Invoke()
        {
            var articles = new List<Article>
            {
                new Article( id:1, title:" ویندوز ", description:"آموزش ویندورز" , image:"blog-post-thumb-card-1.jpg" ),
                 new Article( id:2, title:"  ورد ", description:"آموزش ورد" , image:"blog-post-thumb-card-2.jpg" ),
                  new Article( id:3, title:" اکسل ", description:"آموزش اکسل" , image:"blog-post-thumb-card-3.jpg" ),
                   new Article( id:4, title:" سی شارپ ", description:"آموزش  سی شارپ" , image:"blog-post-thumb-card-4.jpg" ),

            };
            return View("_LatestArticles", articles);
        }
    }
}
