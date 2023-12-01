using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1
{
    class Program
    {
        static void Main()
        {
            Pyramid(5);
        }

        static void Pyramid(int Num)
        {
            int number = 1;
            for (int i = 1; i <= Num; i++)
            {
                for (int j = 1; j <= Num - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(number + " ");
                    number++;
                }
                Console.WriteLine();
               
            }
            Console.ReadLine();
        }
    }
}