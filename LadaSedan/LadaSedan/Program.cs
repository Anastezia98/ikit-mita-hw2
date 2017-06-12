using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace LadaSedan
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime date = new DateTime(2015,02,01);
            //Driver d1 = new Driver("Петя",date,"A,B");
            //Car c1 = new Car();
            //c1.Category = 'B';
            //try
            //{
            //   d1.OwnCar(c1);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
                
            //}
            
            //Console.WriteLine(d1.Expirience);
            Driver driver1 = new Driver("Иван",new DateTime(2014,02,03));
            driver1.Categories.Add(Category.B);
            Driver driver2 = new Driver("Пётр", new DateTime(2016,05,01));
            Car car1 = new Car("Lada Sedan",Category.B, "ВР231А",driver1);
            
            Console.WriteLine("Водитель: {0}; Опыт вождения {1} года",driver1.Name, driver1.Expirience);
            driver1.OwnCar(car1);
            car1.ChangeOwner(driver2, "КА131Д");
            Console.WriteLine(car1.Color);
            Console.ReadKey();
        }
    }
}
