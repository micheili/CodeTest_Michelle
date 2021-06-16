using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CodeTest_Michelle
{
    [TestFixture]
    class ThesaurusTests
    {
        private Thesaurus thesaurus;

        [SetUp]
        public void SetUp()
        {
            thesaurus = new Thesaurus();
        }

        [Test]
        public void Test_That_AddSynonyms_Adds_All_Synonyms_To_Word()
        {
            List<string> synonyms = new() { "love", "infatuation", "devotion", "fondness" }; 
    
            thesaurus.AddSynonyms(synonyms);
            var result = thesaurus.GetSynonyms("love").ToList();

            Assert.That(result.Count == 3);
        }

        [Test]
        public void Test_For_Adding_Already_Existing_Words()
        {
            List<string> synonyms = new() { "love", "affection", "devotion", "fondness" };
            List<string> synonyms2 = new() { "love", "affection", "devotion", "infatuation" };

            thesaurus.AddSynonyms(synonyms);
            thesaurus.AddSynonyms(synonyms2);

            bool wordsAreUnique = thesaurus.GetWords().Distinct().Count() == thesaurus.GetWords().Count();
            bool duplicateSynonyms = thesaurus.GetSynonyms("love").Distinct().Count() == thesaurus.GetSynonyms("love").Count();
             
            Assert.IsTrue(wordsAreUnique);
            Assert.IsFalse(duplicateSynonyms);
            
        }

        [Test]
        [TestCase("Banana", ExpectedResult = true)]
        [TestCase("Banana2", ExpectedResult = false)]
        [TestCase("Banana ", ExpectedResult = false)]
        [TestCase("Banana!", ExpectedResult = false)]
        public bool Test_For_Validating_Input(string word)
        {
            return thesaurus.CheckIfWordIsAccepted(word);
        }

        [Test]
        public void Test_That_Get_Word_Return_Correct_Amount() 
        {
            var result = thesaurus.GetWords().ToList();

            Assert.AreEqual(result.Count, thesaurus.dictionary.Count);
        }

        [Test]
        public void Test_That_Return_IsEmpty_If_Word_Doesnt_Exist()
        {
            string word = "banana";

            var result = thesaurus.GetSynonyms(word);

            Assert.IsEmpty(result);

        }
        [Test]
        public void Test_That_Existing_Synonyms_Are_Returned()
        {
            List<string> wordAndSynonyms = new() { "love", "affection", "devotion", "infatuation" };
            List<string> synonymResultFromWord = new();

            thesaurus.AddSynonyms(wordAndSynonyms);
            var synonyms = wordAndSynonyms.Remove(wordAndSynonyms[0]);
            

            foreach(string synonym in thesaurus.GetSynonyms("love"))
            {
                synonymResultFromWord.Add(synonym);
            }

            Assert.AreEqual(synonymResultFromWord, wordAndSynonyms);
        }

    }
}