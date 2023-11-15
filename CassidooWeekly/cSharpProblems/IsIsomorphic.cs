namespace cSharpProblems;

public class Program
{
   public static void NotMainIsomorphic()
   {
      Console.WriteLine(IsIsomorphic("abb", "cdd"));
      Console.WriteLine(IsIsomorphic("cassidy", "1234567"));
      Console.WriteLine(IsIsomorphic("cass", "1233"));
   }

   private static bool IsIsomorphic(string word1, string word2)
   {
      var isoDict = new Dictionary<char, char>();

      for (var i = 0; i < word1.Length; i++)
      {
         if (isoDict.ContainsKey(word1[i]))
         {
            if (isoDict[word1[i]] != word2[i])
            {
               return false;
            }
         }
         else
         {
            isoDict.Add(word1[i], word2[i]);
         }
      }
      
      return true;
   }
}