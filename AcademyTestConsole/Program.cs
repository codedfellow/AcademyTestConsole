namespace AcademyTestConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====================================");
            Console.WriteLine("Welcome To academy 2023");
            Console.WriteLine("====================================");
            Console.WriteLine("------------- Mini Calculator ------------\n\n");
            Console.WriteLine("Enter first value");
            decimal.TryParse(Console.ReadLine(),out decimal firstValue);
            Console.WriteLine("Enter second value");
            decimal.TryParse(Console.ReadLine(), out decimal secondValue);
            decimal sum = firstValue + secondValue;
            Console.WriteLine($"\nThe sum is {decimal.Round(sum, 2)}");
            Console.ReadKey();
        }
    }
}