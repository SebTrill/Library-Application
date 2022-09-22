using Exam1.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    public class Book
    {
        /// <summary>
        /// Title of the book.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The name of the author of the book.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// This is the page number of the current page.
        /// </summary>
        public int CurrentPage { get; set; }

        /// <summary>
        /// These are the pages of the book.
        /// </summary>
        public List<Page> Pages;

        /// <summary>
        /// This is the Book constructor.
        /// </summary>
        public Book()
        {

        }
    }
}
