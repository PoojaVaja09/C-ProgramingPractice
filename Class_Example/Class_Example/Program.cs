using System;
using System.Xml.Schema;

namespace Class_Example
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Car car = new Car();
            Console.WriteLine(car.color);
            Car car1 = new Car("Purple", "Honda");
            Console.WriteLine(car1.color);
            car1.DisplayName();

            Console.ReadLine();
        }
        

    }
}
