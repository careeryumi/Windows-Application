namespace ContactManager
{
    partial class ManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstContacts = new System.Windows.Forms.ListBox();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.grbNotes = new System.Windows.Forms.GroupBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.grbTakeNote = new System.Windows.Forms.GroupBox();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.txtTakeANote = new System.Windows.Forms.TextBox();
            this.grbPhone = new System.Windows.Forms.GroupBox();
            this.txtPhoneType = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblTypePhone = new System.Windows.Forms.Label();
            this.grbEmail = new System.Windows.Forms.GroupBox();
            this.txtEmailType = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblTypeEmail = new System.Windows.Forms.Label();
            this.grbAddress = new System.Windows.Forms.GroupBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtAddressType = new System.Windows.Forms.TextBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblTypeAddress = new System.Windows.Forms.Label();
            this.btnEditContact = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.picPicture = new System.Windows.Forms.PictureBox();
            this.pnlDetails.SuspendLayout();
            this.grbNotes.SuspendLayout();
            this.grbTakeNote.SuspendLayout();
            this.grbPhone.SuspendLayout();
            this.grbEmail.SuspendLayout();
            this.grbAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lstContacts
            // 
            this.lstContacts.FormattingEnabled = true;
            this.lstContacts.Location = new System.Drawing.Point(13, 11);
            this.lstContacts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstContacts.Name = "lstContacts";
            this.lstContacts.Size = new System.Drawing.Size(132, 316);
            this.lstContacts.TabIndex = 0;
            this.lstContacts.SelectedIndexChanged += new System.EventHandler(this.lstContacts_SelectedIndexChanged);
            // 
            // btnAddContact
            // 
            this.btnAddContact.Location = new System.Drawing.Point(14, 343);
            this.btnAddContact.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(128, 29);
            this.btnAddContact.TabIndex = 1;
            this.btnAddContact.Text = "Add Contact";
            this.btnAddContact.UseVisualStyleBackColor = true;
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.grbNotes);
            this.pnlDetails.Controls.Add(this.grbTakeNote);
            this.pnlDetails.Controls.Add(this.grbPhone);
            this.pnlDetails.Controls.Add(this.grbEmail);
            this.pnlDetails.Controls.Add(this.grbAddress);
            this.pnlDetails.Controls.Add(this.btnEditContact);
            this.pnlDetails.Controls.Add(this.txtLastName);
            this.pnlDetails.Controls.Add(this.lblLastName);
            this.pnlDetails.Controls.Add(this.txtFirstName);
            this.pnlDetails.Controls.Add(this.lblFirstName);
            this.pnlDetails.Controls.Add(this.picPicture);
            this.pnlDetails.Location = new System.Drawing.Point(146, 14);
            this.pnlDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(586, 370);
            this.pnlDetails.TabIndex = 2;
            // 
            // grbNotes
            // 
            this.grbNotes.Controls.Add(this.txtNotes);
            this.grbNotes.Location = new System.Drawing.Point(365, 144);
            this.grbNotes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbNotes.Name = "grbNotes";
            this.grbNotes.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbNotes.Size = new System.Drawing.Size(217, 214);
            this.grbNotes.TabIndex = 10;
            this.grbNotes.TabStop = false;
            this.grbNotes.Text = "Notes";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(9, 17);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ReadOnly = true;
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(200, 191);
            this.txtNotes.TabIndex = 0;
            // 
            // grbTakeNote
            // 
            this.grbTakeNote.Controls.Add(this.btnAddNote);
            this.grbTakeNote.Controls.Add(this.txtTakeANote);
            this.grbTakeNote.Location = new System.Drawing.Point(365, 12);
            this.grbTakeNote.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbTakeNote.Name = "grbTakeNote";
            this.grbTakeNote.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbTakeNote.Size = new System.Drawing.Size(208, 118);
            this.grbTakeNote.TabIndex = 9;
            this.grbTakeNote.TabStop = false;
            this.grbTakeNote.Text = "Take a Note:";
            // 
            // btnAddNote
            // 
            this.btnAddNote.Location = new System.Drawing.Point(115, 95);
            this.btnAddNote.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(86, 19);
            this.btnAddNote.TabIndex = 1;
            this.btnAddNote.Text = "Add Note";
            this.btnAddNote.UseVisualStyleBackColor = true;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // txtTakeANote
            // 
            this.txtTakeANote.Location = new System.Drawing.Point(10, 19);
            this.txtTakeANote.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTakeANote.Multiline = true;
            this.txtTakeANote.Name = "txtTakeANote";
            this.txtTakeANote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTakeANote.Size = new System.Drawing.Size(193, 70);
            this.txtTakeANote.TabIndex = 0;
            // 
            // grbPhone
            // 
            this.grbPhone.Controls.Add(this.txtPhoneType);
            this.grbPhone.Controls.Add(this.txtPhone);
            this.grbPhone.Controls.Add(this.lblTypePhone);
            this.grbPhone.Location = new System.Drawing.Point(13, 322);
            this.grbPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbPhone.Name = "grbPhone";
            this.grbPhone.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbPhone.Size = new System.Drawing.Size(341, 48);
            this.grbPhone.TabIndex = 8;
            this.grbPhone.TabStop = false;
            this.grbPhone.Text = "Phone";
            // 
            // txtPhoneType
            // 
            this.txtPhoneType.Location = new System.Drawing.Point(212, 15);
            this.txtPhoneType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPhoneType.Name = "txtPhoneType";
            this.txtPhoneType.ReadOnly = true;
            this.txtPhoneType.Size = new System.Drawing.Size(115, 20);
            this.txtPhoneType.TabIndex = 2;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(13, 18);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(148, 20);
            this.txtPhone.TabIndex = 1;
            // 
            // lblTypePhone
            // 
            this.lblTypePhone.AutoSize = true;
            this.lblTypePhone.Location = new System.Drawing.Point(171, 15);
            this.lblTypePhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTypePhone.Name = "lblTypePhone";
            this.lblTypePhone.Size = new System.Drawing.Size(34, 13);
            this.lblTypePhone.TabIndex = 0;
            this.lblTypePhone.Text = "Type:";
            // 
            // grbEmail
            // 
            this.grbEmail.Controls.Add(this.txtEmailType);
            this.grbEmail.Controls.Add(this.txtEmail);
            this.grbEmail.Controls.Add(this.lblTypeEmail);
            this.grbEmail.Location = new System.Drawing.Point(15, 257);
            this.grbEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbEmail.Name = "grbEmail";
            this.grbEmail.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbEmail.Size = new System.Drawing.Size(336, 49);
            this.grbEmail.TabIndex = 7;
            this.grbEmail.TabStop = false;
            this.grbEmail.Text = "Email";
            // 
            // txtEmailType
            // 
            this.txtEmailType.Location = new System.Drawing.Point(212, 18);
            this.txtEmailType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmailType.Name = "txtEmailType";
            this.txtEmailType.ReadOnly = true;
            this.txtEmailType.Size = new System.Drawing.Size(114, 20);
            this.txtEmailType.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(8, 22);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(152, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // lblTypeEmail
            // 
            this.lblTypeEmail.AutoSize = true;
            this.lblTypeEmail.Location = new System.Drawing.Point(165, 20);
            this.lblTypeEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTypeEmail.Name = "lblTypeEmail";
            this.lblTypeEmail.Size = new System.Drawing.Size(34, 13);
            this.lblTypeEmail.TabIndex = 0;
            this.lblTypeEmail.Text = "Type:";
            // 
            // grbAddress
            // 
            this.grbAddress.Controls.Add(this.txtZip);
            this.grbAddress.Controls.Add(this.txtProvince);
            this.grbAddress.Controls.Add(this.txtCity);
            this.grbAddress.Controls.Add(this.txtStreet);
            this.grbAddress.Controls.Add(this.txtAddressType);
            this.grbAddress.Controls.Add(this.lblZip);
            this.grbAddress.Controls.Add(this.lblProvince);
            this.grbAddress.Controls.Add(this.lblCity);
            this.grbAddress.Controls.Add(this.lblStreet);
            this.grbAddress.Controls.Add(this.lblTypeAddress);
            this.grbAddress.Location = new System.Drawing.Point(19, 136);
            this.grbAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbAddress.Name = "grbAddress";
            this.grbAddress.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbAddress.Size = new System.Drawing.Size(332, 112);
            this.grbAddress.TabIndex = 6;
            this.grbAddress.TabStop = false;
            this.grbAddress.Text = "Address";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(240, 75);
            this.txtZip.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtZip.Name = "txtZip";
            this.txtZip.ReadOnly = true;
            this.txtZip.Size = new System.Drawing.Size(82, 20);
            this.txtZip.TabIndex = 9;
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(168, 75);
            this.txtProvince.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.ReadOnly = true;
            this.txtProvince.Size = new System.Drawing.Size(37, 20);
            this.txtProvince.TabIndex = 8;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(41, 73);
            this.txtCity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(69, 20);
            this.txtCity.TabIndex = 7;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(53, 46);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.ReadOnly = true;
            this.txtStreet.Size = new System.Drawing.Size(269, 20);
            this.txtStreet.TabIndex = 6;
            // 
            // txtAddressType
            // 
            this.txtAddressType.Location = new System.Drawing.Point(53, 25);
            this.txtAddressType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAddressType.Name = "txtAddressType";
            this.txtAddressType.ReadOnly = true;
            this.txtAddressType.Size = new System.Drawing.Size(91, 20);
            this.txtAddressType.TabIndex = 5;
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(212, 73);
            this.lblZip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(25, 13);
            this.lblZip.TabIndex = 4;
            this.lblZip.Text = "Zip:";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(113, 75);
            this.lblProvince.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(52, 13);
            this.lblProvince.TabIndex = 3;
            this.lblProvince.Text = "Province:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(10, 73);
            this.lblCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "City:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(10, 48);
            this.lblStreet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(38, 13);
            this.lblStreet.TabIndex = 1;
            this.lblStreet.Text = "Street:";
            // 
            // lblTypeAddress
            // 
            this.lblTypeAddress.AutoSize = true;
            this.lblTypeAddress.Location = new System.Drawing.Point(10, 22);
            this.lblTypeAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTypeAddress.Name = "lblTypeAddress";
            this.lblTypeAddress.Size = new System.Drawing.Size(34, 13);
            this.lblTypeAddress.TabIndex = 0;
            this.lblTypeAddress.Text = "Type:";
            // 
            // btnEditContact
            // 
            this.btnEditContact.Location = new System.Drawing.Point(264, 102);
            this.btnEditContact.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditContact.Name = "btnEditContact";
            this.btnEditContact.Size = new System.Drawing.Size(75, 25);
            this.btnEditContact.TabIndex = 5;
            this.btnEditContact.Text = "Edit Contact";
            this.btnEditContact.UseVisualStyleBackColor = true;
            this.btnEditContact.Click += new System.EventHandler(this.btnEditContact_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(211, 47);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(129, 20);
            this.txtLastName.TabIndex = 4;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(144, 47);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(209, 18);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(131, 20);
            this.txtFirstName.TabIndex = 2;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(144, 18);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name:";
            // 
            // picPicture
            // 
            this.picPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPicture.Image = global::ContactManager.Properties.Resources.defaultImage;
            this.picPicture.InitialImage = global::ContactManager.Properties.Resources.defaultImage;
            this.picPicture.Location = new System.Drawing.Point(13, 12);
            this.picPicture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picPicture.Name = "picPicture";
            this.picPicture.Size = new System.Drawing.Size(115, 114);
            this.picPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPicture.TabIndex = 0;
            this.picPicture.TabStop = false;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 403);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.btnAddContact);
            this.Controls.Add(this.lstContacts);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Manager";
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.grbNotes.ResumeLayout(false);
            this.grbNotes.PerformLayout();
            this.grbTakeNote.ResumeLayout(false);
            this.grbTakeNote.PerformLayout();
            this.grbPhone.ResumeLayout(false);
            this.grbPhone.PerformLayout();
            this.grbEmail.ResumeLayout(false);
            this.grbEmail.PerformLayout();
            this.grbAddress.ResumeLayout(false);
            this.grbAddress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstContacts;
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.GroupBox grbNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.GroupBox grbTakeNote;
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.TextBox txtTakeANote;
        private System.Windows.Forms.GroupBox grbPhone;
        private System.Windows.Forms.TextBox txtPhoneType;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblTypePhone;
        private System.Windows.Forms.GroupBox grbEmail;
        private System.Windows.Forms.TextBox txtEmailType;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblTypeEmail;
        private System.Windows.Forms.GroupBox grbAddress;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtAddressType;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblTypeAddress;
        private System.Windows.Forms.Button btnEditContact;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.PictureBox picPicture;
    }
}

