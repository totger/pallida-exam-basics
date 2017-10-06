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
            List<char> returnList = new List<char>();
            Dictionary<char, int> characters = new Dictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (characters.ContainsKey(input[i]))
                {
                    characters[input[i]]++;
                }
                else
                {
                    characters.Add(input[i], 1);
                }
            }
            foreach (var item in characters)
            {
                if (item.Value == 1)
                {
                    returnList.Add(item.Key);
                }
            }
            return returnList;
        }
    }
}
