using Homework2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HW2Tests
{
    [TestClass]
    public class HWorkTests
    {
        [TestMethod]
        public void Test_DifferenceOfElements()
        {
            // Arrange
            string myString = "rte555veaaaaaVVV9999teyrhfjsiw33333333sadhdwbdaSSSSSSS";
            int expected = 12;

            // Act
            SymbolString symStr = new SymbolString();
            int actual = SymbolString.DifferentElem(myString);

            // Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Test_RepeatingOfNumbers()
        {
            // Arrange
            string myString = "rte555veaaaaaVVV9999teyrhfjsiw33333333sadhdwbdaSSSSSSS";
            int expected = 8;

            // Act
            SymbolString symStr = new SymbolString();
            int actual = SymbolString.EqualNumbers(myString);

            // Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Test_RepeatingOfLatinElem()
        {
            // Arrange
            string myString = "rte555veaaaaaVVV9999teyrhfjsiw33333333sadhdwbdaSSSSSSS";
            int expected = 7;

            // Act
            SymbolString symStr = new SymbolString();
            int actual = SymbolString.EqualLatin(myString);

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Test_DifferenceOfElements_whenEmpty()
        {
            // Arrange
            string myString = "";
            int expected = 0;

            // Act
            SymbolString symStr = new SymbolString();
            int actual = SymbolString.DifferentElem(myString);

            // Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Test_RepeatingOfNumbers_whenEmpty()
        {
            // Arrange
            string myString = "";
            int expected = 0;

            // Act
            SymbolString symStr = new SymbolString();
            int actual = SymbolString.EqualNumbers(myString);

            // Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Test_RepeatingOfLatinElem_whenEmpty()
        {
            // Arrange
            string myString = "";
            int expected = 0;

            // Act
            SymbolString symStr = new SymbolString();
            int actual = SymbolString.EqualLatin(myString);

            // Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
