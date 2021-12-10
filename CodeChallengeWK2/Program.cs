using System;

namespace CodeChallengeWK2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   Question1 question1 = new Question1();
               string result = question1.CheckSherlockStringValidity("abccc");
               Console.WriteLine(result);*/

            Question2 question2 = new Question2();
            int result2 = question2.SuperDigit("9", 1);
            Console.WriteLine(result2);

        }
    }
}
