using System;

namespace number4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Массив №1");
            float[,] mas1 = new float[3, 3];
            Random rand = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mas1[i, j] = rand.Next(0, 10);
                    Console.Write($"{mas1[i, j]} ");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("Массив №2");
            float[,] mas2 = new float[3, 3];
            Random rand2 = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mas2[i, j] = rand2.Next(0, 10);
                    Console.Write($"{mas2[i, j]} ");
                }
                Console.WriteLine(" ");
            }
            string word = "";
            try
            {
                Console.WriteLine("Выберите операцию с массивом: ");
                Console.WriteLine("|Summ|  |Diff|  |Midle|");
                word = Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка формата, введите слово");
            }
            if (word == "Summ")
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(Summ(mas1, mas2)[i, j] + " ");
                    }
                    Console.WriteLine(" ");
                }
                
            }
            else if (word == "Diff")
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(Diff(mas1, mas2)[i, j] + " ");
                    }
                    Console.WriteLine(" ");
                }
            }
            else if (word == "Midle")
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(Midle(mas1, mas2)[i, j] + " ");
                    }
                    Console.WriteLine(" ");
                }
            }
            else
                Console.WriteLine("Ошибка обработки, некорректная запись");
        }
        static float[,] Summ(float[,] mas1, float[,] mas2)
        {
            float[,] summas = new float[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    summas[i, j] = mas1[i, j] + mas2[i, j];
                }
            }
            
            return summas;
        }
        static float[,] Diff(float[,] mas1, float[,] mas2)
        {
            float[,] diffmas = new float[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    diffmas[i, j] = mas1[i, j] - mas2[i, j];
                }
            }
            return diffmas;
        }
        static float[,] Midle(float[,] mas1, float[,] mas2)
        {
            float[,] midmas = new float[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    midmas[i, j] = (mas1[i, j] + mas2[i, j]) / 2;
                }
            }
            return midmas;
        }
    }
}