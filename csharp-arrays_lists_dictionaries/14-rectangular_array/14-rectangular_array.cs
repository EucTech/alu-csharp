using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] array = new int[5, 5];
        array[2, 2] = 1;

        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int column = 0; column < array.GetLength(1); column++)
            {
                if (column > 0)
                    Console.Write(" ");
                Console.Write(array[row, column]);
            }

            Console.WriteLine();
        }
    }
}
