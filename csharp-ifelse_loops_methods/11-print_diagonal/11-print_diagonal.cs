using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        for (int row = 0; row < length; row++)
            Console.WriteLine(new string(' ', row) + "\\");

        Console.WriteLine();
    }
}
