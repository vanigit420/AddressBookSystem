using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Program
    {
        //Main  Method / program Entry Point
        static void Main(string[] args)
        {
            //Showing Welcome Message On console.
            Console.WriteLine("Welcome to Address Book Progam \n");
            AddressBook createAddressBook = new AddressBook();
            createAddressBook.ReadInput();
            Console.ReadLine();
        }
    }
}