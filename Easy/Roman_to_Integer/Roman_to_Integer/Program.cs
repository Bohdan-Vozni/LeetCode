using System;
using System.Collections.Generic;

class Solution
{
    public int RomanToInt(string s)
    {
        // Словник для відповідності римських символів і їх значень
        var romanValues = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        int total = 0;
        int previousValue = 0;

        // Проходимо через символи рядка з кінця
        for (int i = s.Length - 1; i >= 0; i--)
        {
            int currentValue = romanValues[s[i]];

            // Віднімання або додавання на основі значень
            if (currentValue < previousValue)
            {
                total -= currentValue; // Віднімання
            }
            else
            {
                total += currentValue; // Додавання
            }

            previousValue = currentValue;
        }

        return total;
    }
}

class Program
{
    static void Main()
    {
        var converter = new Solution();

        // Приклади використання
        Console.WriteLine(converter.RomanToInt("III"));       // Вихід: 3
        Console.WriteLine(converter.RomanToInt("LVIII"));     // Вихід: 58
        Console.WriteLine(converter.RomanToInt("MCMXCIV"));   // Вихід: 1994
    }
}
