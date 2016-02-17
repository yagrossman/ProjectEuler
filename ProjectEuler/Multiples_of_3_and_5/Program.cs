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
         int count = 0;
         int[] validMultiples = { 0 };
         Console.WriteLine("Please Enter Max Value: ");
         int maxValue = int.Parse(Console.ReadLine());
         for (int i = 1; i < maxValue; i++)
         {
            if ((3 * i) < maxValue)//valid multiple of 3
            {
               validMultiples[count] = 3 * i;
               count++;
            }
            else if ((5 * i) < maxValue)//valid multiple of 5
            {
               validMultiples[count] = 5 * i;
               count++;
            }
         }
         int sumValidMultiples = 0;
         for (int x = 0; x < validMultiples.Length; x++)//sum up the valid multiples
         {
            sumValidMultiples += validMultiples[x];
         }
         Console.WriteLine(sumValidMultiples);
         Console.ReadLine();
      }
   }
}
