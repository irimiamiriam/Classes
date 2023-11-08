using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Car
    {
        public string color;
        public string name;
        public int year;
        public int maxSpeed;
        public Car(string nameC, string colorC, int yearC, int maxC)
        {
            name = nameC;
            color = colorC;
            year = yearC;
            maxSpeed = maxC;

        }

        public Car (string nameC)
        {
            name = nameC;
        }

        public void Display()
        {
            Console.WriteLine(name);
            Console.WriteLine(year);
            Console.WriteLine(color);
            Console.WriteLine(maxSpeed);
            fullThrottle();
            Console.WriteLine();
        }
        public void fullThrottle()
        {
            Console.WriteLine(name + " is going at the speed of " + maxSpeed);
        }

    }
}
