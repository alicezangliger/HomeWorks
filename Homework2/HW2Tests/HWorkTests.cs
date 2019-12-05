using Homework2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HW2Tests
{
    [TestClass]
    public class HWorkTests
    {
        [TestMethod]
        [DataRow("rte555veaaaaaVVV9999teyrhfjsiw33333333sadhdwbdaSSSSSSS", 12)]
        [DataRow("", 0)]
        public void Test_DifferenceOfElements_Positive(string str, int expected)
        {
            Assert.AreEqual(expected, SymbolString.DifferentElem(str));
        }
        [TestMethod]
        [DataRow("rte555veaaaaaVVV9999teyrhfjsiw33333333sadhdwbdaSSSSSSS", 8)]
        [DataRow("", 0)]
        public void Test_RepeatingOfNumbers_Positive(string str, int expected)
        {
            Assert.AreEqual(expected, SymbolString.EqualNumbers(str));
        }
        [TestMethod]
        [DataRow("rte555veaaaaaVVV9999teyrhfjsiw33333333sadhdwbdaSSSSSSS", 7)]
        [DataRow("", 0)]
        public void Test_RepeatingOfLatinElem_Positive(string str, int expected)
        {
            Assert.AreEqual(expected, SymbolString.EqualLatin(str));
        }      
       
    }
}
