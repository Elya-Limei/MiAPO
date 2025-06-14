using System;

class SimpleCalculator
{
    static void Main()
    {
        Console.WriteLine("Простой консольный калькулятор");
        Console.WriteLine("-----------------------------");
        
        while (true)
        {
            try
            {
                Console.Write("Введите первое число: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Введите оператор (+, -, *, /) или 'q' для выхода: ");
                string op = Console.ReadLine();

                if (op == "q")
                {
                    Console.WriteLine("Выход из калькулятора...");
                    break;
                }

                Console.Write("Введите второе число: ");
                double num2 = double.Parse(Console.ReadLine());

                double result = 0;
                bool validOperation = true;

                switch (op)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            Console.WriteLine("Ошибка: деление на ноль!");
                            validOperation = false;
                        }
                        else
                        {
                            result = num1 / num2;
                        }
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    default:
                        Console.WriteLine("Неверный оператор!");
                        validOperation = false;
                        break;
                }
                
                if (validOperation)
                {
                    Console.WriteLine($"Результат: {num1} {op} {num2} = {result}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введите корректное число!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }

            Console.WriteLine();
        }
    }
}