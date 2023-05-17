using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_1
{
    class Point
    {
        private double x;
        private double y;
        public Point(double x,double y)
        {
            this.x = x;
            this.y = y;
        }
        public void Move()
        {
            x = x - 5;
            y = y + 5;
            Console.WriteLine("x=" + x);
            Console.WriteLine("y=" + y);
        }
        public void Quadrant()
        {
            if (x > 0 && y > 0)
                Console.WriteLine("the coordinate point lise in the first quandrant.");
           else if (x < 0 && y > 0)
                Console.WriteLine("the coordinate point lise in the second quandrant.");
          else  if (x < 0 && y < 0)
                Console.WriteLine("the coordinate point lise in the third quandrant.");
             else if (x > 0 && y < 0)
                Console.WriteLine("the coordinate point lise in the fourth quandrant.");
            else if (x == 0 && y == 0)
                Console.WriteLine("the coordinate point lise in the origin quandrant");
        }
        public void Print()
        {
            Console.WriteLine("(" + x + "," + y + ")");
        }
    }
}
