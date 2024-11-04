using System;
using System.Text.RegularExpressions;



string pattern = @"\d";
Regex regex = new Regex(pattern);

string text = "Hi there, my number is 12345";

MatchCollection matchCollection = regex.Matches(text);

Console.WriteLine($"{matchCollection.Count} hits found:\n {text}");

foreach (Match hit in matchCollection)
{
    GroupCollection group = hit.Groups;
    Console.WriteLine($"{group[0].Value} hit found in position {group[0].Index}");
}
