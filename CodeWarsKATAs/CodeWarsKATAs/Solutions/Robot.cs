using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWarsKATAs.Solutions
{
    public class Robot
    {
        private HashSet<string> learnedWords = new HashSet<string>(15) {
                "thank", "you", "for", "teaching", "me",
                "i", "do", "not", "understand", "the", "input",
                "already", "know", "word" 
        };

        public string LearnWord(string word)
        {
            if (string.IsNullOrEmpty(word))
                return "I do not understand the input";

            foreach (char c in word)
            {
                if (!char.IsLetter(c))
                    return "I do not understand the input";
            }

            string normalized = word.ToLower();

            if (learnedWords.Contains(normalized))
                return $"I already know the word {word}";

            learnedWords.Add(normalized);
            return $"Thank you for teaching me {word}";
        }



        private readonly HashSet<string> _storage = new(15)
        {
            "i", "do", "not", "understand", "the", "input", "already",
            "know", "word", "thank", "you", "for", "teaching", "me",
        };

        public string LearnWord2(string word)
        {
            if (word is null or "" || Regex.IsMatch(word, "[^a-zA-Z]"))
                return "I do not understand the input";

            if (!_storage.Add(word.ToLower()))
                return $"I already know the word {word}";

            return $"Thank you for teaching me {word}";
        }
    }
}
