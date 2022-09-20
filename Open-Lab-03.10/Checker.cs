using System;
using System.Diagnostics.Tracing;
using System.Net.Http;

namespace Open_Lab_03._10
{
    public class Checker
    {
        public int GetNumberOfCharsInString(char letter, string str)
        {
            return str.Split(letter).Length - 1;
        }
    }
}
