using System;
namespace Homework_4
{
	public class Vowel
	{
		public string nVowel(string input, int n)
		{
            string vowels = "aeiouAEIOU";
            string result = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (vowels.Contains(input[i]))
                {
                    result += input[i];

                    if (result.Length == n)
                    {
                        return result;
                    }
                }
            }
            return "invalid";
        }
	}
}

