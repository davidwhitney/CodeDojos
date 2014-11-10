using System;
using System.Collections.Generic;
using System.Linq;

namespace TddOneOhOne
{
    public interface IRecogniseCharacter
    {
        Tuple<bool, string> TryMatch(Token token);
    }

    public class ZeroRecogniser : IRecogniseCharacter
    {
        private List<string> _pattern = new List<string>
        {
            {" _ "},
            {"| |"},
            {"|_|"}
        };

        public Tuple<bool, string> TryMatch(Token token)
        {
            var matches = string.Concat(_pattern) == string.Concat(token.Raw);

            return new Tuple<bool, string>(matches, "0");
        }
    }
}