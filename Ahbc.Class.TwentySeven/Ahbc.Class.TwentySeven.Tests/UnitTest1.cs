using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ahbc.Class.TwentySeven.Tests
{
    [TestClass]
    public class SorterTests
    {
        [TestMethod]
        public void Sorter_EmptyArray_ReturnsEmptyArray()
        {
            // Arrange
            var numbers = new int[0];

            // Act
            var sut = new Sorter();
            var result = sut.BubbleSort(numbers);

            // Assert
            Assert.AreEqual(0, result.Length);
        }

        [TestMethod]
        public void Sorter_Null_ReturnsNull()
        {
            // Arrange

            // Act
            var sut = new Sorter();
            var result = sut.BubbleSort(null);

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void Sorter_SingleElement_ReturnsSingleElement()
        {
            // Arrange
            var numbers = new[] { 5 };

            // Act
            var sut = new Sorter();
            var result = sut.BubbleSort(numbers);

            // Assert
            Assert.AreEqual(5, result[0]);
            Assert.AreEqual(1, result.Length);
        }

        [TestMethod]
        public void Sorter_Unsorted_ReturnsSorted()
        {
            // Arrange
            var numbers = new[] { 5, 4, 7, 3, 8, 2, 1 };

            // Act
            var sut = new Sorter();
            var result = sut.BubbleSort(numbers);

            // Assert
            var expected = new[] { 1, 2, 3, 4, 5, 7, 8 };
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
            
            Assert.AreEqual(expected.Length, result.Length);
        }




    }
}
