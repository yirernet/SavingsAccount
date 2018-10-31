using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SavingsAccount.Library.Test
{
    [TestClass]
    public class SavingAccountTest
    {
        [TestMethod]
        public void CalculateRate_When999_Returns9_99()
        {
            // Arrange
            int input = 999;
            // Act
            decimal output = SavingsAccount.CalculateRate(input);

            // Assert
            Assert.AreEqual("9.99", output.ToString());
        }

        [TestMethod]
        public void CalculateRate_When1001_Returns15_02()
        {
            // Arrange
            int input = 1001;
            // Act
            decimal output = SavingsAccount.CalculateRate(input);

            // Assert
            Assert.AreEqual("15.02", output.ToString());
        }

        [TestMethod]
        public void CalculateRate_When5001_Returns100_02()
        {
            // Arrange
            int input = 5001;
            // Act
            decimal output = SavingsAccount.CalculateRate(input);

            // Assert
            Assert.AreEqual("100.02", output.ToString());
        }

        [TestMethod]
        public void CalculateRate_When10001_Returns250_03()
        {
            // Arrange
            int input = 10001;
            // Act
            decimal output = SavingsAccount.CalculateRate(input);

            // Assert
            Assert.AreEqual("250.02", output.ToString());

        }

        [TestMethod]
        public void CalculateRate_When50001_Returns1500_03()
        {
            // Arrange
            int input = 50001;
            // Act
            decimal output = SavingsAccount.CalculateRate(input);

            // Assert
            Assert.AreEqual("1500.03", output.ToString());
        }

        [TestMethod]
        public void ATest()
        {
            this.Perform_ATest(548, 5.48);

            this.Perform_ATest(1558, 23.37);

            this.Perform_ATest(6248, 124.96);

            this.Perform_ATest(45125, 1128.12);

            this.Perform_ATest(151548, 4546.44);
        }

        private void Perform_ATest(int input, double expected)
        {
            Assert.IsTrue(SavingsAccount.CalculateRate(input).ToString() == expected.ToString());

            // or 
            // Assert.AreEqual(expected, input);
        }

    }
}
