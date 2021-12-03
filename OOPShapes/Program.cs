using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPShapes
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle();
            c1.Radius = 5;
            c1.CalculateArea();
            c1.CalculatePerimeter();

            Rectangle r1 = new Rectangle();
            r1.Height = 5;
            r1.Width = 12;
            r1.CalculateArea();
            r1.CalculatePerimeter();

            Square s1 = new Square();
            s1.Side = 6;
            s1.CalculateArea();
            s1.CalculatePerimeter();

            Console.ReadKey();

        }

       
    }
}
