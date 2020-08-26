using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DictionaryAssistant.Dictionary;
using DictionaryAssistant.Exceptions;

namespace DictionaryAssistant.Tests
{
    public class MockDictionary : IWordDictionary
    {
        private static readonly string[] Words = new string[]
        {
            "abbreviations",
            "abdicates",
            "abductions",
            "abductors",
            "abilities",
            "stammer",
            "stamp",
            "stance",
            "standard",
            "standstill"
        };

        public List<string> GetDictionaryWords()
        {
            return new List<string>(MockDictionary.Words);
        }

        public List<string> GetDictionaryWordsEndingWith(char letter)
        {
            throw new WordEndingNotFoundException();
        }

        public List<string> GetDictionaryWordsStartingWith(char letter)
        {
            throw new WordStartingNotFoundException();
        }

        public void SaveWordsForLettersEnding(char letter, List<string> words)
        {
            return;
        }

        public void SaveWordsForLetterStarting(char letter, List<string> words)
        {
            return;
        }
    }
}
