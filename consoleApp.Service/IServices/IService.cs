using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleApp.Service.IServices
{
    public interface IService
    {
        public void Create();

        public void Delete();

        public void Get();

        public void GetAll();

        public void Update();
    }
}
