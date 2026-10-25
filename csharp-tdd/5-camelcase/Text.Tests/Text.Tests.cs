using NUnit.Framework;

namespace Text.Tests
{
    /// <summary>Tests for the Str.CamelCase method.</summary>
    [TestFixture]
    public class StrTests
    {
        /// <summary>Counts every word in a camelCase string.</summary>
        [Test]
        public void CamelCase_MultipleWords_ReturnsCount()
        {
            Assert.AreEqual(5, Str.CamelCase("saveChangesInTheEditor"));
        }

        /// <summary>A single lowercase word counts as one.</summary>
        [Test]
        public void CamelCase_SingleWord_ReturnsOne()
        {
            Assert.AreEqual(1, Str.CamelCase("hello"));
            Assert.AreEqual(1, Str.CamelCase("a"));
        }

        /// <summary>Single letter words are counted.</summary>
        [Test]
        public void CamelCase_SingleLetterWords_ReturnsCount()
        {
            Assert.AreEqual(4, Str.CamelCase("aBCD"));
        }

        /// <summary>A capitalized first letter does not count as an extra word.</summary>
        [Test]
        public void CamelCase_CapitalFirstLetter_ReturnsCount()
        {
            Assert.AreEqual(2, Str.CamelCase("HelloWorld"));
        }

        /// <summary>An empty string has no words.</summary>
        [Test]
        public void CamelCase_Empty_ReturnsZero()
        {
            Assert.AreEqual(0, Str.CamelCase(""));
        }

        /// <summary>A null string has no words.</summary>
        [Test]
        public void CamelCase_Null_ReturnsZero()
        {
            Assert.AreEqual(0, Str.CamelCase(null));
        }
    }
}
