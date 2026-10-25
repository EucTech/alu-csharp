using System.Collections.Generic;

namespace Text
{
    /// <summary>Provides string operations.</summary>
    public class Str
    {
        /// <summary>Finds the index of the first non-repeating character of a string.</summary>
        /// <param name="s">The string to search.</param>
        /// <returns>The index of the first non-repeating character, or -1 if there is none.</returns>
        public static int UniqueChar(string s)
        {
            if (string.IsNullOrEmpty(s))
                return -1;

            Dictionary<char, int> counts = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (counts.ContainsKey(c))
                    counts[c]++;
                else
                    counts[c] = 1;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (counts[s[i]] == 1)
                    return i;
            }

            return -1;
        }
    }
}
