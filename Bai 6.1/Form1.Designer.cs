namespace Bai_6._1
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
            this.PlainText_TextBox = new System.Windows.Forms.RichTextBox();
            this.Key1_TextBox = new System.Windows.Forms.TextBox();
            this.Key2_TextBox = new System.Windows.Forms.TextBox();
            this.Encrypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CipherText_TextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlainText_TextBox
            // 
            this.PlainText_TextBox.Location = new System.Drawing.Point(12, 43);
            this.PlainText_TextBox.Name = "PlainText_TextBox";
            this.PlainText_TextBox.Size = new System.Drawing.Size(806, 187);
            this.PlainText_TextBox.TabIndex = 0;
            this.PlainText_TextBox.Text = "";
            // 
            // Key1_TextBox
            // 
            this.Key1_TextBox.Location = new System.Drawing.Point(139, 236);
            this.Key1_TextBox.Name = "Key1_TextBox";
            this.Key1_TextBox.Size = new System.Drawing.Size(112, 20);
            this.Key1_TextBox.TabIndex = 1;
            // 
            // Key2_TextBox
            // 
            this.Key2_TextBox.Location = new System.Drawing.Point(139, 276);
            this.Key2_TextBox.Name = "Key2_TextBox";
            this.Key2_TextBox.Size = new System.Drawing.Size(112, 20);
            this.Key2_TextBox.TabIndex = 2;
            // 
            // Encrypt
            // 
            this.Encrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Encrypt.Location = new System.Drawing.Point(278, 232);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(540, 64);
            this.Encrypt.TabIndex = 3;
            this.Encrypt.Text = "Encrypt!";
            this.Encrypt.UseVisualStyleBackColor = true;
            this.Encrypt.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Plain Text";
            // 
            // CipherText_TextBox
            // 
            this.CipherText_TextBox.Location = new System.Drawing.Point(12, 321);
            this.CipherText_TextBox.Name = "CipherText_TextBox";
            this.CipherText_TextBox.Size = new System.Drawing.Size(806, 175);
            this.CipherText_TextBox.TabIndex = 5;
            this.CipherText_TextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Key 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Key 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 525);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CipherText_TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Encrypt);
            this.Controls.Add(this.Key2_TextBox);
            this.Controls.Add(this.Key1_TextBox);
            this.Controls.Add(this.PlainText_TextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox PlainText_TextBox;
        private System.Windows.Forms.TextBox Key1_TextBox;
        private System.Windows.Forms.TextBox Key2_TextBox;
        private System.Windows.Forms.Button Encrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox CipherText_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

