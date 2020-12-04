using NUnit.Framework;
using FluentAssertions;

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

        /// <summary>
        /// For more extra BDD style assertions for <b>C#</b> unit tests: <br/>
        /// See <a href="https://fluentassertions.com/introduction">Fluent Assertions Documentation</a>
        /// </summary>
        [Test, Description("Example test using Behaviour Driven Development (BDD) style approach, with FluentAssertions nuget package")]
        public void TestWithBddAssertions()
        {
            var obj = new MyComponent();
            obj.Method().Should().Equals("This is a method");
        }
    }
}
