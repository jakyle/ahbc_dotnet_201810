using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ahbc.Class.TwentySeven.Tests
{
    [TestClass]
    public class TempConverterTests
    {
        [TestMethod]
        public void TempConverter_GetsF_ConvertsToC()
        {
            // Arrange 
            var input = 32;

            // Act
            var sut = new TempConverter();
            var result = sut.Convert(input, "C");

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TempConverter_GetsC_ConvertsToF()
        {
            // Arrange 
            var input = 100;

            // Act
            var sut = new TempConverter();
            var result = sut.Convert(input, "F");

            // Assert
            Assert.AreEqual(212, result);
        }
    }
}
