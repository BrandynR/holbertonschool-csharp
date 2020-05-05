using System;

namespace Text
{
	///<summary> string operations</summary>
	public class Str
	{
		///<summary>method that returns the index of the first non-repeating character of a string</summary>
		public static int UniqueChar(string s)
		{
			if (s == "")
			{
				return (-1);
			}

			char x = s[0];
            var sizing =  s.Length;
            int index = 0;
			for (; index < sizing; index++)
			{
				if (s[index] != x)
				{
					return index;
				}
				x = s[index];
			}
			return (-1);
		}
	}
}
