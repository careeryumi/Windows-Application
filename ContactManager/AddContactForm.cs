/* Name: Yumi Lee
Assignment: Assignment3
This program is a Contact Manager
Course Code: PROG-1815-1 Programming Concepts2
Professor: Aneta Canhoto
Date: July 24, 2019 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager
{
    public partial class AddContactForm : Form
    {
        int checkedIndex;

        string pathProfilePicture = "";

        string addressType;
        string province;
        string emailType;
        string phoneType;


        Contact currentContact;

        public AddContactForm(int selectedIndexP)
        {
            InitializeComponent();
            checkedIndex = selectedIndexP;
        }

        //Get the all data from mainForm and fill when edit button clicked
        public AddContactForm(Contact selectedContactP, int checkedIndexP)
        {
            InitializeComponent();

            checkedIndex = checkedIndexP;

            txtFirstNameAdd.Text = selectedContactP.FirstName;
            txtLastNameAdd.Text = selectedContactP.LastName;
            cboAddressType.SelectedItem = selectedContactP.AddressType;
            txtStreetAdd.Text = selectedContactP.Street;
            txtCityAdd.Text = selectedContactP.City;
            cboProvince.SelectedItem = selectedContactP.Province;
            mskTxtZip.Text = selectedContactP.Zip;
            txtEmailAdd.Text = selectedContactP.Email;
            cboEmail.SelectedItem = selectedContactP.Email;
            mskTxtPhone.Text = selectedContactP.Phone;
            cboPhone.SelectedItem = selectedContactP.PhoneType;
            if (selectedContactP.PathProfilePicture != "")
            {
                picAddContactPicture.ImageLocation = selectedContactP.PathProfilePicture;
                picAddContactPicture.Tag = selectedContactP.PathProfilePicture;
            }
            else if (selectedContactP.PathProfilePicture == "")
            {
                picAddContactPicture.Image = Properties.Resources.defaultImage;

                //store the image path to tag property
                picAddContactPicture.Tag = Properties.Resources.defaultImage;
            }

        }


        /// <summary>
        /// When Add Photo is clicked, store the photo path and display.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = Environment.CurrentDirectory;

            openFileDialog.Filter = "Image Files (*.bmp; *jpg;*.jpeg;*.png)|*.bmp; *.jpg; *.jpeg; *.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picAddContactPicture.ImageLocation = openFileDialog.FileName;

                picAddContactPicture.Tag = openFileDialog.FileName;

            }
        }

        /// <summary>
        /// When Save button clicked, distinguish if the secondary form is from add or edit,
        /// if it is from add, write to contacts.txt and create a note file
        /// if it is from edit, read contacts.txt and write again with the changes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            string noteFileNamePath = "";

            ManagerForm managerForm = new ManagerForm();

            if (txtFirstNameAdd.Text == "" || txtLastNameAdd.Text =="" || 
                txtLastNameAdd.Text.Length < 2 || txtLastNameAdd.Text.Length < 2)
            {
                MessageBox.Show("FirstName and Last Name are required!" +
                    "\r\nName should be more than 2 characters");
               
            }
            else
            {
                //When Add -Save is clicked
                if (checkedIndex == -1)
                {
                    
                    this.DialogResult = DialogResult.OK;

                    pathProfilePicture = (string)picAddContactPicture.Tag;

                    //send the user typed data to contact constructor to save
                    currentContact = new Contact(txtFirstNameAdd.Text, txtLastNameAdd.Text, addressType,
                        txtStreetAdd.Text, txtCityAdd.Text, province, mskTxtZip.Text, txtEmailAdd.Text,
                        emailType, mskTxtPhone.Text, phoneType, pathProfilePicture, noteFileNamePath);
           

                    // Create file and call the method to write to file and create a note file.               
                    using (StreamWriter writer = File.AppendText(managerForm.ContactFile))
                    {
                        currentContact.AppendToContactFile(writer);

                    }

                    this.Close();
                }
                
                //When Edit -Save is clicked
                else if (checkedIndex > -1)
                {
                    this.DialogResult = DialogResult.OK;

                    string[] allLines = File.ReadAllLines(managerForm.ContactFile);

                    List<Contact> editList = new List<Contact>();

                    foreach (string eachLine in allLines)
                    {
                        Contact eachLineContact = new Contact();
                        eachLineContact.SplitLine(eachLine);
                        editList.Add(eachLineContact);
                    }

                    //Store the note file path which was generated when the new person added 
                    noteFileNamePath = editList[checkedIndex].NoteFileNamePath;

                    pathProfilePicture = (string)picAddContactPicture.Tag;

                    //store the filled in/changed data to new object
                    currentContact = new Contact(txtFirstNameAdd.Text, txtLastNameAdd.Text, addressType,
                        txtStreetAdd.Text, txtCityAdd.Text, province, mskTxtZip.Text, txtEmailAdd.Text,
                        emailType, mskTxtPhone.Text, phoneType, pathProfilePicture, noteFileNamePath);

                    //Remove the current checked index from the list
                    editList.RemoveAt(checkedIndex);

                    //Insert the current checked index to the list
                    editList.Insert(checkedIndex, currentContact);

                    //Make the file empty
                    File.WriteAllText(managerForm.ContactFile, "");

                    //Rewrite the whole list 
                    using (StreamWriter writer = File.AppendText(managerForm.ContactFile))
                    {
                        foreach (Contact eachList in editList)
                        {
                            eachList.AppendToContactFileEdit(writer);
                        }

                    }

                    this.Close();

                }

            }

        }

        /// <summary>
        /// Make the zip code to upper case.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mskTxtZip_Leave(object sender, EventArgs e)
        {
            mskTxtZip.Text = mskTxtZip.Text.ToUpper();
        }

        //When comboBox selections are changed, store them.

        private void cboAddressType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAddressType.SelectedIndex != -1)
            {
                addressType = cboAddressType.SelectedItem.ToString();

            }
        }
       
        private void cboProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProvince.SelectedIndex != -1)
            {
                province = cboProvince.SelectedItem.ToString();

            }
        }
       
        private void cboEmail_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEmail.SelectedIndex != -1)
            {
                emailType = cboEmail.SelectedItem.ToString();

            }
        }
        
        private void cboPhone_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPhone.SelectedIndex != -1)
            {
                phoneType = cboPhone.SelectedItem.ToString();

            }
        }
    }
}
