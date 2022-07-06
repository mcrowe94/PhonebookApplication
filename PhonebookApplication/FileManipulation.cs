using System;
using System.Collections.Generic;
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
    }
}
