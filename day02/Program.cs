var input = File.ReadLines("../../../input.csv").Select(s => s.Split(' ').Select(int.Parse));

Console.WriteLine(input.Count(IsSafe));
Console.WriteLine(input.Count(IsActuallySafe));
return;

//First part
bool IsSafe(IEnumerable<int> a) => IsLineSafe(a.Zip(a.Skip(1), (x, y) => x - y));

//Second part
bool IsActuallySafe(IEnumerable<int> a) => Enumerable.Range(0, a.Count()).Any(i => IsSafe(a.Take(i).Concat(a.Skip(i + 1))));

bool IsLineSafe(IEnumerable<int> b) => b.All(x => x is >= -3 and <= -1) || b.All(x => x is >= 1 and <= 3);