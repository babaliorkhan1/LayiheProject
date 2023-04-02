using consoleApp.Service.IServices;
using ConsoleApp.Core.Enums;
using ConsoleApp.Core.Models;
using ConsoleApp.Data.Repositeries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleApp.Service.Services
{
    public class ProductService : IProsuctService
    {
       static RestoranRepositery repooo=new RestoranRepositery();
        public async void Create()
        {
            Product product= new Product();
            Console.WriteLine("enter name: ");
            product.Name = Console.ReadLine();
            Console.WriteLine("enter price: ");
            product.price=double.Parse(Console.ReadLine());
            Console.WriteLine("enter the category: ");
            Console.WriteLine((int)ProductCategory.Blue+":"+ProductCategory.Blue);
            Console.WriteLine((int)ProductCategory.Green + ":" + ProductCategory.Green);
            Console.WriteLine((int)ProductCategory.Red + ":" + ProductCategory.Red);
            int.TryParse(Console.ReadLine(), out int choose);
            switch (choose)
            {
                case 1:
                    product.category=ProductCategory.Blue; break;
                case 2:
                    product.category=ProductCategory.Green; break;
                case 3: 
                    product.category=ProductCategory.Red; break;

                default:
                    break;
            }
            Console.WriteLine("where you wanna add this prodyct?");
            foreach (var item in repooo.GetAll())
            {
                Console.WriteLine($"name:{item.Name} id:{item.id}");
            }
            int.TryParse(Console.ReadLine(), out int choice6);
            Restoran restoran= await repooo.GetAsync(x=>x.id==choice6);
            restoran.products.Add(product);

        }

        public async void Delete()
        {
            Console.WriteLine("where you wanna delete this prodyct?");
            foreach (var item in repooo.GetAll())
            {
                Console.WriteLine($"name:{item.Name} id:{item.id}");
            }
            int.TryParse(Console.ReadLine(), out int choice7);
            Restoran restoran = await repooo.GetAsync(x => x.id == choice7);
            for (int i = 0; i < restoran.products.Count; i++)
            {
                if (restoran.products[i].id == choice7)
                {
                    restoran.products.Remove(restoran.products[i]);
                }
            }
           
        }

        public async void Get()
        {
            Console.WriteLine("in which restoran you wanna find");
            int select57=Convert.ToInt32(Console.ReadLine());
            Restoran restoran = await repooo.GetAsync(w => w.id == select57);
            Console.WriteLine("enter id of the product you wanna find");
            int.TryParse(Console.ReadLine(), out int request);
            foreach (var item in restoran.products)
            {
                if (item.id == request)
                {
                    Console.WriteLine($"id:{item.id} name:{item.Name}  category:{item.category}");
                }
            }
        }

        public async void GetAll()
        {
            Console.WriteLine("where you wanna see?");
            int.TryParse(Console.ReadLine(),out int choice7);   
            Restoran restoran=await repooo.GetAsync(x=>x.id== choice7);
            foreach (var item in restoran.products)
            {
                Console.WriteLine($"id:{item.id} name:{item.Name}  category:{item.category}");
            }

        }

        public async void Update()
        {
            Console.WriteLine("in which restoran you wanna update?");
            int.TryParse(Console.ReadLine(), out int select9);
            Restoran restoran=await repooo.GetAsync(x=>x.id== select9);
            Console.WriteLine("enter id of the product that you wanna update");
            int UpdateId=int.Parse(Console.ReadLine());
            for (int i = 0; i < restoran.products.Count; i++)
            {
                if (restoran.products[i].id == UpdateId)
                {
                    Console.WriteLine("what you wanna change?");
                    Console.WriteLine("1:name");
                    Console.WriteLine("2:category");
                    Console.WriteLine("3:price");
                    int selectcc=int.Parse (Console.ReadLine());

                    switch (selectcc)
                    {
                        case 1:
                            Console.WriteLine("enter new name: ");
                            restoran.products[i].Name = Console.ReadLine(); break;
                        case 2:
                            Console.WriteLine("choose new category");
                            Console.WriteLine((int)ProductCategory.Blue+":"+ProductCategory.Blue);
                            Console.WriteLine((int)ProductCategory.Red + ":" + ProductCategory.Red);
                            Console.WriteLine((int)ProductCategory.Green + ":" + ProductCategory.Green);
                            int choice=Convert.ToInt32(Console.ReadLine());
                            switch (choice)
                            {
                                case 1:
                                    restoran.products[i].category = ProductCategory.Blue; break;
                                case 2:
                                    restoran.products[i].category = ProductCategory.Red; break;
                                case 3:
                                    restoran.products[i].category = ProductCategory.Green; break;
                                default:

                                    break;
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
