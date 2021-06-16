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
            List<string> synonymsList = synonyms.ToList();
            string key;

            if (CheckIfWordIsAccepted(synonymsList[0]))
            {
                key = synonymsList[0];
                synonymsList.Remove(synonymsList[0]);

                if (dictionary.ContainsKey(key))
                {
                    //if it does, check if the other synonyms exists as values
                    //add other synonyms if they don't

                    foreach (var synonym in synonymsList)
                    {
                        if (!dictionary[key].Contains(synonym))
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

        public bool CheckIfWordIsAccepted(string word)
        {
            string wordRegex = @"^[a-zA-Z]+$";
            return Regex.IsMatch(word, wordRegex);
        }

        public IEnumerable<string> GetSynonyms(string word)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<string> GetWords()
        {
            List<string> wordsOfDictionary = new();

            foreach (var word in dictionary)
            {
                string key = word.Key;
                List<string> values = word.Value;
                //wordsOfDictionary.Add(key + (value => values );
            }
            return wordsOfDictionary;
        }
    }
}