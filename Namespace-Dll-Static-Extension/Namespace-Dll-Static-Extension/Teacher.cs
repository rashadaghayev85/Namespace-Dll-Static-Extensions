using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespace_Dll_Static_Extension
{
    internal class Teacher
    {
        public static int Count { get; set; }
        public int Age { get; set; }
        public Teacher()
        {
            Count++;
        }
    }
}
