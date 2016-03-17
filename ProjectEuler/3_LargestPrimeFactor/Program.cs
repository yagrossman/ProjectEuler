using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_LargestPrimeFactor
{
   class Program
   {
      static void Main(string[] args)
      {
         double number = 600851475143;
         Console.WriteLine(largestPrimeFactor(number));
         Console.Read();
      }

      public static double largestPrimeFactor(double number)
      {
         double[] factors = new double[1000];
         int factorsPos = 0;
         int d = 2;
         while (number > 1)
         {
            while (number % d == 0)
            {
               factors[factorsPos++] = d;
               number /= d;
            }
            d = d + 1;
            if (d * d > number)
            {
               if (number > 1)
               {
                  factors[factorsPos++] = number;
                  break;
               }
            }
         }
         double largestPrime = factors.Max();
         return largestPrime;
      }
   }
}
