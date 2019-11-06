/* Name: Yumi Lee
Assignment: Assignment3
This program is a Contact Manager
Course Code: PROG-1815-1 Programming Concepts2
Professor: Aneta Canhoto
Date: July 24, 2019 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public class Contact
    {
        public Contact()
        {
        }

        public Contact(string pathProfilePictureP)
        {
            pathProfilePicture = pathProfilePictureP;
        }

        List<Note> noteList = new List<Note>();

        string firstName;
        public string FirstName
        {
            get => firstName;
        }

        string lastName;
        public string LastName
        {
            get => lastName;
        }

        string addressType;
        public string AddressType
        {
            get => addressType;
        }

        string street;
        public string Street
        {
            get => street; 
        }

        string city;
        public string City
        {
            get => city;
        }

        string province;
        public string Province
        {
            get => province;
        }

        string zip;
        public string Zip
        {
            get => zip;
        }

        string email;
        public string Email
        {
            get => email;
        }

        string emailType;
        public string EmailType
        {
            get => emailType;
        }

        string phone;
        public string Phone
        {
            get => phone;
        }

        string phoneType;
        public string PhoneType
        {
            get => phoneType;
        }

        string pathProfilePicture;
        public string PathProfilePicture
        {
            get => pathProfilePicture;
        }

        string noteFileNamePath = "";
        public string NoteFileNamePath
        {
            get => noteFileNamePath;
        }

        public Contact(string firstNameP, string lastNameP, string addressTypeP, string streetP, 
            string cityP, string provinceP, string zipP, string emailP, string emailTypeP, string phoneP, 
            string phoneTypeP, string pathProfilePictureP, string noteFileNamePathP)
        {
            firstName = firstNameP;
            lastName = lastNameP;
            addressType = addressTypeP;
            street = streetP;
            city = cityP;
            province = provinceP;
            zip = zipP;
            email = emailP;
            emailType = emailTypeP;
            phone = phoneP;
            phoneType = phoneTypeP;
            pathProfilePicture = pathProfilePictureP;
            noteFileNamePath = noteFileNamePathP;

        }

        /// <summary>
        /// Split by delimiter and store each item.
        /// </summary>
        /// <param name="eachLineP"></param>
        internal void SplitLine(string eachLineP)
        {
            string[] lineData = eachLineP.Split('|');
            firstName = lineData[0];
            lastName = lineData[1];
            addressType = lineData[2];
            street = lineData[3];
            city = lineData[4];
            province = lineData[5];
            zip = lineData[6];
            email = lineData[7];
            emailType = lineData[8];
            phone = lineData[9];
            phoneType = lineData[10];
            pathProfilePicture = lineData[11];
            noteFileNamePath = lineData[12];

        }

        //When edit- save clicked, write to contacts.txt and create a note file.
        public void AppendToContactFile(StreamWriter writer)
        {
            noteFileNamePath = $"{firstName.Substring(0, 2)}{lastName.Substring(0, 2)}" +
            $"{DateTime.Now.Ticks}.txt";

            using (StreamWriter noteWriter = File.AppendText(noteFileNamePath))
            {

            }

            writer.WriteLine($"{firstName}|{lastName}|{addressType}|{street}|{city}|{province}|" +
                $"{zip}|{email}|{emailType}|{phone}|{PhoneType}|{pathProfilePicture}|{noteFileNamePath}");

        }
       
        /// <summary>
        /// When add-save clicked, write to contacts.txt
        /// </summary>
        /// <param name="writer"></param>
        public void AppendToContactFileEdit(StreamWriter writer)
        {

                writer.WriteLine($"{firstName}|{lastName}|{addressType}|{street}|{city}|{province}|" +
                $"{zip}|{email}|{emailType}|{phone}|{PhoneType}|{PathProfilePicture}|{noteFileNamePath}");
           
        }

        /// <summary>
        /// To ruturn name format in listbox in main form
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{firstName} {lastName}";
        }
    }
}
