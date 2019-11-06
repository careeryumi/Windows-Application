namespace ContactManager
{
    partial class AddContactForm
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstNameAdd = new System.Windows.Forms.TextBox();
            this.txtLastNameAdd = new System.Windows.Forms.TextBox();
            this.btnAddPhoto = new System.Windows.Forms.Button();
            this.grbAddress = new System.Windows.Forms.GroupBox();
            this.cboAddressType = new System.Windows.Forms.ComboBox();
            this.mskTxtZip = new System.Windows.Forms.MaskedTextBox();
            this.cboProvince = new System.Windows.Forms.ComboBox();
            this.txtCityAdd = new System.Windows.Forms.TextBox();
            this.txtStreetAdd = new System.Windows.Forms.TextBox();
            this.lblZipAdd = new System.Windows.Forms.Label();
            this.lblProvinceAdd = new System.Windows.Forms.Label();
            this.lblCityAdd = new System.Windows.Forms.Label();
            this.lblStreetAdd = new System.Windows.Forms.Label();
            this.lblAddressTypeAdd = new System.Windows.Forms.Label();
            this.grbEmail = new System.Windows.Forms.GroupBox();
            this.cboEmail = new System.Windows.Forms.ComboBox();
            this.txtEmailAdd = new System.Windows.Forms.TextBox();
            this.lblTypeEmailAdd = new System.Windows.Forms.Label();
            this.grbPhone = new System.Windows.Forms.GroupBox();
            this.mskTxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.cboPhone = new System.Windows.Forms.ComboBox();
            this.lblTypePhoneAdd = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.picAddContactPicture = new System.Windows.Forms.PictureBox();
            this.grbAddress.SuspendLayout();
            this.grbEmail.SuspendLayout();
            this.grbPhone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddContactPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(180, 24);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(180, 61);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtFirstNameAdd
            // 
            this.txtFirstNameAdd.AccessibleDescription = "";
            this.txtFirstNameAdd.Location = new System.Drawing.Point(250, 23);
            this.txtFirstNameAdd.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirstNameAdd.Name = "txtFirstNameAdd";
            this.txtFirstNameAdd.Size = new System.Drawing.Size(158, 20);
            this.txtFirstNameAdd.TabIndex = 3;
            // 
            // txtLastNameAdd
            // 
            this.txtLastNameAdd.Location = new System.Drawing.Point(250, 59);
            this.txtLastNameAdd.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastNameAdd.Name = "txtLastNameAdd";
            this.txtLastNameAdd.Size = new System.Drawing.Size(158, 20);
            this.txtLastNameAdd.TabIndex = 4;
            // 
            // btnAddPhoto
            // 
            this.btnAddPhoto.Location = new System.Drawing.Point(185, 104);
            this.btnAddPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPhoto.Name = "btnAddPhoto";
            this.btnAddPhoto.Size = new System.Drawing.Size(91, 21);
            this.btnAddPhoto.TabIndex = 5;
            this.btnAddPhoto.Text = "Add Photo";
            this.btnAddPhoto.UseVisualStyleBackColor = true;
            this.btnAddPhoto.Click += new System.EventHandler(this.btnAddPhoto_Click);
            // 
            // grbAddress
            // 
            this.grbAddress.Controls.Add(this.cboAddressType);
            this.grbAddress.Controls.Add(this.mskTxtZip);
            this.grbAddress.Controls.Add(this.cboProvince);
            this.grbAddress.Controls.Add(this.txtCityAdd);
            this.grbAddress.Controls.Add(this.txtStreetAdd);
            this.grbAddress.Controls.Add(this.lblZipAdd);
            this.grbAddress.Controls.Add(this.lblProvinceAdd);
            this.grbAddress.Controls.Add(this.lblCityAdd);
            this.grbAddress.Controls.Add(this.lblStreetAdd);
            this.grbAddress.Controls.Add(this.lblAddressTypeAdd);
            this.grbAddress.Location = new System.Drawing.Point(18, 152);
            this.grbAddress.Margin = new System.Windows.Forms.Padding(2);
            this.grbAddress.Name = "grbAddress";
            this.grbAddress.Padding = new System.Windows.Forms.Padding(2);
            this.grbAddress.Size = new System.Drawing.Size(388, 103);
            this.grbAddress.TabIndex = 6;
            this.grbAddress.TabStop = false;
            this.grbAddress.Text = "Address";
            // 
            // cboAddressType
            // 
            this.cboAddressType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboAddressType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboAddressType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAddressType.FormattingEnabled = true;
            this.cboAddressType.Items.AddRange(new object[] {
            "Home",
            "Business"});
            this.cboAddressType.Location = new System.Drawing.Point(78, 23);
            this.cboAddressType.Margin = new System.Windows.Forms.Padding(2);
            this.cboAddressType.Name = "cboAddressType";
            this.cboAddressType.Size = new System.Drawing.Size(174, 21);
            this.cboAddressType.TabIndex = 10;
            this.cboAddressType.SelectedIndexChanged += new System.EventHandler(this.cboAddressType_SelectedIndexChanged);
            // 
            // mskTxtZip
            // 
            this.mskTxtZip.Location = new System.Drawing.Point(307, 76);
            this.mskTxtZip.Margin = new System.Windows.Forms.Padding(2);
            this.mskTxtZip.Mask = "L0L 0L0";
            this.mskTxtZip.Name = "mskTxtZip";
            this.mskTxtZip.Size = new System.Drawing.Size(68, 20);
            this.mskTxtZip.TabIndex = 9;
            this.mskTxtZip.Leave += new System.EventHandler(this.mskTxtZip_Leave);
            // 
            // cboProvince
            // 
            this.cboProvince.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboProvince.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvince.FormattingEnabled = true;
            this.cboProvince.Items.AddRange(new object[] {
            "AB",
            "BC",
            "MB",
            "NB",
            "NL",
            "NT",
            "NS",
            "NU",
            "ON",
            "PE",
            "QC",
            "SK",
            "YT"});
            this.cboProvince.Location = new System.Drawing.Point(205, 76);
            this.cboProvince.Margin = new System.Windows.Forms.Padding(2);
            this.cboProvince.Name = "cboProvince";
            this.cboProvince.Size = new System.Drawing.Size(63, 21);
            this.cboProvince.TabIndex = 8;
            this.cboProvince.SelectedIndexChanged += new System.EventHandler(this.cboProvince_SelectedIndexChanged);
            // 
            // txtCityAdd
            // 
            this.txtCityAdd.Location = new System.Drawing.Point(78, 79);
            this.txtCityAdd.Margin = new System.Windows.Forms.Padding(2);
            this.txtCityAdd.Name = "txtCityAdd";
            this.txtCityAdd.Size = new System.Drawing.Size(73, 20);
            this.txtCityAdd.TabIndex = 6;
            // 
            // txtStreetAdd
            // 
            this.txtStreetAdd.Location = new System.Drawing.Point(78, 50);
            this.txtStreetAdd.Margin = new System.Windows.Forms.Padding(2);
            this.txtStreetAdd.Name = "txtStreetAdd";
            this.txtStreetAdd.Size = new System.Drawing.Size(297, 20);
            this.txtStreetAdd.TabIndex = 5;
            // 
            // lblZipAdd
            // 
            this.lblZipAdd.AutoSize = true;
            this.lblZipAdd.Location = new System.Drawing.Point(274, 76);
            this.lblZipAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblZipAdd.Name = "lblZipAdd";
            this.lblZipAdd.Size = new System.Drawing.Size(25, 13);
            this.lblZipAdd.TabIndex = 4;
            this.lblZipAdd.Text = "Zip:";
            // 
            // lblProvinceAdd
            // 
            this.lblProvinceAdd.AutoSize = true;
            this.lblProvinceAdd.Location = new System.Drawing.Point(150, 79);
            this.lblProvinceAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProvinceAdd.Name = "lblProvinceAdd";
            this.lblProvinceAdd.Size = new System.Drawing.Size(52, 13);
            this.lblProvinceAdd.TabIndex = 3;
            this.lblProvinceAdd.Text = "Province:";
            // 
            // lblCityAdd
            // 
            this.lblCityAdd.AutoSize = true;
            this.lblCityAdd.Location = new System.Drawing.Point(23, 76);
            this.lblCityAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCityAdd.Name = "lblCityAdd";
            this.lblCityAdd.Size = new System.Drawing.Size(27, 13);
            this.lblCityAdd.TabIndex = 2;
            this.lblCityAdd.Text = "City:";
            // 
            // lblStreetAdd
            // 
            this.lblStreetAdd.AutoSize = true;
            this.lblStreetAdd.Location = new System.Drawing.Point(20, 50);
            this.lblStreetAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStreetAdd.Name = "lblStreetAdd";
            this.lblStreetAdd.Size = new System.Drawing.Size(38, 13);
            this.lblStreetAdd.TabIndex = 1;
            this.lblStreetAdd.Text = "Street:";
            // 
            // lblAddressTypeAdd
            // 
            this.lblAddressTypeAdd.AutoSize = true;
            this.lblAddressTypeAdd.Location = new System.Drawing.Point(23, 26);
            this.lblAddressTypeAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddressTypeAdd.Name = "lblAddressTypeAdd";
            this.lblAddressTypeAdd.Size = new System.Drawing.Size(34, 13);
            this.lblAddressTypeAdd.TabIndex = 0;
            this.lblAddressTypeAdd.Text = "Type:";
            // 
            // grbEmail
            // 
            this.grbEmail.Controls.Add(this.cboEmail);
            this.grbEmail.Controls.Add(this.txtEmailAdd);
            this.grbEmail.Controls.Add(this.lblTypeEmailAdd);
            this.grbEmail.Location = new System.Drawing.Point(18, 270);
            this.grbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.grbEmail.Name = "grbEmail";
            this.grbEmail.Padding = new System.Windows.Forms.Padding(2);
            this.grbEmail.Size = new System.Drawing.Size(388, 53);
            this.grbEmail.TabIndex = 7;
            this.grbEmail.TabStop = false;
            this.grbEmail.Text = "Email";
            // 
            // cboEmail
            // 
            this.cboEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboEmail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmail.FormattingEnabled = true;
            this.cboEmail.Items.AddRange(new object[] {
            "Business",
            "Personal"});
            this.cboEmail.Location = new System.Drawing.Point(266, 24);
            this.cboEmail.Margin = new System.Windows.Forms.Padding(2);
            this.cboEmail.Name = "cboEmail";
            this.cboEmail.Size = new System.Drawing.Size(105, 21);
            this.cboEmail.TabIndex = 2;
            this.cboEmail.SelectedIndexChanged += new System.EventHandler(this.cboEmail_SelectedIndexChanged);
            // 
            // txtEmailAdd
            // 
            this.txtEmailAdd.Location = new System.Drawing.Point(14, 23);
            this.txtEmailAdd.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmailAdd.Name = "txtEmailAdd";
            this.txtEmailAdd.Size = new System.Drawing.Size(186, 20);
            this.txtEmailAdd.TabIndex = 1;
            // 
            // lblTypeEmailAdd
            // 
            this.lblTypeEmailAdd.AutoSize = true;
            this.lblTypeEmailAdd.Location = new System.Drawing.Point(219, 25);
            this.lblTypeEmailAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTypeEmailAdd.Name = "lblTypeEmailAdd";
            this.lblTypeEmailAdd.Size = new System.Drawing.Size(34, 13);
            this.lblTypeEmailAdd.TabIndex = 0;
            this.lblTypeEmailAdd.Text = "Type:";
            // 
            // grbPhone
            // 
            this.grbPhone.Controls.Add(this.mskTxtPhone);
            this.grbPhone.Controls.Add(this.cboPhone);
            this.grbPhone.Controls.Add(this.lblTypePhoneAdd);
            this.grbPhone.Location = new System.Drawing.Point(18, 332);
            this.grbPhone.Margin = new System.Windows.Forms.Padding(2);
            this.grbPhone.Name = "grbPhone";
            this.grbPhone.Padding = new System.Windows.Forms.Padding(2);
            this.grbPhone.Size = new System.Drawing.Size(388, 46);
            this.grbPhone.TabIndex = 8;
            this.grbPhone.TabStop = false;
            this.grbPhone.Text = "Phone";
            // 
            // mskTxtPhone
            // 
            this.mskTxtPhone.Location = new System.Drawing.Point(10, 17);
            this.mskTxtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.mskTxtPhone.Mask = "(000) 000-0000";
            this.mskTxtPhone.Name = "mskTxtPhone";
            this.mskTxtPhone.Size = new System.Drawing.Size(192, 20);
            this.mskTxtPhone.TabIndex = 3;
            // 
            // cboPhone
            // 
            this.cboPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboPhone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhone.FormattingEnabled = true;
            this.cboPhone.Items.AddRange(new object[] {
            "Business",
            "Personal"});
            this.cboPhone.Location = new System.Drawing.Point(266, 15);
            this.cboPhone.Margin = new System.Windows.Forms.Padding(2);
            this.cboPhone.Name = "cboPhone";
            this.cboPhone.Size = new System.Drawing.Size(103, 21);
            this.cboPhone.TabIndex = 2;
            this.cboPhone.SelectedIndexChanged += new System.EventHandler(this.cboPhone_SelectedIndexChanged);
            // 
            // lblTypePhoneAdd
            // 
            this.lblTypePhoneAdd.AutoSize = true;
            this.lblTypePhoneAdd.Location = new System.Drawing.Point(223, 14);
            this.lblTypePhoneAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTypePhoneAdd.Name = "lblTypePhoneAdd";
            this.lblTypePhoneAdd.Size = new System.Drawing.Size(34, 13);
            this.lblTypePhoneAdd.TabIndex = 0;
            this.lblTypePhoneAdd.Text = "Type:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(304, 388);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 20);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // picAddContactPicture
            // 
            this.picAddContactPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAddContactPicture.Image = global::ContactManager.Properties.Resources.defaultImage;
            this.picAddContactPicture.Location = new System.Drawing.Point(22, 20);
            this.picAddContactPicture.Name = "picAddContactPicture";
            this.picAddContactPicture.Padding = new System.Windows.Forms.Padding(3);
            this.picAddContactPicture.Size = new System.Drawing.Size(127, 108);
            this.picAddContactPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAddContactPicture.TabIndex = 10;
            this.picAddContactPicture.TabStop = false;
            // 
            // AddContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 433);
            this.Controls.Add(this.picAddContactPicture);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grbPhone);
            this.Controls.Add(this.grbEmail);
            this.Controls.Add(this.grbAddress);
            this.Controls.Add(this.btnAddPhoto);
            this.Controls.Add(this.txtLastNameAdd);
            this.Controls.Add(this.txtFirstNameAdd);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddContactForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Contact";
            this.grbAddress.ResumeLayout(false);
            this.grbAddress.PerformLayout();
            this.grbEmail.ResumeLayout(false);
            this.grbEmail.PerformLayout();
            this.grbPhone.ResumeLayout(false);
            this.grbPhone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddContactPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstNameAdd;
        private System.Windows.Forms.TextBox txtLastNameAdd;
        private System.Windows.Forms.Button btnAddPhoto;
        private System.Windows.Forms.GroupBox grbAddress;
        private System.Windows.Forms.GroupBox grbEmail;
        private System.Windows.Forms.GroupBox grbPhone;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCityAdd;
        private System.Windows.Forms.TextBox txtStreetAdd;
        private System.Windows.Forms.Label lblZipAdd;
        private System.Windows.Forms.Label lblProvinceAdd;
        private System.Windows.Forms.Label lblCityAdd;
        private System.Windows.Forms.Label lblStreetAdd;
        private System.Windows.Forms.Label lblAddressTypeAdd;
        private System.Windows.Forms.TextBox txtEmailAdd;
        private System.Windows.Forms.Label lblTypeEmailAdd;
        private System.Windows.Forms.Label lblTypePhoneAdd;
        private System.Windows.Forms.MaskedTextBox mskTxtZip;
        private System.Windows.Forms.ComboBox cboProvince;
        private System.Windows.Forms.ComboBox cboEmail;
        private System.Windows.Forms.MaskedTextBox mskTxtPhone;
        private System.Windows.Forms.ComboBox cboPhone;
        private System.Windows.Forms.ComboBox cboAddressType;
        private System.Windows.Forms.PictureBox picAddContactPicture;
    }
}