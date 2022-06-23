using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Program
    {
        //Main  Method 
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Address Book Progam \n");
            AddressBook createAddressBook = new AddressBook();
            createAddressBook.ReadInput();
            Console.ReadLine();

        }
    }
}