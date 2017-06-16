﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var result = "";
            foreach (var letter in input)
            {
                result+="\\u" + ((int)letter).ToString("X4");
            }
            Console.WriteLine(result.ToLower());
        }
    }
}
