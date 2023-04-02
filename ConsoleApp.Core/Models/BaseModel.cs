using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Core.Models
{
    public class BaseModel
    {
        public string Name { get; set; }
        
        public int id { get; set; } 

        public DateTime createtime { get; set; }
    }
}
