using System;

namespace number6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[10];
            Random rand = new Random();
            Console.WriteLine("Имеем массив: ");
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rand.Next(-10, 10);
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Выберете и введите демонстрируемую функцию: ");
            Console.WriteLine("|sumRecursive|   |sumIterative|   |minRecursive|   |minIterative|");
            string word = " ";
            try
            {
                word = Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка ввода, некорректный формат");
            }
            int ans;
            if (word == "sumRecursive")
            {
                ans = sumRecursive(mas);
                Console.WriteLine("Ответ: " + ans);
            }
            else if (word == "sumIterative")
            {
                ans = sumIterative(mas);
                Console.WriteLine("Ответ: " + ans);
            }
            else if (word == "minRecursive")
            {
                ans = minRecursive(mas);
                Console.WriteLine("Ответ: " + ans);
            }
            else if (word == "minIterative")
            {
                ans = minIterative(mas, 1);
                Console.WriteLine("Ответ: " + ans);
            }
            else
                Console.WriteLine("Ошибка, некорректная функция");

        }
        static int sumRecursive(int[] mas, int i = 0)
        {
            if (i >= mas.Length) 
                return 0;
            else 
                return mas[i] + sumRecursive(mas, i + 1);
        }
        static int sumIterative(int[] mas, int i = 0)
        {
            int sum = 0;
            for (i = 0; i < mas.Length; i++)
            {
                sum += mas[i];
            }
            return sum;
        }
        static int minRecursive(int[] mas, int i = 0)
        {
            if (i + 1 == mas.Length)
                return mas[i];
            else 
                return Math.Min(mas[i], minRecursive(mas, ++i));
        }
        static int minIterative(int[] mas, int min, int i = 0)
        {
            for (i = 0; i < mas.Length; i++)
            {
                if (mas[i] < min)
                {
                    min = mas[i];
                }
            }
            return min;
        }
    }
}