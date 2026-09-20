using System.Collections.Generic;

class LList
{
    public static int Sum(LinkedList<int> myLList)
    {
        int sum = 0;

        foreach (int number in myLList)
        {
            sum += number;
        }

        return sum;
    }
}
