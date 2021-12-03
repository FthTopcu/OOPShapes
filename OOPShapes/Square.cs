using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPShapes
{
    public class Square:Shape
    {
        private int _side;
        
        public int Side
        {
            get { return _side; }
            set { _side = value; }
        }
        public Square()
        { 
            Console.WriteLine("Kare");  
        }
        public override void CalculateArea()
        {
            Console.WriteLine("Karenin Alanı");
            area = _side * _side;
            Console.WriteLine(area);
        }
        public override void CalculatePerimeter()
        {
            Console.WriteLine("Karenin çevresi");
            Perimeter = _side * 4;
            Console.WriteLine(Perimeter);
        }
        
    }
}
