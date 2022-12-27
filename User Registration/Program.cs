using System;

namespace User_Registration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pattern pat = new Pattern();
            Console.WriteLine("Enter the First Name: ");
            string firstname = Console.ReadLine();
            bool name = pat.Validate_FirstName(firstname);
            Console.WriteLine(name);
            
        }
    }
}
