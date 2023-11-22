using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotekaKlas.Lab4
{
    public class Shape
    {
        public int X;
        public int Y;
        public int Height;
        public int Width;


        public virtual string Draw()
        {
            return "Shape";
        }
    }

    public class Rectangle : Shape
    {

        public override string Draw()
        {
            return "Rectangle";
        }

    }

    public class Triangle : Shape
    {
        public override string Draw()
        {
            return "Triangle";
        }
    }

    public class Circle : Shape
    {
        public override string Draw()
        {
            return "Circle";
        }
    }
}
