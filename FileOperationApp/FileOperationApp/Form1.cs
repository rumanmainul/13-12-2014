using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;

namespace FileOperationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string customerInfo = CustomerinfoTextBox.Text;
            File.AppendAllText("e:\\info.txt", customerInfo + Environment.NewLine);
            CustomerinfoTextBox.Clear();
            MessageBox.Show("Save Successfully");
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            string file = File.ReadAllText("e:\\info.txt");
            showAllTextBox.Text = file;
        }
    }
}
