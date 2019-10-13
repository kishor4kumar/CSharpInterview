using NUnit.Framework;
using Basics;

namespace BasicsTest
{
    public class DelegatesTest
    {
        [Test]
        public void SimpleDelegateTest()
        {
            Log log = new Log();
            log.LogError("Test Logging");
            Assert.Pass();
        }
    }
}
