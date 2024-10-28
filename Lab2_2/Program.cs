using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите количество слагаемых для приближенного вычисления числа π:");

        // Ввод количества слагаемых
        int n = Convert.ToInt32(Console.ReadLine());

        double piOverFour = 0.0;

        // Вычисление суммы
        for (int i = 0; i < n; i++)
        {
            // Чередование знаков
            double term = (i % 2 == 0 ? 1.0 : -1.0) / (2 * i + 1);
            piOverFour += term;
        }

        // Умножаем на 4 для получения π
        double pi = piOverFour * 4;

        Console.WriteLine($"Приближенное значение числа π с использованием {n} слагаемых: {pi}");
    }
}
