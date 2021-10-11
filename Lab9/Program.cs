using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0;
            Console.WriteLine("Вас приветствует калькулятор!");
            Console.Write("Введите целое число: Х=");
            try
            {
                x = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Write("Введите целое число: Y=");
            try
            {
                y = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Ошибка! Входная строка имела неверный формат.");
            }


            double result = Calc(x, y);
            Console.WriteLine("Результат: {0:f2}", result);
            Console.ReadKey();

        }
        static double Calc(int x, int y)
        {
            double result = 0;
            int option = 0;
            Console.Write("Введите код операции:\n   1 - Сложение\n   2 - Вычитание\n   3 - Произведение\n   4 - Частное\nВаш выбор:");
            try
            {
                option = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

            switch (option)
            {
                case 1:
                    result = x + y;
                    break;
                case 2:
                    result = x - y;
                    break;
                case 3:
                    result = x * y;
                    break;
                case 4:
                    try
                    {
                        result = x / y;
                    }
                    catch (DivideByZeroException ex) when (y==0)
                    {
                        Console.WriteLine(ex.Message);
                       
                    }

                    break;
                default:
                    Console.WriteLine("Ошибка.");
                    break;
            }

            return result;
        }
    }
}
