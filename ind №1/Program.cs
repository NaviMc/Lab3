using System;

namespace indnumber1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Заполнение матрицы линейной последовательностью чисел "); 
            int[,] mat = new int[9, 9];
            int row = 0, col = 0, dx = 1, dy = 0, edits = 0, attend = 9;
            for (int i = 0; i < mat.Length; i++)
            {
                mat[row, col] = i + 1;
                if (--attend == 0)
                {
                    attend = 9 * (edits % 2) + 9 * ((edits + 1) % 2) - (edits / 2 - 1) - 2;
                    int space = dx;
                    dx = -dy;
                    dy = space;
                    edits++;
                }
                col += dx;
                row += dy;
            }
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write("  " + mat[i, j] + "  ");
                }
                Console.WriteLine(" ");
            }
        }
    }
}