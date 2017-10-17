using System.Collections.Generic;
using CodeBreaker;
using NUnit.Framework;

namespace CodeBreakerGame
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
