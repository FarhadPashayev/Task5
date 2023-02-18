using System;
using static Class;

public class Class1
{
    internal class Parallelepiped : Cone
    {
        public Parallelepiped(double a, double b, double c)
            : base(a, b, c)
        {
        }
        public override double Area()
        {
            double area = 2 * (a * b + a * length + b * length);
            return area;

        }
        public override double Volume()
        {
            double volume = a * b * length;
            return volume;
        }
    }
}
