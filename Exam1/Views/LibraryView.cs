using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exam1.Controllers;
using Exam1.Models;

namespace Exam1
{
    public partial class LibraryView : Form
    {
        /// <summary>
        /// This is the current library.
        /// </summary>
        public BindingList<BookModel> CurrentLibrary;

        public List<string> titleList = new();

        /// <summary>
        /// This is the Control reference for the LibraryView class.
        /// </summary>
        public LibraryController LibControl;

        /// <summary>
        /// The delegate responsible for decoupling the 
        /// </summary>
        SyncLibraryDelegate SyncDel;

        /// <summary>
        /// This is the constructor for LibraryView.
        /// </summary>
        public LibraryView(LibraryController c, SyncLibraryDelegate colin_sucks)
        {
            InitializeComponent();
            LibControl = c;
            SyncDel = colin_sucks;
            BindingList<BookModel> list = c.ReadFile();
            CurrentLibrary = list;

            foreach (BookModel b in CurrentLibrary) if(b.Synced == true) titleList.Add(b.book.Title);
            ux_listBox.DataSource = titleList;
        }

        private void OpenBook_Click(object sender, EventArgs e)
        {
            BookModel model = new(new Book(new List<string>(), ""), true);
            foreach (BookModel b in CurrentLibrary)
            {
                if (b.book.Title == ux_listBox.SelectedItem) model = b;
            }
            BookController controller = new BookController(model);
            BookView view = new BookView(model, controller);
            controller.SetConstructor(view);

            LibControl.OpenBook(model.book, model.book.CurrentPage);
        }


        private void synchronize_button_Click(object sender, EventArgs e)
        {
            SyncDel(CurrentLibrary);
        }
    }
}