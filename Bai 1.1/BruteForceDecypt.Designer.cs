using System.Windows.Forms;

namespace Bai_1._1
{
    partial class BruteForceDecypt
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
            this.EncryptedTextBox = new System.Windows.Forms.RichTextBox();
            this.EncryptLabel = new System.Windows.Forms.Label();
            this.Bruteforce_button = new System.Windows.Forms.Button();
            this.AllPlainTextBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // EncryptedTextBox
            // 
            this.EncryptedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EncryptedTextBox.Location = new System.Drawing.Point(12, 41);
            this.EncryptedTextBox.Name = "EncryptedTextBox";
            this.EncryptedTextBox.Size = new System.Drawing.Size(775, 165);
            this.EncryptedTextBox.TabIndex = 0;
            this.EncryptedTextBox.Text = "";
            // 
            // EncryptLabel
            // 
            this.EncryptLabel.AutoSize = true;
            this.EncryptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptLabel.Location = new System.Drawing.Point(12, 13);
            this.EncryptLabel.Name = "EncryptLabel";
            this.EncryptLabel.Size = new System.Drawing.Size(157, 25);
            this.EncryptLabel.TabIndex = 1;
            this.EncryptLabel.Text = "Encrypted Text";
            // 
            // Bruteforce_button
            // 
            this.Bruteforce_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bruteforce_button.Location = new System.Drawing.Point(289, 212);
            this.Bruteforce_button.Name = "Bruteforce_button";
            this.Bruteforce_button.Size = new System.Drawing.Size(193, 37);
            this.Bruteforce_button.TabIndex = 3;
            this.Bruteforce_button.Text = "Brute-force!";
            this.Bruteforce_button.UseVisualStyleBackColor = true;
            this.Bruteforce_button.Click += new System.EventHandler(this.Bruteforce_button_Click);
            // 
            // AllPlainTextBox
            // 
            this.AllPlainTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AllPlainTextBox.FormattingEnabled = true;
            this.AllPlainTextBox.HorizontalExtent = 99;
            this.AllPlainTextBox.HorizontalScrollbar = true;
            this.AllPlainTextBox.Location = new System.Drawing.Point(12, 269);
            this.AllPlainTextBox.Name = "AllPlainTextBox";
            this.AllPlainTextBox.ScrollAlwaysVisible = true;
            this.AllPlainTextBox.Size = new System.Drawing.Size(776, 355);
            this.AllPlainTextBox.TabIndex = 4;
            this.AllPlainTextBox.SelectedIndexChanged += new System.EventHandler(this.AllPlainTextBox_SelectedIndexChanged);
            this.AllPlainTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AllPlainTextBox_KeyDown);
            // 
            // BruteForceDecypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 632);
            this.Controls.Add(this.AllPlainTextBox);
            this.Controls.Add(this.Bruteforce_button);
            this.Controls.Add(this.EncryptLabel);
            this.Controls.Add(this.EncryptedTextBox);
            this.Name = "BruteForceDecypt";
            this.Text = "BruteForceDecypt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox EncryptedTextBox;
        private System.Windows.Forms.Label EncryptLabel;
        private System.Windows.Forms.Button Bruteforce_button;
        private System.Windows.Forms.ListBox AllPlainTextBox;
        //create event Listbox Keydown

    }
}