using System;
using System.Text.RegularExpressions;

namespace Text
{
	///<summary>Class for string operations</summary>
	public class Str
	{
		///<summary>check if string s is palindrome and returns true or false</summary>
		public static bool IsPalindrome(string s)
		{
			s = Regex.Replace(s, "[^A-Za-z]", "");

			char[] array = s.ToCharArray();
			Array.Reverse(array);

			return s.ToLower() == new string(array).ToLower();
		}
	}
}
