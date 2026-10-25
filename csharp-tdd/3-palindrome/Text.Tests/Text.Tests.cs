using NUnit.Framework;

namespace Text.Tests
{
    /// <summary>Tests for the Str.IsPalindrome method.</summary>
    [TestFixture]
    public class StrTests
    {
        /// <summary>Simple lowercase palindromes return true.</summary>
        [Test]
        public void IsPalindrome_Lowercase_ReturnsTrue()
        {
            Assert.IsTrue(Str.IsPalindrome("level"));
        }

        /// <summary>Palindromes are not case sensitive.</summary>
        [Test]
        public void IsPalindrome_MixedCase_ReturnsTrue()
        {
            Assert.IsTrue(Str.IsPalindrome("Racecar"));
        }

        /// <summary>Spaces and punctuation are ignored.</summary>
        [Test]
        public void IsPalindrome_SpacesAndPunctuation_ReturnsTrue()
        {
            Assert.IsTrue(Str.IsPalindrome("A man, a plan, a canal: Panama."));
        }

        /// <summary>An empty string is a palindrome.</summary>
        [Test]
        public void IsPalindrome_Empty_ReturnsTrue()
        {
            Assert.IsTrue(Str.IsPalindrome(""));
        }

        /// <summary>A string of only spaces and punctuation is a palindrome.</summary>
        [Test]
        public void IsPalindrome_OnlyPunctuation_ReturnsTrue()
        {
            Assert.IsTrue(Str.IsPalindrome(" ,.!? "));
        }

        /// <summary>A single character is a palindrome.</summary>
        [Test]
        public void IsPalindrome_SingleChar_ReturnsTrue()
        {
            Assert.IsTrue(Str.IsPalindrome("a"));
        }

        /// <summary>Digits are compared like letters.</summary>
        [Test]
        public void IsPalindrome_Digits_ReturnsExpected()
        {
            Assert.IsTrue(Str.IsPalindrome("12321"));
            Assert.IsFalse(Str.IsPalindrome("123"));
        }

        /// <summary>Non palindromes return false.</summary>
        [Test]
        public void IsPalindrome_NotPalindrome_ReturnsFalse()
        {
            Assert.IsFalse(Str.IsPalindrome("hello"));
            Assert.IsFalse(Str.IsPalindrome("ab"));
            Assert.IsFalse(Str.IsPalindrome("Hello, World!"));
        }

        /// <summary>A null string is not a palindrome.</summary>
        [Test]
        public void IsPalindrome_Null_ReturnsFalse()
        {
            Assert.IsFalse(Str.IsPalindrome(null));
        }
    }
}
