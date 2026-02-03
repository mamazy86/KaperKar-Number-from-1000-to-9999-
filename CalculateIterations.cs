using System;
using System.Collections.Generic;
using System.Text;

namespace KaperkarNumberTest;

public class CalculateIterations
{
    public string KaperkarNumber(int n)
    {
        if (n < 1000 || n > 9999)
        {
            return "Number must be in the range of 1000 to 9999";
        }

        string initialStr = n.ToString("D4");

        if (initialStr.Distinct().Count() == 1)
        {
            return "number wont be converted to 6174";
        }

        int iteration = 0;
        int currentNumber = n;

        while (currentNumber != 6174)
        {
            iteration++;

            string s = currentNumber.ToString("D4");

            char[] charsMax = s.ToCharArray();
            Array.Sort(charsMax);
            Array.Reverse(charsMax);
            int MaxNum = int.Parse(new string(charsMax));

            char[] charsMin = s.ToCharArray();
            Array.Sort(charsMin);
            int MinNum = int.Parse(new string(charsMin));

            currentNumber = MaxNum - MinNum;
            Console.WriteLine($"{currentNumber} = {MaxNum} - {MinNum}");
        }

        if (iteration <= 5)
        {
            return $"iteration :{iteration}";
        }
        else
        {
            return "number wont be converted to 6174";
        }
    }
}