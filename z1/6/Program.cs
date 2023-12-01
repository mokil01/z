using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 2; // Замените на нужное значение
            int l = 4; // Замените на нужное значение

            GeneratePasswords(n, l);
        }

        static void GeneratePasswords(int n, int l)
        {
            for (int symbol1 = 1; symbol1 <= n; symbol1++)
            {
                for (int symbol2 = 1; symbol2 <= n; symbol2++)
                {
                    for (int symbol3 = 0; symbol3 < l; symbol3++)
                    {
                        char char3 = (char)('a' + symbol3);

                        for (int symbol4 = 0; symbol4 < l; symbol4++)
                        {
                            char char4 = (char)('a' + symbol4);

                            for (int symbol5 = Math.Max(symbol1, symbol2) + 1; symbol5 <= 9; symbol5++)
                            {
                                string password = $"{symbol1}{symbol2}{char3}{char4}{symbol5}";
                                Console.WriteLine(password);
                                

                            }
                            
                        }
                    }
                }
            }
            Console.ReadLine();
        }
        
    }
    
}