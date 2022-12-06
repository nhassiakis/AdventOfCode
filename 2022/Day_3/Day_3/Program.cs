string[] input = System.IO.File.ReadAllLines(@"../../../../Input_Day3.txt");


//PART 1
int sum = 0;
foreach (var line in input)
{
    var first = line.Take(line.Length / 2);
    var second = line.Skip(line.Length / 2);
    // Scores are counter as a-z = 1-26 and A-Z = 27-52
    //  Score of ASCII char of non upper case = ascii(char) - 96 while score of uppercase = ASCII(char) - 38 
    sum += first.Intersect(second).Select(c => char.IsUpper(c) ? c - 38 : c - 96).Sum();
}
Console.WriteLine(sum);



//Part 2
int sumPart2 = 0;
foreach (var line in input.Chunk(3))
{
    var first = line[0];
    var second = line[1];
    var third = line[2];

    sumPart2 += first.Intersect(second).Intersect(third).Select(c => char.IsUpper(c) ? c - 38 : c - 96).Sum();
}

Console.WriteLine(sumPart2);