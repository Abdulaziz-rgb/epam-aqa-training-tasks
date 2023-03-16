namespace ConsoleApp1.task_3;

public static class Solution
{
    // Function to return char for a given value
    private static char CharMapper(int num)
    {
        if (num >= 0 && num <= 9)
        {
            return (char)(num + 48);
        }
        else
        {
            return (char)(num - 10 + 65);
        }
    }

    // Function to convert a number to a given base 
    private static string ConvertFromDecimal(int base1, int inputNum)
    {
        string s = "";
        while (inputNum > 0)
        {
            s += CharMapper(inputNum % base1);
            inputNum /= base1;
        }
        char[] res = s.ToCharArray();
        Array.Reverse(res);
        
        return new String(res);
    }

    public static void Main()
    {
        int inputNum = 282, base1 = 16;
        var result = ConvertFromDecimal(base1, inputNum);
        Console.Write($"Equivalent of {inputNum} in base {base1} is {result}");
    }
}