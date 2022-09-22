using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1.Models
{
    public class LibraryModel
    {
        /// <summary>
        /// This is the current Library.
        /// </summary>
        public List<Book> CurrentLibrary = new();

        /// <summary>
        /// This is the cloud Library.
        /// </summary>
        public List<Book> CloudLibrary = new();

        /// <summary>
        /// This is the constructor for the LibraryModel.
        /// </summary>
        public LibraryModel()
        {

        }
    }
}
