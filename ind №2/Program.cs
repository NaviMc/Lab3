using System;

namespace indnumber2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива: ");
            int size = 0;
            try
            {
                size = int.Parse(Console.ReadLine());
            } 
            catch (FormatException)
            {
                Console.WriteLine("Ошибка ввода, некорректный формат");
            }
            if (size % 2 != 0)
                Console.WriteLine("Размер массива должен быть четным");
            else
            {
                int[] mas = new int[10];
                for (int i = 1; i < size + 1; i++)
                {
                    Console.WriteLine("Задайте значение массива ");
                    int z = 0;
                    try
                    {
                        z = int.Parse(Console.ReadLine());
                    } 
                    catch (FormatException)
                    {
                        Console.WriteLine("Ошибка ввода, некорректный формат");
                    }
                    if (z < 0)
                        Console.WriteLine("Значение массива не может быть меньше 0");
                    else
                    {
                        mas[i] = z;
                    }
                }
                for (int i = 1; i < size + 1; i++)
                {

                    Console.Write(mas[i] + "  ");
                }
                int x, y, k = 0, check, diff;
                Console.WriteLine();
                for (int i = 1; i < size + 1; i++)
                {

                    x = Math.Abs(mas[i]);
                    y = Math.Abs(mas[i - 1]);
                    diff = x - y;
                    check = Math.Abs(diff);
                    if (check <= 5)
                    {
                        k++;
                    }
                    else
                    {
                        Console.WriteLine("Предел не был соблюден ");  
                    }
                }
                Console.WriteLine($"Ответ: {k}");
            }
        }
    }
}