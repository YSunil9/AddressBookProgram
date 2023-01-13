using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProgram
{
    internal class AddressBook
    {
        List<Contact> person = new List<Contact>();
        public void AddContact()
        {
            Contact contact = new Contact();
            Console.WriteLine("Welcome to Address Book Program\n");
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
            person.Add(contact);
        }
    }
}
