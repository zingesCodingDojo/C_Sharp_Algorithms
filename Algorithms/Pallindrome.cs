using System;
namespace Algorithms
{
	public static class IsPallindrome
	{
		// we need to see if we are getting a pallindrome or not
		public static bool CheckPal(string pallindrome)
		{
			int start = 0;
			int end = pallindrome.Length - 1;
			for (int i = 0; i < pallindrome.Length / 2; i++)
			{
				if (pallindrome[start] != pallindrome[end])
				{
					System.Console.WriteLine("Not Pallindrome");
					return false;
				}
				start++;
				end--;
			}
			System.Console.WriteLine("PAllindrome!");
			return true;
		}
	}
}
