using System;
using System.Collections.Generic;

namespace AddressBook
{
    public class AddressBook
    {

        public Dictionary<string, Contact> addressBook = new Dictionary<string, Contact>();

        public void AddContact(Contact contact)
        {
            addressBook.Add(contact.Email, contact);
        }

        public Contact GetByEmail(String selectedEmail)
        {
            Contact foundContact = null;
            foreach (KeyValuePair<string, Contact> contact in addressBook)
            {
                if (contact.Key == selectedEmail)
                {
                    foundContact = contact.Value;
                };
            }
            return foundContact;
        }
    }
}