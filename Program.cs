using System;

class Program
{
    static void Main()
    {
        // Задание 1.1
        Console.WriteLine("Задание 1.1");
        for (int i = 10; i >= 1; i--)
        {
            Console.WriteLine(i);
        }

        // Задание 1.2
        Console.WriteLine("Задание 1.2");
        for (int i = 2; i <= 50; i += 2)
        {
            Console.WriteLine(i);
        }

        for (int i = 1; i <= 50; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }

        // Задание 2
        Console.WriteLine("Задание 2");
        int sum3 = 0;
        int count7 = 0;
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0)
            {
                sum3 += i;
            }
            if (i % 7 == 0)
            {
                count7++;
            }
        }
        Console.WriteLine($"Сумма чисел, кратных 3: {sum3}");     // 1683
        Console.WriteLine($"Количество чисел, кратных 7: {count7}"); // 14

        // Задание 3
        Console.WriteLine("Задание 3");
        int number = Convert.ToInt32(Console.ReadLine());
        int positive = 0;
        int negative = 0;
        while (number != 0)
        {
            if (number > 0)
            {
                positive++;
            }
            else
            {
                negative++;
            }
            number = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine($"Положительных: {positive}");
        Console.WriteLine($"Отрицательных: {negative}");

        // Задание 4
        Console.WriteLine("Задание 4");
        bool accessGranted = false;
        for (int attempt = 1; attempt <= 3; attempt++)
        {
            Console.Write($"Попытка {attempt}. Введите пароль: ");
            string password = Console.ReadLine();
            if (password == "qwerty")
            {
                Console.WriteLine("Доступ разрешён");
                accessGranted = true;
                break;
            }
        }
        if (!accessGranted)
        {
            Console.WriteLine("Доступ заблокирован");
        }

        // Задание 5
        Console.WriteLine("Задание 5");
        Console.Write("Введите число от 1 до 9: ");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{n} × {i} = {n * i}");
        }

        // Задание 6
        Console.WriteLine("Задание 6");
        for (int i = 1; i <= 30; i++)
        {
            if (i % 3 == 0)
            {
                continue;
            }
            if (i % 10 == 0 && i > 20)
            {
                break;
            }
            Console.WriteLine(i);
        }

        // Итоговая задача
        Console.WriteLine("Итоговая задача");
        int secret = 42;
        bool guessed = false;
        for (int attempt = 1; attempt <= 5; attempt++)
        {
            Console.Write($"Попытка {attempt}. Введите число: ");
            int guess = Convert.ToInt32(Console.ReadLine());
            if (guess == secret)
            {
                Console.WriteLine($"Победа! Попыток: {attempt}");
                guessed = true;
                break;
            }
            else if (guess < secret)
            {
                Console.WriteLine("Больше");
            }
            else
            {
                Console.WriteLine("Меньше");
            }
        }
        if (!guessed)
        {
            Console.WriteLine($"Вы проиграли, число было {secret}");
        }
    }
}