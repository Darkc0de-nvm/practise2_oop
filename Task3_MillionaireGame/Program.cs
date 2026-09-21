class Program
{
    static void Main()
    {
        int score = 0;

        string[] questions = {
            "Який океан є найбiльшим на Землi?",
            "Скiльки бiт мiститься в одному байтi?",
            "Яка хiмiчна формула чистої води?",
            "Який девайс вважається «серцем» комп'ютера?",
            "Скiльки днiв у звичайному (не високосному) роцi?"
        };

        string[][] options = {
            new string[] { "1. Атлантичний", "2. Тихий", "3. Iндiйський", "4. Пiвнiчний Льодовитий" },
            new string[] { "1. 4", "2. 8", "3. 16", "4. 32" },
            new string[] { "1. CO2", "2. NaCl", "3. H2O", "4. O2" },
            new string[] { "1. Процесор (CPU)", "2. Оперативна пам'ять (RAM)", "3. Жорсткий диск (HDD)", "4. Блок живлення" },
            new string[] { "1. 300", "2. 366", "3. 360", "4. 365" }
        };

        int[] correctAnswers = { 2, 2, 3, 1, 4 };

        for (int i = 0; i < questions.Length; i++)
        {
            Console.WriteLine($"Current User Score: {score}");
            Console.WriteLine($"Питання {i + 1}. {questions[i]}");

            foreach (var option in options[i])
            {
                Console.WriteLine(option);
            }

            Console.Write("Ваш вибiр: ");

            if (!int.TryParse(Console.ReadLine(), out int answer) || answer < 1 || answer > 4)
            {
                Console.WriteLine("Оберiть вiдповiдь iз запропонованих (1–4)!");
                i--;
                continue;
            }

            if (answer == correctAnswers[i])
            {
                Console.WriteLine("Правильна вiдповiдь!\n");
                score += 100;
            }
            else
            {
                Console.WriteLine("Неправильна вiдповiдь.");
                Console.WriteLine($"Ваш рахунок: {score}");
                Console.WriteLine("Дякуємо за гру.");
                return;
            }
        }

        Console.WriteLine($"Вiтаємо! Ви вiдповiли на всi питання. Фiнальний рахунок: {score}");
    }
}