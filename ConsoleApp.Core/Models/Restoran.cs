using ConsoleApp.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Core.Models
{
    public class Restoran:BaseModel
    {
        private static int _id;

        public RestoranCategory category { get; set; }

        public List<Product> products { get; set; }

        public Restoran()
        {
            products= new List<Product>();
            _id++;
            id = _id;
        }
    }
}
