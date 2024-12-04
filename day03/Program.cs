using System.Text.RegularExpressions;

var regex = MyRegex();
var file = File.ReadAllText("../../../input.txt");
var matches = regex.Matches(file).Cast<Match>();
var sum = matches.Select(match => match.ToString().Replace("mul(", string.Empty).Replace(")", string.Empty).Split(',').Select(int.Parse)).Select(factors => factors.First() * factors.Last()).Sum();
Console.WriteLine(sum);

partial class Program
{
    [GeneratedRegex(@"mul\(\d{1,3},\d{1,3}\)")]
    private static partial Regex MyRegex();
}