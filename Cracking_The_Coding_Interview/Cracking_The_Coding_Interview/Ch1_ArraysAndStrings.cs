using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cracking_The_Coding_Interview
{
    class Ch1_ArraysAndStrings
    {
        // 1.1 - Is Unique:
        // Implement an algorithm to determine if a string has all unique characters.
        // What if you cannot use additional data structures?
        public string IsUnique(string testString)
        {
            string abc = "abcdefghijklmnopqrstuvwxyz";  //better way to get this? 
            //current solution does not account for spaces
            //set up a testing suite? instead of writing out to the console?
            

            foreach (var letter in testString)
            {
                if (abc.Contains(letter))
                {
                    int index = abc.IndexOf(letter);
                    abc = abc.Remove(index, 1);
                }
                else
                {
                    return "not unique";
                }
            }

            return "is unique"; 
        }

    }
}
