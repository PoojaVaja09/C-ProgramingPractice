using System;

namespace Assessment2
{
    class Program
    {
        static void Main(string[] args)
        {
            double ACircle = Area.AreaOfCircle(3.4);
            Console.WriteLine("Area of Circle is: {0} ", ACircle);


            double ATriangle = Area.AreaOfTriangle(3.5, 2);
            Console.WriteLine("Area of Trianle is: {0}", ATriangle);

            Area area = new Area();
            double ATrapezium = area.AreOfTrapezium(3.4, 5, 1.5);
            Console.WriteLine("Area of Trepezuim is :{0}", ATrapezium);

        }
    }
}
