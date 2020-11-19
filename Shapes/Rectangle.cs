using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private readonly double width;
        private readonly double hieght;

        public Rectangle(double width, double hieght)
        {
            this.width = width;
            this.hieght = hieght;
        }

        public override double CalculateArea()
        {
            return width * hieght;
        }

        public override double CalculatePerimeter()
        {
            return 2 * width + 2 * hieght;
        }

        public override string Draw()
        {
            return "Rectangle";
        }
    }
}
