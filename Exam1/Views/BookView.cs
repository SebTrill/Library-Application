using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exam1.Models;

namespace Exam1
{
    public partial class BookView : Form
    {
        /// <summary>
        /// This is the Book reference.
        /// </summary>
        public BookModel book_M;

        /// <summary>
        /// This is the BookController reference.
        /// </summary>
        public BookController book_C;

        /// <summary>
        /// This is the constructor for the BookView.
        /// </summary>
        public BookView(BookModel b, BookController c)
        {
            InitializeComponent();
            book_M = b;
            book_C = c;
        }

        /// <summary>
        /// This is the event for the Next button (Goes to the next page).
        /// </summary>
        /// <param name="sender">This is the button.</param>
        /// <param name="e">These are the arguments</param>
        private void next_button_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This is the event for the Previous button (Goes to the previous page).
        /// </summary>
        /// <param name="sender">This is the button.</param>
        /// <param name="e">These are the arguments</param>
        private void previous_button_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This is the event for the Set Bookmark button (sets the bookmark for the current page).
        /// </summary>
        /// <param name="sender">This is the button.</param>
        /// <param name="e">These are the arguments</param>
        private void set_bookmark_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This is the event for the Change Page numeric up-down (Goes to the set page).
        /// </summary>
        /// <param name="sender">This is the numeric up-down.</param>
        /// <param name="e">These are the arguments</param>
        private void change_page_ValueChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This is the event for the Close button (Goes back to the LibraryView).
        /// </summary>
        /// <param name="sender">This is the button.</param>
        /// <param name="e">These are the arguments</param>
        private void back_button_Click(object sender, EventArgs e)
        {

        }
    }
}
