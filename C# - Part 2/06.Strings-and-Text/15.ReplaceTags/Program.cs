﻿using System;
using System.Text.RegularExpressions;

namespace _15.ReplaceTags
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string parsedHTML = Regex.Replace(text, "(<a href=\")(.*?)(\">)(.*?)(</a>)", "[$4]($2)");
            Console.WriteLine(parsedHTML);
        }

       
    }
}
