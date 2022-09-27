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
        /// This is the page number of the current page.
        /// </summary>
        public int CurrentPage { get; set; }

        public string Title { get; set; }

        /// <summary>
        /// These are the pages of the book.
        /// </summary>
        public List<string> Pages;

        /// <summary>
        /// This is the Book constructor.
        /// </summary>
        public Book(List<string> strings)
        {
            Pages = strings;
        }
    }
}
