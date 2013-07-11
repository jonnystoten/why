using NUnit.Framework;
using Why;

namespace WhyTests
{
    [TestFixture]
    public class WhyCombinatorTests
    {
        [Test]
        public void Test()
        {
            var why = new WhyCombinator();

            Assert.That(why.FactorialUsingY(5), Is.EqualTo(120));
        }
    }
}
