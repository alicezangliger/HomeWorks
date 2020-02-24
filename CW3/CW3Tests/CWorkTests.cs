using CW3;
using CW3Library;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using Assert = NUnit.Framework.Assert;

namespace Tests
{
    [TestFixture]
    public class CWorkTests
    {
        CalkulyatorPage calkPage;        
        CommandsInvoker invoker;
        [OneTimeSetUp]
        public void Setup()
        {
            calkPage = new CalkulyatorPage(new ChromeDriver());
            calkPage.Init();
            invoker = new CommandsInvoker(calkPage);

        }

        [Test]
        public void TestForPlus_positive()
        {
            string actualResult = invoker.GetResult("5 + 5 =");

            Assert.AreEqual(actualResult, calkPage.Display.Text);

        }

        [Test]
        public void TestForMinus_positive()
        {
            string actualResult = invoker.GetResult("9 - 3 =");

            Assert.AreEqual(actualResult, calkPage.Display.Text.ToString());
        }

        [Test]
        public void TestForMultiplication_positive()
        {
            string actualResult = invoker.GetResult("5 * 8 =");

            Assert.AreEqual(actualResult, calkPage.Display.Text.ToString());
        }

        [Test]
        public void TestForDivision_positive()
        {
            string actualResult = invoker.GetResult("3 / 4 =");

            Assert.AreEqual(actualResult, calkPage.Display.Text.ToString());
        }

        [Test]
        public void TestForPercent_positive()
        {
            string actualResult = invoker.GetResult("9 % 5 =");

            Assert.AreEqual(actualResult, calkPage.Display.Text.ToString());
        }
        [TearDown]
        public void Clear()
        {
            invoker.GetResult("AC");
        }
    }
}