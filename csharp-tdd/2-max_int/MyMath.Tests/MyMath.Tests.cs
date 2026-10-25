using System.Collections.Generic;
using NUnit.Framework;

namespace MyMath.Tests
{
    /// <summary>Tests for the Operations.Max method.</summary>
    [TestFixture]
    public class OperationsTests
    {
        /// <summary>Returns the largest value in an unsorted list.</summary>
        [Test]
        public void Max_UnsortedList_ReturnsMax()
        {
            Assert.AreEqual(98, Operations.Max(new List<int> { 3, 98, 12, 50 }));
        }

        /// <summary>Works when the max is at the start or the end.</summary>
        [Test]
        public void Max_MaxAtEdges_ReturnsMax()
        {
            Assert.AreEqual(10, Operations.Max(new List<int> { 10, 1, 2 }));
            Assert.AreEqual(10, Operations.Max(new List<int> { 1, 2, 10 }));
        }

        /// <summary>Works with only negative numbers.</summary>
        [Test]
        public void Max_AllNegatives_ReturnsMax()
        {
            Assert.AreEqual(-2, Operations.Max(new List<int> { -5, -2, -9 }));
        }

        /// <summary>A single element list returns that element.</summary>
        [Test]
        public void Max_SingleElement_ReturnsElement()
        {
            Assert.AreEqual(-7, Operations.Max(new List<int> { -7 }));
        }

        /// <summary>Duplicate maximum values are handled.</summary>
        [Test]
        public void Max_Duplicates_ReturnsMax()
        {
            Assert.AreEqual(4, Operations.Max(new List<int> { 4, 4, 1, 4 }));
        }

        /// <summary>Works with the int boundaries.</summary>
        [Test]
        public void Max_IntBoundaries_ReturnsMax()
        {
            Assert.AreEqual(int.MaxValue, Operations.Max(new List<int> { int.MinValue, int.MaxValue }));
            Assert.AreEqual(int.MinValue, Operations.Max(new List<int> { int.MinValue }));
        }

        /// <summary>An empty list returns 0.</summary>
        [Test]
        public void Max_EmptyList_ReturnsZero()
        {
            Assert.AreEqual(0, Operations.Max(new List<int>()));
        }

        /// <summary>A null list returns 0.</summary>
        [Test]
        public void Max_NullList_ReturnsZero()
        {
            Assert.AreEqual(0, Operations.Max(null));
        }
    }
}
