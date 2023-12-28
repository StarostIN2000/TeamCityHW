namespace TestProject2
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
            Assert.IsTrue(p.Aboba(2) == 4);
            Assert.Pass();
        }
        [Test]
        public void Test2()
        {
            Programmm p = new Programmm();
            Assert.IsTrue(p.Aboba(3) == 8);
            Assert.Pass();
        }
        [Test]
        public void Test3()
        {
            Programmm p = new Programmm();
            Assert.IsTrue(p.Aboba(0) == 1);
            Assert.Pass();
        }
    }
}