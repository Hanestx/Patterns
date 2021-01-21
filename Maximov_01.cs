using System;
using System.Diagnostics;

namespace Math
{
    internal class MathProgram
    {
        private const string _exit = "q";

        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте вас приветствует математическая программа");
            Console.WriteLine($"{_exit} - выход");
            Console.Write("\nВведите число больше 0: ");

            int number = CheckUserInput(Console.ReadLine());
            Calculations();

            int CheckUserInput(string userInput)
            {
                int num;
                while (!Int32.TryParse(userInput, out num) || num <= 0)
                {
                    if (userInput == _exit)
                    {
                        CloseProgram();
                    }

                    Console.Write("Пожалуйста введите число больше '0': ");
                    userInput = Console.ReadLine();
                }

                return num;
            }

            void Calculations()
            {
                int sum = 0;
                int factorial = 0;
                int maxValue = 0;

                for (int i = 0; i <= number; i++)
                {
                    sum = sum + i;
                    factorial = number * i;

                    if (i % 2 == 0 && i < number)
                        maxValue = i;
                }
                
                Output(sum, factorial, maxValue);
                CloseProgram();
            }

            void Output(int sum, int factorial, int maxValue)
            {
                Console.WriteLine($"\nСумма от '1' до '{number}' равна '{sum}'");
                Console.WriteLine($"Факториал числа '{number}' равен '{factorial}'");
                Console.WriteLine($"Максимальное четное число меньше чем '{number}' равно '{maxValue}'");
            }

            void CloseProgram()
            {
                Console.WriteLine("\nВыполнение программы завершено.");
                Console.WriteLine("Нажмите любую клавишу чтобы закрыть окно.");
                Console.ReadKey();

                Process.GetCurrentProcess().Kill();
            }
        }
    }
}

