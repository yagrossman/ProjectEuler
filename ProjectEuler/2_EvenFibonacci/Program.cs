using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_EvenFibonacci
{
   class Program
   {
      static void Main(string[] args)
      {
         int fibonacciTerm1 = 1,fibonacciTerm2 = 2, sumFibonacci = 0;
         while (fibonacciTerm2 < 4000000)
         {
            if (fibonacciTerm2 % 2 == 0)
               sumFibonacci += fibonacciTerm2;
            int fibonacciTermNew = fibonacciTerm1 + fibonacciTerm2;
            fibonacciTerm1 = fibonacciTerm2;
            fibonacciTerm2 = fibonacciTermNew;
         }
         Console.WriteLine(sumFibonacci);
         Console.ReadLine();
      }
   }
}
