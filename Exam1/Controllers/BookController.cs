using Exam1.Objects;
using Exam1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    public class BookController
    {
        /// <summary>
        /// This is the BookView reference.
        /// </summary>
        private BookView book_V;

        /// <summary>
        /// This is the Book class reference (AKA the Book Model).
        /// </summary>
        private BookModel book_M;

        /// <summary>
        /// This is the list integers that represent the bookmarks (page numbers).
        /// </summary>
        public List<int> Bookmarks = new();

        /// <summary>
        /// This is the page number of the current page.
        /// </summary>
        public int CurrentPage;

        /// <summary>
        /// This is the controller for the BookController.
        /// </summary>
        /// <param name="v">This is the BookView reference.</param>
        /// <param name="b">This is the Book reference.</param>
        public BookController(BookView v, BookModel b)
        {
            book_V = v;
            book_M = b;
        }

        /// <summary>
        /// This sets the constructor.
        /// </summary>
        /// <param name="bv">This is the BookView reference.</param>
        public void SetConstructor(BookView bv)
        {
            book_V = bv;
        }

        /// <summary>
        /// This flips to the next page of the book.
        /// </summary>
        public void FlipPageForward()
        {

        }

        /// <summary>
        /// Flip to the previous page of the book.
        /// </summary>
        public void FlipPageBack()
        {

        }

        /// <summary>
        /// This sets a bookmark for the current book.
        /// </summary>
        /// <param name="i">This is the page number.</param>
        /// <returns>Return if a bookmark can or can't be created.</returns>
        public bool SetBookMark(int i)
        {
            if (Bookmarks.Count() < 6)
            {
                Bookmarks.Add(i);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// This goes to the specific page in the book.
        /// </summary>
        /// <param name="i">This is the page number.</param>
        public void GoToPage(int i)
        {

        }

        /// <summary>
        /// This opens a book into the View.
        /// </summary>
        /// <param name="b">This is the book to open.</param>
        /// <param name="i">Current page to open book to.</param>
        public void OpenBook(Book b, int i)
        {

        }

        /// <summary>
        /// Closes the book in the View.
        /// </summary>
        /// <returns>Returns the page number (page when closed).</returns>
        public int CloseBook()
        {
            return 0;
        }

        public void SyncLibrary(Library l)
        {

        }
    }
}
