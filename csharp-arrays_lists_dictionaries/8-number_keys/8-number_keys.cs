using System.Collections.Generic;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int numberOfKeys = 0;

        foreach (string key in myDict.Keys)
        {
            numberOfKeys++;
        }

        return numberOfKeys;
    }
}
