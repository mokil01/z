using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayNumber = 5; // Замените на нужное значение

            string dayOfWeek = GetDayOfWeek(dayNumber);

            if (dayOfWeek != null)
            {
                Console.WriteLine("День недели: " + dayOfWeek);
            }
            else
            {
                Console.WriteLine("Ошибка!");
               
            }
            Console.ReadLine();
        }

        static string GetDayOfWeek(int dayNumber)
        {
            string dayOfWeek = null;

            switch (dayNumber)
            {
                case 1:
                    dayOfWeek = "Понедельник";
                    break;
                case 2:
                    dayOfWeek = "Вторник";
                    break;
                case 3:
                    dayOfWeek = "Среда";
                    break;
                case 4:
                    dayOfWeek = "Четверг";
                    break;
                case 5:
                    dayOfWeek = "Пятница";
                    break;
                case 6:
                    dayOfWeek = "Суббота";
                    break;
                case 7:
                    dayOfWeek = "Воскресенье";
                    break;
            }

            return dayOfWeek;
           
        }
        
    }
}