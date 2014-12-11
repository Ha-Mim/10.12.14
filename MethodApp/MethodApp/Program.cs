using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodApp
{
    class Program
    {
        private static void Main(string[] args)
        {
            double i = 11;

            int a = 100;
            long b = a;

            long c = 20;
            int d = (int)c;

            double result = GetSquare(i);
            Console.WriteLine(result);
            Console.ReadLine();

        }

        private static double GetSquare(double aValue)
        {
         double square = aValue*aValue;
            return square;
        }


    }
}
