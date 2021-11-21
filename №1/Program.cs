using System;

namespace number1
{
    class Program
    {
        static void Main(string[] args)
        {
            int col = 0;
            try
            {
                Console.WriteLine("Введите число элементов массмва: ");
                col = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка ввода, некоректный формат");
            }
            if (col < 1)
                Console.WriteLine("Число элементов не может быть меньше 1");
            else
            {
                int[] mas = new int[col];
                Random rand = new Random();
                Console.WriteLine("Элементы массива: ");
                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] = rand.Next(-30, 45);
                    Console.WriteLine(mas[i]);
                }
                Console.WriteLine("Положительные элементы в обратном порядке: ");
                Array.Reverse(mas);
                foreach (int el in mas)
                {
                    if (el >= 0)
                    Console.WriteLine(el);
                }
            }
        }
    }
}