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
            Console.WriteLine("Enter the Last Name: ");
            string lastname = Console.ReadLine();
            bool name1 = pat.Validate_LastName(lastname);
            Console.WriteLine(name1);

        }
    }
}
