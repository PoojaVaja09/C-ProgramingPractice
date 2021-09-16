using System;

namespace Keyword_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Car mycar = new Car();
            Console.WriteLine("Colore Before" + mycar.color);
            mycar.color = "Blue";
            Console.WriteLine("Colore After" + mycar.color);


        }
    }
}
