using NUnit.Framework;

namespace PageObjectModelTest.Helper
{
    public class Base
    {
        [SetUp]
        public static void BeforeScenario()
        {
            WebDriver.Driver.Initialization();
        }
        [TearDown]
        public static void AfterScenario()
        {
            WebDriver.Driver.CleanUp();
        }
    }
}
