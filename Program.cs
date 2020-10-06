using System;

namespace PINCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the PIN Code : ");
            String pin = Console.ReadLine();
            RegexValidation rv = new RegexValidation();
            rv.Validation(pin);
        }
    }
}
