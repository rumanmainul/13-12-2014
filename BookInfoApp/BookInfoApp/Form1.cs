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

namespace BookInfoApp
{
    public partial class Form1 : Form
    {
        Hashtable aHashtable = new Hashtable();
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
           
            if (aHashtable.ContainsKey(isbnToAddTextBox.Text)==true)
            {
                MessageBox.Show("Already added");
                
            }
            else
            {
               
                aHashtable.Add(isbnToAddTextBox.Text, bookDetailsAddTextBox.Text);
                MessageBox.Show("Added Successfully");
            }
          
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            if (aHashtable.ContainsKey(isbnSearchTextBox.Text))
            {
                bookDetailstextBox.Text = (string)aHashtable[isbnSearchTextBox.Text];
            }
            else
            {
                MessageBox.Show("Not Found");

            }
        }
    }
}
