using Homework3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HW3Tests
{
    [TestClass]
    public class HWork3Tests
    {
        [TestMethod]
        [DataRow("Зубная щётка нуждается в замене", "Zubnaya schyotka nuzhdaetsya v zamene")]        
        public void Test_TranslationFromRussian_Positive(string str,string expected)
        {
            Assert.AreEqual(expected, LineHelper.RussianToTranslit(str));            
        }
        [TestMethod]
        [DataRow("Zubnaya schyotka nuzhdaetsya v zamene", "Зубная щётка нуждается в замене")]
        public void Test_TranslationToRussian_Positive(string str, string expected)
        {
       
            Assert.AreEqual(expected, LineHelper.TranslitToRussian(str));        
        }
        [ExpectedException(typeof (ArgumentException),"Exception was not thrown")]
        [TestMethod]
        public void Test_TranslationFromRussian_Numbers_Negative()
        { 
            LineHelper.RussianToTranslit("123456789");         
        }
        [ExpectedException(typeof(ArgumentException), "Exception was not thrown")]
        [TestMethod]
        public void Test_TranslationToRussian_Numbers_Negative()
        {
            LineHelper.TranslitToRussian("123456789");
        }
        [ExpectedException(typeof(Exception), "Exception was not thrown")]
        [TestMethod]
        public void Test_TranslationFromRussian_Empty_Negative()
        {
            LineHelper.RussianToTranslit(string.Empty);
        }
        [ExpectedException(typeof(Exception), "Exception was not thrown")]
        [TestMethod]
        public void Test_TranslationToRussian_Empty_Negative()
        {
            LineHelper.TranslitToRussian(string.Empty);
        }
        [ExpectedException(typeof(ArgumentException), "Exception was not thrown")]
        [TestMethod]
        public void Test_TranslationFromRussian_Symbols_Negative()
        {
            LineHelper.RussianToTranslit("!+$(%'");
        }
        [ExpectedException(typeof(ArgumentException), "Exception was not thrown")]
        [TestMethod]
        public void Test_TranslationToRussian_Symbols_Negative()
        {
            LineHelper.TranslitToRussian("!+$(%'");
        }
        [ExpectedException(typeof(ArgumentNullException), "Exception was not thrown")]
        [TestMethod]
        public void Test_TranslationFromRussian_Null_Negative()
        {
            LineHelper.RussianToTranslit(null);
        }
        [ExpectedException(typeof(ArgumentNullException), "Exception was not thrown")]
        [TestMethod]
        public void Test_TranslationToRussian_Null_Negative()
        {
            LineHelper.TranslitToRussian(null);
        }
    }
}
