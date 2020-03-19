using System;
using System.Collections.Generic;
using System.Text;

namespace Triangle
{
    class Triangle
    {
        private double side1 { get; set; }
        private double side2 { get; set; }
        private double side3 { get; set; }

        public Triangle(double a, double b, double c)
        {
            this.side1 = a;
            this.side2 = b;
            this.side3 = c;
        }
       public void SideLength()
        {
            Console.WriteLine("Side Length");
            Console.WriteLine("Side 1: {0}",side1);
            Console.WriteLine("Side 2: {0}",side2);
            Console.WriteLine("Side 3: {0}",side3);
            Console.WriteLine("");

        }
        public double Square()
        {
            try
            {
                if (side1 >= side2 + side3 || side2 >= side1 + side3 || side3 >= side1 + side2)
                    throw new Exception("Incorrect side length");

                double P = side1 + side2 + side3;
                double S = Math.Sqrt(P * (P - side1) * (P - side2) * (P - side3));
                return S;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
                return 0;
            }
        }
        public double Perimeter()
        {
            try
            {
                if (side1 >= side2 + side3 || side2 >= side1 + side3 || side3 >= side1 + side2)
                    throw new Exception("Incorrect side length");

                double P = side1 + side2 + side3;
                return P;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
                return 0;
            }
        }
    }
}
