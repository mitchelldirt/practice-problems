namespace cSharpProblems;

public class GeneratorRange
{
    public static void Main()
    {
        var range = FromTo(0, 3).GetEnumerator();
        
        while (range.MoveNext())
        {
            Console.WriteLine(range.Current);
        }
        
        range.Dispose();
    }

    private static IEnumerable<int> FromTo(int start, int end)
    {
        for (var i = start; i < end; i++)
        {
            yield return i;
        }
    }
}