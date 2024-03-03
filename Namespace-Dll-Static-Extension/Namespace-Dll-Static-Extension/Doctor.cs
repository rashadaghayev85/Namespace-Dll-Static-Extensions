using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Namespace_Dll_Static_Extension
{
    internal   class Doctor
    {
        public static int Id { get; set; }
        public static string Name { get; set; }
        

        static Doctor()//parametrless olur
        {
            Console.WriteLine("static constructor");
        }
        public Doctor()
        {
            Console.WriteLine("non-static constructor");
        }
    }
}
