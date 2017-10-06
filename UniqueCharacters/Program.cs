using System;
using System.Collections.Generic;
using System.Linq;

namespace UniqueCharacters
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            UniqueChars("anagram");
        }
        public static List<char> UniqueChars(string input)
        {
            List<char> characters = new List<char>();
            for (int i = 0; i < input.Length; i++)
            {
                characters.Add(input[i]);
            }
            List<char> returnList = new List<char>();
        }
    }
}
