using System;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_mvc.Models
{
    public class Project
    {
        public long Id { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public string Image { set; get; }
        public string Client { set; get; }

        public Project(long id, string name, string description, string image, string client)
        {
            Id = id;
            Name = name;
            Description = description;
            Client = client;
            Image = image;
        }
    }
}



