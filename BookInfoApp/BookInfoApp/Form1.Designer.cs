namespace BookInfoApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.isbnToAddTextBox = new System.Windows.Forms.TextBox();
            this.bookDetailsAddTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.isbnSearchTextBox = new System.Windows.Forms.TextBox();
            this.bookDetailstextBox = new System.Windows.Forms.TextBox();
            this.findButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN: ";
            // 
            // isbnToAddTextBox
            // 
            this.isbnToAddTextBox.Location = new System.Drawing.Point(111, 25);
            this.isbnToAddTextBox.Name = "isbnToAddTextBox";
            this.isbnToAddTextBox.Size = new System.Drawing.Size(135, 20);
            this.isbnToAddTextBox.TabIndex = 1;
            // 
            // bookDetailsAddTextBox
            // 
            this.bookDetailsAddTextBox.Location = new System.Drawing.Point(111, 66);
            this.bookDetailsAddTextBox.Multiline = true;
            this.bookDetailsAddTextBox.Name = "bookDetailsAddTextBox";
            this.bookDetailsAddTextBox.Size = new System.Drawing.Size(135, 43);
            this.bookDetailsAddTextBox.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(302, 22);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Book Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "ISBN:";
            // 
            // isbnSearchTextBox
            // 
            this.isbnSearchTextBox.Location = new System.Drawing.Point(111, 162);
            this.isbnSearchTextBox.Name = "isbnSearchTextBox";
            this.isbnSearchTextBox.Size = new System.Drawing.Size(135, 20);
            this.isbnSearchTextBox.TabIndex = 1;
            // 
            // bookDetailstextBox
            // 
            this.bookDetailstextBox.Location = new System.Drawing.Point(111, 210);
            this.bookDetailstextBox.Multiline = true;
            this.bookDetailstextBox.Name = "bookDetailstextBox";
            this.bookDetailstextBox.Size = new System.Drawing.Size(135, 43);
            this.bookDetailstextBox.TabIndex = 2;
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(302, 159);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 23);
            this.findButton.TabIndex = 3;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 418);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.bookDetailstextBox);
            this.Controls.Add(this.isbnSearchTextBox);
            this.Controls.Add(this.bookDetailsAddTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.isbnToAddTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox isbnToAddTextBox;
        private System.Windows.Forms.TextBox bookDetailsAddTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox isbnSearchTextBox;
        private System.Windows.Forms.TextBox bookDetailstextBox;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Label label4;
    }
}

