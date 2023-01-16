using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProgram
{
    internal class AddressBook
    {      
        Contact contact = new Contact();
        public void AddContact()
        {
            Console.WriteLine("Enter your First Name");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name");
            string LastName = Console.ReadLine();
            Console.WriteLine("Enter your Address");
            string Address = Console.ReadLine();
            Console.WriteLine("Enter your State");
            string State = Console.ReadLine();
            Console.WriteLine("Enter your ZipCode");
            string ZipCode = Console.ReadLine();
            Console.WriteLine("Enter your Email_Id");
            string EmailId = Console.ReadLine();
            Console.WriteLine("Enter your Phone_Number");
            string PhoneNo = Console.ReadLine();

        }
    }
}
