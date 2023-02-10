using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        Dictionary<string, List<Contact>> PersonDict = new Dictionary<string, List<Contact>>();
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
            Console.WriteLine("Enter your City");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter your ZipCode");
            contact.ZipCode = Console.ReadLine();
            Console.WriteLine("Enter your Email_Id");
            contact.EmailId = Console.ReadLine();
            Console.WriteLine("Enter your Phone_Number");
            contact.PhoneNo = Console.ReadLine();
            //uc7
            if (person.Count > 0)
            {
                foreach (var contact in person)
                {
                    if (contact.FirstName.Equals(contact.FirstName) && contact.LastName.Equals(contact.LastName))
                    {
                        Console.WriteLine("*************");
                        Console.WriteLine(contact.FirstName + " is already Present in the AddressBook");
                    }
                    else
                        person.Add(contact);
                }
            }
            else
                person.Add(contact);
                Console.ReadLine();
        }    
        public void Display()
        {
            foreach (Contact contact in person)
            {
                Console.WriteLine("Name of person : " + contact.FirstName + " " + contact.LastName);
                Console.WriteLine("Address of person is : " + contact.Address);
                Console.WriteLine("State :" + contact.State);
                Console.WriteLine("City :" + contact.City);
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
                        contact.City = Console.ReadLine();
                        break;
                    case 6:
                        contact.ZipCode = Console.ReadLine();
                        break;
                    case 7:
                        contact.PhoneNo = Console.ReadLine();
                        break;
                    case 8:
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
        public void MultipleAddressBook()
        {
            Console.WriteLine("Enter a name here");
            string name = Console.ReadLine();
            PersonDict.Add(name, person);
            person = new List<Contact>();
            Display();
        }
        public void SearchByCityState()
        {
            Console.WriteLine("Please enter the name of City or State:");
            string CheckCityOrState = Console.ReadLine();
            foreach (var data in person)
            {
                string ActualCity = data.City;
                string ActualState = data.State;
                if (person.Exists(data => (ActualCity == CheckCityOrState) || (ActualState == CheckCityOrState)))
                {
                    Console.WriteLine("Name of person : " + data.FirstName + " " + data.LastName);
                    Console.WriteLine("Address of person is : " + data.Address);
                    Console.WriteLine("City : " + data.City);
                    Console.WriteLine("State :" + data.State);
                    Console.WriteLine("Zip :" + data.ZipCode);
                    Console.WriteLine("Email of person : " + data.EmailId);
                    Console.WriteLine("Phone Number of person : " + data.PhoneNo);
                }
            }
        }
        public void ViewByCityState()
        {
            Console.WriteLine("Enter your Choice for Viewing a Person by:");
            Console.WriteLine("1. City 2. State");
            String choice = Console.ReadLine();
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter your City");
                    String city = Console.ReadLine();
                    foreach (Contact data in this.person.FindAll(data => data.City == city))
                        Console.WriteLine("The person name is : " + data.FirstName + " " + data.LastName);
                    break;
                case 2:
                    Console.WriteLine("Enter your State");
                    String state = Console.ReadLine();
                    foreach (Contact data in this.person.FindAll(data => data.State == state))
                        Console.WriteLine("The person name is : " + data.FirstName + " " + data.LastName);
                    break;
                default:
                    Console.WriteLine("Contact not found");
                    break;
            }
        }
        public void CountContacts()
        {
            int count = 0;
            Console.WriteLine("Enter your Choice for Count Person by:");
            Console.WriteLine("1. City 2. State");
            String choice = Console.ReadLine();
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter your City");
                    String city = Console.ReadLine();
                    foreach (Contact personal_Details in this.person.FindAll(data => data.City == city))
                    {
                        count = this.person.Count();
                    }
                    Console.WriteLine(count + " Contacts Availabel From This City");
                    break;
                case 2:
                    Console.WriteLine("Enter your State");
                    String state = Console.ReadLine();
                    foreach (Contact personal_Details in this.person.FindAll(data => data.State == state))
                    {
                        count = this.person.Count();
                    }
                    Console.WriteLine(count + " Contacts Availabel From This State");
                    break;
            }
        }
        // sorting the contacts list in alphabetical order of firstName
        public void SortingList()
        {
            List<Contact> Sorted = new List<Contact>();
            Sorted = person.OrderBy(s => s.FirstName).ToList();
            foreach (var data in Sorted)
            {
                if (person.Contains(data))
                {
                    Console.WriteLine("Name of person : " + data.FirstName + " " + data.LastName);
                    Console.WriteLine("Address of person is : " + data.Address);
                    Console.WriteLine("City : " + data.City);
                    Console.WriteLine("State :" + data.State);
                    Console.WriteLine("Zip :" + data.ZipCode);
                    Console.WriteLine("Email of person : " + data.EmailId);
                    Console.WriteLine("Phone Number of person : " + data.PhoneNo);
                }
            }
        }
        // sorting the contact list by zip
        public void SortByZip()
        {
            List<Contact> Sorted = new List<Contact>();
            Sorted = person.OrderBy(s => s.ZipCode).ToList();
            foreach (var data in Sorted)
            {
                if (person.Contains(data))
                {
                    Console.WriteLine("Name of person : " + data.FirstName + " " + data.LastName);
                    Console.WriteLine("Address of person is : " + data.Address);
                    Console.WriteLine("City : " + data.City);
                    Console.WriteLine("State :" + data.State);
                    Console.WriteLine("Zip :" + data.ZipCode);
                    Console.WriteLine("Email of person : " + data.EmailId);
                    Console.WriteLine("Phone Number of person : " + data.PhoneNo);
                }
            }
        }
     
        private string filePath = @"D:\Bridgelab\repos\AddressBookProgram\AddressBookProgram\Addresses.csv";
        public void WriteToFile()
        {
            using StreamWriter writer = new StreamWriter(filePath, true);
            foreach (Contact item in person)
            {
                writer.WriteLine(item.FirstName);
                writer.WriteLine(item.LastName);
                writer.WriteLine(item.Address);
                writer.WriteLine(item.City);
                writer.WriteLine(item.State);
                writer.WriteLine(item.ZipCode);
                writer.WriteLine(item.EmailId);
                writer.WriteLine(item.PhoneNo);
            }
            Console.WriteLine("\nSuccessfully added Text to The file.");
            writer.Close();
        }
        public void ReadFromFile()
        {
            Console.WriteLine("Below are Contents of Text File");
            string lines = File.ReadAllText(filePath);
            Console.WriteLine(lines);
        }
    }
}


