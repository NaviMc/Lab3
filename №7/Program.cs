using System;

namespace number7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Формулы из лаб №2
            //f0 = f1 = 1;
            //fi = fi - 1 + fi - 2 , i = 2,3,4...
            Console.WriteLine("Введите порядковый номер числа Фибоначчи: ");
            int n = 0;
            try
            {
                n = int.Parse(Console.ReadLine());
            } 
            catch (FormatException)
            {
                Console.WriteLine("Ошибка ввода, некорректный формат");
            }
            if (n < 0)
                Console.WriteLine("Порядковый номер не может быть меньше 0");
            else 
                Console.WriteLine($"Число Фибоначчи: {f(n)}");
        }

        static int f(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1 || n == 2)
                return 1;
            return f(n - 2) + f(n - 1);
        }
    }
}