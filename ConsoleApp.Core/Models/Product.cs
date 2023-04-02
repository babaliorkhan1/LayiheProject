using ConsoleApp.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Core.Models
{
    public class Product:BaseModel
    {
        public double price { get; set; }

        private int _id;

        public ProductCategory category { get; set; }

        public Product()
        {
            _id++;
            id = _id;
        }
    }
}
