using System;
using System.Collections.Generic;

namespace PhonebookApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contact> contacts = new List<Contact>();


            ConsoleLogging.MainConsole(contacts);
        }
    }
}
