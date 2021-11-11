using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas
{
    class Triangle
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public double Area()
        {
            double semi_perimeter = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(semi_perimeter * (SideA - semi_perimeter) * (SideB - semi_perimeter) * (SideC - semi_perimeter));
        }

        public double Perimeter()
        {
            return SideA + SideB + SideC;
        }
    }
}
