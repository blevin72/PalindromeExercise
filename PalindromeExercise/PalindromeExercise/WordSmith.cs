using System;
using System.Linq;
namespace PalindromeExercise
{
	public class WordSmith
	{
		public bool IsPalindrome(string word)
		{
			string reversedWord = string.Empty;

			for(int i = word.Length-1; i >= 0; i--)
			{
				reversedWord += word[i];
			}
			if(word == reversedWord)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}

