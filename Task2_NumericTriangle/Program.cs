class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Введiть висоту трикутника (0 — вихiд): ");

            if (int.TryParse(Console.ReadLine(), out int height))
            {
                if (height == 0)
                    break;

                if (height > 0)
                {
                    for (int i = 1; i <= height; i++)
                    {
                        for (int j = 0; j < height - i; j++)
                        {
                            Console.Write(" ");
                        }

                        for (int k = 0; k < i; k++)
                        {
                            Console.Write($"{i} ");
                        }

                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Будь ласка, введiть додатне число.");
                }
            }
            else
            {
                Console.WriteLine("Некоректне значення.");
            }
        }
    }
}