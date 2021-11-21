using System;

namespace number3
{
    class Program
    {
        static void Main(string[] args)
        {
            int col = 0;
            try
            {
                Console.WriteLine("Введите число элементов: ");
                col = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка ввода, некоректный формат");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка обработки, слишком большое число");
            }
            if (col < 1)
                    Console.WriteLine("Число элементов не может быть меньше 1");
            else
            {
                int[] mas = new int[col];
                Random scope = new Random();
                Console.WriteLine("Имеем массив: ");
                for (int i = 0; i < mas.Length; i++)
                {
                mas[i] = scope.Next(0, 10);
                Console.Write($"{mas[i]} ");
                }
                Console.WriteLine(" ");
                Console.WriteLine("Введите количество сдвигаемых позиций: ");
                int k = 0;
                try
                {
                    k = int.Parse(Console.ReadLine());
                }
                catch(FormatException)
                {
                    Console.WriteLine("Ошибка ввода, некорректный формат");
                }
                if (k < 1)
                    Console.WriteLine("Количество сдвигаемых позиций не может быть меньше 1");
                else if (k >= col)
                    Console.WriteLine("Ошибка, количество сдвигаемых позиций больше или равно числу элементов");
                else
                {
                    Console.WriteLine($"Сдвигаем массив на {k} влево: ");
                    for (int i = 0; i < k; i++)
                    {
                        int shift = mas[0];
                        for (int j = 0; j < col - 1; j++)
                        {
                            mas[j] = mas[j + 1];
                            mas[col - 1] = shift;
                        }
                    }
                    for (int a = 0; a < col; a++)
                    {
                        Console.Write($"{mas[a]} ");
                    }
                }
            }
        }
    }
}