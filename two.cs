using System;
namespace Homework_4
{
    public class Flip
    {
        public string FlipChar(string str)
        {
            if (str.Length < 2)
            {
                return "Incompatible.";
            }
            if (str[0] == str[str.Length - 1])
            {
                return "Two's a pair.";
            }

            string Str1 = "";

            Str1 += str[str.Length - 1];

            for (int i = 1; i < str.Length - 1; i++)
            {
                Str1 += str[i]; // Add middle characters
            }
            Str1 += str[0]; // Add first character

            return Str1;
        }
    }
}