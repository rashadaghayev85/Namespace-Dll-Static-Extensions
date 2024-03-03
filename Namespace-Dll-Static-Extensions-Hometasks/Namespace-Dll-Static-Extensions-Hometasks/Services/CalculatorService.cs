using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Namespace_Dll_Static_Extensions_Hometasks.Services
{
    internal class CalculatorService
    { 
       public double Calculation(double num1, double num2)
        {
            double result;
            label: Console.WriteLine("1.+\n2.-\n3.*\n4./\n");
            int num = int.Parse(Console.ReadLine());
            if (num == 1 || num == 2 || num == 3 || num == 4)
            {

                switch (num)
                {
                case 1: result=num1 + num2; break;
            case 2: result=num1 - num2; break;
            case 3: result = num1 * num2; break;
                case 4: result = num1 / num2; break;
                default: result = 0; break;

            }
        }
            else
            {
                Console.WriteLine("secimi duzgun edin");
                goto label;
            }
            return result;

        }
    }
}
