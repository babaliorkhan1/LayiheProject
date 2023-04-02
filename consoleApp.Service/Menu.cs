using consoleApp.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleApp.Service
{
    public static class Menu
    {
        public static void Menuu()
        {
            HERE:
            RestoranService service1 = new RestoranService();
            ProductService service2= new ProductService();
            Console.WriteLine("1:Create restoran");
            Console.WriteLine("2:Show all the restoran");
            Console.WriteLine("3:get the restoran by its id");
            Console.WriteLine("4:update restoran");
            Console.WriteLine("5:remove restoran");
            Console.WriteLine("6:create product");
            Console.WriteLine("7:show all the products");
            Console.WriteLine("8:Get product by its id");
            Console.WriteLine("9:update the product");
            Console.WriteLine("10:remove the product");
            Console.WriteLine("0:Stop");

            int select=Convert.ToInt32(Console.ReadLine());
            switch (select)
            {
                case 1:
                    service1.Create(); 
                    goto HERE;
                case 2:
                    service1.GetAll();
                    goto HERE;
                case 3:
                    service1.Get();
                    goto HERE;
                case 4:
                    service1.Update();
                    goto HERE;
                case 5:
                    service1.Delete();
                    goto HERE;
                case 6:
                    service2.Create();
                    goto HERE;
                case 7:
                    service2.GetAll();
                    goto HERE;
                case 8:
                    service2.Get();
                    goto HERE;
                case 9:
                    service2.Update();
                  goto HERE;
                case 10:
                    service2.Delete();
                    goto HERE;
                case 0:
                   break;
                default:
                    break;
            }
        }
    }
}
