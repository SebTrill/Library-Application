using Exam1.Controllers;
using Exam1.Models;
using System.ComponentModel;

namespace Exam1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            LibraryController c = new LibraryController(new LibraryModel());
            //LibraryView v = new LibraryView(c.SyncLibrary);
            LibraryView v = new LibraryView(c, c.SyncLibrary);
            c.SetConstructor(v);

            Application.Run(v);
        }
    }

    public delegate void SyncLibraryDelegate(BindingList<BookModel> listBooks);

    public delegate void HandleEvent(BookModel book, int page);
}