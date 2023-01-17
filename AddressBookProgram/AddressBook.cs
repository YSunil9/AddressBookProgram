using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProgram
{
    public class AddressBook
    {
        Contact contact = new Contact();
        List<Contact> person = new List<Contact>();
        public void AddContact()
        {            
            Console.WriteLine("Enter your First Name");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("Enter your Address");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter your State");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter your ZipCode");
            contact.ZipCode = Console.ReadLine();
            Console.WriteLine("Enter your Email_Id");
            contact.EmailId = Console.ReadLine();
            Console.WriteLine("Enter your Phone_Number");
            contact.PhoneNo = Console.ReadLine();
            person.Add(contact);
        }
        public void Display()
        {
            foreach (Contact contact in person)
            {
                Console.WriteLine("Name of person : " + contact.FirstName + " " + contact.LastName);
                Console.WriteLine("Address of person is : " + contact.Address);
                Console.WriteLine("State :" + contact.State);
                Console.WriteLine("Zip :" + contact.ZipCode);
                Console.WriteLine("Email of person : " + contact.EmailId);
                Console.WriteLine("Phone Number of person : " + contact.PhoneNo);
            }
        }
        public void Edit()
        {
            Console.WriteLine("For editing a contact enter first name : ");
            string name = Console.ReadLine();
            if (contact.FirstName == name)
            {
                Console.WriteLine("Choose Field to edit");
                Console.WriteLine("1 - First Name");
                Console.WriteLine("2 - Last Name");
                Console.WriteLine("3 - Address");               
                Console.WriteLine("5 - State");
                Console.WriteLine("4 - Zip");
                Console.WriteLine("7 - E-mail");
                Console.WriteLine("6 - Phone Number");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        contact.FirstName = Console.ReadLine();
                        break;
                    case 2:
                        contact.LastName = Console.ReadLine();
                        break;
                    case 3:
                        contact.Address = Console.ReadLine();
                        break;                   
                    case 4:
                        contact.State = Console.ReadLine();
                        break;
                    case 5:
                        contact.ZipCode = Console.ReadLine();
                        break;
                    case 6:
                        contact.PhoneNo =Console.ReadLine();
                        break;
                    case 7:
                        contact.EmailId = Console.ReadLine();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Contact doesn't exist");
            }
        }
        public void Delete()
        {
            Console.WriteLine("Enter First Name to Delete Contact");
            string fname = Console.ReadLine();
            foreach (Contact input in person.ToList())
            {
                if (input.FirstName == fname)
                {
                    person.Remove(input);
                }
                Console.WriteLine("Contacts are successfully Deleted");
                Console.ReadLine();
            }
        }
        public void MultipleContact()
        {
            Console.WriteLine("Enter Number of Contacts to Create");
            int Number = Convert.ToInt32(Console.ReadLine());
            while (Number > 0)
            {
                AddContact();
                Number--;
            }
        }
    }
}


