using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_mvc.Models
{
    public class Service
    {
        public int Id { set; get; }
        public string Name { set; get; }

        public Service(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
