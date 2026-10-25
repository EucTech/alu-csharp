using NUnit.Framework;

namespace Text.Tests
{
    /// <summary>Tests for the Str.UniqueChar method.</summary>
    [TestFixture]
    public class StrTests
    {
        /// <summary>Returns 0 when the first character is unique.</summary>
        [Test]
        public void UniqueChar_FirstIsUnique_ReturnsZero()
        {
            Assert.AreEqual(0, Str.UniqueChar("leetcode"));
        }

        /// <summary>Returns the index of a unique character in the middle.</summary>
        [Test]
        public void UniqueChar_UniqueInMiddle_ReturnsIndex()
        {
            Assert.AreEqual(2, Str.UniqueChar("loveleetcode"));
        }

        /// <summary>Returns the index of a unique character at the end.</summary>
        [Test]
        public void UniqueChar_UniqueAtEnd_ReturnsIndex()
        {
            Assert.AreEqual(4, Str.UniqueChar("aabbc"));
        }

        /// <summary>A single character string returns 0.</summary>
        [Test]
        public void UniqueChar_SingleChar_ReturnsZero()
        {
            Assert.AreEqual(0, Str.UniqueChar("z"));
        }

        /// <summary>Returns -1 when every character repeats.</summary>
        [Test]
        public void UniqueChar_NoUnique_ReturnsMinusOne()
        {
            Assert.AreEqual(-1, Str.UniqueChar("aabb"));
            Assert.AreEqual(-1, Str.UniqueChar("abab"));
        }

        /// <summary>An empty string returns -1.</summary>
        [Test]
        public void UniqueChar_Empty_ReturnsMinusOne()
        {
            Assert.AreEqual(-1, Str.UniqueChar(""));
        }

        /// <summary>A null string returns -1.</summary>
        [Test]
        public void UniqueChar_Null_ReturnsMinusOne()
        {
            Assert.AreEqual(-1, Str.UniqueChar(null));
        }
    }
}
