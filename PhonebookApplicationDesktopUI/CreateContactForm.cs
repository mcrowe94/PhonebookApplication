using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhonebookApplication;

namespace PhonebookApplicationDesktopUI
{
    public partial class CreateContactForm : Form
    {
        private readonly HomeForm _homeForm;
        public CreateContactForm()
        {
            InitializeComponent();

            _homeForm = (HomeForm)Application.OpenForms[nameof(HomeForm)];
        }

        private void CreateContactButton_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();

            contact.FirstName = firstNameTextBox.Text;
            contact.LastName = lastNameTextbox.Text;
            contact.EmailAddress = emailTextBox.Text;
            contact.PhoneNumber = phoneNumberTextBox.Text;

            HomeForm.contacts.Add(contact);

            MessageBox.Show("Contact Created! Refresh Data", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            _homeForm.RefreshData();

            Close();
        }
    }
}
