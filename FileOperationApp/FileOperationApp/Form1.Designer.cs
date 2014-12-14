namespace FileOperationApp
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
            this.CustomerinfoTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.showAllTextBox = new System.Windows.Forms.TextBox();
            this.showAllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Info";
            // 
            // CustomerinfoTextBox
            // 
            this.CustomerinfoTextBox.Location = new System.Drawing.Point(163, 59);
            this.CustomerinfoTextBox.Name = "CustomerinfoTextBox";
            this.CustomerinfoTextBox.Size = new System.Drawing.Size(184, 20);
            this.CustomerinfoTextBox.TabIndex = 1;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(382, 56);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // showAllTextBox
            // 
            this.showAllTextBox.Location = new System.Drawing.Point(163, 183);
            this.showAllTextBox.Multiline = true;
            this.showAllTextBox.Name = "showAllTextBox";
            this.showAllTextBox.Size = new System.Drawing.Size(184, 171);
            this.showAllTextBox.TabIndex = 1;
            // 
            // showAllButton
            // 
            this.showAllButton.Location = new System.Drawing.Point(369, 183);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(75, 23);
            this.showAllButton.TabIndex = 2;
            this.showAllButton.Text = "Show All";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 421);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.showAllTextBox);
            this.Controls.Add(this.CustomerinfoTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CustomerinfoTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox showAllTextBox;
        private System.Windows.Forms.Button showAllButton;
    }
}

