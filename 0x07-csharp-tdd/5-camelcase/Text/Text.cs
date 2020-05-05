using System;
using System.Collections.Generic;

namespace Text
{
    ///<summary>operations class</summary>
    public class Str
    {
        ///<summary>returns the max integer in a list of integers</summary>
        public static int CamelCase(string s)
        {
            int count = 1;
            if (s == "" || s == null)
			{
				return 0;
			}
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsUpper(s[i]))
                {
                    count += 1;
                }
            }
			return count;
        }
    }
}
