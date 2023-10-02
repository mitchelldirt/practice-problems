using System.Text.Json;

namespace cSharpProblems;

public class Pokemon
{
    public static async Task Main()
    {
        Console.WriteLine(await TypeMatchup("normal"));
        Console.WriteLine(await TypeMatchup("fighting"));
        Console.WriteLine(await TypeMatchup("Water"));
        Console.WriteLine(await TypeMatchup("Electric"));
    }

    private static async Task<string> TypeMatchup(string type)
    {
        type = type.ToLower();
        var http = new HttpClient();
        var response = await http.GetAsync("https://pokeapi.co/api/v2/type/");

        if (!response.IsSuccessStatusCode)
        {
            return "Failed to grab types";
        }

        var json = await response.Content.ReadAsStringAsync();
        var types = JsonSerializer.Deserialize<TypesJSON>(json);
        var matchups = new MatchUps();

        foreach (var result in types.results)
        {
            if (result.name == type)
            {
                var matchupResponse = await http.GetAsync(result.url);
                if (!matchupResponse.IsSuccessStatusCode) return "Failed to grab the match ups";
                var matchupsJson = await matchupResponse.Content.ReadAsStringAsync();
                var typeRelations = JsonSerializer.Deserialize<DamageRelations>(matchupsJson);
                matchups = typeRelations.damage_relations;
            }
        }

        Console.WriteLine(matchups);

        var weakTypesList = "";
        foreach (var pokeType in matchups.double_damage_from)
        {
            weakTypesList += pokeType.name + ", ";
        }

        var strongTypesList = "";
        foreach (var pokeType in matchups.double_damage_to)
        {
            strongTypesList += pokeType.name + ", ";
        }

        string message = $"TYPE {type}:\nWeak against: {weakTypesList}\nStrong against: {strongTypesList}\n";


        return types == null ? "Failed to deserialize types" : message;
    }
}

public class TypesJSON
{
    public int count { get; set; }
    public TypeData[] results { get; set; }
}

public class TypeData
{
    public string name { get; set; }
    public string url { get; set; }
}

public class DamageRelations
{
    public MatchUps damage_relations { get; set; }
}

public class MatchUps
{
    public TypeData[] double_damage_from { get; set; }
    public TypeData[] double_damage_to { get; set; }
    public TypeData[] half_damage_from { get; set; }
    public TypeData[] half_damage_to { get; set; }
    public TypeData[] no_damage_from { get; set; }
    public TypeData[] no_damage_to { get; set; }
}