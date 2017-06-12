using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CarPassport
    {
        public Driver Owner { get; set; }
        public Car Car { get; }

        public CarPassport(Driver driver, Car car)
        {
            Owner = driver;
            Car = car;
        }

        public void Inform()
        {
            Console.WriteLine("Хозяин машины: {0} ", Owner.Name);
            Console.WriteLine("Номер машины: {0}", Car.CarNumber);
        }
    }
}
