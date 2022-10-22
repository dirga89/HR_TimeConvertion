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
        int hour=0;
        string result = "";

        if(String.Compare(s.Substring(8,2),"PM") == 0)
        {
            hour = int.Parse(s.Substring(0,2));
            hour += 12;

            if(hour == 24)
            {
                hour -= 12;
                result = hour.ToString() + s.Substring(2,6);
            }
            else if(hour > 24)
            {
                hour -= 24;
                result = "0" + hour.ToString() + s.Substring(2,6);
            }
            else
            {
                result = hour.ToString() + s.Substring(2,6);
            }
        }
        else if(String.Compare(s.Substring(8,2),"AM") == 0)
        {
            hour = int.Parse(s.Substring(0,2));

            if(hour == 12)
            {
                hour -= 12;
                result = "0" + hour.ToString() + s.Substring(2,6);
            }
            else
            {
                result = s.Substring(0,8);
            }
        }

        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = "12:10:00PM";//Console.ReadLine();

        string result = Result.timeConversion(s);

        Console.WriteLine(result);

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
