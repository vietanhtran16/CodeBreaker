using System;
using System.Collections.Generic;
using CodeBreaker;

namespace CodeBreakerGame.Logic
{
    public class CodeGenerator
    {
        public List<Colour> Create()
        {
            var randomCode = new List<Colour>();
            var enumValues = Enum.GetValues(typeof(Colour));
            var random = new Random();
            var codeLength = 4;
            for (var i = 0; i < codeLength; i++)
            {
                randomCode.Add((Colour) enumValues.GetValue(random.Next(enumValues.Length)));
            }
            return randomCode;
        }
    }
}