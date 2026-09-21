class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Введiть рiк (0 — вихiд): ");

            if (int.TryParse(Console.ReadLine(), out int year))
            {
                if (year == 0)
                    break;

                // Кратне 400 — високосний, кратне 4 — так, кратне 100 — ні
                bool isLeap = (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);

                if (isLeap)
                    Console.WriteLine($"{year} — це високосний рiк.");
                else
                    Console.WriteLine($"{year} — це НЕ високосний рiк.");
            }
            else
            {
                Console.WriteLine("Некоректне значення.");
            }
        }
    }
}