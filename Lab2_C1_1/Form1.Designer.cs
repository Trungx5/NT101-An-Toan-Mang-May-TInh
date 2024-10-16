namespace Lab2_C1_1
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
            this.Bit8PrimeButton = new System.Windows.Forms.Button();
            this.Bit16PrimeButton = new System.Windows.Forms.Button();
            this.Bit64PrimeButton = new System.Windows.Forms.Button();
            this.PrimeListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckPrimeTextBox = new System.Windows.Forms.TextBox();
            this.CheckPrimeButton = new System.Windows.Forms.Button();
            this.TrueFalseTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FirstNumberTextBox = new System.Windows.Forms.TextBox();
            this.SecondNumberTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GCDCalcButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.BaseNumberTextBox = new System.Windows.Forms.TextBox();
            this.ExponentTextBox = new System.Windows.Forms.TextBox();
            this.ModulusTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ModularCheckButton = new System.Windows.Forms.Button();
            this.ResultModularTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generate Prime Numbers:";
            // 
            // Bit8PrimeButton
            // 
            this.Bit8PrimeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bit8PrimeButton.Location = new System.Drawing.Point(33, 263);
            this.Bit8PrimeButton.Name = "Bit8PrimeButton";
            this.Bit8PrimeButton.Size = new System.Drawing.Size(206, 42);
            this.Bit8PrimeButton.TabIndex = 1;
            this.Bit8PrimeButton.Text = "8-bit";
            this.Bit8PrimeButton.UseVisualStyleBackColor = true;
            this.Bit8PrimeButton.Click += new System.EventHandler(this.Bit8PrimeButton_Click);
            // 
            // Bit16PrimeButton
            // 
            this.Bit16PrimeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bit16PrimeButton.Location = new System.Drawing.Point(33, 329);
            this.Bit16PrimeButton.Name = "Bit16PrimeButton";
            this.Bit16PrimeButton.Size = new System.Drawing.Size(206, 42);
            this.Bit16PrimeButton.TabIndex = 2;
            this.Bit16PrimeButton.Text = "16-bit";
            this.Bit16PrimeButton.UseVisualStyleBackColor = true;
            this.Bit16PrimeButton.Click += new System.EventHandler(this.Bit16PrimeButton_Click_1);
            // 
            // Bit64PrimeButton
            // 
            this.Bit64PrimeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bit64PrimeButton.Location = new System.Drawing.Point(33, 396);
            this.Bit64PrimeButton.Name = "Bit64PrimeButton";
            this.Bit64PrimeButton.Size = new System.Drawing.Size(206, 42);
            this.Bit64PrimeButton.TabIndex = 3;
            this.Bit64PrimeButton.Text = "64-bit";
            this.Bit64PrimeButton.UseVisualStyleBackColor = true;
            this.Bit64PrimeButton.Click += new System.EventHandler(this.Bit64PrimeButton_Click_1);
            // 
            // PrimeListBox
            // 
            this.PrimeListBox.FormattingEnabled = true;
            this.PrimeListBox.Location = new System.Drawing.Point(33, 50);
            this.PrimeListBox.Name = "PrimeListBox";
            this.PrimeListBox.Size = new System.Drawing.Size(206, 186);
            this.PrimeListBox.Sorted = true;
            this.PrimeListBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(300, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Check Prime";
            // 
            // CheckPrimeTextBox
            // 
            this.CheckPrimeTextBox.Location = new System.Drawing.Point(440, 12);
            this.CheckPrimeTextBox.Name = "CheckPrimeTextBox";
            this.CheckPrimeTextBox.Size = new System.Drawing.Size(173, 20);
            this.CheckPrimeTextBox.TabIndex = 6;
            // 
            // CheckPrimeButton
            // 
            this.CheckPrimeButton.Location = new System.Drawing.Point(636, 10);
            this.CheckPrimeButton.Name = "CheckPrimeButton";
            this.CheckPrimeButton.Size = new System.Drawing.Size(75, 23);
            this.CheckPrimeButton.TabIndex = 7;
            this.CheckPrimeButton.Text = "Check";
            this.CheckPrimeButton.UseVisualStyleBackColor = true;
            this.CheckPrimeButton.Click += new System.EventHandler(this.CheckPrimeButton_Click_1);
            // 
            // TrueFalseTextBox
            // 
            this.TrueFalseTextBox.Location = new System.Drawing.Point(440, 38);
            this.TrueFalseTextBox.Name = "TrueFalseTextBox";
            this.TrueFalseTextBox.ReadOnly = true;
            this.TrueFalseTextBox.Size = new System.Drawing.Size(173, 20);
            this.TrueFalseTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(300, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "GCD Calculation";
            // 
            // FirstNumberTextBox
            // 
            this.FirstNumberTextBox.Location = new System.Drawing.Point(440, 168);
            this.FirstNumberTextBox.Name = "FirstNumberTextBox";
            this.FirstNumberTextBox.Size = new System.Drawing.Size(173, 20);
            this.FirstNumberTextBox.TabIndex = 10;
            // 
            // SecondNumberTextBox
            // 
            this.SecondNumberTextBox.Location = new System.Drawing.Point(440, 204);
            this.SecondNumberTextBox.Name = "SecondNumberTextBox";
            this.SecondNumberTextBox.Size = new System.Drawing.Size(173, 20);
            this.SecondNumberTextBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(300, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "1stNumber";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(300, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "2ndNumber";
            // 
            // GCDCalcButton
            // 
            this.GCDCalcButton.Location = new System.Drawing.Point(305, 236);
            this.GCDCalcButton.Name = "GCDCalcButton";
            this.GCDCalcButton.Size = new System.Drawing.Size(308, 23);
            this.GCDCalcButton.TabIndex = 14;
            this.GCDCalcButton.Text = "Check";
            this.GCDCalcButton.UseVisualStyleBackColor = true;
            this.GCDCalcButton.Click += new System.EventHandler(this.GCDCalcButton_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(300, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Modular Exponetiation";
            // 
            // BaseNumberTextBox
            // 
            this.BaseNumberTextBox.Location = new System.Drawing.Point(440, 347);
            this.BaseNumberTextBox.Name = "BaseNumberTextBox";
            this.BaseNumberTextBox.Size = new System.Drawing.Size(173, 20);
            this.BaseNumberTextBox.TabIndex = 16;
            // 
            // ExponentTextBox
            // 
            this.ExponentTextBox.Location = new System.Drawing.Point(440, 388);
            this.ExponentTextBox.Name = "ExponentTextBox";
            this.ExponentTextBox.Size = new System.Drawing.Size(173, 20);
            this.ExponentTextBox.TabIndex = 17;
            // 
            // ModulusTextBox
            // 
            this.ModulusTextBox.Location = new System.Drawing.Point(440, 428);
            this.ModulusTextBox.Name = "ModulusTextBox";
            this.ModulusTextBox.Size = new System.Drawing.Size(173, 20);
            this.ModulusTextBox.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(292, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Base Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(292, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "Exponent";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(292, 422);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "Modulus";
            // 
            // ModularCheckButton
            // 
            this.ModularCheckButton.Location = new System.Drawing.Point(297, 454);
            this.ModularCheckButton.Name = "ModularCheckButton";
            this.ModularCheckButton.Size = new System.Drawing.Size(316, 23);
            this.ModularCheckButton.TabIndex = 22;
            this.ModularCheckButton.Text = "Check";
            this.ModularCheckButton.UseVisualStyleBackColor = true;
            this.ModularCheckButton.Click += new System.EventHandler(this.ModularCheckButton_Click_1);
            // 
            // ResultModularTextBox
            // 
            this.ResultModularTextBox.Location = new System.Drawing.Point(297, 492);
            this.ResultModularTextBox.Name = "ResultModularTextBox";
            this.ResultModularTextBox.ReadOnly = true;
            this.ResultModularTextBox.Size = new System.Drawing.Size(502, 20);
            this.ResultModularTextBox.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.ResultModularTextBox);
            this.Controls.Add(this.ModularCheckButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ModulusTextBox);
            this.Controls.Add(this.ExponentTextBox);
            this.Controls.Add(this.BaseNumberTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GCDCalcButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SecondNumberTextBox);
            this.Controls.Add(this.FirstNumberTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TrueFalseTextBox);
            this.Controls.Add(this.CheckPrimeButton);
            this.Controls.Add(this.CheckPrimeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PrimeListBox);
            this.Controls.Add(this.Bit64PrimeButton);
            this.Controls.Add(this.Bit16PrimeButton);
            this.Controls.Add(this.Bit8PrimeButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bit8PrimeButton;
        private System.Windows.Forms.Button Bit16PrimeButton;
        private System.Windows.Forms.Button Bit64PrimeButton;
        private System.Windows.Forms.ListBox PrimeListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CheckPrimeTextBox;
        private System.Windows.Forms.Button CheckPrimeButton;
        private System.Windows.Forms.TextBox TrueFalseTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FirstNumberTextBox;
        private System.Windows.Forms.TextBox SecondNumberTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button GCDCalcButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BaseNumberTextBox;
        private System.Windows.Forms.TextBox ExponentTextBox;
        private System.Windows.Forms.TextBox ModulusTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ModularCheckButton;
        private System.Windows.Forms.TextBox ResultModularTextBox;
    }
}

