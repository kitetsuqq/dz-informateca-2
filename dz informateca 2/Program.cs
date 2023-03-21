using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 5, 2, 8, 9, 5, 3, 8, 8, 4, 7 };
        int max = numbers[0];
        int count = 1;

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
                count = 1;
            }
            else if (numbers[i] == max)
            {
                count++;
            }
        }

        Console.WriteLine($"Максимальное значение: {max}, количество элементов: {count}");
    }
}