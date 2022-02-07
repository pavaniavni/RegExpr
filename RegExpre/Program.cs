using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace HandlingRegEx
{
    public class RegEx
    {
        static void Main(string[] args)
        {
            Regex r = new Regex("^[0-9]{4}$");
            Match m = r.Match("9798skhdah");
            if (m.Success)
            {
                Console.WriteLine("Mached the value " + m.Value);
            }
            else
            {
                Console.WriteLine("Please Enter Correct String Input");
            }
        }
    }
}
