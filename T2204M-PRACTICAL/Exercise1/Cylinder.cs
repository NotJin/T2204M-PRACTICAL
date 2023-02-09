using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2204M_PRACTICAL.Exercise1
{
    public class Cylinder
    {

        private double radius;
        private double height;
        private double basearea;
        private double laterarea;
        private double totalarea;
        private double volume;

        public Cylinder(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }
        public void Process()
        {
            basearea = radius*radius*Math.PI;
            laterarea= 2*height*radius*Math.PI;
            totalarea = 2*radius*Math.PI*(height+radius);
            volume = Math.PI * radius * radius * height;
        }

        public void Result()
        {
            Console.WriteLine("Base Area: " + basearea);
            Console.WriteLine("Lateral Area: " + laterarea);
            Console.WriteLine("Total Area: " + totalarea);
            Console.WriteLine("Volume: " + volume);
        }


    }
}
