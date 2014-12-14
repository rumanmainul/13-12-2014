using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace HashTableWindowsApp
{
    public partial class BookInfoUI : Form
    {
        public BookInfoUI()
        {
            InitializeComponent();
        }

        Hashtable aHashtable = new Hashtable();
        private void addBookButton_Click(object sender, EventArgs e)
        {
            string isbnOfBook = isbnTextBox.Text;
            string bookName = bookDetailsListBox.Text;
            aHashtable.Add(isbnOfBook, bookName);
            MessageBox.Show("asdasdasdasd");

            isbnTextBox.Text = "";
            bookDetailsListBox.Text = "";
            
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            string searchIsbn = searchIsbnTextBox.Text;
                string bookdetails = (string)aHashtable[searchIsbn];
                bookNameListBox.Items.Add(bookdetails);
           
            
         
        }
    }
}
