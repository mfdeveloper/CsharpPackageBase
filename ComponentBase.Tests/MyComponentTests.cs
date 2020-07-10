using NUnit.Framework;

namespace ComponentBase.Tests
{
    public class MyComponentTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var obj = new MyComponent();
            Assert.AreEqual(obj.Method(), "This is a method");
        }
    }
}
