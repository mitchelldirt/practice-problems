namespace cSharpProblems;

public class Flip2DArray
{
    public static void MainFlipArray()
    {
        var array = new int[3][] {new int[] {1, 2, 3}, new int[] {4, 5, 6}, new int[] {7, 8, 9}};
        var array2 = new int[3][] {new int[] {1, 2, 3}, new int[] {4, 5, 6}, new int[] {7, 8, 9}};
        
        var result = FlipArray(array, "vertical"); // [[7,8,9],[4,5,6],[1,2,3]]
        var result2 = FlipArray(array2, "horizontal"); // [[3,2,1],[6,5,4],[9,8,7]]
        
        Console.WriteLine($"Vertical: {RenderArray(result)} \nHorizontal: {RenderArray(result2)}");
    }

    private static IEnumerable<int[]> FlipArray(int[][] array, string direction)
    {
        if(direction == "vertical")
        {
            Array.Reverse(array);
            return array;
        }

        foreach (var subArray in array)
        {
            Array.Reverse(subArray);
        }

        return array;
    }
    
    private static string RenderArray(IEnumerable<int[]> array)
    {
        var result = "";
        result += "[";
        foreach (var subArray in array)
        {
            result += "[";
            foreach (var num in subArray)
            {
                result += $"{num},";
            }

            result = result[..^1] + "]";
        }
        result += "]";

        return result;
    }
}