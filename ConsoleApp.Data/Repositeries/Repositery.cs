using ConsoleApp.Core.InterfaceRepooo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Data.Repositeries
{
    public class Repositery<T> : IRepositery<T>
    {
       static List<T> restorans= new List<T>();   
        public async Task CreateAsync(T model)
        {
            restorans.Add(model);
        }

        public async Task DeleteAsync(T model)
        {
            restorans.Remove(model);
        }

        public List<T> GetAll()
        {
            return restorans; 
        }

        
        public async Task<T> GetAsync(Func<T, bool> expression)
        {
            T restoran=restorans.FirstOrDefault(expression);
            return restoran;
        }
    }
}
