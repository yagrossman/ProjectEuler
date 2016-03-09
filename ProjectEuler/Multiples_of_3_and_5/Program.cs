using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples_of_3_and_5
{
   class Program
   {
      static void Main(string[] args)
      {
         int sumMultiples = 0;
         Console.WriteLine("Please Enter Max Value: ");
         int maxValue = int.Parse(Console.ReadLine());
         for (int i = 1; i < maxValue; i++)
         {
            if (i % 3 == 0 || i % 5 == 0)
               sumMultiples += i;
         }
         Console.WriteLine("The sum of all the multiples of 3 or 5 below "+ maxValue+" is:");
         Console.WriteLine(sumMultiples);
         Console.WriteLine("Press Enter to Exit.");
         Console.ReadLine();
      }
   }
}
