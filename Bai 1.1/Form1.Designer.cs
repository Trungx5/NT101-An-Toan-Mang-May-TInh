namespace Bai_1._1
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
            this.EncryptButton = new System.Windows.Forms.Button();
            this.Bruteforce_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EncryptButton
            // 
            this.EncryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptButton.Location = new System.Drawing.Point(27, 13);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(170, 41);
            this.EncryptButton.TabIndex = 0;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // Bruteforce_button
            // 
            this.Bruteforce_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bruteforce_button.Location = new System.Drawing.Point(254, 12);
            this.Bruteforce_button.Name = "Bruteforce_button";
            this.Bruteforce_button.Size = new System.Drawing.Size(189, 41);
            this.Bruteforce_button.TabIndex = 1;
            this.Bruteforce_button.Text = "Brute-force";
            this.Bruteforce_button.UseVisualStyleBackColor = true;
            this.Bruteforce_button.Click += new System.EventHandler(this.Bruteforce_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 69);
            this.Controls.Add(this.Bruteforce_button);
            this.Controls.Add(this.EncryptButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button Bruteforce_button;
    }
}

