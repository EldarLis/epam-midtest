using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            PowNumber wo = new PowNumber();
            double w = wo.Root();

            Console.WriteLine("Root is: {0}", w);
        }
    }


    class PowNumber
    {
        public double x, n, eps, term = 2;
        public PowNumber(double x, double n, double eps)
        {
            this.x = x;
            this.n = n;
            this.eps = Math.Pow(10, -eps);
        }

        public PowNumber()
        {
            Console.WriteLine("Input x: ");
            this.x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input root to find [n]: ");
            this.n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input precision [epsilon] where [epsilon] is negative power of 10( 10^(-[epsilon]) ): ");
            this.eps = Convert.ToDouble(Console.ReadLine());
            this.eps = Math.Pow(10, -eps);
        }

        public void RootFind()
        {

            while (Math.Abs(this.x - Math.Pow(this.term, this.n)) >= this.eps)
            {
                double v = 1.0 / this.n;
                this.term = v * ((this.n - 1) * this.term + this.x / (Math.Pow(this.term, (this.n - 1))));
            }
        }

        public double Root()
        {
            RootFind();

            return term;
        }
    }
}
