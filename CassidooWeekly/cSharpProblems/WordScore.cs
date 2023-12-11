namespace cSharpProblems;

public class WordScore
{   
  
    
    public static void WordScoreMain()
    {
        string[] wordList = {"apple", "banana", "cherry", "date", "fig"};   
        
        Console.WriteLine(SumOfWords(wordList));
    }

    public static string SumOfWords(string[] words)
    {
        var letterToNum = new Dictionary<char, int>();

        for (int i = 0; i < 26; i++) {
            letterToNum.Add((char)('a' + i), i + 1);  
        }

        BestWord bestWord = new BestWord(){ Word = "", Score = 0 };
        
        // for each word in words
        
        // iterate through each letter grabbing its score and adding it up
        
        // multiply by length to get final score
        
        // If it's the first one then overwrite the bestWord object
        
        // If it's not the first one check if bigger than bestScore if it is replace bestWord otherwise continue

        foreach (var word in words)
        {
            int sumOfLetters = 0;
            var lengthOfWord = word.Length;

            foreach (var letter in word)
            {
                sumOfLetters += letterToNum[letter];
            }


            var score = sumOfLetters * lengthOfWord;

            if (score > bestWord.Score)
            {
                bestWord.Word = word;
                bestWord.Score = score;
            } 
            else if (score == bestWord.Score)
            {
                bestWord.Word = string.Compare(word, bestWord.Word) < 0 ? word : bestWord.Word;
            }
        }

        return bestWord.Word;
    }
}

public class BestWord
{
    public string Word { get; set; }
    public int Score { get; set; }
}