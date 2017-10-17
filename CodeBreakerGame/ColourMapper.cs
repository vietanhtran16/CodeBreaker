using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeBreaker;

namespace CodeBreakerGame
{
    public class ColourMapper
    {
        private readonly IEnumerable<Colour> _colourEnum = Enum.GetValues(typeof(Colour)).Cast<Colour>();
        public List<Colour> Map(string colourLetter)
        {
            var colours = colourLetter.Split(',');
            return GetMappedColours(colours);
        }

        private List<Colour> GetMappedColours(string[] colours)
        {
            return colours.Select(colour => _colourEnum.FirstOrDefault(x => x.ToString().StartsWith(colour.ToUpper()))).ToList();
        }
    }
}
