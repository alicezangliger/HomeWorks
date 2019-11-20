using Homework3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HW3Tests
{
    [TestClass]
    public class HWork3Tests
    {
        [TestMethod]
        public void Test_TranslationFromRussian()
        {
            // Arrange
            string myString = "Зубная щётка нуждается в замене";
            string expected = "Zubnaya schyotka nuzhdaetsya v zamene";

            // Act
            LineHelper line = new LineHelper();
            string actual = LineHelper.RussianToTranslit(myString);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_TranslationToRussian()
        {
            // Arrange
            string myString = "Zubnaya schyotka nuzhdaetsya v zamene";
            string expected = "Зубная щётка нуждается в замене";

            // Act
            LineHelper line = new LineHelper();
            string actual = LineHelper.TranslitToRussian(myString);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [ExpectedException(typeof (ArgumentException),"Exception was not thrown")]
        [TestMethod]
        public void Test_TranslationFromRussian_Numbers()
        { 
            LineHelper.RussianToTranslit("123456789");         
        }
        [ExpectedException(typeof(ArgumentException), "Exception was not thrown")]
        [TestMethod]
        public void Test_TranslationToRussian_Numbers()
        {
            LineHelper.TranslitToRussian("123456789");
        }
        [ExpectedException(typeof(Exception), "Exception was not thrown")]
        [TestMethod]
        public void Test_TranslationFromRussian_Null()
        {
            LineHelper.RussianToTranslit("");
        }
        [ExpectedException(typeof(Exception), "Exception was not thrown")]
        [TestMethod]
        public void Test_TranslationToRussian_Null()
        {
            LineHelper.TranslitToRussian("");
        }
        [ExpectedException(typeof(ArgumentException), "Exception was not thrown")]
        [TestMethod]
        public void Test_TranslationFromRussian_Symbols()
        {
            LineHelper.RussianToTranslit("!+$(%'");
        }
        [ExpectedException(typeof(ArgumentException), "Exception was not thrown")]
        [TestMethod]
        public void Test_TranslationToRussian_Symbols()
        {
            LineHelper.TranslitToRussian("!+$(%'");
        }
    }
}
