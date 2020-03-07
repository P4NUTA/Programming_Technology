using System;

namespace Distance
{
    class Program
    {
        public struct Distance
        {
            private int foot;
            private int inch;
            public Distance(int foot, int inch)
            {
                this.foot = foot;
                this.inch = inch;
            }
            public static Distance AddDist(Distance a, Distance b)
            {
                Distance c;
                c.foot = a.foot + b.foot;
                c.inch = a.inch + b.inch;
                c.foot += c.inch / 12;
                c.inch %= 12;
                return c;
            }
            public void ShowDist()
            {
                Console.WriteLine("foot = {0}\tinch = {1}", this.foot, this.inch);
            }
        }
        static void Main(string[] args)
        {
            Distance a = new Distance(3, 5);
            Distance b = new Distance(4, 10);
            Distance c;
            c = Distance.AddDist(a, b);
            c.ShowDist();
        }
    }
}
