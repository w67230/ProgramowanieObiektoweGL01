using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotekaKlas.Lab5
{
    public abstract class Shape
    {

        public abstract float CalculateArea();
    }

    public class Square : Shape
    {

        private float a;

        public Square(float a)
        {
            this.a = a;
        }
        public override float CalculateArea()
        {
            return this.a * this.a;
        }
    }

    public class Triangle : Shape
    {
        private float a;
        private float h;

        public Triangle(float a, float h)
        {
            this.a = a;
            this.h = h;
        }
        public override float CalculateArea()
        {
            return this.a / 2 * this.h;
        }
    }
}
