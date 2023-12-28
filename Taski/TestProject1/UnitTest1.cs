using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Programmm p = new Programmm();
            p.Aboba(2);
            Assert.Pass();
        }
    }
}