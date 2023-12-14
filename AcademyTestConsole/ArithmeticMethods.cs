using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyTestConsole
{
    internal class ArithmeticMethods
    {
        public void StartArithMeticCalculations()
        {
            Console.WriteLine("Enter an option to perform an arithmetic operation");
            Console.WriteLine("Kindly input one of the following options to continue: +,-,/,*,%");
            Console.WriteLine("Input s or stop to breakOut");
            var defaultOption = Console.ReadLine();
            
            while (!string.IsNullOrEmpty(defaultOption) && defaultOption.Trim().ToLower() != "s" && defaultOption.Trim().ToLower() != "stop")
            {
                switch (defaultOption)
                {
                    case "+":
                        PerformAddition();
                        break;
                    case "-":
                        PerformSubtraction();
                        break;
                    case "/":
                        PerformDivision();
                        break;
                    case "*":
                        PerformMultiplication();
                        break;
                    case "%":
                        PerformModulus();
                        break;
                }

                Console.WriteLine("Kindly input one of the following options to continue: +,-,/,*,%");
                Console.WriteLine("Input s or stop to breakOut");
                defaultOption = Console.ReadLine();
            }
            Console.WriteLine("Operations concluded");
        }

        public void PerformSubtraction()
        {
            Console.WriteLine("Enter first value");
            decimal.TryParse(Console.ReadLine(), out decimal firstValue);
            Console.WriteLine("Enter second value");
            decimal.TryParse(Console.ReadLine(), out decimal secondValue);
            decimal difference = firstValue - secondValue;
            Console.WriteLine($"\nThe difference is {decimal.Round(difference, 2)}");
        }

        public void PerformAddition()
        {
            Console.WriteLine("Enter first value");
            decimal.TryParse(Console.ReadLine(), out decimal firstValue);
            Console.WriteLine("Enter second value");
            decimal.TryParse(Console.ReadLine(), out decimal secondValue);
            decimal sum = firstValue + secondValue;
            Console.WriteLine($"\nThe sum is {decimal.Round(sum, 2)}");
        }

        public void PerformDivision()
        {
            Console.WriteLine("Enter first value");
            decimal.TryParse(Console.ReadLine(), out decimal firstValue);
            Console.WriteLine("Enter second value");
            decimal.TryParse(Console.ReadLine(), out decimal secondValue);
            decimal divResult = firstValue / secondValue;
            Console.WriteLine($"\nThe difference is {decimal.Round(divResult, 2)}");
        }

        public void PerformMultiplication()
        {
            Console.WriteLine("Enter first value");
            decimal.TryParse(Console.ReadLine(), out decimal firstValue);
            Console.WriteLine("Enter second value");
            decimal.TryParse(Console.ReadLine(), out decimal secondValue);
            decimal multipliedValue = firstValue * secondValue;
            Console.WriteLine($"\nThe multiplied value is {decimal.Round(multipliedValue, 2)}");
        }

        public void PerformModulus()
        {
            Console.WriteLine("Enter first value");
            int.TryParse(Console.ReadLine(), out int firstValue);
            Console.WriteLine("Enter second value");
            int.TryParse(Console.ReadLine(), out int secondValue);
            int modulus = firstValue % secondValue;
            Console.WriteLine($"\nThe modulus is {modulus}");
        }
    }
}
