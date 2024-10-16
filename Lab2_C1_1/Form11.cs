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
            this.SuspendLayout();
            // 
            // Bit8PrimeButton
            // 
            this.Bit8PrimeButton.Location = new System.Drawing.Point(12, 12);
            this.Bit8PrimeButton.Name = "Bit8PrimeButton";
            this.Bit8PrimeButton.Size = new System.Drawing.Size(75, 23);
            this.Bit8PrimeButton.TabIndex = 0;
            this.Bit8PrimeButton.Text = "8-bit Prime";
            this.Bit8PrimeButton.UseVisualStyleBackColor = true;
            this.Bit8PrimeButton.Click += new System.EventHandler(this.Bit8PrimeButton_Click);
            // 
            // Bit16PrimeButton
            // 
            this.Bit16PrimeButton.Location = new System.Drawing.Point(12, 41);
            this.Bit16PrimeButton.Name = "Bit16PrimeButton";
            this.Bit16PrimeButton.Size = new System.Drawing.Size(75, 23);
            this.Bit16PrimeButton.TabIndex = 1;
            this.Bit16PrimeButton.Text = "16-bit Prime";
            this.Bit16PrimeButton.UseVisualStyleBackColor = true;
            this.Bit16PrimeButton.Click += new System.EventHandler(this.Bit16PrimeButton_Click);
            // 
            // Bit64PrimeButton
            // 
            this.Bit64PrimeButton.Location = new System.Drawing.Point(12, 70);
            this.Bit64PrimeButton.Name = "Bit64PrimeButton";
            this.Bit64PrimeButton.Size = new System.Drawing.Size(75, 23);
            this.Bit64PrimeButton.TabIndex = 2;
            this.Bit64PrimeButton.Text = "64-bit Prime";
            this.Bit64PrimeButton.UseVisualStyleBackColor = true;
            this.Bit64PrimeButton.Click += new System.EventHandler(this.Bit64PrimeButton_Click);
            // 
            // CheckPrimeButton
            // 
            this.CheckPrimeButton.Location = new System.Drawing.Point(12, 99);
            this.CheckPrimeButton.Name = "CheckPrimeButton";
            this.CheckPrimeButton.Size = new System.Drawing.Size(75, 23);
            this.CheckPrimeButton.TabIndex = 3;
            this.CheckPrimeButton.Text = "Check Prime";
            this.CheckPrimeButton.UseVisualStyleBackColor = true;
            this.CheckPrimeButton.Click += new System.EventHandler(this.CheckPrimeButton_Click);
            // 
            // GCDCalcButton
            // 
            this.GCDCalcButton.Location = new System.Drawing.Point(12, 128);
            this.GCDCalcButton.Name = "GCDCalcButton";
            this.GCDCalcButton.Size = new System.Drawing.Size(75, 23);
            this.GCDCalcButton.TabIndex = 4;
            this.GCDCalcButton.Text = "Calculate GCD";
            this.GCDCalcButton.UseVisualStyleBackColor = true;
            this.GCDCalcButton.Click += new System.EventHandler(this.GCDCalcButton_Click);
            // 
            // ModularCheckButton
            // 
            this.ModularCheckButton.Location = new System.Drawing.Point(12, 157);
            this.ModularCheckButton.Name = "ModularCheckButton";
            this.ModularCheckButton.Size = new System.Drawing.Size(75, 23);
            this.ModularCheckButton.TabIndex = 5;
            this.ModularCheckButton.Text = "Modular Exp";
            this.ModularCheckButton.UseVisualStyleBackColor = true;
            this.ModularCheckButton.Click += new System.EventHandler(this.ModularCheckButton_Click);
            // 
            // PrimeListBox
            // 
            this.PrimeListBox.FormattingEnabled = true;
            this.PrimeListBox.Location = new System.Drawing.Point(93, 12);
            this.PrimeListBox.Name = "PrimeListBox";
            this.PrimeListBox.Size = new System.Drawing.Size(120, 95);
            this.PrimeListBox.TabIndex = 6;
            // 
            // CheckPrimeTextBox
            // 
            this.CheckPrimeTextBox.Location = new System.Drawing.Point(93, 101);
            this.CheckPrimeTextBox.Name = "CheckPrimeTextBox";
            this.CheckPrimeTextBox.Size = new System.Drawing.Size(120, 20);
            this.CheckPrimeTextBox.TabIndex = 7;
            // 
            // TrueFalseTextBox
            // 
            this.TrueFalseTextBox.Location = new System.Drawing.Point(93, 127);
            this.TrueFalseTextBox.Name = "TrueFalseTextBox";
            this.TrueFalseTextBox.Size = new System.Drawing.Size(120, 20);
            this.TrueFalseTextBox.TabIndex = 8;
            // 
            // FirstNumberTextBox
            // 
            this.FirstNumberTextBox.Location = new System.Drawing.Point(93, 153);
            this.FirstNumberTextBox.Name = "FirstNumberTextBox";
            this.FirstNumberTextBox.Size = new System.Drawing.Size(120, 20);
            this.FirstNumberTextBox.TabIndex = 9;
            // 
            // SecondNumberTextBox
            // 
            this.SecondNumberTextBox.Location = new System.Drawing.Point(93, 179);
            this.SecondNumberTextBox.Name = "SecondNumberTextBox";
            this.SecondNumberTextBox.Size = new System.Drawing.Size(120, 20);
            this.SecondNumberTextBox.TabIndex = 10;
            // 
            // BaseNumberTextBox
            // 
            this.BaseNumberTextBox.Location = new System.Drawing.Point(93, 205);
            this.BaseNumberTextBox.Name = "BaseNumberTextBox";
            this.BaseNumberTextBox.Size = new System.Drawing.Size(120, 20);
            this.BaseNumberTextBox.TabIndex = 11;
            // 
            // ExponentTextBox
            // 
            this.ExponentTextBox.Location = new System.Drawing.Point(93, 231);
            this.ExponentTextBox.Name = "ExponentTextBox";
            this.ExponentTextBox.Size = new System.Drawing.Size(120, 20);
            this.ExponentTextBox.TabIndex = 12;
            // 
            // ModulusTextBox
            // 
            this.ModulusTextBox.Location = new System.Drawing.Point(93, 257);
            this.ModulusTextBox.Name = "ModulusTextBox";
            this.ModulusTextBox.Size = new System.Drawing.Size(120, 20);
            this.ModulusTextBox.TabIndex = 13;
            // 
            // ResultModularTextBox
            // 
            this.ResultModularTextBox.Location = new System.Drawing.Point(93, 283);
            this.ResultModularTextBox.Name = "ResultModularTextBox";
            this.ResultModularTextBox.Size = new System.Drawing.Size(120, 20);
            this.ResultModularTextBox.TabIndex = 14;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 311);
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
    }
}
