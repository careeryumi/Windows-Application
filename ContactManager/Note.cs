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
    class Note
    {
        
        string note;
        string timeStamp;

        public Note()
        {

        }

        /// <summary>
        /// Save note data and format time stamp
        /// </summary>
        /// <param name="noteP"></param>
        public Note(string noteP)
        {
         
            string today = DateTime.Today.ToString("dd/MM/yyyy");
            string time = DateTime.Now.ToShortTimeString().ToString();

            timeStamp =  $"{today} - {time}";

            note = noteP;
            
        }

        /// <summary>
        /// to return printing format in text box.
        /// </summary>
        /// <returns></returns>
        public string ReturnNotes()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"{timeStamp}");
            builder.AppendLine($"{note}");
            builder.AppendLine();

            return builder.ToString();
        }

        /// <summary>
        /// to Write to the note file
        /// </summary>
        /// <param name="noteWriterP"></param>
        public void AppendToNoteFile(StreamWriter noteWriterP)
        {
            noteWriterP.Write($"{timeStamp}\r\n{note}|");
        }

    }
}
