using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DictionaryAssistant.Exceptions;

namespace DictionaryAssistant.Dictionary
{
    public class ActiveDictionary : IWordDictionary
    {
        private readonly List<string> allDictionaryWords;
        private readonly Dictionary<char, List<String>> wordsEndingWith;
        private readonly Dictionary<char, List<String>> wordsStartingWith;

        public ActiveDictionary(List<string> allDictionaryWords)
        {
            this.allDictionaryWords = allDictionaryWords;
            wordsEndingWith = new Dictionary<char, List<string>>();
            wordsStartingWith = new Dictionary<char, List<string>>();
        }

        /* Implements IWordDictionary: */

        public List<string> GetDictionaryWords()
        {
            return allDictionaryWords;
        }

        public List<string> GetDictionaryWordsEndingWith(char letter)
        {
            if (!wordsEndingWith.ContainsKey(letter))
            {
                throw new WordEndingNotFoundException();
            }

            return wordsEndingWith[letter];
        }

        public List<string> GetDictionaryWordsStartingWith(char letter)
        {
            if (!wordsStartingWith.ContainsKey(letter))
            {
                throw new WordStartingNotFoundException();
            }

            return wordsStartingWith[letter];
        }

        public void SaveWordsForLettersEnding(char letter, List<string> words)
        {
            wordsEndingWith[letter] = words;
        }

        public void SaveWordsForLetterStarting(char letter, List<string> words)
        {
            wordsStartingWith[letter] = words;
        }
    }
}
