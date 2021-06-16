using System;
using System.Collections.Generic;

namespace CodeTest_Michelle
{
    class ProgramRunner
    {
        private Thesaurus thesaurus;
        List<string> synonyms = new() { "love", "affection", "devotion", "fondness" };
        List<string> synonyms2 = new() { "heart", "stjärt", "devotion", "fondness" };
        List<string> synonyms3 = new() { "love", "lingon", "devotion", "fondness" };

        public ProgramRunner(Thesaurus thesaurus)
        {
            this.thesaurus = thesaurus;
        }

        public void Run()
        {

            thesaurus.AddSynonyms(synonyms);
            thesaurus.AddSynonyms(synonyms2);
            thesaurus.AddSynonyms(synonyms3);

            IEnumerable<string> words = thesaurus.GetWords();
            
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
               
            Console.WriteLine("hej", words);

        }
    }
}