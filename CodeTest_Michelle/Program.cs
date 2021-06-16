using System;

namespace CodeTest_Michelle
{
    class Program
    {
        static void Main(string[] args)
        {

            //use singleton or send Ithesaurus to programrunner
            ProgramRunner programRunner = new();

            programRunner.Run();
        }
    }
}
