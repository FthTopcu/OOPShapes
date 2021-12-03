using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPShapes
{
    public class Rectangle:Shape
    {
        private int _height;

        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }
        private int _width;

        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }
        public Rectangle()
        {
            
            Console.WriteLine("Dikdörtgen");
        }

        public override void CalculateArea()
        {
            Console.WriteLine("Dikdörtgenin alanı");
            area = _height * _width;
            Console.WriteLine(area);
        }
        public override void CalculatePerimeter()
        {
            Console.WriteLine("Dikdörtgenin çevresi");
            Perimeter = (_height * 2) + (_width * 2);
            Console.WriteLine(Perimeter);
        }
    }
}
