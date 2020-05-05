using System;
using System.Collections.Generic;

namespace Text
{
    ///<summary>class Str</summary>
    public class Str
    {
        ///<summary>determines how many words are in a string with Upper Case letter</summary>
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
