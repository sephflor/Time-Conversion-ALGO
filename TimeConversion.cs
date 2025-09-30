using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        string period = s.Substring(s.Length - 2);
        string time = s.Substring(0, s.Length - 2);
        
      string[] timeParts = time.Split(':');
        int hours = int.Parse(timeParts[0]);
        string minutes = timeParts[1];
        string seconds = timeParts[2];
        
       
        if (period == "AM")
        {
            if (hours == 12)
            {
                hours = 0; 
            }
        }
        else 
        {
            if (hours != 12)
            {
                hours += 12; 
            }
        }
        
        
        string militaryHours = hours.ToString("00");
        
        return $"{militaryHours}:{minutes}:{seconds}";
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
