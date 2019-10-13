using NUnit.Framework;
using Basics;

namespace BasicsTest
{
    class DataTypesTest
    {
        [Test]
        public void DateTimeFormatTest()
        {
            string date = DataTypes.GetDateTime("yyyy-MM-dd-ss");
            Assert.AreEqual(13, date.Length);
        }
    }
}
