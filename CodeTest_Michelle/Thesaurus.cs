using System.Collections.Generic;
using System.Linq;
using System;
using System.Text.RegularExpressions;


namespace CodeTest_Michelle
{
    class Thesaurus : IThesaurus
    {
        public Dictionary<string, List<string>> dictionary = new();
        
        public void AddSynonyms(IEnumerable<string> synonyms)
        {
            string key;
            List<string> synonymsList = synonyms.ToList();

            if (CheckIfWordIsAccepted(synonymsList[0]))
            {
                key = synonymsList[0];
                synonymsList.Remove(synonymsList[0]);

                if (dictionary.ContainsKey(key))
                {
                    foreach (var synonym in synonymsList)
                    {
                        if (!dictionary[key].Contains(synonym) && CheckIfWordIsAccepted(synonym))
                            dictionary[key].Add(synonym);
                    }
                }
                else
                {
                    dictionary.Add(key, synonymsList);
                }
            }
            else
            {
                Console.WriteLine("Incorrect input.");
            }  
        }

        public IEnumerable<string> GetSynonyms(string word)
        {
            List<string> synonyms = new();

            if (dictionary.ContainsKey(word))
            {
                foreach (var synonym in dictionary[word])
                {
                    synonyms.Add(synonym);
                }
            }
                return synonyms;
        }

        public IEnumerable<string> GetWords()
        {
            List<string> wordsOfDictionary = new();

            foreach (var word in dictionary)
            {
                string key = word.Key;
                wordsOfDictionary.Add(key);
            }
            return wordsOfDictionary;
        }  
        
        public bool CheckIfWordIsAccepted(string word)
        {
            string wordRegex = @"^[a-zA-Z]+$";
            return Regex.IsMatch(word, wordRegex);
        }
    }
}