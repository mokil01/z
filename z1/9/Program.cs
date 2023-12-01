using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод типа показа
            Console.Write("Введите тип показа (премьера/обычный/льготный): ");
            string type = Console.ReadLine();

            // Ввод количества строк и столбцов в зале
            Console.Write("Введите количество строк: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов: ");
            int cols = int.Parse(Console.ReadLine());

            // Расчет стоимости билетов
            int price;
            switch (type)
            {
                case "премьера":
                    price = 600;
                    break;
                case "обычный":
                    price = 410;
                    break;
                case "льготный":
                    price = 250;
                    break;
                default:
                    Console.WriteLine("Неверный тип показа");
                    return;
            }

            // Расчет общего дохода
            int totalIncome = price * rows * cols;

            // Вывод результата
            Console.WriteLine("Общий доход от билетов: {0} рублей", totalIncome);
            Console.ReadLine();
        }
    }
}
