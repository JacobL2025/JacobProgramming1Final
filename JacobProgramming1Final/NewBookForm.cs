using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace JacobProgramming1Final
{
    public partial class NewBookForm : Form
    {

        private MainForm _mainForm;
        private int BookCount = 0;

        public NewBookForm(MainForm form)
        {
            InitializeComponent();
            _mainForm = form;
            


        }

        private void AddBook()
        {
            MessageBox.Show("AddBook method called!");
            if (CheckContents(txtBookGenre))
            {
                MessageBox.Show("Please Provide a Book Genre!");
                return;
            }

            if (CheckContents(txtBookName))
            {
                MessageBox.Show("Please Provide a Book Name!");
                return;
            }

            if (CheckContents(txtBookAuthor))
            {
                MessageBox.Show("Please Provide an Author Name!");
                return;
            }

            Bookshelf book = new Bookshelf
            {
                BookId = BookCount,
                BookGenre = txtBookGenre.Text,
                BookName = txtBookName.Text,
                BookAuthor = txtBookAuthor.Text,

            };

            string bookGenre = txtBookGenre.Text;
            string bookTitle = txtBookName.Text;
            string bookAuthor = txtBookAuthor.Text;

            string filepath = Path.Combine(Directory.GetCurrentDirectory(), "JacobsLibrary.csv"); 

            try
            {
                bool fileExists = File.Exists(filepath); 

                using (StreamWriter writer = new StreamWriter(filepath, true))
                {
                    if (!fileExists) 
                    {
                        writer.WriteLine("BookGenre,BookName,BookAuthor"); 
                    }


                    writer.WriteLine($"{book.BookGenre},{book.BookName},{book.BookAuthor}"); 
                }


                _mainForm.AddBook(book);
                BookCount++;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry, We Couldn't Save Your Book!");  
            }

        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddBook();
        }

        private bool CheckContents(Control control)
        {
            return control.Text == ""; // this is going to validate the content within the text boxes
        }
    }



}
