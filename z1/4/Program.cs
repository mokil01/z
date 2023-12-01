using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
  class Program
    {
        static void Main(string[] args)
        {
            int[] array = {65, 30, 2, 6, 17, 83, 99, 8, 12, 91};
            Array.Sort(array);
            Console.WriteLine("Отсортированный массив:");
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
     
    }
}