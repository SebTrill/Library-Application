namespace Exam1
{
    public partial class LibraryView : Form
    {
        /// <summary>
        /// This is the Library from the cloud.
        /// </summary>
        public List<Book> Cloud;

        /// <summary>
        /// This is the current library.
        /// </summary>
        public List<Book> CurrentLibrary;

        /// <summary>
        /// This is the Control reference for the LibraryView class.
        /// </summary>
        public BookController LibControl;

        /// <summary>
        /// This is the constructor for LibraryView.
        /// </summary>
        public LibraryView()
        {
            InitializeComponent();
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
    }
}