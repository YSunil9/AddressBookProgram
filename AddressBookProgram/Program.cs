﻿using AddressBookProgram;
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
                Console.WriteLine("1.AddContact\n2.DisplayContact\n3.EditContact");
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
                    default:
                        break;
                }
            }
        }
    }
}
