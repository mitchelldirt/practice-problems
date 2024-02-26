namespace cSharpProblems;

public class RemoveDigit
{
    public static void Main()
    {
        Console.WriteLine(RemoveDigitFunc(31415926, 1)); // 3,415,926
        Console.WriteLine(RemoveDigitFunc(1231, 1)); // 231
        Console.WriteLine(RemoveDigitFunc(69949, 9)); // 6,994
    }

    private static int RemoveDigitFunc(int number, int remove)
    {
        var numberString = number.ToString();
        var removeString = remove.ToString();
        
        var max = 0;
        var offset = 0;
        var index = numberString.IndexOf(removeString);

        

        if (index == -1)
        {
            return -1;
        }

        while (index != -1)
        {
            offset = index + 1;
            var removed = int.Parse(numberString[..index] + numberString[offset..]);

            if (removed > max) max = removed;

            index = numberString.IndexOf(removeString, offset);
        }

        return max;
    }
}