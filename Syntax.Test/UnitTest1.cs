using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace Syntax.Test
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.That("Hello", new EqualConstraint("Hello"));
        }
        [Test]
        public void Test2()
        {
            Assert.That("Hello", Is.EqualTo("Hello"));
        }
    }
}