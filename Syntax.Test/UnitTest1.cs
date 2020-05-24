using NUnit.Framework;
using NUnit.Framework.Constraints;
using System;
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

        [Test]
        [Category("sample_category")]
        public void Test_Constraint_IsSameAs()
        {
            var e1 = new Exception();
            var e2 = new Exception();
            var e3 = e1;
            Assert.That(e1, Is.SameAs(e3));
        }
    }
}