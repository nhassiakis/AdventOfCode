using Day_one;

string[] input = new DataLayer().ReadData();
int sum = 0;
List<int> results = new List<int>();
for (int i = 0; i < input.Length; i++)
{
    string current = input[i];

	if (int.TryParse(current, out int result))
	{
		sum += Int32.Parse(current);
	}
	else
	{
		results.Add(sum);
		sum = 0;
	}
}

//int resultMostCalories = results.Max(maxValue => maxValue);
//Console.WriteLine(resultMostCalories);
int[] resultMostCalories = results.OrderByDescending(mostCalories => mostCalories).Take(3).ToArray();
int topThreeElves = resultMostCalories.Sum();
Console.WriteLine(topThreeElves);