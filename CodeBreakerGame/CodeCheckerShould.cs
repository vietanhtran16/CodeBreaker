using System.Collections.Generic;
using CodeBreaker;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace CodeBreakerGame
{
    [TestFixture]
    public class CodeCheckerShould
    {
        private static readonly object[] OneMarkForOneCorrectColourAndPosition =
        {
            new object[]
            {
                "b", new List<Colour>() {Colour.Red, Colour.Green, Colour.Yellow, Colour.Cyan},
                new List<Colour>() {Colour.Red, Colour.White, Colour.White, Colour.White}
            }
        };

        private static readonly object[] TwoMarkForTwoCorrectColourAndPosition =
        {
            new object[]
            {
                "bb", new List<Colour>() {Colour.Red, Colour.Green, Colour.Yellow, Colour.Cyan},
                new List<Colour>() {Colour.White, Colour.Green, Colour.White, Colour.Cyan}
            }
        };
        private static readonly object[] ThreeMarkForThreeCorrectColourAndTwoMatchingPosition =
        {
            new object[]
            {
                "bbw", new List<Colour>() {Colour.Red, Colour.Green, Colour.Yellow, Colour.Cyan},
                new List<Colour>() {Colour.White, Colour.Red, Colour.Yellow, Colour.Cyan}
            }
        };
        private static readonly object[] FourMarkForTwoCorrectColourAndTwoMatchingPosition =
        {
            new object[]
            {
                "bbww", new List<Colour>() {Colour.Red, Colour.Green, Colour.Yellow, Colour.Cyan},
                new List<Colour>() {Colour.Red, Colour.Green, Colour.Cyan, Colour.Yellow}
            }
        };
        [Test]
        [TestCaseSource(nameof(OneMarkForOneCorrectColourAndPosition))]
        [TestCaseSource(nameof(TwoMarkForTwoCorrectColourAndPosition))]
        [TestCaseSource(nameof(ThreeMarkForThreeCorrectColourAndTwoMatchingPosition))]
        [TestCaseSource(nameof(FourMarkForTwoCorrectColourAndTwoMatchingPosition))]

        public void ReturnCorrectMark(string expectedMark, List<Colour> code, List<Colour> guess)
        {
            var codeBreaker = new CodeBreaker.CodeChecker();
            var actual = codeBreaker.CheckGuess(code, guess);
            Assert.AreEqual(expectedMark, actual);
        }
    }
}
