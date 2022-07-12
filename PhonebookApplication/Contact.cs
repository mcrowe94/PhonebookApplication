using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PhonebookApplication
{
    public class Contact : INotifyPropertyChanged
    {
        private string firstName;   

        public string FirstName
        {
            get { return firstName; }
            set 
            { 
                firstName = value;
                NotifyPropertyChanged(nameof(FirstName));
            }

        }
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set
            {
               lastName  = value;
                NotifyPropertyChanged(nameof(LastName));
            }

        }
        private string phoneNumber;

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                phoneNumber = value;
                NotifyPropertyChanged(nameof(PhoneNumber));
            }

        }
        private string emailAddress;

        public string EmailAddress
        {
            get { return emailAddress; }
            set
            {
                emailAddress = value;
                NotifyPropertyChanged(nameof(EmailAddress));
            }

        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
