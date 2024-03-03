using Namespace_Dll_Static_Extensions_Hometasks.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespace_Dll_Static_Extensions_Hometasks.Controllers
{
    internal class CalculationController
    {
        CalculatorService _calculatorService;
        public CalculationController()
        {
            _calculatorService = new CalculatorService();
        }

        

        public void Calculation()
        {
            Console.WriteLine("Enter number 1");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            double num2 = double.Parse(Console.ReadLine());


            if (num2 == 0)
            {
                Console.WriteLine("0a bolmek olmaz");
                return;
            }

            Console.WriteLine("Cavab:"+_calculatorService.Calculation(num1, num2));

        }
    }
}
