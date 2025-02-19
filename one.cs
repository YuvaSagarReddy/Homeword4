using System;

namespace Homework_4
{
    public class CountWord
    {
        private int wordCount;

        public CountWord(string str)
        {
            string[] str1 = str.Split(' ');
            wordCount = str1.Length;
        }


        public int GetWordCount()
        {
            return wordCount;
        }
    }
      
}
