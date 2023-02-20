namespace ConsoleApp1.task_1;

public  class Solution
{
    public  int FindConsecutiveIdenticalLetters(string words)
    {
        var LatinLetters = "abcdefghiklmnopqrstvxyz";
        words.ToLower();
        var result = BaseHandler(words, LatinLetters);
        return result;
    }

    public  int FindConsecutiveIdenticalDigits(string words)
    {
        var digits = "0123456789";
        var result = BaseHandler(words,digits);
        return result;
    }

    private  int BaseHandler(string words, string testSet)
    {
        int count = 1;
        int maxCount = 1;

        for (int i = 1; i < words.Length; i++)
        {
            if (testSet.Contains(words[i]) && words[i] == words[i-1])
            {
                count++;
                if (count > maxCount) maxCount = count;
            }
            else
            {
                count = 1;
            }
        }
        return maxCount;
    }
}

