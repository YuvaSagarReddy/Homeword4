using System;

namespace Homework_4
{
    public class Shift
    {
        public string Change(string input1)
        {
            string result = "";

            for (int i = 0; i < input1.Length; i++)
            {
                result += (char)((int)input1[i] + 1);
            }

            return result;
        }
    }
}