using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Class_Example
{
    public class Car
    {
        public string color;
        private string name;

        public Car()
        {
            color = "Red";
            name = "Honda";
        }
        public Car(string colorparam,string nameparam)
        {
            color = colorparam;
            name = nameparam;
        }

        public void DisplayName()
        {
            Console.WriteLine(name);
        }
    }
}
