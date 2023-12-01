using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число N:");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число M:");
            int M = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число S:");
            int S = Convert.ToInt32(Console.ReadLine());

            for (int i = M; i >= N; i--)
            {
                if (i % 2 == 0 && i % 3 == 0 && i != S)
                {
                    Console.WriteLine(i);
                  
                }
                else if (i == S)
                {
                    
                    break;
                    
                }
                

            }
            Console.ReadLine();
        }
        
    }
}