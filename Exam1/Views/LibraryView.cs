using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public Controllers.LibraryController LibControl;

        /// <summary>
        /// This is the constructor for LibraryView.
        /// </summary>
        public LibraryView(Controllers.LibraryController c)
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}