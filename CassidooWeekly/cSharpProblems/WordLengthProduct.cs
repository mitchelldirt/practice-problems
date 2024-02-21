namespace cSharpProblems;

public class WordLengthProduct
{
    public static void Main()
    {
        Console.WriteLine(WordLengthProductFunc(new []{"fish","fear","boo","egg","cake","abcdef"}));
        Console.WriteLine(WordLengthProductFunc(new []{"a","aa","aaa","aaaa"}));
    }
    
    private static 
        int WordLengthProductFunc(string[] words)
    {
        // Create a data structure to hold onto all valid combos
        var products = new List<int>();
        
        // Loop over the list of words
        foreach (var word in words)
        {
            // Nested loops to check against each word
            for (var i = 0; i < words.Length; i++)
            {
                var compare = words[i];

                var wordArray = word.ToCharArray();
                var compareArray = compare.ToCharArray();
                var valid = true;

                foreach (var letter in wordArray)
                {
                    if (Array.Exists(compareArray, element => element == letter)) valid = false;

                    if (valid == false) break;
                }
                
                if (valid) products.Add(word.Length * compare.Length);
            }
        }
        // Return the largest combo
        return products.Count > 0 ? products.Max() : 0;
    }
}