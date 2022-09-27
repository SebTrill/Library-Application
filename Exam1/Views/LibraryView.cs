using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exam1.Controllers;

namespace Exam1
{
    public partial class LibraryView : Form
    {
        /// <summary>
        /// This is the current library.
        /// </summary>
        public List<Book> CurrentLibrary;

        /// <summary>
        /// This is the Control reference for the LibraryView class.
        /// </summary>
        public LibraryController LibControl;

        /// <summary>
        /// This is the constructor for LibraryView.
        /// </summary>
        public LibraryView(LibraryController c)
        {
            InitializeComponent();
            LibControl = c;
        }

        /// <summary>
        /// This picks the book from the current library.
        /// </summary>
        /// <returns>Returns the book from the library.</returns>
        public Book PickBook()
        {
            return new Book();
        }

        /// <summary>
        /// Sync the Library.
        /// </summary>
        /// <param name="book_list">This is the list of books to sync.</param>
        public void Sync(List<Book> book_list)
        {

        }

        /// <summary>
        /// This is the event for the Open Book button.
        /// </summary>
        /// <param name="sender">This is the button.</param>
        /// <param name="e">These are the arguments.</param>
        private void OpenBook_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This is the event for the Synchronize button.
        /// </summary>
        /// <param name="sender">This is the button.</param>
        /// <param name="e">These are the arguments.</param>
        private void synchronize_button_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This is the event for when there is an ItemSelected in the listbox.
        /// </summary>
        /// <param name="sender">This is listbox.</param>
        /// <param name="e">These are the arguments.</param>
        private void booklist_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}