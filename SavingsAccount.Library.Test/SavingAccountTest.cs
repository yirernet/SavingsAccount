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
            string input = "999";
            // Act
            decimal output = SavingsAccount.CalculateRate(input);

            // Assert
            Assert.AreEqual("9.99", output.ToString());
        }

        [TestMethod]
        public void CalculateRate_When1001_Returns15_02()
        {
            // Arrange
            string input = "1001";
            // Act
            decimal output = SavingsAccount.CalculateRate(input);

            // Assert
            Assert.AreEqual("15.02", output.ToString());
        }

        [TestMethod]
        public void CalculateRate_When5001_Returns100_02()
        {
            // Arrange
            string input = "5001";
            // Act
            decimal output = SavingsAccount.CalculateRate(input);

            // Assert
            Assert.AreEqual("100.02", output.ToString());
        }

        [TestMethod]
        public void CalculateRate_When10001_Returns250_03()
        {
            // Arrange
            string input = "10001";
            // Act
            decimal output = SavingsAccount.CalculateRate(input);

            // Assert
            Assert.AreEqual("250.02", output.ToString());

        }

        [TestMethod]
        public void CalculateRate_When50001_Returns1500_03()
        {
            // Arrange
            string input = "50001";
            // Act
            decimal output = SavingsAccount.CalculateRate(input);

            // Assert
            Assert.AreEqual("1500.03", output.ToString());
        }

        [TestMethod]
        public void MultiTest()
        {
            Perform_MultiTest("548", 5.48);

            Perform_MultiTest("1558", 23.37);

            Perform_MultiTest("6248", 124.96);

            Perform_MultiTest("45125", 1128.12);

            Perform_MultiTest("151548", 4546.44);
        }

        private void Perform_MultiTest(string input, double expected)
        {
            Assert.IsTrue(SavingsAccount.CalculateRate(input).ToString() == expected.ToString());

            // or 
            // Assert.AreEqual(expected, input);
        }

    }
}
