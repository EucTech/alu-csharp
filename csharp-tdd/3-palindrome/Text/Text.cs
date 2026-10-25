namespace Text
{
    /// <summary>Provides string operations.</summary>
    public class Str
    {
        /// <summary>Checks if a string is a palindrome, ignoring case, spaces and punctuation.</summary>
        /// <param name="s">The string to check.</param>
        /// <returns>True if s is a palindrome, False if it's not.</returns>
        public static bool IsPalindrome(string s)
        {
            if (s == null)
                return false;

            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                if (!char.IsLetterOrDigit(s[left]))
                    left++;
                else if (!char.IsLetterOrDigit(s[right]))
                    right--;
                else
                {
                    if (char.ToLowerInvariant(s[left]) != char.ToLowerInvariant(s[right]))
                        return false;
                    left++;
                    right--;
                }
            }

            return true;
        }
    }
}
