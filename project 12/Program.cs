using System;
using System.Linq;

namespace project_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("type of your password");
            
            var isvalid = false;
            while (!isvalid)
            {
                isvalid = makepassword();
            }
            Console.WriteLine("Password valid and accepted");
         
        }
        public static bool makepassword()
        {
            var input = Console.ReadLine();
            if (input.Length >= 7 &&
                input.Length <= 12 &&
                input.Contains("!") &&
                input.Any(char.IsUpper) &&
                input.Any(char.IsLower) &&
                input.Any(char.IsLetterOrDigit))
            {
                return true;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Error");
                return false;
            }
        }
    }
}
