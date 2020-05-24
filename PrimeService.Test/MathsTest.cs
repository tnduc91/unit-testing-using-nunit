using NUnit.Framework;
using NUnit.Framework.Constraints;
using Prime.Service;

namespace Prime.UnitTests.Services
{
    [TestFixture]
    public class MathsTest 
    {
        [Test, Combinatorial]
        public void Test_TryCombinatorialAttribute([Values(1, 2, 3)] int val1, [Values(4,5,6)] int val2)
        {
            var math = new Maths();
            Assert.That(math.TryCombinatorialAttribute(val1, val2), Is.EqualTo(true));
        }
    }
}