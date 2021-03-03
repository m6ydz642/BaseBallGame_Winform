using NUnit.Framework;

namespace NUnitTestProject_BaseBallGame_Winform
{
    public class Tests : Form1
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(_save) ;
        }
    }
}