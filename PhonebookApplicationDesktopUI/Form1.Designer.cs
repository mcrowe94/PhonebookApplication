
namespace PhonebookApplicationDesktopUI
{
    partial class HomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.ReadContactsBtn = new System.Windows.Forms.Button();
            this.ContactsGridView = new System.Windows.Forms.DataGridView();
            this.CreateContactBtn = new System.Windows.Forms.Button();
            this.UpdateContactBtn = new System.Windows.Forms.Button();
            this.deleteContactBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ContactsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ReadContactsBtn
            // 
            this.ReadContactsBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ReadContactsBtn.Location = new System.Drawing.Point(665, 135);
            this.ReadContactsBtn.Name = "ReadContactsBtn";
            this.ReadContactsBtn.Size = new System.Drawing.Size(146, 66);
            this.ReadContactsBtn.TabIndex = 0;
            this.ReadContactsBtn.Text = "Read Contacts";
            this.ReadContactsBtn.UseVisualStyleBackColor = true;
            this.ReadContactsBtn.Click += new System.EventHandler(this.ReadContactsBtn_Click);
            // 
            // ContactsGridView
            // 
            this.ContactsGridView.AllowUserToAddRows = false;
            this.ContactsGridView.AllowUserToDeleteRows = false;
            this.ContactsGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ContactsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContactsGridView.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ContactsGridView.Location = new System.Drawing.Point(12, 76);
            this.ContactsGridView.MultiSelect = false;
            this.ContactsGridView.Name = "ContactsGridView";
            this.ContactsGridView.ReadOnly = true;
            this.ContactsGridView.RowHeadersWidth = 62;
            this.ContactsGridView.RowTemplate.Height = 33;
            this.ContactsGridView.Size = new System.Drawing.Size(619, 379);
            this.ContactsGridView.TabIndex = 1;
            // 
            // CreateContactBtn
            // 
            this.CreateContactBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateContactBtn.Location = new System.Drawing.Point(665, 207);
            this.CreateContactBtn.Name = "CreateContactBtn";
            this.CreateContactBtn.Size = new System.Drawing.Size(146, 64);
            this.CreateContactBtn.TabIndex = 2;
            this.CreateContactBtn.Text = "Create Contact";
            this.CreateContactBtn.UseVisualStyleBackColor = true;
            this.CreateContactBtn.Click += new System.EventHandler(this.CreateContactBtn_Click);
            // 
            // UpdateContactBtn
            // 
            this.UpdateContactBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdateContactBtn.Location = new System.Drawing.Point(665, 277);
            this.UpdateContactBtn.Name = "UpdateContactBtn";
            this.UpdateContactBtn.Size = new System.Drawing.Size(146, 65);
            this.UpdateContactBtn.TabIndex = 3;
            this.UpdateContactBtn.Text = "Update Contact";
            this.UpdateContactBtn.UseVisualStyleBackColor = true;
            this.UpdateContactBtn.Click += new System.EventHandler(this.UpdateContactBtn_Click);
            // 
            // deleteContactBtn
            // 
            this.deleteContactBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteContactBtn.Location = new System.Drawing.Point(665, 348);
            this.deleteContactBtn.Name = "deleteContactBtn";
            this.deleteContactBtn.Size = new System.Drawing.Size(146, 70);
            this.deleteContactBtn.TabIndex = 4;
            this.deleteContactBtn.Text = "Delete Contact";
            this.deleteContactBtn.UseVisualStyleBackColor = true;
            this.deleteContactBtn.Click += new System.EventHandler(this.deleteContactBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(189, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 48);
            this.label1.TabIndex = 5;
            this.label1.Text = "My Phonebook";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(688, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 38);
            this.label2.TabIndex = 6;
            this.label2.Text = "MENU";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(839, 518);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteContactBtn);
            this.Controls.Add(this.UpdateContactBtn);
            this.Controls.Add(this.CreateContactBtn);
            this.Controls.Add(this.ContactsGridView);
            this.Controls.Add(this.ReadContactsBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeForm";
            this.Text = "Phonebook App";
            ((System.ComponentModel.ISupportInitialize)(this.ContactsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReadContactsBtn;
        private System.Windows.Forms.DataGridView ContactsGridView;
        private System.Windows.Forms.Button CreateContactBtn;
        private System.Windows.Forms.Button UpdateContactBtn;
        private System.Windows.Forms.Button deleteContactBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

