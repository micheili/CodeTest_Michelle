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
        public void Test_That_AddSynonyms_Adds_Correct_Amount_Of_Words()
        {
            List<string> synonyms = new() { "love", "affection", "devotion", "fondness" };
            int lengthOfDictionaryBeforeAdd = thesaurus.dictionary.Count;
    
            thesaurus.AddSynonyms(synonyms);
            int lengthOfDictionaryAfterAdd = thesaurus.dictionary.Count;
     
            Assert.AreEqual(lengthOfDictionaryAfterAdd - lengthOfDictionaryAfterAdd, synonyms.Count);
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

    }
}