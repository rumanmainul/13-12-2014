using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryCitizenApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<int, string> citizenDictionary = new Dictionary<int, string>();
        private void SaveButton_Click(object sender, EventArgs e)
        {
            bool find = citizenDictionary.ContainsKey(Convert.ToInt32(idAddToTextBox.Text));
            if (find)
            {
                MessageBox.Show("allready added");
            }
            else
            {
                citizenDictionary.Add(Convert.ToInt32(idAddToTextBox.Text), DetailsAddToTextBox.Text);
                MessageBox.Show("Successfully Added");
            }
          
           
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            bool find = citizenDictionary.ContainsKey(Convert.ToInt32(idSearchTextBox.Text));
            if (find)
            {
                string citizenDetails = citizenDictionary[Convert.ToInt32(idSearchTextBox.Text)];
                showAllListBox.Items.Add(citizenDetails);
            }
            else
            {
                MessageBox.Show("Not Found");
            }
        }

        private void showAllbutton_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<int, string> allResult in citizenDictionary)
            {
                //showResultlabel.Text = allResult.Key.ToString() + "->" + allResult.Value+"\n";
                showAllListBox.Items.Add(allResult.Key.ToString() + "->" + allResult.Value);
            }
        }
    }
}
