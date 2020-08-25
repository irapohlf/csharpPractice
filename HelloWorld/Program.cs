using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // _words is a string array that we'll sort alphabetically
            string[] _words = {
                "the",
                "quick",
                "brown",
                "fox",
                "jumps"
            };

            string[] morewords = {
                "over",
                "the",
                "lazy",
                "dog"
            };

            IEnumerable<string> query = from word in _words
                                        orderby word.Length
                                        select word;
        }
    }
}
