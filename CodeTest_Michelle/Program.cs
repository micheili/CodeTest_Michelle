using System;
using System.Collections.Generic;

namespace CodeTest_Michelle
{
    class Program
    {
        static void Main(string[] args)
        {
            //use singleton or send Ithesaurus to programrunner
            Thesaurus thesaurus = new();
            ProgramRunner programRunner = new(thesaurus);
            programRunner.Run(); 



        }
    }
}
