using AddressBookProgram;
using System.Xml.Linq;
using System;
using System.Threading.Channels;

namespace AddressBookProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To AddressBook program..... ");
            Contact contact = new Contact();
            AddressBook obj = new AddressBook();
            obj.AddContact();
        }
    }
}
