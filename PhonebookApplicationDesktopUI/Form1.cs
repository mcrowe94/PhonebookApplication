using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using PhonebookApplication;

namespace PhonebookApplicationDesktopUI
{
    public partial class HomeForm : Form
    {
        public static BindingList<Contact> contacts;

        public HomeForm()
        {
            InitializeComponent();
            ContactsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            contacts = FileManipulation.LoadContacts(contacts);
            RefreshData();
        }

        private void ReadContactsBtn_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        public void RefreshData()
        {
            ContactsGridView.DataSource = contacts;
        }

        private void CreateContactBtn_Click(object sender, EventArgs e)
        {
            var createContactForm = new CreateContactForm();
            createContactForm.Show();
        }

        private void UpdateContactBtn_Click(object sender, EventArgs e)
        {
            var row = ContactsGridView.SelectedRows[0];

            Contact c = contacts.Where(x => x.EmailAddress == row.Cells["EmailAddress"].Value.ToString()).FirstOrDefault();

            var updateContactForm = new UpdateContactForm(c);

            updateContactForm.Show();
        }

        private void deleteContactBtn_Click(object sender, EventArgs e)
        {
            var row = ContactsGridView.SelectedRows[0];

            Contact c = contacts.Where(x => x.EmailAddress == row.Cells["EmailAddress"].Value.ToString()).FirstOrDefault();

            var result = MessageBox.Show("You are about to delete a contact. This is a permanent action. \nDo you wish to continue?", "WARNING!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                MessageBox.Show("Delete aborted.", "", MessageBoxButtons.OK);
                return;
            }

            contacts.Remove(c);
            MessageBox.Show("Contact Deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            RefreshData();

        }

    }
}
