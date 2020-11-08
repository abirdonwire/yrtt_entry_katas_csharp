using System;

// Move the first letter of each word to the end of it, then add "ay" to the end of the word. 
// Leave punctuation marks untouched.

namespace TechReturners.Tasks
{
    public class Exercise004
    {
        public static string PigIt(string str)
        {
            throw new NotImplementedException();

            foreach (var word in string)
            {
                string firstLetter = word.Substring(0, 1);
                word.Concat(firstLetter.Concat("ay"));
            }

        }
    }
}

