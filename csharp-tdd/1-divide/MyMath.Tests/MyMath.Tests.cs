using System;
using System.IO;
using NUnit.Framework;

namespace MyMath.Tests
{
    /// <summary>Tests for the Matrix.Divide method.</summary>
    [TestFixture]
    public class MatrixTests
    {
        /// <summary>Each element is divided by num using integer division.</summary>
        [Test]
        public void Divide_ValidMatrix_ReturnsDividedMatrix()
        {
            int[,] matrix = { { 2, 4, 6 }, { 8, 10, 13 } };
            int[,] expected = { { 1, 2, 3 }, { 4, 5, 6 } };

            Assert.AreEqual(expected, Matrix.Divide(matrix, 2));
        }

        /// <summary>Dividing by a negative number flips the signs.</summary>
        [Test]
        public void Divide_NegativeNum_ReturnsDividedMatrix()
        {
            int[,] matrix = { { 3, -6 }, { 9, 0 } };
            int[,] expected = { { -1, 2 }, { -3, 0 } };

            Assert.AreEqual(expected, Matrix.Divide(matrix, -3));
        }

        /// <summary>Dividing by one returns an equal matrix.</summary>
        [Test]
        public void Divide_ByOne_ReturnsEqualMatrix()
        {
            int[,] matrix = { { 1, 2 }, { 3, 4 } };

            Assert.AreEqual(matrix, Matrix.Divide(matrix, 1));
        }

        /// <summary>The original matrix is not modified and a new one is returned.</summary>
        [Test]
        public void Divide_ValidMatrix_ReturnsNewMatrix()
        {
            int[,] matrix = { { 4, 8 } };
            int[,] result = Matrix.Divide(matrix, 2);

            Assert.AreNotSame(matrix, result);
            Assert.AreEqual(new int[,] { { 4, 8 } }, matrix);
        }

        /// <summary>An empty matrix returns an empty matrix.</summary>
        [Test]
        public void Divide_EmptyMatrix_ReturnsEmptyMatrix()
        {
            int[,] result = Matrix.Divide(new int[0, 0], 5);

            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Length);
        }

        /// <summary>Dividing by zero prints a message and returns null.</summary>
        [Test]
        public void Divide_ByZero_PrintsMessageAndReturnsNull()
        {
            int[,] matrix = { { 1, 2 }, { 3, 4 } };
            TextWriter original = Console.Out;

            using (StringWriter output = new StringWriter())
            {
                Console.SetOut(output);
                int[,] result = Matrix.Divide(matrix, 0);
                Console.SetOut(original);

                Assert.IsNull(result);
                Assert.AreEqual("Num cannot be 0", output.ToString().Trim());
            }
        }

        /// <summary>Dividing an empty matrix by zero still prints a message and returns null.</summary>
        [Test]
        public void Divide_EmptyMatrixByZero_PrintsMessageAndReturnsNull()
        {
            TextWriter original = Console.Out;

            using (StringWriter output = new StringWriter())
            {
                Console.SetOut(output);
                int[,] result = Matrix.Divide(new int[0, 0], 0);
                Console.SetOut(original);

                Assert.IsNull(result);
                Assert.AreEqual("Num cannot be 0", output.ToString().Trim());
            }
        }

        /// <summary>A null matrix returns null.</summary>
        [Test]
        public void Divide_NullMatrix_ReturnsNull()
        {
            Assert.IsNull(Matrix.Divide(null, 2));
        }
    }
}
