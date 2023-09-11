using System;
using System.Collections.Generic;

namespace cSharpProblems
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(CreateSentence(112222555));
            Console.WriteLine(CreateSentence(3333333333));
        }
    
        static string CreateSentence(uint seq)
        {
            // Create a numbers array
            string[] numbers = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
    
            // Create dictionary <string=num, int=qty>
            Dictionary<char, int> seqDict = new Dictionary<char, int>();
    
            // convert to string
            string stringSeq = seq.ToString();
    
            // loop over the string. If it exists in dictionary increase qty otherwise add to dict
            for (var i = 0; i < stringSeq.Length; i++)
            {
                if (seqDict.ContainsKey(stringSeq[i]))
                {
                    seqDict[stringSeq[i]] = seqDict[stringSeq[i]] + 1;
                }
                else
                {
                    seqDict.Add(stringSeq[i], 1);
                }
            }
            // Return string numbers[dict[0].qty] dict[0].key <== something like this. Use a loop
            string result = "";
    
            char[] seqDictKeys = new char[seqDict.Count];
            var kvpIndex = 0;
            foreach (KeyValuePair<char, int> kvp in seqDict)
            {
                seqDictKeys.SetValue(kvp.Key, kvpIndex);
                kvpIndex++;
            }
    
            for (var i = 0; i < seqDict.Count; i++)
            {
                if (i != 0)
                {
                    result += ", then ";
                }
    
                // dictionary[keys[i]]
                result += numbers[seqDict[seqDictKeys[i]]] + " " + seqDictKeys[i] + "s";
            }
    
            return result;
        }
    }
}
