using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas
{
    class Rectangle
    {

        public double Height { get; set; }
        public double Width { get; set; }
        public double Area()
        {
            return Height * Width;
        }

        public double Perimeter()
        {
            return Height * Width;
        }
    }
}
