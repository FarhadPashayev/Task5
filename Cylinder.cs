using System;

public class Class1
{
	

         public class Cylinder : Figures
    {
        public Cylinder(double radius, double height)
            : base(radius, height)
        {
        }
        public override double Area()
        {
            double area = Math.PI * 2 * a * (a + b);
            return area;
        }
        public override double Volume()
        {
            double volume = Math.PI * a * a * b;
            return volume;
        }
    }
}

