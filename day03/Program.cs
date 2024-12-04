using System.Text.RegularExpressions;

var regex = MulRegex();
var file = File.ReadAllText("../../../input.txt");
//first
Console.WriteLine(SumMatches(regex.Matches(file)));
//second
Console.WriteLine(SumMatches(regex.Matches(CleanInput(file))));
return;

int SumMatches(IEnumerable<Match> matches)
{
    return matches.Select(match => match.ToString().Replace("mul(", string.Empty).Replace(")", string.Empty).Split(',').Select(int.Parse)).Select(factors => factors.First() * factors.Last()).Sum();
}

string CleanInput(string input)
{
    var cleaned = "";
    var split = input.Split("do()");
    for (var i = 0; i < split.Length; i++)
    {
        if (split[i].Contains("don't()"))
        {
            cleaned += split[i].Remove(split[i].IndexOf("don't()"));
        }
        else
        {
            cleaned += split[i];
        }
    }

    return cleaned;
}

partial class Program
{
    [GeneratedRegex(@"mul\(\d{1,3},\d{1,3}\)")]
    private static partial Regex MulRegex();
}