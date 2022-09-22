using System.Collections.Generic;

string[] instructions = File.ReadAllLines(@"C:\Users\Axion\OneDrive\Desktop\AdventOfCode\instructions.txt");

int horizontal = 0;
int depth = 0;

foreach (string line in instructions)
{
    if (line.Contains("forward"))
    {
        horizontal += int.Parse(GetNumbers(line));
    }
    if (line.Contains("down"))
    {
        depth += int.Parse(GetNumbers(line));
    }
    if (line.Contains("up"))
    {
        depth -= int.Parse(GetNumbers(line));
    }
}

int mult = horizontal * depth;

Console.WriteLine(mult);

static string GetNumbers(string input)
{
    return new string(input.Where(c => char.IsDigit(c)).ToArray());
}

