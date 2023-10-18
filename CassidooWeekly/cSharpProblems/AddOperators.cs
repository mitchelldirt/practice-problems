namespace cSharpProblems;

public class AddOperators
{
    public static void NotMain()
    {
        var result1 = AddOps(123, 6);
        var result2 = AddOps(345623749, 9191);
        var result3 = AddOps(555, 15);


        foreach (var result in result1)
        {
            Console.Write($"{result}  ");
        }
        
        Console.WriteLine();

        foreach (var result in result3)
        {
            Console.WriteLine($"{result}   ");
        }

    }

    public static string[] AddOps(int source, int target)
    {
        // split the source
        var splitSource = source.ToString().ToCharArray();
        
        // create a total var with 0
        int total = 0;
        bool addsToTarget = false;
        bool multsToTarget = false;
        
        // foreach in split source try multiplying together then adding together. If either reach the target then return
        // an array of like so ["1+2+3"]
        // Just use array.join("+")
        foreach (var value in splitSource)
        {
            total += int.Parse(value.ToString());
        }

        if (total == target)
            addsToTarget = true;
        
        // Can't multiply by zero
        total = int.Parse(splitSource[0].ToString());

        for (int i = 1; i < splitSource.Length; i++)
        {
            total *= int.Parse(splitSource[i].ToString());
        }

        if (total == target)
            multsToTarget = true;

        var result = new string[2];

        if (addsToTarget)
            result[0] = string.Join('+', splitSource);

        if (multsToTarget)
            result[1] = string.Join('*', splitSource);

        return result;
    }
}