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
            Console.WriteLine("Вас приветствует калькулятор!");

            try
            {
                Console.Write("Введите целое число: Х=");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите целое число: Y=");
                int y = Convert.ToInt32(Console.ReadLine());
                Calc(x, y);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка! {0}", ex.Message);
            }
            Console.ReadKey();
        }


        static void Calc(int x, int y)
        {

                Console.Write("Введите код операции:\n   1 - Сложение\n   2 - Вычитание\n   3 - Произведение\n   4 - Частное\nВаш выбор:");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Результат: {0}", x + y);
                        break;
                    case 2:
                        Console.WriteLine("Результат: {0}", x - y);
                        break;
                    case 3:
                        Console.WriteLine("Результат: {0}", x * y);
                        break;
                    case 4:
                        try
                        {
                            Console.WriteLine("Результат: {0:f2}", (double)x / y);
                        }
                        catch (DivideByZeroException ex)
                        {
                            Console.WriteLine("Ошибка! {0}", ex.Message);
                        }

                        break;
                    default:
                        Console.WriteLine("Ошибка. Нет операции с указанным номером");
                        break;
                }
        }
    }
}
