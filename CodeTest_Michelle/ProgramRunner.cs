using System;
using System.Collections.Generic;

namespace CodeTest_Michelle
{
    class ProgramRunner
    {
        private Thesaurus thesaurus;
       
        public ProgramRunner(Thesaurus thesaurus)
        {
            this.thesaurus = thesaurus;
        }

        public void Run()
        {
            RunAddSynonyms();
            PrintWordsInThesaurus();
            PrintSynonymsForWord("Animal");
            PrintSynonymsForWord("Heart");
            PrintSynonymsForWord("Love");
        }

        private void RunAddSynonyms()
        {
            List<string> synonyms = new() { "Love", "Affection", "Devotion", "Fondness" };
            List<string> synonyms2 = new() { "Heart", "Character", "Nature", "Soul" };
            List<string> synonyms3 = new() { "Animal", "Beast", "Creature", "Pet" };

            thesaurus.AddSynonyms(synonyms);
            thesaurus.AddSynonyms(synonyms2);
            thesaurus.AddSynonyms(synonyms3);
        } 
        
        private void PrintWordsInThesaurus()
        {
            IEnumerable<string> words = thesaurus.GetWords();
            Console.WriteLine("Words in Thesaurus:");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }

        private void PrintSynonymsForWord(string word)
        {
            IEnumerable<string> synonyms = thesaurus.GetSynonyms(word);

            Console.WriteLine("\nSynonyms for " + word + ":");

            foreach (string synonym in synonyms)
            {
                Console.WriteLine(synonym);
            }
        }

    }
}