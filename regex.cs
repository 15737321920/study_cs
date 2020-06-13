using System;
using System.Text.RegularExpressions;

public class regex
{
    public static void Main()
    {
        Console.WriteLine("Please input the value you want to do regex:");
        string value = System.Console.ReadLine();        
        IsNumberAndWordOnly(value);
        GetNumber(value);
        IsContineNuberAndWord(value);
    }
    public static bool IsNumberAndWordOnly(string value)
    {
        Regex r = new Regex(@"^[a-zA-Z0-9]+$");
        return r.Match(value).Success;
    }
    
    public static void GetNumber(string value) 
    {
        string pattern = @"[0-9]";
        RegexOptions options = RegexOptions.Multiline;

        foreach (Match m in Regex.Matches(value, pattern, options))
        {
            Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
        }
    }
    public static bool IsContineNuberAndWord(string value)
    {
        Regex r = new Regex(@"[a-z]....[0-9]");
        return r.Match(value).Success;
    }
}