using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        string bestStudent = "None";
        int bestScore = -1;

        foreach (KeyValuePair<string, int> entry in myList)
        {
            if (entry.Value > bestScore)
            {
                bestScore = entry.Value;
                bestStudent = entry.Key;
            }
        }

        return bestStudent;
    }
}
