using CodeBreakerGame.Logic;
using NUnit.Framework;

namespace CodeBreakerGame.UnitTest
{
    [TestFixture]
    public class CodeGeneratorShould
    {
        [Test]
        public void ReturnACodeOf4RandomColours()
        {
            var generator = new CodeGenerator();
            var actual = generator.Create();
            Assert.AreEqual(4, actual.Count);
        }
    }
}
