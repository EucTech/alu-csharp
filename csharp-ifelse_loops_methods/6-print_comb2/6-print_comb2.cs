using System;

class Program
{
    static void Main(string[] args)
    {
        for (int first = 0; first <= 8; first++)
        {
            for (int second = first + 1; second <= 9; second++)
            {
                Console.Write(first == 8 && second == 9
                    ? $"{first}{second}\n"
                    : $"{first}{second}, ");
            }
        }
    }
}
