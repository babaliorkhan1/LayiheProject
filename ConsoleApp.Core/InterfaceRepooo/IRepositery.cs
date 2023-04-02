using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Core.InterfaceRepooo
{
    public interface IRepositery<T>
    {
        public Task CreateAsync(T model);

        public Task DeleteAsync(T model);

        public List<T> GetAll();

        public Task<T> GetAsync(Func<T, bool> expression);


    }
}
