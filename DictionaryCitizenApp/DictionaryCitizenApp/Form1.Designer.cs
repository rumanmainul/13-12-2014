namespace DictionaryCitizenApp
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idAddToTextBox = new System.Windows.Forms.TextBox();
            this.DetailsAddToTextBox = new System.Windows.Forms.TextBox();
            this.idSearchTextBox = new System.Windows.Forms.TextBox();
            this.searchbutton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.showAllbutton = new System.Windows.Forms.Button();
            this.showAllListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Details";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // idAddToTextBox
            // 
            this.idAddToTextBox.Location = new System.Drawing.Point(93, 16);
            this.idAddToTextBox.Name = "idAddToTextBox";
            this.idAddToTextBox.Size = new System.Drawing.Size(196, 20);
            this.idAddToTextBox.TabIndex = 3;
            // 
            // DetailsAddToTextBox
            // 
            this.DetailsAddToTextBox.Location = new System.Drawing.Point(93, 78);
            this.DetailsAddToTextBox.Multiline = true;
            this.DetailsAddToTextBox.Name = "DetailsAddToTextBox";
            this.DetailsAddToTextBox.Size = new System.Drawing.Size(202, 65);
            this.DetailsAddToTextBox.TabIndex = 4;
            // 
            // idSearchTextBox
            // 
            this.idSearchTextBox.Location = new System.Drawing.Point(93, 242);
            this.idSearchTextBox.Name = "idSearchTextBox";
            this.idSearchTextBox.Size = new System.Drawing.Size(215, 20);
            this.idSearchTextBox.TabIndex = 5;
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(348, 239);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(75, 23);
            this.searchbutton.TabIndex = 6;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(348, 14);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // showAllbutton
            // 
            this.showAllbutton.Location = new System.Drawing.Point(133, 304);
            this.showAllbutton.Name = "showAllbutton";
            this.showAllbutton.Size = new System.Drawing.Size(109, 34);
            this.showAllbutton.TabIndex = 6;
            this.showAllbutton.Text = "Show All";
            this.showAllbutton.UseVisualStyleBackColor = true;
            this.showAllbutton.Click += new System.EventHandler(this.showAllbutton_Click);
            // 
            // showAllListBox
            // 
            this.showAllListBox.BackColor = System.Drawing.SystemColors.Menu;
            this.showAllListBox.FormattingEnabled = true;
            this.showAllListBox.Location = new System.Drawing.Point(93, 154);
            this.showAllListBox.Name = "showAllListBox";
            this.showAllListBox.Size = new System.Drawing.Size(215, 56);
            this.showAllListBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 382);
            this.Controls.Add(this.showAllListBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.showAllbutton);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.idSearchTextBox);
            this.Controls.Add(this.DetailsAddToTextBox);
            this.Controls.Add(this.idAddToTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idAddToTextBox;
        private System.Windows.Forms.TextBox DetailsAddToTextBox;
        private System.Windows.Forms.TextBox idSearchTextBox;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button showAllbutton;
        private System.Windows.Forms.ListBox showAllListBox;
    }
}

