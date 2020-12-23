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
        public string Client { set; get; }

    }
}

