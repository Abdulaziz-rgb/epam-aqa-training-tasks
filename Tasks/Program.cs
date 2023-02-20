using ConsoleApp1.task_1;

Console.Write("Enter a word to check: ");
var input = Console.ReadLine();
        
if (input.Length == 0 || input.Length == 1 ) Console.Write("Value cannot be one string or  null. Please re-run the program with correct credential!");

var sol = new Solution();
Console.WriteLine(sol.FindConsecutiveIdenticalLetters(input));