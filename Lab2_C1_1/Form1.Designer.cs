namespace Lab2_C1_1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button Bit8PrimeButton;
        private System.Windows.Forms.Button Bit16PrimeButton;
        private System.Windows.Forms.Button Bit64PrimeButton;
        private System.Windows.Forms.Button CheckPrimeButton;
        private System.Windows.Forms.Button GCDCalcButton;
        private System.Windows.Forms.Button ModularCheckButton;
        private System.Windows.Forms.ListBox PrimeListBox;
        private System.Windows.Forms.TextBox CheckPrimeTextBox;
        private System.Windows.Forms.TextBox TrueFalseTextBox;
        private System.Windows.Forms.TextBox FirstNumberTextBox;
        private System.Windows.Forms.TextBox SecondNumberTextBox;
        private System.Windows.Forms.TextBox BaseNumberTextBox;
        private System.Windows.Forms.TextBox ExponentTextBox;
        private System.Windows.Forms.TextBox ModulusTextBox;
        private System.Windows.Forms.TextBox ResultModularTextBox;

        private void InitializeComponent()
        {
            this.Bit8PrimeButton = new System.Windows.Forms.Button();
            this.Bit16PrimeButton = new System.Windows.Forms.Button();
            this.Bit64PrimeButton = new System.Windows.Forms.Button();
            this.CheckPrimeButton = new System.Windows.Forms.Button();
            this.GCDCalcButton = new System.Windows.Forms.Button();
            this.ModularCheckButton = new System.Windows.Forms.Button();
            this.PrimeListBox = new System.Windows.Forms.ListBox();
            this.CheckPrimeTextBox = new System.Windows.Forms.TextBox();
            this.TrueFalseTextBox = new System.Windows.Forms.TextBox();
            this.FirstNumberTextBox = new System.Windows.Forms.TextBox();
            this.SecondNumberTextBox = new System.Windows.Forms.TextBox();
            this.BaseNumberTextBox = new System.Windows.Forms.TextBox();
            this.ExponentTextBox = new System.Windows.Forms.TextBox();
            this.ModulusTextBox = new System.Windows.Forms.TextBox();
            this.ResultModularTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Bit8PrimeButton
            // 
            this.Bit8PrimeButton.Location = new System.Drawing.Point(32, 178);
            this.Bit8PrimeButton.Name = "Bit8PrimeButton";
            this.Bit8PrimeButton.Size = new System.Drawing.Size(157, 24);
            this.Bit8PrimeButton.TabIndex = 0;
            this.Bit8PrimeButton.Text = "8-bit Prime";
            this.Bit8PrimeButton.UseVisualStyleBackColor = true;
            this.Bit8PrimeButton.Click += new System.EventHandler(this.Bit8PrimeButton_Click);
            // 
            // Bit16PrimeButton
            // 
            this.Bit16PrimeButton.Location = new System.Drawing.Point(32, 209);
            this.Bit16PrimeButton.Name = "Bit16PrimeButton";
            this.Bit16PrimeButton.Size = new System.Drawing.Size(157, 31);
            this.Bit16PrimeButton.TabIndex = 1;
            this.Bit16PrimeButton.Text = "16-bit Prime";
            this.Bit16PrimeButton.UseVisualStyleBackColor = true;
            this.Bit16PrimeButton.Click += new System.EventHandler(this.Bit16PrimeButton_Click);
            // 
            // Bit64PrimeButton
            // 
            this.Bit64PrimeButton.Location = new System.Drawing.Point(32, 246);
            this.Bit64PrimeButton.Name = "Bit64PrimeButton";
            this.Bit64PrimeButton.Size = new System.Drawing.Size(157, 29);
            this.Bit64PrimeButton.TabIndex = 2;
            this.Bit64PrimeButton.Text = "64-bit Prime";
            this.Bit64PrimeButton.UseVisualStyleBackColor = true;
            this.Bit64PrimeButton.Click += new System.EventHandler(this.Bit64PrimeButton_Click);
            // 
            // CheckPrimeButton
            // 
            this.CheckPrimeButton.Location = new System.Drawing.Point(670, 44);
            this.CheckPrimeButton.Name = "CheckPrimeButton";
            this.CheckPrimeButton.Size = new System.Drawing.Size(132, 23);
            this.CheckPrimeButton.TabIndex = 3;
            this.CheckPrimeButton.Text = "Check Prime";
            this.CheckPrimeButton.UseVisualStyleBackColor = true;
            this.CheckPrimeButton.Click += new System.EventHandler(this.CheckPrimeButton_Click);
            // 
            // GCDCalcButton
            // 
            this.GCDCalcButton.Location = new System.Drawing.Point(670, 131);
            this.GCDCalcButton.Name = "GCDCalcButton";
            this.GCDCalcButton.Size = new System.Drawing.Size(132, 53);
            this.GCDCalcButton.TabIndex = 4;
            this.GCDCalcButton.Text = "Calculate GCD";
            this.GCDCalcButton.UseVisualStyleBackColor = true;
            this.GCDCalcButton.Click += new System.EventHandler(this.GCDCalcButton_Click);
            // 
            // ModularCheckButton
            // 
            this.ModularCheckButton.Location = new System.Drawing.Point(535, 290);
            this.ModularCheckButton.Name = "ModularCheckButton";
            this.ModularCheckButton.Size = new System.Drawing.Size(129, 41);
            this.ModularCheckButton.TabIndex = 5;
            this.ModularCheckButton.Text = "Calculatate!";
            this.ModularCheckButton.UseVisualStyleBackColor = true;
            this.ModularCheckButton.Click += new System.EventHandler(this.ModularCheckButton_Click);
            // 
            // PrimeListBox
            // 
            this.PrimeListBox.FormattingEnabled = true;
            this.PrimeListBox.Location = new System.Drawing.Point(12, 12);
            this.PrimeListBox.Name = "PrimeListBox";
            this.PrimeListBox.Size = new System.Drawing.Size(196, 160);
            this.PrimeListBox.TabIndex = 6;
            // 
            // CheckPrimeTextBox
            // 
            this.CheckPrimeTextBox.Location = new System.Drawing.Point(544, 44);
            this.CheckPrimeTextBox.Name = "CheckPrimeTextBox";
            this.CheckPrimeTextBox.Size = new System.Drawing.Size(120, 20);
            this.CheckPrimeTextBox.TabIndex = 7;
            // 
            // TrueFalseTextBox
            // 
            this.TrueFalseTextBox.Location = new System.Drawing.Point(544, 73);
            this.TrueFalseTextBox.Name = "TrueFalseTextBox";
            this.TrueFalseTextBox.ReadOnly = true;
            this.TrueFalseTextBox.Size = new System.Drawing.Size(120, 20);
            this.TrueFalseTextBox.TabIndex = 8;
            // 
            // FirstNumberTextBox
            // 
            this.FirstNumberTextBox.Location = new System.Drawing.Point(544, 131);
            this.FirstNumberTextBox.Name = "FirstNumberTextBox";
            this.FirstNumberTextBox.Size = new System.Drawing.Size(120, 20);
            this.FirstNumberTextBox.TabIndex = 9;
            // 
            // SecondNumberTextBox
            // 
            this.SecondNumberTextBox.Location = new System.Drawing.Point(544, 157);
            this.SecondNumberTextBox.Name = "SecondNumberTextBox";
            this.SecondNumberTextBox.Size = new System.Drawing.Size(120, 20);
            this.SecondNumberTextBox.TabIndex = 10;
            // 
            // BaseNumberTextBox
            // 
            this.BaseNumberTextBox.Location = new System.Drawing.Point(544, 209);
            this.BaseNumberTextBox.Name = "BaseNumberTextBox";
            this.BaseNumberTextBox.Size = new System.Drawing.Size(120, 20);
            this.BaseNumberTextBox.TabIndex = 11;
            // 
            // ExponentTextBox
            // 
            this.ExponentTextBox.Location = new System.Drawing.Point(544, 238);
            this.ExponentTextBox.Name = "ExponentTextBox";
            this.ExponentTextBox.Size = new System.Drawing.Size(120, 20);
            this.ExponentTextBox.TabIndex = 12;
            // 
            // ModulusTextBox
            // 
            this.ModulusTextBox.Location = new System.Drawing.Point(544, 264);
            this.ModulusTextBox.Name = "ModulusTextBox";
            this.ModulusTextBox.Size = new System.Drawing.Size(120, 20);
            this.ModulusTextBox.TabIndex = 13;
            // 
            // ResultModularTextBox
            // 
            this.ResultModularTextBox.Location = new System.Drawing.Point(544, 343);
            this.ResultModularTextBox.Name = "ResultModularTextBox";
            this.ResultModularTextBox.Size = new System.Drawing.Size(120, 20);
            this.ResultModularTextBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-4, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Prime Number Generator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Prime Number Check";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(259, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "GCD Calculator";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(259, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Modular Exponentiation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(684, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Base Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(684, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Exponents";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(684, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Modular";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1074, 395);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultModularTextBox);
            this.Controls.Add(this.ModulusTextBox);
            this.Controls.Add(this.ExponentTextBox);
            this.Controls.Add(this.BaseNumberTextBox);
            this.Controls.Add(this.SecondNumberTextBox);
            this.Controls.Add(this.FirstNumberTextBox);
            this.Controls.Add(this.TrueFalseTextBox);
            this.Controls.Add(this.CheckPrimeTextBox);
            this.Controls.Add(this.PrimeListBox);
            this.Controls.Add(this.ModularCheckButton);
            this.Controls.Add(this.GCDCalcButton);
            this.Controls.Add(this.CheckPrimeButton);
            this.Controls.Add(this.Bit64PrimeButton);
            this.Controls.Add(this.Bit16PrimeButton);
            this.Controls.Add(this.Bit8PrimeButton);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
