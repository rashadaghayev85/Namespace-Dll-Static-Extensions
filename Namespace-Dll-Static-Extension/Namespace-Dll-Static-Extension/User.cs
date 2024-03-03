using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespace_Dll_Static_Extension
{
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Password { get; set; }
        public User()
        {
            
        }
        public User(string name,string surname,int age,string password)

        {
            Name = name;  
            Surname = surname;  
            Age = age; 
            Password =password ;
        }
        public string Get()
        {
            return Password;
        }
        public void Set(string pass)
        {
           Password=pass;
        }
    }
}
