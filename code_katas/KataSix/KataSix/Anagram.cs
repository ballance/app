using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KataSix
{
    public class Anagram
    {
        public bool IsAnagram(string input)
        {
            string reversed = ReverseString(input);
            Console.WriteLine("Comparing {0} to", input);
            Console.WriteLine("Output    {0} ", reversed);
            return reversed.Equals(input, StringComparison.OrdinalIgnoreCase);

        }

        private string ReverseString(string input)
        {
            var inputCharArray = input.ToCharArray();
            string reversedString = string.Empty;
            for (int i = inputCharArray.Length-1; i >= 0; i-- )
            {
                reversedString += inputCharArray[i];
            }
            return reversedString;
        }
    }
}
