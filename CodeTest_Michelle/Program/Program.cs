using System;
using System.Collections.Generic;

namespace CodeTest_Michelle
{
    class Program
    {
        static void Main(string[] args)
        {
            Thesaurus thesaurus = new();
            ProgramRunner programRunner = new(thesaurus);

            programRunner.Run(); 
        }
    }
}
