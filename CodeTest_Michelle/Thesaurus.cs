using System.Collections.Generic;

namespace CodeTest_Michelle
{

    class Thesaurus : IThesaurus
    {
        List<string> dictionary = new();
        
        public void AddSynonyms(IEnumerable<string> synonyms)
        {
            throw new System.NotImplementedException();
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