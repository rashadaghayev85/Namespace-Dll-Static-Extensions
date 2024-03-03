using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespace_Dll_Static_Extensions_Hometasks.Helpers.Extensions
{
    internal static class TextExtensions
    {
        public static bool CharContains(this string text,char letter)
        {
          //  return text.Contains(letter);   
          for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == letter)
                {
                    return true;
                }
                   
            }
            return false;
        }

        public static bool CheckPasswordLength(this string password)
        {
            if (password.Length < 8)
            {
                return false;
            }
            return true;
        }
        public static int ResultOfArrayNumbers(this int[] arr)
        {
            int result = 1;
            for(int i = 0; i < arr.Length; i++)
            {
                result*= arr[i];
            }
            return result;
        }
    }
}





