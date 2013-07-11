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
            var factorial = new WhyCombinator<int, int>(fac => n => n < 3 ? n : n * fac(n - 1));

            Assert.That(factorial.Execute(5), Is.EqualTo(120));
        }
    }
}
