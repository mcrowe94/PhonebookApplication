using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonebookApplication
{
    public class UserInterface
    {
        public static void MainMenu()
        {
            ConsoleLogging.Greeting();

            Console.WriteLine();

            ConsoleLogging.PassMessage("What would you like to do?\n 1: View all contacts.\n 2: Create a contact.\n 3: Update a contact.\n 4: Delete a contact.\n 5: Save and Exit.");

            var userAnswer = Console.ReadLine();

            if (userAnswer == "1") //View All
            {
                Console.WriteLine("1");
                ConsoleLogging.ClearConsole();
            }
            else if (userAnswer == "2") //Create
            {
                Console.WriteLine("2");
                ConsoleLogging.ClearConsole();
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
                ConsoleLogging.ExitMessage();
            }
            else //Not a Choice
            {
                ConsoleLogging.InvalidResponse();
            }
        }
    }
}
