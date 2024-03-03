using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Namespace_Dll_Static.Helpers
{
    internal static class MathExtension
    {
        
        public static int Factorial(this int num)
        {
            int factorial=1;

           for (int i = 0; i <= num; i++)
            {
                factorial = Factorial(num - i);
            }

          

               
           
           
           return factorial;

        }

    }
}
