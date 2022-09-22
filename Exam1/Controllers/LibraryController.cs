using Exam1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1.Controllers
{
    public class LibraryController
    {
        /// <summary>
        /// This is the reference to the LibraryView form.
        /// </summary>
        private LibraryView libView;

        /// <summary>
        /// This is the reference to the LiraryModel class.
        /// </summary>
        private LibraryModel libModel;

        /// <summary>
        /// This is the cloud library.
        /// </summary>
        public List<Book> Cloud = new();

        /// <summary>
        /// This is the current library.
        /// </summary>
        public List<Book> CurrentLibrary = new();

        /// <summary>
        /// This is the constructor of the LibraryController class.
        /// </summary>
        /// <param name="libView">This is the LibraryView reference.</param>
        /// <param name="libModel">This is the LibraryModel reference.</param>
        public LibraryController(LibraryView libView, LibraryModel libModel)
        {
            this.libView = libView;
            this.libModel = libModel;
        }

        /// <summary>
        /// This opens the given book.
        /// </summary>
        /// <param name="b">The book to open.</param>
        /// <param name="page">The page to open the book to.</param>
        public void OpenBook(Book b, int page)
        {

        }

        /// <summary>
        /// This syncs the library.
        /// </summary>
        /// <param name="listBooks">This is the library to sync.</param>
        public void SyncLibrary(List<Book> listBooks)
        {

        }
    }
}
