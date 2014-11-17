using System.Collections.Generic;
using System.IO;
using System.Linq;
using NUnit.Framework;

namespace MorseKata
{
    [TestFixture]
    public class MorseParserTests
    {
        private MorseParser _parser;

        [SetUp]
        public void SetUp()
        {
            _parser = new MorseParser();
        }

        [TestCase("A", ".-")]
        [TestCase("B", "-...")]
        [TestCase("C", "-.-.")]
        [TestCase("D", "-..")]
        [TestCase("E", ".")]
        [TestCase("F", "..-.")]
        [TestCase("G", "--.")]
        [TestCase("H", "....")]
        [TestCase("I", "..")]
        [TestCase("J", ".---")]
        [TestCase("K", "-.-")]
        [TestCase("L", ".-..")]
        [TestCase("M", "--")]
        [TestCase("N", "-.")]
        [TestCase("O", "---")]
        [TestCase("P", ".--.")]
        [TestCase("Q", "--.-")]
        [TestCase("R", ".-.")]
        [TestCase("S", "...")]
        [TestCase("T", "-")]
        [TestCase("U", "..-")]
        [TestCase("V", "...-")]
        [TestCase("W", ".--")]
        [TestCase("X", "-..-")]
        [TestCase("Y", "-.--")]
        [TestCase("Z", "--..")]
        public void Parse_WithMorseForSingleLetter_ReturnsA(string expectation, string morse)
        {
            var letter = _parser.Paser(morse);

            Assert.That(letter[0], Is.EqualTo(expectation));
        }

        [Test]
        public void Parse_WithMorseSequenceThatHasTwoWordMatchesReturnsBothMatches()
        {
            var results = _parser.Paser("...---..-....-");

            Assert.That(results.Contains("SOFIA"));
            Assert.That(results.Contains("EUGENIA"));

        }
    }

    public class MorseParser
    {
        private readonly Dictionary<string, List<string>> _wordDic;
        private readonly Dictionary<char, string> _charToMorse;
        private readonly Dictionary<string, string> _morseLookup
            = new Dictionary<string, string>
            {
                {".-", "A"}, {"-...", "B"}, {"-.-.", "C"}, {"-..", "D"}, {".", "E"},
                {"..-.", "F"}, {"--.", "G"}, {"....", "H"}, {"..", "I"}, {".---", "J"},
                {"-.-", "K"}, {".-..", "L"}, {"--", "M"}, {"-.", "N"}, {"---", "O"},
                {".--.", "P"}, {"--.-", "Q"}, {".-.", "R"}, {"...", "S"}, {"-", "T"},
                {"..-", "U"}, {"...-", "V"}, {".--", "W"}, {"-..-", "X"}, {"-.--", "Y"},
                {"--..", "Z"}
            };

        public MorseParser()
        {
            _charToMorse = new Dictionary<char, string>();
            PopulateCharacterToMorseCodeMap();
            _wordDic = BuildMorseCodeToWordListMapping();
        }
        
        public List<string> Paser(string code)
        {
            if (_morseLookup.ContainsKey(code))
            {
                return new List<string>{_morseLookup[code]};
            }

            return _wordDic[code];
        }

        private void PopulateCharacterToMorseCodeMap()
        {
            foreach (var item in _morseLookup)
            {
                _charToMorse.Add(item.Value.ToUpper()[0], item.Key);
            }
        }

        private Dictionary<string, List<string>> BuildMorseCodeToWordListMapping()
        {
            var wordDic = new Dictionary<string, List<string>>();
            var allWords = File.ReadAllLines("words.txt");
            
            foreach (var word in allWords.Select(x=>x.ToUpper()))
            {
                var morse = word.Where(chr => _charToMorse.ContainsKey(chr))
                                     .Aggregate("", (current, chr) => current + _charToMorse[chr]);

                if (!wordDic.ContainsKey(morse))
                {
                    wordDic.Add(morse, new List<string>());
                }

                wordDic[morse].Add(word);
            }

            return wordDic;
        }
    }
}
