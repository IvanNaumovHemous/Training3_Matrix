using System;

namespace matrixTraining3
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());

            int[,] matrix = GetMatrix(size);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static int[,] GetMatrix(int size)
        {
            var matrix = new int[size, size];

            var row = 0;
            var col = 0;
            var direction = "down";

            for (int i = 1; i <= matrix.Length; i++)
            {
                if (direction == "down" && row > size - 1)
                {
                    direction = "up";
                    row--;
                    col++;
                }
                if (direction == "up" && row < 0)
                {
                    direction = "down";
                    row++;
                    col++;
                }

                matrix[row, col] = i;

                switch (direction)
                {
                    case "down": row++; break;
                    case "up": row--; break;                  
                }
            }

            return matrix;
        }
    }
}
