using System;

namespace C_Sharp_Mark
{
	public static class ReverseString
	{
		public static string Reverse(string word)
		{
			string newString = "";
			int reverseWalk = word.Length - 1;
			for (int i = 0; i < word.Length; i++)
			{
				newString += word[reverseWalk];
				Console.WriteLine(newString);
				reverseWalk--;
			}
			return newString;
		}
	}
}
