using System.Collections.Generic;

namespace CodeTest_Michelle
{
    interface IThesaurus
    {
        void AddSynonyms(IEnumerable<string> synonyms);
       
        IEnumerable<string> GetSynonyms(string word);
       
        IEnumerable<string> GetWords();
    }
}
