using System;

namespace number5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Матрица №1: ");
            int[,] mat1 = new int[5, 5];
            Random rand1 = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    mat1[i, j] = rand1.Next(0, 10);
                    Console.Write(mat1[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("Матрица №2: ");
            int[,] mat2 = new int[5, 5];
            Random rand2 = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    mat2[i, j] = rand2.Next(0, 10);
                    Console.Write(mat2[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("Найдем произведение матриц №1 и №2: ");
            int[,] mat3 = Multi(mat1, mat2);
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(mat3[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
        }
        static int[,] Multi(int[,] mat1, int[,] mat2)
        {
            int[,] multimat = new int[mat1.GetLength(0), mat2.GetLength(1)];
            for (int i = 0; i < mat1.GetLength(0); i++)
            {
                for (int j = 0; j < mat2.GetLength(1); j++)
                {
                    for (int k = 0; k < mat2.GetLength(0); k++)
                    {
                        multimat[i, j] += mat1[i, k] * mat2[k, j];
                    }
                }
            }
            return multimat;
        }
    }
}