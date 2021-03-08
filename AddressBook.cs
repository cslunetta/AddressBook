using System;
using System.Collections.Generic;

namespace AddressBook
{
    public class AddressBook 
    { 
        // Create New addressBook Dictionary
        private Dictionary<string, Contact> addressBook = new Dictionary<string, Contact>();
        
        // Add contact to addressBook
        public void AddContact(Contact contact)
        {
            try
            {
                addressBook.Add(contact.Email, contact );
            }
            catch (ArgumentException)
            {
                Console.WriteLine("----------------------------");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error");
                Console.WriteLine("Cannot add contact ");
                Console.WriteLine($"{contact.FullName}");
                Console.WriteLine("to the address book multiple times");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        // match the email in the addressBook to the email address from the contact 
        public Contact GetByEmail(string email)
        {
                return addressBook[email];
        }
    }
}