using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1.Models
{
    public class BookModel
    {
        /// <summary>
        /// This is the list of bookmarks.
        /// </summary>
        private List<int> Bookmarks = new List<int>(5);

        /// <summary>
        /// This is the saved page number.
        /// </summary>
        private int SavedPageNumber { get; set; }

        /// <summary>
        /// This tells us whether or not the book should be shown in the list.
        /// </summary>
        private bool Synced { get; set; }

        /// <summary>
        /// This is the Book reference.
        /// </summary>
        public Book book;

        /// <summary>
        /// This is the constructor for the BookModel class.
        /// </summary>
        /// <param name="b">This is the Book reference.</param>
        public BookModel(Book b, bool bl)
        {
            this.book = b;
            this.Synced = bl;
        }
    }
}
