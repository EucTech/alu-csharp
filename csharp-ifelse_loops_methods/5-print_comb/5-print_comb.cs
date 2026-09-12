using System;

class Program
{
    static void Main(string[] args)
    {
        for (int number = 0; number <= 99; number++)
            Console.Write(number < 99 ? $"{number:D2}, " : $"{number:D2}\n");
    }
}
