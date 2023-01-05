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
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Enter the Last Name: ");
            string lastname = Console.ReadLine();
            bool name1 = pat.Validate_LastName(lastname);
            Console.WriteLine(name1);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Enter the Email Id: ");
            string email = Console.ReadLine();
            bool id = pat.Validate_Email(email);
            Console.WriteLine(id);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Enter the Phone Number: ");
            string phonenumber = Console.ReadLine();
            bool num = pat.Validate_PhoneNumber(phonenumber);
            Console.WriteLine(num);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Enter Password: ");
            string password1 = Console.ReadLine();
            bool pass1 = pat.Validate_Password1(password1);
            Console.WriteLine(pass1);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Enter Password: ");
            string password2 = Console.ReadLine();
            bool pass2 = pat.Validate_Password2(password2);
            Console.WriteLine(pass2);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Enter Password: ");
            string password3 = Console.ReadLine();
            bool pass3 = pat.Validate_Password3(password3);
            Console.WriteLine(pass3);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Enter Password: ");
            string password4 = Console.ReadLine();
            bool pass4 = pat.Validate_Password4(password4);
            Console.WriteLine(pass4);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Enter Email: ");
            string email1 = Console.ReadLine();
            bool id1 = pat.Validate_Email1(email1);
            Console.WriteLine(id1);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Enter Email: ");
            string email2 = Console.ReadLine();
            bool id2 = pat.Validate_Email2(email2);
            Console.WriteLine(id2);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Enter Email: ");
            string email3 = Console.ReadLine();
            bool id3 = pat.Validate_Email3(email3);
            Console.WriteLine(id3);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Enter Email: ");
            string email4 = Console.ReadLine();
            bool id4 = pat.Validate_Email4(email4);
            Console.WriteLine(id4);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Enter Email: ");
            string email5 = Console.ReadLine();
            bool id5 = pat.Validate_Email5(email5);
            Console.WriteLine(id5);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Enter Email: ");
            string email6 = Console.ReadLine();
            bool id6 = pat.Validate_Email6(email6);
            Console.WriteLine(id6);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Enter Email: ");
            string email7 = Console.ReadLine();
            bool id7 = pat.Validate_Email7(email7);
            Console.WriteLine(id7);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Enter Email: ");
            string email8 = Console.ReadLine();
            bool id8 = pat.Validate_Email8(email8);
            Console.WriteLine(id8);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Enter Email: ");
            string email9 = Console.ReadLine();
            bool id9 = pat.Validate_Email9(email9);
            Console.WriteLine(id9);
            Console.WriteLine("----------------------------------------");
            UserEntryValidation userEntry = new UserEntryValidation();
            userEntry.ValidationFirstName("Sam");
            userEntry.ValidationLastName("Roy");
            userEntry.ValidationEmail("abc.xyz@bl.co.in");
            userEntry.ValidationPhoneNumber("91 9919819801");
            userEntry.ValidationPassword("jyotirao");

        }
    }
}
