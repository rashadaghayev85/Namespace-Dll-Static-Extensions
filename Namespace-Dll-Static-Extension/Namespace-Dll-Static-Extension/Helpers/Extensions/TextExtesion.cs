 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespace_Dll_Static_Extension.Helpers.Extensions
{
    internal static class TextExtesion
    {
        public static int GetLength(this string str)
        {
            return str.Length;
        }
        public static bool CheckCharInText(this string str,char letter)
        {
            return str.Contains(letter);
        }
        public static int CountOfCharInText(this string text,char letter)
        {
            int count = 0;  
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i]==letter)
                {
                    count++;
                }
                
            }
            return count;
            // return text.Where(m => m == letter).Count();
        }
    }
}
