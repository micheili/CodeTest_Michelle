using System.Collections.Generic;
using System.Linq;
using System;

namespace CodeTest_Michelle
{

    class Thesaurus : IThesaurus
    {
        public Dictionary<string, List<string>> dictionary = new();
        
        public void AddSynonyms(IEnumerable<string> synonyms)
        {
            List<string> synonymsList = synonyms.ToList();

            string key = synonymsList[0];
            synonymsList.Remove(synonymsList[0]);

            dictionary.Add(key, synonymsList);
           
        }

        public IEnumerable<string> GetSynonyms(string word)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<string> GetWords()
        {
            throw new System.NotImplementedException();

        }
    }
}