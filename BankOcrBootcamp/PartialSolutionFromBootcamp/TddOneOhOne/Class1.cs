using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace TddOneOhOne
{
    [TestFixture]
    public class BankInputTokeniserTests
    {
        [Test]
        public void Tokenise_GivenOneKnownCharacter_ReturnsOneToken()
        {
            var tokeniser = new BankInputTokeniser();

            const string input = 
@" _ 
| |
|_|";

            var tokens = tokeniser.TokeniseLine(input);

            Assert.That(tokens.Count, Is.EqualTo(1));
        }

        [Test]
        public void Tokenise_GivenOneKnownCharacter_TokenReturnedContainsCorrectRawData()
        {
            var tokeniser = new BankInputTokeniser();

            const string input =
@" _ 
| |
|_|";

            var tokens = tokeniser.TokeniseLine(input);

            Assert.That(tokens[0].Raw[0], Is.EqualTo(" _ "));
            Assert.That(tokens[0].Raw[1], Is.EqualTo("| |"));
            Assert.That(tokens[0].Raw[2], Is.EqualTo("|_|"));
        }

        [Test]
        public void Tokenise_GivenStringOfKnownCharacters_ReturnsCorrectNumberOfTokens()
        {
            var tokeniser = new BankInputTokeniser();

            var input =
@" _  _  _  _  _  _  _  _  _ 
| || || || || || || || || |
|_||_||_||_||_||_||_||_||_|";

            var tokens = tokeniser.TokeniseLine(input);

            Assert.That(tokens.Count, Is.EqualTo(9));
        }
        
    }

    [TestFixture]
    public class BankOcrTests
    {
        [Test]
        public void RecogniseAZero_GivenSingleToken_Recognises()
        {
            var ocr = new Ocr(new []{new ZeroRecogniser(), });
            var token = new Token
            {
                Raw = new List<string>
                {
                    {" _ "},
                    {"| |"},
                    {"|_|"}
                }
            };

            var digits = ocr.Recognise(token);

            Assert.That(digits[0], Is.EqualTo(0));
        }
    }

    [TestFixture]
    public class ZeroRecogniserTests
    {
        [Test]
        public void TryMatch_GivenZero_Matches()
        {
            var token = new Token
            {
                Raw = new List<string>
                {
                    {" _ "},
                    {"| |"},
                    {"|_|"}
                }
            };

            var zr = new ZeroRecogniser();

            var result = zr.TryMatch(token);

            Assert.That(result.Item1, Is.True);
        }
    }

    public class Ocr
    {
        private readonly IList<IRecogniseCharacter> _components;

        public Ocr(IList<IRecogniseCharacter> components)
        {
            _components = components;
        }

        public int[] Recognise(params Token[] tokens)
        {
            var ints = new List<int>();

            foreach (var token in tokens)
            {
                foreach (var c in _components)
                {
                    var result = c.TryMatch(token);
                    if (result.Item1)
                    {
                        ints.Add(Int32.Parse( result.Item2));
                    }
                }

                ints.Add(0);
            }

            return ints.ToArray();
        }
    }

    public class BankInputTokeniser
    {
        public List<Token> TokeniseLine(string input)
        {
            var tokens = new List<Token>();
            var lines = input.Split(new[] {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries);

            for (var startIndex = 0; startIndex < lines[0].Length; startIndex = startIndex+3)
            {
                var token = new Token();
                token.Raw.Add(lines[0].Substring(startIndex, 3));
                token.Raw.Add(lines[1].Substring(startIndex, 3));
                token.Raw.Add(lines[2].Substring(startIndex, 3));
                tokens.Add(token);
                
            }

            return tokens;
        }
    }

    public class Token
    {
        public List<string> Raw { get; set; }

        public Token()
        {
            Raw = new List<string>();
        }
    }
}
