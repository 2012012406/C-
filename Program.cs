using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project8
{
    delegate double F(double  x);
    class Program
    {
        public static double fun(double x)
        {
            return x * x;
        }
        public static double abs(double a)
        {
            if (a > 0)
            {
                return a ;
            }
            else
            {
                return -a;
            }
        }
        public static double getArea(double a, double b, F f)
        {
            int sign = 1;
            if (a > b)
            {
                double t = a;
                a = b;
                b = t;
                sign = -1;
            }
            double h;
            double x;
            double sum = 0;
            int n = 10000;
            h = abs(a - b) / n;
            x = a;
            for (int i = 0; i < n; i++)
            {

                sum += f(x) + f(x + h);
                x = x + h;
            }
            return sum * h / 2 * sign;
        }
        static void Main(string[] args)
        {
            double a = 0;
            double b = 1;
            F f = new F(Program.fun);
            double sum = getArea(a, b, f);
            Console.WriteLine(sum);
        }
    }
}
