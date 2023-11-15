namespace cSharpProblems;

public class MaxCasidooTasks_ccs
{
    public static void Main()
    {
        var sampleCasidooTasks = new List<CasidooTask>();
        sampleCasidooTasks.Add(new CasidooTask {Name = "A", Duration = 4});
        sampleCasidooTasks.Add(new CasidooTask {Name = "B", Duration = 2});
        sampleCasidooTasks.Add(new CasidooTask {Name = "C", Duration = 3});
        sampleCasidooTasks.Add(new CasidooTask {Name = "D", Duration = 1});
        sampleCasidooTasks.Add(new CasidooTask {Name = "E", Duration = 5});
        sampleCasidooTasks.Add(new CasidooTask {Name = "F", Duration = 2});
        
        var result = MaxCasidooTasks(sampleCasidooTasks, 7);
        foreach (var task in result)
        {
            Console.WriteLine(task);
        }
    }

    private static List<string> MaxCasidooTasks(List<CasidooTask> CasidooTasks, int timeToWork)
    {
        var timeWorked = 0;
        var CasidooTasksCompleted = new List<string>();
        CasidooTasks.Sort();
        
        for (var i = 0; i < CasidooTasks.Count; i++)
        {
            if (timeWorked + CasidooTasks[i].Duration > timeToWork) break;
            
            timeWorked += CasidooTasks[i].Duration;
            CasidooTasksCompleted.Add(CasidooTasks[i].Name);
        }

        return CasidooTasksCompleted;
    }
}

class CasidooTask : IComparable<CasidooTask>
{
    public string Name { get; set; }
    public int Duration { get; set; }
    
    public int CompareTo(CasidooTask compareCasidooTask)
    {
        return Duration.CompareTo(compareCasidooTask.Duration);
    }
}