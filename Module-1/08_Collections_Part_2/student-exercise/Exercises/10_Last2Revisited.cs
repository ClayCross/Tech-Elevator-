using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Just when you thought it was safe to get back in the water --- Last2Revisited!!!!
         *
         * Given an array of strings, for each string, the count of the number of times that a substring length 2 appears
         * in the string and also as the last 2 chars of the string, so "hixxxhi" yields 1.
         *
         * We don't count the end substring, but the substring may overlap a prior position by one.  For instance, "xxxx"
         * has a count of 2, one pair at position 0, and the second at position 1. The third pair at position 2 is the
         * end substring, which we don't count.
         *
         * Return Dictionary<string, int>, where the key is string from the array, and its last2 count.
         *
         * Last2Revisited(["hixxhi", "xaxxaxaxx", "axxxaaxx"]) → {"hixxhi": 1, "xaxxaxaxx": 1, "axxxaaxx": 2}
         *
         */
        public Dictionary<string, int> Last2Revisited(string[] words)
        {
            //Make a dictionary
            Dictionary<string, int> result = new Dictionary<string, int>(); 

            //check "each" string in the array using a "foreach loop"
            foreach (string word in words)
            {
                //grab the lst two charachters as stringtoFind
                string stringToFind = word.Substring(word.Length - 2);
                // loop through current string to see if it == stringToFind
                int count = 0;
                for (int i = 0; i < word.Length - 2; i++)
                {
                    // if word.Substring == stringToFind count++
                    if (word.Substring(i, 2) == stringToFind)
                    {
                        count++;

                    }


                }
                // assign word to key and count to value(make sure not to duplicate)
                //result.Add(word, count);
                result[word] = count;
                



            }











            //return the dictionary







            return result;
        }
    }
}
