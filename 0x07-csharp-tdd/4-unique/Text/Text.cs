using System;

namespace Text
{
	///<summary> string operations</summary>
	public class Str
	{
		///<summary>method that returns the index of the first non-repeating character of a string</summary>
		public static int UniqueChar(string s)
        {
            int ch = 256, idx = -1, i;
            char[] count = new char[ch];
            for (i = 0; i < s.Length; i++)
                count[s[i]]++;
            for (i = 0; i < s.Length; i++)
            {
                if (count[s[i]] == 1)
                {
                    idx = i;
                    break;
                }
            }
            return idx;
        }
    }
}
