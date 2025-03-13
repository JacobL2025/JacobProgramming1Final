using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace JacobProgramming1Final
{
    public partial class MainForm : Form
    {

        private NewBookForm _newBook;
        private List<Bookshelf> _bookshelf;


        public MainForm()
        {
            InitializeComponent();
            _newBook = new NewBookForm(this);
            _bookshelf = new List<Bookshelf>();

            LoadCsvOnOpen();

            ReloadDataGridView();

        }
        private void btnToast_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Toast :)");
        }
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            _newBook.ShowDialog();
        }
        public void AddBook(Bookshelf book)
        {
            book.BookId = _bookshelf.Count + 1;

            _bookshelf.Add(book);

            SaveBooksToFile();

            ReloadDataGridView();
        }
        public void SaveBooksToFile()
        {
            string filepath = Path.Combine(Directory.GetCurrentDirectory(), "JacobsLibrary.csv");

            try
            {
                bool fileExists = File.Exists(filepath);

                using (StreamWriter writer = new StreamWriter(filepath, false))
                {
                    writer.WriteLine("BookId,BookGenre,BookName,BookAuthor");
                    foreach (var BookShelf in _bookshelf)
                    {
                        writer.WriteLine($"{BookShelf.BookId},{BookShelf.BookGenre},{BookShelf.BookName},{BookShelf.BookAuthor}");
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry, We Couldn't Save Your Favorite Book!");
            }
        }
        public void LoadCsvOnOpen()
        {
            string filepath = Path.Combine(Directory.GetCurrentDirectory(), "JacobsLibrary.csv");

            try
            {
                if (File.Exists(filepath))
                {
                    _bookshelf.Clear();

                    string[] lines = File.ReadAllLines(filepath);

                    for (int i = 1;  i < lines.Length; i++)
                    {
                        string[] BookInfo = lines[i].Split(',');

                        if (BookInfo.Length == 4)
                        {
                            Bookshelf book = new Bookshelf
                            {
                                BookId = Convert.ToInt32(BookInfo[0]),
                                BookGenre = BookInfo[1],
                                BookName = BookInfo[2],
                                BookAuthor = BookInfo[3]
                            };

                            _bookshelf.Add(book);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("There are no books saved! Add one to get started!");
                }
            }

            catch (Exception exception)
            {
                MessageBox.Show("Something broke. Please try again, if you dare!");
            }

        }
        private void ReloadDataGridView()
        {
            dgvLibrary.DataSource = null;
            dgvLibrary.DataSource = _bookshelf;

        }

    }
}


    




// so first, i have the form. And in that form is the dgv, and the add book button.
// i know that i will need a function to add a book to that list.
// i have three different sections in that dgv. BookId, BookName, and BookAuthor.
// for the add customer button, I will need to create a new panel/pop-up that will allow me to add books by the specifie info.
// // in that new pop-up, i will have to have it interact with the csv file to save the info to it.
 










// i will also need to make a csv file so that i can save information into it.