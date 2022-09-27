using Exam1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public List<string> titleList = new();

        /// <summary>
        /// This is the constructor of the LibraryController class.
        /// </summary>
        /// <param name="libModel">This is the LibraryModel reference.</param>
        public LibraryController(LibraryModel libModel)
        {
            this.libModel = libModel;
            this.libView = new LibraryView(this, SyncLibrary);
        }

        public BindingList<BookModel> ReadFile()
        {
            BindingList<BookModel> bList = new BindingList<BookModel>();

            if (File.Exists("BookData.txt"))
            {
                StreamReader sr = new StreamReader("BookData.txt");
                while (!sr.EndOfStream)
                {
                    string[] bookData = sr.ReadLine().Split(',');
                    string[] bookContent = sr.ReadLine().Split('|');
                    string empty = sr.ReadLine();

                    string title = bookData[0];
                    bool synced;
                    if (bookData[1] == "true") synced = true;
                    else synced = false;
                    string[] bookmarks = bookData[2].Split(':');

                    List<string> contentList = new List<string>();
                    foreach (string s in bookContent) contentList.Add(s);

                    Book b = new Book(contentList, title);
                    BookModel bookM = new BookModel(b, synced);

                    bList.Add(bookM);
                }
                sr.Close();
            }
            return bList;
        }

        /// <summary>
        /// This sets the constructor.
        /// </summary>
        /// <param name="lv">This is the reference to the Library View.</param>
        public void SetConstructor(LibraryView lv)
        {
            libView = lv;
        }

        /// <summary>
        /// This opens the given book.
        /// </summary>
        /// <param name="b">The book to open.</param>
        /// <param name="page">The page to open the book to.</param>
        public void OpenBook(Book b, int page)
        {
            BookController c = new BookController(new BookModel(b, true));
            BookView v = new BookView(new BookModel(b, true), c);
            c.SetConstructor(v);
            v.book_C.GoToPage(page);

            v.ux_label.Text = v.book_M.book.Pages[v.book_M.book.CurrentPage];
            v.Show();
        }

        /// <summary>
        /// This syncs the library.
        /// </summary>
        /// <param name="listBooks">This is the library to sync.</param>
        public void SyncLibrary(BindingList<BookModel> listBooks)
        {
            foreach (BookModel b in listBooks) if (b.Synced == false) b.Synced = true;
        }
    }
}
