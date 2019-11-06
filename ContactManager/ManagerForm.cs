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
    public partial class ManagerForm : Form
    {
     
        string contactFile = "contacts.txt";

        Contact selectedContact;

        //To save to contact.txt in the secondary form
        public string ContactFile
        {
            get => contactFile;
        }

        //To check which one is clicked in the list box
        int selectedIndex;
        public int SelectedIndex
        {
            get => selectedIndex;
        }

        /// <summary>
        /// When the main form loaded check if contacts.txt already exist,
        /// if it is exist, read it and put it into Contact object, 
        /// split by delimiter, put the itmes in list box and display. 
        /// </summary>
        public ManagerForm()
        {
            InitializeComponent();
            pnlDetails.Enabled = false;

            if (File.Exists(contactFile))
            {
                string[] allLines = File.ReadAllLines(contactFile);

                foreach (string eachLine in allLines)
                {
                    Contact eachLineContact = new Contact();
                    eachLineContact.SplitLine(eachLine);

                    lstContacts.Items.Add(eachLineContact);

                }
            }
                                 
        }


        /// <summary>
        /// When Add contact button is clicked, update the names in listbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddContact_Click(object sender, EventArgs e)
        {
            //To set no person is selected when Add contact clicked
            selectedIndex = -1;

            //initialize selectedIndex in AddContactForm
            AddContactForm addContactForm = new AddContactForm(selectedIndex);

            //Update the names in listBox
            if (addContactForm.ShowDialog(this) == DialogResult.OK)
            {
                lstContacts.Items.Clear();

                string[] allLines = File.ReadAllLines(contactFile);

                foreach (string eachLine in allLines)
                {
                    Contact eachLineContact = new Contact();
                    eachLineContact.SplitLine(eachLine);

                    //put the new item to listbox
                    lstContacts.Items.Add(eachLineContact);

                }

            }

            pnlDetails.Enabled = false;

        }

        /// <summary>
        /// When a person is selected, put the object of selected item into contact object 
        /// , get the object items and print in the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndex = lstContacts.SelectedIndex;

            if (lstContacts.SelectedIndex != -1)
            {
                pnlDetails.Enabled = true;

                selectedContact = (Contact)lstContacts.SelectedItem;
                txtFirstName.Text = selectedContact.FirstName;
                txtLastName.Text = selectedContact.LastName;
                txtAddressType.Text = selectedContact.AddressType;
                txtStreet.Text = selectedContact.Street;
                txtCity.Text = selectedContact.City;
                txtProvince.Text = selectedContact.Province;
                txtZip.Text = selectedContact.Zip;
                txtEmail.Text = selectedContact.Email;
                txtEmailType.Text = selectedContact.Email;
                txtPhone.Text = selectedContact.Phone;
                txtPhoneType.Text = selectedContact.PhoneType;

                if (selectedContact.PathProfilePicture != "")
                {
                    picPicture.ImageLocation = selectedContact.PathProfilePicture;
                }
                else if(selectedContact.PathProfilePicture == "")
                {
                    picPicture.Image = Properties.Resources.defaultImage;
                }

                txtNotes.Clear();

                //Note file printing
                ReadSelectedNoteFilePrint();

            }
        }

        /// <summary>
        /// Read all text from the correspond note file,
        /// split each note with delimiter '|', 
        /// put them to list to remove the unwanted blank item,
        /// reverse the list to print in recent order.
        /// </summary>
        private void ReadSelectedNoteFilePrint()
        {
            string fileContent = File.ReadAllText(selectedContact.NoteFileNamePath);

            string[] noteArray = fileContent.Split('|');

            List<string> noteList = new List<string>(noteArray);

            //Last blank item was included in the array, not need to print it
            noteList.RemoveAt(noteList.Count - 1);

            noteList.Reverse();

            foreach (string eachNotePrint in noteList)
            {
                txtNotes.Text += $"{eachNotePrint.ToString()}\r\n\r\n";

            }
        }

        /// <summary>
        /// When Edit button clicked, Read contacts.txt,
        /// save them into listbox to print when the secondary form opened.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditContact_Click(object sender, EventArgs e)
        {
            selectedIndex = lstContacts.SelectedIndex;
 
            AddContactForm addContactForm = new AddContactForm(selectedContact, selectedIndex);

            if (addContactForm.ShowDialog(this) == DialogResult.OK)
            {

                lstContacts.Items.Clear();

                string[] allLines = File.ReadAllLines(contactFile);

                foreach (string eachLine in allLines)
                {
                    Contact eachLineContact = new Contact();
                    eachLineContact.SplitLine(eachLine);

                    lstContacts.Items.Add(eachLineContact);

                }
            }

            pnlDetails.Enabled = false;

        }

        /// <summary>
        /// When Add note clicked, write to each note file,
        /// print in the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddNote_Click(object sender, EventArgs e)
        {         

            Note note = new Note(txtTakeANote.Text);

            List<string> noteList = new List<string>();

            //Format the notes and return and add to the list
            noteList.Add(note.ReturnNotes());

           //reverse the list to print in recent order.
            noteList.Reverse();

            //Clear the notes 
            txtNotes.Clear();

            using (StreamWriter writer = File.AppendText(selectedContact.NoteFileNamePath))
            {
                note.AppendToNoteFile(writer);
            }

            //To print to txtNotes
            ReadSelectedNoteFilePrint();

            txtTakeANote.Clear();
        }

    }
}
