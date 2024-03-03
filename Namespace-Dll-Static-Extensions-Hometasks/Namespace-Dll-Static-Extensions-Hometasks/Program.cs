using Namespace_Dll_Static_Extensions_Hometasks.Controllers;
using Namespace_Dll_Static_Extensions_Hometasks.Helpers.Extensions;
using Namespace_Dll_Static_Extensions_Hometasks.Services;

//2) 2 eded extension method yazirsiz. Biri emailin icinde @ isaresinin olub olmamasini yoxlamalidir. Digeri passwordun uzunluqunun 8den boyuk olub olmadigini yoxlamalidir.


//string text = "azerbaycan@";
//Console.WriteLine(text.CharContains('@'));


//string password = "rashad12";
//Console.WriteLine(password.CheckPasswordLength());

//3)int arrayi ucun extention method yazirsiz. Hemin extention method arrayin elementlerinin hasilini tapsin.

//int[] arr = { 1, 2, 3, 4, 5 };
//Console.WriteLine(arr.ResultOfArrayNumbers());

//4)CalculatorService adinda class yaradirsiz, hemin classin icinde Calculation metodunuz olur. Method 2 parametr qebul edir. 4 emeliyyati (+,-,*,/)hesablayan calculator olacaq. Reqemler ve operatorlar console-dan daxil edilmelidir. Uygun controller de olsun.

CalculationController calculationController = new CalculationController();
calculationController.Calculation();














