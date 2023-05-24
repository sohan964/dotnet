using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raju
{
    public abstract class Figure
    {
        public double Width, Height, Radius;
        public const float Pi = 3.14f;
        public abstract double GetArea();
    }
    public class Rectangle : Figure
    {
        public Rectangle(double Width, double Hieght)
        {
            this.Width = Width;
            this.Height = Hieght;
        }
        public override double GetArea()
        {
            return Height*Width;
        }

        static void Main(string[] args)
        {
            Rectangle R1 = new Rectangle((double)2.7571, (double)3.25574);

            Console.WriteLine(R1.GetArea());
        }
    }
}
