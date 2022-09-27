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
using Exam1.Models;

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
        /// The delegate responsible for decoupling the 
        /// </summary>
        SyncLibraryDelegate SyncDel;

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
            return new Book(new List<string>());
        }

        /// <summary>
        /// Sync the Library.
        /// </summary>
        /// <param name="book_list">This is the list of books to sync.</param>
        public void Sync(List<Book> book_list)
        {
            SyncDel(book_list);
        }

        private void OpenBook_Click(object sender, EventArgs e)
        {

        }

        private void booklist_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void synchronize_button_Click(object sender, EventArgs e)
        {

        }
    }
}