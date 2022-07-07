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
                Console.WriteLine("3");
                ConsoleLogging.ClearConsole();
            }
            else if (userAnswer == "4") //Delete
            {
                Console.WriteLine("4");
                ConsoleLogging.ClearConsole();
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
            Console.WriteLine("Create a new contact:");
            var contact = new Contact();
            Console.WriteLine("What is the first name of your new contact?");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("What is the last name of your new contact?");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("What is the new contacts phone number?");
            contact.PhoneNumber = Console.ReadLine();
            Console.WriteLine("What is the new contacts email address?");
            contact.EmailAddress = Console.ReadLine();

            return contact;
        }
    }
}
