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
            AddressBook obj = new AddressBook();
            while (true)
            {
                Console.WriteLine("1.AddContact\n2.DisplayContact\n3.EditContact\n4.Delete" +
                    "\n5.MultipleContact\n6.MultipleAddressBook\n7.SearchByCityState\n8.ViewByCityState" +
                    "\n9.CountContacts\n10.SortingList\n11.SortByZip\n12.WriteFile&ReadFile");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        obj.AddContact();
                        break;
                    case 2:
                        obj.Display();
                        break;
                    case 3:
                        obj.Edit();
                        break;
                    case 4:
                        obj.Delete();
                        break;
                    case 5:
                        obj.MultipleContact();
                        break;
                    case 6:
                        obj.MultipleAddressBook();
                        break;
                    case 7:
                        obj.SearchByCityState();
                        break;
                    case 8:
                        obj.ViewByCityState();
                        break;
                    case 9:
                        obj.CountContacts();
                        break;
                    case 10:
                        obj.SortingList();
                        break;
                    case 11:
                        obj.SortByZip();
                        break;
                    case 12:
                        obj.AddContact();
                        obj.WriteToFile();
                        obj.ReadFromFile();
                        break;

                }
            }
        }
    }
}
