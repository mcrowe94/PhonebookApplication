using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonebookApplication
{
    public class FileManipulation
    {
        public static string GetFilePath()
        {
            string filePath = $"{Directory.GetCurrentDirectory()}/Contacts.JSON";
            return filePath;
        }
        
        public static void SaveContacts(BindingList<Contact> contacts)
        {
            var filePath = GetFilePath();

            var json = JsonConvert.SerializeObject(contacts, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public static void SaveContacts(List<Contact> contacts)
        {
            var filePath = GetFilePath();

            var json = JsonConvert.SerializeObject(contacts, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public static List<Contact> LoadContacts(List<Contact> contacts)
        {
            string filePath = GetFilePath();
            
            if(!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }

            var json = File.ReadAllText(filePath);
            contacts = JsonConvert.DeserializeObject<List<Contact>>(json);

            return contacts;

        }

        public static BindingList<Contact> LoadContacts(BindingList<Contact> contacts)
        {
            string filePath = GetFilePath();

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }

            var json = File.ReadAllText(filePath);
            contacts = JsonConvert.DeserializeObject<BindingList<Contact>>(json);

            return contacts;

        }
    }
}
