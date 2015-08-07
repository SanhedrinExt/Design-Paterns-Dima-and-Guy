using System;
using System.Collections.Generic;
using System.Text;

namespace C15_Ex01_FacebookApp
{
    public static class StringModifier
    {
        public static string SpaceCamelCased(string i_Str)
        {
            StringBuilder spacedStr = new StringBuilder(i_Str[0].ToString());
            int currWordLength = 0;
            int currWordStartingIndex = 1;

            for (int i = 1; i < i_Str.Length; i++)
            {
                if (char.IsUpper(i_Str[i]))
                {
                    spacedStr.Append(i_Str.Substring(currWordStartingIndex, currWordLength));
                    spacedStr.Append(" ");
                    currWordLength = 1;

                    // pointing to next word
                    currWordStartingIndex = i;
                }
                else if (i == (i_Str.Length - 1))
                {
                    spacedStr.Append(i_Str.Substring(currWordStartingIndex, currWordLength + 1));
                }
                else
                {
                    currWordLength++;
                }
            }

            return spacedStr.ToString();
        }

        public static void SpaceCamelCased(string[] io_strArr)
        {
            for (int i = 0; i < io_strArr.Length; i++)
            {
                io_strArr[i] = SpaceCamelCased(io_strArr[i]);
            }
        }
    }

   
}
