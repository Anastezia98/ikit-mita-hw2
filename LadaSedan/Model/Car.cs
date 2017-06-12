using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Model
{
    public class Car
    {
        public string Model { get; }
        public Category Category { get; }
        public Color Color { get; set; } = Color.Blue;
        public string CarNumber { get; internal set; }
        public CarPassport CarPassport { get; }

        public Car(string model, Category category, string number, Driver driver)
        {
            Model = model;
            Category = category;
            CarNumber = number;
            CarPassport = new CarPassport(driver, this);
        }

        public void ChangeOwner(Driver driver, string number)
        {
            driver.OwnCar(this);
            int a = 0;
            foreach (var c in driver.Categories)
            {
                if (this.Category == c)
                {
                    CarPassport.Owner = driver;
                    CarPassport.Car.CarNumber = number;
                    a += 1;
                }
            }
            CarPassport.Inform();
        }
    }
   

}
