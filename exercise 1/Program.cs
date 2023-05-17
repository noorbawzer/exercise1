using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the coordinates x:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the coordinates y:");
            double y = Convert.ToDouble(Console.ReadLine());
            Point p = new Point(x,y);
            p.Move();
            p.Quadrant();
            p.Print();
        }
    }
}
