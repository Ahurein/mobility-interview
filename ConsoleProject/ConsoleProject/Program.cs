using System.Net.WebSockets;
using System.Runtime.InteropServices;

namespace ConsoleProject
{
    internal class Program
    {                                           
        private const string _multiplyDllPath = @"D:\Interview\turgut\WebProject\ConsoleProject\x64\Debug\MultiplyInput.dll";

        [DllImport(_multiplyDllPath)]
        private static extern int MultiplyTwoNumbers(int a, int b);

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the two number to multiply");
            string valueOne, valueTwo;
            int a, b;

            do
            {
                Console.WriteLine("Enter first value, it should be a digit: ");
                valueOne = Console.ReadLine()!;
            } while (!int.TryParse(valueOne, out a));

            do
            {
                Console.WriteLine("Enter second value, it should be a digit: ");
                valueTwo = Console.ReadLine()!;
            } while (!int.TryParse(valueTwo, out b));

            Console.WriteLine(MultiplyTwoNumbers(a, b));
        }
    }
}
