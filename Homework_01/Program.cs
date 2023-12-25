using System;

namespace Homework_01
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            if (args.Length >= 3)
            {
                if (int.TryParse(args[0], out int num1) && int.TryParse(args[2], out int num2))
                {
                    Calculate(num1, num2, args[1]);
                }
            }

            void Calculate(int num1, int num2, string operationSign)
            {
                int summ = 0;

                switch (args[1])
                {
                    case "+":
                        summ = num1 + num2;
                        break;
                    case "-":
                        summ = num1 - num2;
                        break;
                    case "x":
                        summ = num1 * num2;
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            Console.WriteLine("Ошибка, деление на 0");
                            return;
                        }
                        else
                            summ = num1 / num2;
                        break;

                    default:
                        Console.WriteLine("Вы ввели неверный знак операции");
                        return;
                }

                Console.WriteLine($"Результат: {summ}");
            }
        }
    }
}
