using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions_SCM
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            cars.Add(new Car("Black"));
            cars.Add(new Car("Purple"));
            cars.Add(new Car("Red"));
            cars.Add(new Car("Green"));
            cars.Add(new Car("Primer Grey"));

            foreach (Car car in cars)
            {
                Console.WriteLine(car.Describe());
            }


            Console.ReadKey();
           


        }
    }
}
       