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
        public void TestIfMethodReturnAString()
        {
            var obj = new MyComponent();
            Assert.AreEqual("This is a method", obj.Method());
        }
    }
}
