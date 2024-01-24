using System;
using System.Collections.Generic;
using System.Text;

namespace Laby.Zadania
{
    public abstract class Kształt
    {
        public float X;
        public float Y;
        public static List<Kształt> listaKształtów = new List<Kształt>();

        protected Kształt(float x, float y)
        {
            this.X = x;
            this.Y = y;
            listaKształtów.Add(this);
        }

        public abstract float zwrocPole();
        public abstract float zwrocObwod();
    }

    public class Prostokat : Kształt
    {
        public Prostokat(float x, float y) :base(x, y)
        {

        }

        public override float zwrocObwod()
        {
            return 2*this.X + 2*this.Y;
        }

        public override float zwrocPole()
        {
            return this.X*this.Y;
        }
    }

    public class Trojkat : Kształt
    {

        public float Z { get; set; }
        public float H { get; set; }

        public Trojkat(float x, float y, float z, float h) : base(x, y)
        {
            this.Z = z;
            this.H = h;
        }
        public override float zwrocObwod()
        {
            return this.X + this.Y + this.Z;
        }

        public override float zwrocPole()
        {
            return 0.5F*this.X*this.H;
        }
    }
}
