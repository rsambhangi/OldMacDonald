using System;
using System.Linq;
using System.Collections.Generic;
public class Brace
{
    public static bool validBraces(string braces)
    {
        // Immediately fail.
        if (braces == null || braces.Length < 2 || braces.Length % 2 != 0) return false;

        var options = new List<char> { '(', ')', '{', '}', '[', ']' };
        string opened = string.Empty;

        var position = 1;
        while (position < braces.Length)
        {
            var current = braces[position - 1];
            Console.WriteLine($"Current character: {current}");
            Console.WriteLine($"Opened: {opened}");
            if (options.IndexOf(current) % 2 != 0)
            {
                // Check that anything is open, if so, check that the closer matches last opener.
                if (string.IsNullOrWhiteSpace(opened) || options.IndexOf(current) - 1 != options.IndexOf(opened.Last()))
                {
                    return false;
                }
                opened = opened.Remove(opened.Length - 1, 1);
            }
            else
            {
                // Add opener to buffer
                opened += current;
            }
            position++;
        }
        return true;
    }
}