using System;
using Ahbc.Class.TwentyEight;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ahbc.Class.TwentyEightTests
{
    [TestClass]
    public class DateTimeHelperTests
    {
        [TestMethod]
        public void Distance_PreviousTime_ReturnsDistance()
        {
            // Arrange
            var currentTime = DateTime.UtcNow;
            var input = currentTime - TimeSpan.FromHours(1);

            // Act
            var sut = new DateTimeHelper();
            var response = sut.Distance(input);

            // Assert
            Assert.IsTrue(response > TimeSpan.Zero && response <= TimeSpan.FromHours(1));
        }
    }
}
