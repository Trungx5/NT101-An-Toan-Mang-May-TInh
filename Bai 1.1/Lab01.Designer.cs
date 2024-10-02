namespace Bai_1._1
{
    partial class Lab01
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
            this.Bai01_button = new System.Windows.Forms.Button();
            this.Bai06_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bai01_button
            // 
            this.Bai01_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bai01_button.Location = new System.Drawing.Point(13, 13);
            this.Bai01_button.Name = "Bai01_button";
            this.Bai01_button.Size = new System.Drawing.Size(593, 35);
            this.Bai01_button.TabIndex = 0;
            this.Bai01_button.Text = "Bai 1";
            this.Bai01_button.UseVisualStyleBackColor = true;
            this.Bai01_button.Click += new System.EventHandler(this.Bai01_button_Click);
            // 
            // Bai06_Button
            // 
            this.Bai06_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bai06_Button.Location = new System.Drawing.Point(13, 68);
            this.Bai06_Button.Name = "Bai06_Button";
            this.Bai06_Button.Size = new System.Drawing.Size(593, 35);
            this.Bai06_Button.TabIndex = 1;
            this.Bai06_Button.Text = "Bai 6";
            this.Bai06_Button.UseVisualStyleBackColor = true;
            this.Bai06_Button.Click += new System.EventHandler(this.Bai06_Button_Click);
            // 
            // Lab01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 128);
            this.Controls.Add(this.Bai06_Button);
            this.Controls.Add(this.Bai01_button);
            this.Name = "Lab01";
            this.Text = "Lab01";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bai01_button;
        private System.Windows.Forms.Button Bai06_Button;
    }
}