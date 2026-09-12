using System;

class Program
{
    static void Main(string[] args)
    {
        for (int number = 1; number <= 100; number++)
        {
            string value;

            if (number % 15 == 0)
                value = "FizzBuzz";
            else if (number % 3 == 0)
                value = "Fizz";
            else if (number % 5 == 0)
                value = "Buzz";
            else
                value = number.ToString();

            Console.Write(number == 100 ? $"{value}\n" : $"{value} ");
        }
    }
}
