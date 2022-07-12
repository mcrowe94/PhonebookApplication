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
    public partial class UpdateContactForm : Form
    {

        private readonly Contact _originalContact;
        private readonly HomeForm _homeForm;

        public UpdateContactForm(Contact originalContact)
        {
            InitializeComponent();

            _originalContact = originalContact;
            _homeForm = (HomeForm)Application.OpenForms[nameof(HomeForm)];

            firstNameTextBox.Text = _originalContact.FirstName;
            lastNameTextBox.Text = _originalContact.LastName;
            emailAddressTextBox.Text = _originalContact.EmailAddress;
            phoneNumberTextBox.Text = _originalContact.PhoneNumber;
        }

        private void UpdateContactBtn_Click(object sender, EventArgs e)
        {
            _originalContact.FirstName = firstNameTextBox.Text;
            _originalContact.LastName = lastNameTextBox.Text;
            _originalContact.EmailAddress = emailAddressTextBox.Text;
            _originalContact.PhoneNumber = phoneNumberTextBox.Text;

            MessageBox.Show("Contact Updated!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            _homeForm.RefreshData();

            Close();

        }
    }
}
