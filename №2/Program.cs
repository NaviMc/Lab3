using System;

namespace number2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mas = new int[7, 7];
            Random scope = new Random();
            Console.WriteLine("Имеем массив: "); 
            for (int i = 0; i < 7; i++)
            {
                for(int j = 0; j < 7; j++)
                {
                    mas[i, j] = scope.Next(2);
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Перевернем его на 90 градусов: ");
            for (int a = 0; a < 7; a++)
            {
                for (int b = 6; b >= 0; b--)
                {
                    Console.Write(mas[a, b] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
