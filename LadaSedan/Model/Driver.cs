using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Driver
    {
        public string Name { get; }
        public DateTime LicenceDate { get; }
        public int Expirience {
            get
            {
                if (DateTime.Now.Month >= LicenceDate.Month)
                { return DateTime.Now.Year - LicenceDate.Year;}
                else
                {
                    return DateTime.Now.Year - LicenceDate.Year - 1;
                }
            }
        }

        public Driver(string name, DateTime ld)
        {
            Name = name;
            LicenceDate = ld;
            Categories = new List<Category>();
        }

        public List<Category> Categories { get; set; }

        public Car Car { get; internal set; }

        public void OwnCar(Car car)
        {
            int a = 0;
            foreach (var c in Categories)
            {
                if (car.Category == c)
                {
                    this.Car = car;
                    a += 1;
                }
            }
            if (a > 0)
            {
                Console.WriteLine("Подходящая категория!");
            }
            else
            {
                Console.WriteLine("У водителя нет подходящей категории");
            }

        }

    }

    public enum Category
    {
        A,
        B,
        C,
        D
    }

}