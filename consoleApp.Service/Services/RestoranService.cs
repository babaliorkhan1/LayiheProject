using consoleApp.Service.IServices;
using ConsoleApp.Core.Enums;
using ConsoleApp.Core.Models;
using ConsoleApp.Data.Repositeries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace consoleApp.Service.Services
{
    public class RestoranService : IRestoranService
    {
      static  RestoranRepositery repositery= new RestoranRepositery();
        public void Create()
        {
            Restoran restoran= new Restoran();
            Console.WriteLine("enter name: ");
            restoran.Name = Console.ReadLine();
            Console.WriteLine("enter category: ");
            Console.WriteLine((int)RestoranCategory.Chinesee+":"+RestoranCategory.Chinesee);
            Console.WriteLine((int)RestoranCategory.Polyac+":"+RestoranCategory.Polyac);
            Console.WriteLine((int)RestoranCategory.Italy+":"+RestoranCategory.Italy);
            int.TryParse(Console.ReadLine(), out int select);

            if (select == (int)RestoranCategory.Chinesee)
            {
                restoran.category= RestoranCategory.Chinesee;
            }
            else if(select==(int)RestoranCategory.Italy)
            {
                restoran.category = RestoranCategory.Italy;
            }
            else if (select == (int)RestoranCategory.Polyac)
            {
                restoran.category = RestoranCategory.Polyac;
            }
            repositery.CreateAsync(restoran);
  
        }

        public async void Delete()
        {
            Console.WriteLine("enter the id of the restoran");
            foreach (var item in repositery.GetAll())
            {
                Console.WriteLine($"name:{item.Name}  category:{item.category} craetedtime:{item.createtime}");
            }
            int.TryParse(Console.ReadLine(), out int select2);
            Restoran restoran=await  repositery.GetAsync(x => x.id == select2);
            repositery.DeleteAsync(restoran);
        }

        public async void Get()
        {
            Console.WriteLine("neter the id");
            int.TryParse(Console.ReadLine(),out int select5);
            Restoran restoran= await repositery.GetAsync(x=>x.id == select5);
            Console.WriteLine($"id:{restoran.id} name:{restoran.Name} category:{restoran.category} created time:{restoran.createtime}");
        }

        public void GetAll()
        {
            foreach (var item in repositery.GetAll())
            {
                Console.WriteLine($"name:{item.Name}  category:{item.category} craetedtime:{item.createtime}");
            }
        }

        public async void Update()
        {
            Console.WriteLine("enter the id");
            foreach (var item in repositery.GetAll())
            {
                Console.WriteLine($"id:{item.id}  name:{item.Name}  category:{item.category} craetedtime:{item.createtime} ");
            }
            int.TryParse (Console.ReadLine(),out int select6);
            Restoran restoran=await  repositery.GetAsync(x=>x.id==select6);
            Console.WriteLine("what do you wanna change?");
            Console.WriteLine("1:name");
            Console.WriteLine("2:category");
            int choice=int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("enter the new name");
                    restoran.Name = Console.ReadLine(); break;
                case 2:
                    Console.WriteLine("enter the new category");
                    Console.WriteLine((int)RestoranCategory.Chinesee+":"+RestoranCategory.Chinesee); 
                    Console.WriteLine((int)RestoranCategory.Polyac+":"+RestoranCategory.Polyac);
                    Console.WriteLine((int)RestoranCategory.Italy + ":" + RestoranCategory.Italy);
                    int choice3=int.Parse(Console.ReadLine());
                    switch (choice3)
                    {
                        case 1:
                            restoran.category = RestoranCategory.Chinesee; break;
                        case 2:
                            restoran.category= RestoranCategory.Polyac; break;
                        case 3:
                            restoran.category=RestoranCategory.Italy; break;
                        default:
                            Console.WriteLine("there are just 3 choices"); break;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
