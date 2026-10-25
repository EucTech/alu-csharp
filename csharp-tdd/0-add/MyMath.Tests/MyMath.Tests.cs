using NUnit.Framework;

namespace MyMath.Tests
{
    /// <summary>Tests for the Operations.Add method.</summary>
    [TestFixture]
    public class OperationsTests
    {
        /// <summary>Adding two positive integers returns their sum.</summary>
        [Test]
        public void Add_TwoPositives_ReturnsSum()
        {
            Assert.AreEqual(5, Operations.Add(2, 3));
        }

        /// <summary>Adding two negative integers returns their sum.</summary>
        [Test]
        public void Add_TwoNegatives_ReturnsSum()
        {
            Assert.AreEqual(-7, Operations.Add(-3, -4));
        }

        /// <summary>Adding a positive and a negative integer returns their sum.</summary>
        [Test]
        public void Add_PositiveAndNegative_ReturnsSum()
        {
            Assert.AreEqual(-2, Operations.Add(3, -5));
        }

        /// <summary>Adding zero returns the other number.</summary>
        [Test]
        public void Add_Zero_ReturnsOtherNumber()
        {
            Assert.AreEqual(9, Operations.Add(9, 0));
            Assert.AreEqual(0, Operations.Add(0, 0));
        }

        /// <summary>Adding a number to its opposite returns zero.</summary>
        [Test]
        public void Add_Opposites_ReturnsZero()
        {
            Assert.AreEqual(0, Operations.Add(42, -42));
        }
    }
}
