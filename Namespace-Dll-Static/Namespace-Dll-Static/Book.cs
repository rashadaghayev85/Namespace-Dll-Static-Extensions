using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespace_Dll_Static
{
    internal class Book
    {
        public static int count;
       
        public Book()
        {
            count++;
        }
        public void Show()
        {
            Console.WriteLine(count);
        }
    }
}
