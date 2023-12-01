using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число:");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите индекс N:");
            int index = Convert.ToInt32(Console.ReadLine());

            FindNthDigit(number, index);
        }

        static void FindNthDigit(int number, int index)
        {
            int count = 0;
            while (number != 0)
            {
                count++;
                if (count == index)
                {
                    Console.WriteLine("N-я цифра числа: " + number % 10);
                    return;
                }
                number = number / 10;
            }
            Console.WriteLine("Индекс выходит за пределы числа");
            Console.ReadLine();

        }
        
    }
}