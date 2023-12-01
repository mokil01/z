using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = 31; // Заменить на нужное значение дня
            int month = 12; // Заменить на нужное значение месяца
            int year = 2023; // Заменить на нужное значение года

            bool isDateCorrect = CheckDate(day, month, year);

            if (isDateCorrect)
            {
                Console.WriteLine("the date is correct");
            }
            else
            {
                Console.WriteLine("the date is incorrect");
            }
            Console.ReadLine();
        }

        static bool CheckDate(int day, int month, int year)
        {
            if (month < 1 || month > 12 || year < 1)
            {
                return false;
            }

            int maxDay;

            switch (month)
            {
                case 2:
                    if (DateTime.IsLeapYear(year))
                    {
                        maxDay = 29;
                    }
                    else
                    {
                        maxDay = 28;
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    maxDay = 30;
                    break;
                default:
                    maxDay = 31;
                    break;
            }

            if (day < 1 || day > maxDay)
            {
                return false;
            }

            return true;
            
        }
        
    }
}