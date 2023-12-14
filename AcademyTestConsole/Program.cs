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

            var arithmeticCaller = new ArithmeticMethods();
            arithmeticCaller.StartArithMeticCalculations();

            Console.ReadKey();
        }
    }
}