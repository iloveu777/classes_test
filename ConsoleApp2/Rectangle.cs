using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public double CalculateArea()
        { 
        double s = Width * Height;
            return s;
        }
        public double Perimetr()
        { 
            double p = 2 * (Width + Height);
            return p;
        }
    }
}
