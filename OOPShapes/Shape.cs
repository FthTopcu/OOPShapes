using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOPShapes
{
    public abstract class Shape
    {
        private int _area;

        protected int area
        {
            get { return _area; }
            set { _area = value; }
        }
        private int _color;
        
        public int Color
        {
           
            get { return _color; }
            set { _color = value; }
        }
        private int _perimeter;

        protected int Perimeter
        {
            get { return _perimeter; }
            set { _perimeter = value; }
        }
        public abstract void CalculateArea();
        public abstract void CalculatePerimeter();

        public Shape()
        {
           
        }


    }
}
