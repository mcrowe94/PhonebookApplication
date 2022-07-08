using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonebookApplication
{
    public class UserInterface
    {
        public static void MainMenu(List<Contact> contacts)
        {
            ConsoleLogging.Greeting();

            Console.WriteLine();

            ConsoleLogging.PassMessage("What would you like to do?\n 1: View all contacts:\n 2: Create a contact:\n 3: Update a contact:\n 4: Delete a contact:\n 5: Save and Exit!");

            var userAnswer = Console.ReadLine();

            if (userAnswer == "1") //View All
            {
                ConsoleLogging.CRUDForEachLoop(contacts);
                ConsoleLogging.PassMessage("Please press ENTER to continue....");
                Console.ReadLine();
                ConsoleLogging.ClearConsole();

            }
            else if (userAnswer == "2") //Create
            {
                ConsoleLogging.ClearConsole();
                var newContact = ContactCreator();
                contacts.Add(newContact);
            }
            else if (userAnswer == "3") //Update
            {
                ConsoleLogging.ClearConsole();
                UpdateContact(contacts);
            }
            else if (userAnswer == "4") //Delete
            {
                ConsoleLogging.ClearConsole();
                DeleteContact(contacts);
            }
            else if (userAnswer == "5") //Save&Exit
            {
                FileManipulation.SaveContacts(contacts);
                ConsoleLogging.ExitMessage();
            }
            else //Not a Choice
            {
                ConsoleLogging.InvalidResponse();
            }
        }

        public static Contact ContactCreator()
        {
            ConsoleLogging.PassMessage("Create a new contact:");
            var contact = new Contact();
            ConsoleLogging.PassMessage("What is the first name of your new contact?");
            contact.FirstName = Console.ReadLine();
            ConsoleLogging.PassMessage("What is the last name of your new contact?");
            contact.LastName = Console.ReadLine();
            ConsoleLogging.PassMessage("What is the new contacts phone number?");
            contact.PhoneNumber = Console.ReadLine();
            ConsoleLogging.PassMessage("What is the new contacts email address?");
            contact.EmailAddress = Console.ReadLine();

            return contact;
        }

        public static void UpdateContact(List<Contact> contacts)
        {
            ConsoleLogging.CRUDForLoop(contacts);
            ConsoleLogging.PassMessage("What is the ID of the contact you would like to update?");
            var contactID = Convert.ToInt32(Console.ReadLine());
            contacts[contactID - 1] = ContactCreator();
            ConsoleLogging.PassMessage("Success!");
        }

        public static void DeleteContact(List<Contact> contacts)
        {
            ConsoleLogging.CRUDForLoop(contacts);
            ConsoleLogging.PassMessage($"What is the ID of the contact you would like to delete?");
            var contactID = Convert.ToInt32(Console.ReadLine());
            contacts.RemoveAt(contactID - 1);
            ConsoleLogging.PassMessage("Success!");
        }
    }
}
