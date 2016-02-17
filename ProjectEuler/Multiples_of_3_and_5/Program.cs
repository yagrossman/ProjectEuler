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
         Console.WriteLine("Please Enter Max Value: ");
         int maxValue = int.Parse(Console.ReadLine());
         int[] validMultiples = new int[maxValue];
         for (int i = 1; i < maxValue; i++)
         {
            int mult3 = 3 * i;
            int mult5 = 5 * i;
            if (mult3 < maxValue)//valid multiple of 3
            {
               validMultiples[count] = mult3;
               count++;
            }
            if (mult5 < maxValue)//valid multiple of 5
            {
               validMultiples[count] = mult5;
               count++;
            }
         }
         //remove doubles
         var uniqueValidMultiples = validMultiples.Distinct().ToArray();
         //sum em up!!!
         int sumValidMultiples = 0;
         for (int z = 0; z < uniqueValidMultiples.Length; z++)//sum up the valid multiples
         {
            sumValidMultiples += uniqueValidMultiples[z];
         }
         Console.WriteLine("The sum of all the multiples of 3 or 5 below "+ maxValue+":");
         Console.WriteLine(sumValidMultiples);
         Console.WriteLine("Press Enter to Exit.");
         Console.ReadLine();
      }
   }
}
