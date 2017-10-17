using System.Collections.Generic;
using CodeBreaker;
using NUnit.Framework;

namespace CodeBreakerGame
{
    [TestFixture()]
    public class ColourMapperShould
    {
        [Test]
        public void MapUserInputtedColourLetterToColours()
        {
            var colourMapper = new ColourMapper();
            var actual = colourMapper.Map("r,g,y,c");
            var expected = new List<Colour>(){Colour.Red, Colour.Green, Colour.Yellow, Colour.Cyan};
            Assert.AreEqual(expected, actual);
        }


    }
}
