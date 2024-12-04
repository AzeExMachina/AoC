// See https://aka.ms/new-console-template for more information
var lines = File.ReadAllLines("../../../input.csv");
var firstColumn = new List<int>(lines.Length);
var secondColumn = new List<int>(lines.Length);

for (var i = 0; i < lines.Length; i++) 
{
    var split = lines[i].Split("   ");
    firstColumn.Add(int.Parse(split[0])); 
    secondColumn.Add(int.Parse(split[1]));
}

firstColumn.Sort();
secondColumn.Sort();

Console.WriteLine(Distance());
Console.WriteLine(Score());
return;

//First part
int Distance()
{
    var sum = 0;

    for (var i = 0; i < lines.Length; i++)
    {
        sum += Math.Abs(firstColumn[i] - secondColumn[i]);
    }

    return sum;
}

// Second part
int Score()
{
    var score = 0;
    for (var i = 0; i < lines.Length; i++)
    {
        firstColumn[i] *= Count(firstColumn[i]);
        score += firstColumn[i];
    }

    return score;
}

int Count(int num)
{
    return secondColumn.Count(o => o == num);
}