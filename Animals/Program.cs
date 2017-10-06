using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Animals
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string path = @"../../favourites.txt";

            if (args == null)
            {
                Console.WriteLine("C# favourite animals: ");
            }
            else
            {
                List<string> animals = File.ReadAllLines(path).ToList();

                foreach (string argument in args)
                {
                    if (!animals.Contains(argument))
                    {
                        using (StreamWriter writer = File.AppendText(path)) 
                        {
							writer.WriteLine(argument);    
                        }
                    }
                }   
            }
        }
    }
}
