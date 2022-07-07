using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonebookApplication
{
    public class ConsoleLogging
    {
        public static void Greeting()
        {
           Console.WriteLine("Welcome to your Phonebook Application!");
        }

        public static void PassMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static void MainConsole(List<Contact> contacts)
        {
            while(true)
            {
                UserInterface.MainMenu(contacts);
            }

        }

        public static void ExitMessage()
        {
            ConsoleLogging.PassMessage("Your contacts have been saved -- Have a nice day!");
            Environment.Exit(0);
        }

        public static void ClearConsole()
        {
            Console.Clear();
        }

        public static void InvalidResponse()
        {
            ConsoleLogging.PassMessage("Please enter a valid response!");
        }

        public static void CRUDForEachLoop(List<Contact> contacts)
        {
            ConsoleLogging.ClearConsole();
            foreach(var contact in contacts)
            {
                Console.WriteLine($"Name: {contact.FirstName} {contact.LastName}\n Email Address: {contact.EmailAddress}\n Phone Number: {contact.PhoneNumber}");
                Console.WriteLine("------------------------------");
            }
        } 
    }
}
