using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPShapes
{
    public class Circle:Shape
    {
        private int _radius;

        public int Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }
        public Circle()
        {
            
            Console.WriteLine("Daire ");
            
        }
        public override void CalculateArea()
        {
            Console.WriteLine("Dairenin alanı");
            area = 3 * _radius * _radius;
            Console.WriteLine(area);
        }
        public override void CalculatePerimeter()
        {
            Console.WriteLine("Dairenin çevresi");
            Perimeter = 2 * 3 * _radius;
            Console.WriteLine(Perimeter);
        }
    }
}
