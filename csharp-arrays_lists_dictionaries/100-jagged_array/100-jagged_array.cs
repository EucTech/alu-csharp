using System;

class Program
{
    static void Main(string[] args)
    {
        int[][] array = new int[][]
        {
            new int[] {0, 1, 2, 3},
            new int[] {0, 1, 2, 3, 4, 5, 6},
            new int[] {0, 1}
        };

        foreach (int[] row in array)
        {
            for (int i = 0; i < row.Length; i++)
            {
                if (i > 0)
                    Console.Write(" ");
                Console.Write(row[i]);
            }

            Console.WriteLine();
        }
    }
}
