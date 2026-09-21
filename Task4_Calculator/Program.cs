class Program
{
    static void Main()
    {
        Console.WriteLine("Вводьте вираз через пробiли мiж числами та операторами.");
        Console.WriteLine("Наприклад: 5 + 5 * 10 + 4 / 2 - 3");
        Console.WriteLine("Для виходу введiть 0.");

        while (true)
        {
            Console.Write("\nВведiть вираз: ");
            string expression = Console.ReadLine();

            if (expression == "0")
                break;

            string[] parts = expression.Split(' ');

            if (parts.Length < 3 || parts.Length % 2 == 0)
            {
                Console.WriteLine("Некоректний вираз. Перевiрте формат введення.");
                continue;
            }

            List<double> numbers = new List<double>();
            List<string> operators = new List<string>();

            bool valid = true;

            for (int i = 0; i < parts.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (double.TryParse(parts[i], out double number))
                        numbers.Add(number);
                    else
                    {
                        valid = false;
                        break;
                    }
                }
                else
                {
                    if (parts[i] == "+" || parts[i] == "-" ||
                        parts[i] == "*" || parts[i] == "/")
                    {
                        operators.Add(parts[i]);
                    }
                    else
                    {
                        valid = false;
                        break;
                    }
                }
            }

            if (!valid)
            {
                Console.WriteLine("Некоректний вираз. Використовуйте числа та оператори +, -, *, /.");
                continue;
            }

            bool divisionError = false;

            for (int i = 0; i < operators.Count;)
            {
                if (operators[i] == "*" || operators[i] == "/")
                {
                    if (operators[i] == "/" && numbers[i + 1] == 0)
                    {
                        divisionError = true;
                        break;
                    }

                    if (operators[i] == "*")
                        numbers[i] = numbers[i] * numbers[i + 1];
                    else
                        numbers[i] = numbers[i] / numbers[i + 1];

                    numbers.RemoveAt(i + 1);
                    operators.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }

            if (divisionError)
            {
                Console.WriteLine("Помилка: на нуль дiлити не можна.");
                continue;
            }

            double result = numbers[0];

            for (int i = 0; i < operators.Count; i++)
            {
                if (operators[i] == "+")
                    result += numbers[i + 1];
                else if (operators[i] == "-")
                    result -= numbers[i + 1];
            }

            Console.WriteLine($"Вiдповiдь: {result}");
        }
    }
}