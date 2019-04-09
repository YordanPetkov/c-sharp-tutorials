using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultyArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix =
            {
                {1, 2, 3 },
                {4, 5, 6 }
            };
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0},",
                        matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int[,,] cube =
            {
                {
                    {1, 2, 3 },
                    {4, 5, 6 }
                },

                {
                    {7, 8, 9 },
                    {10, 11, 12 }
                }
            };

            for (int layer = 0; layer < cube.GetLength(0); layer++)
            {
                for (int row = 0; row < cube.GetLength(1); row++)
                {
                    for (int col = 0; col < cube.GetLength(2); col++)
                    {
                        Console.Write("{0},",
                            cube[layer, row, col]);
                    }
                    Console.WriteLine();
                }
                

            }

            Console.WriteLine();
        }
    }
}
