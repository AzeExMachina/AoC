using System.Text.RegularExpressions;

var regex = MyRegex();

partial class Program
{
    [GeneratedRegex(@"mul\(\d{1,3},\d{1,3}\)")]
    private static partial Regex MyRegex();
}

