namespace SpreadCounter
{
    partial class InputTrades
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
            this.PositionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ContractComboBox = new System.Windows.Forms.ComboBox();
            this.MonthComboBox = new System.Windows.Forms.ComboBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SummaryTextBox = new System.Windows.Forms.RichTextBox();
            this.clearPosition_checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // PositionTextBox
            // 
            this.PositionTextBox.Location = new System.Drawing.Point(165, 25);
            this.PositionTextBox.Name = "PositionTextBox";
            this.PositionTextBox.Size = new System.Drawing.Size(41, 20);
            this.PositionTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Month";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Position";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Contract";
            // 
            // ContractComboBox
            // 
            this.ContractComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ContractComboBox.FormattingEnabled = true;
            this.ContractComboBox.Items.AddRange(new object[] {
            "CL",
            "RB",
            "HO",
            "NG",
            "BZ"});
            this.ContractComboBox.Location = new System.Drawing.Point(12, 25);
            this.ContractComboBox.Name = "ContractComboBox";
            this.ContractComboBox.Size = new System.Drawing.Size(47, 21);
            this.ContractComboBox.TabIndex = 1;
            // 
            // MonthComboBox
            // 
            this.MonthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonthComboBox.FormattingEnabled = true;
            this.MonthComboBox.Items.AddRange(new object[] {
            "F",
            "G",
            "H",
            "J",
            "K",
            "M",
            "N",
            "Q",
            "U",
            "V",
            "X",
            "Z"});
            this.MonthComboBox.Location = new System.Drawing.Point(65, 25);
            this.MonthComboBox.Name = "MonthComboBox";
            this.MonthComboBox.Size = new System.Drawing.Size(47, 21);
            this.MonthComboBox.TabIndex = 2;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(212, 23);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(73, 22);
            this.SubmitButton.TabIndex = 5;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Year";
            // 
            // YearTextBox
            // 
            this.YearTextBox.Location = new System.Drawing.Point(118, 25);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(41, 20);
            this.YearTextBox.TabIndex = 3;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(212, 50);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(73, 23);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SummaryTextBox
            // 
            this.SummaryTextBox.Location = new System.Drawing.Point(12, 52);
            this.SummaryTextBox.Name = "SummaryTextBox";
            this.SummaryTextBox.ReadOnly = true;
            this.SummaryTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.SummaryTextBox.Size = new System.Drawing.Size(194, 143);
            this.SummaryTextBox.TabIndex = 8;
            this.SummaryTextBox.TabStop = false;
            this.SummaryTextBox.Text = "";
            // 
            // clearPosition_checkBox
            // 
            this.clearPosition_checkBox.AutoSize = true;
            this.clearPosition_checkBox.Location = new System.Drawing.Point(212, 79);
            this.clearPosition_checkBox.Name = "clearPosition_checkBox";
            this.clearPosition_checkBox.Size = new System.Drawing.Size(90, 17);
            this.clearPosition_checkBox.TabIndex = 9;
            this.clearPosition_checkBox.Text = "Clear Position";
            this.clearPosition_checkBox.UseVisualStyleBackColor = true;
            this.clearPosition_checkBox.CheckedChanged += new System.EventHandler(this.ClearPosition_CheckedChanged);
            // 
            // InputTrades
            // 
            this.AcceptButton = this.SubmitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 207);
            this.Controls.Add(this.clearPosition_checkBox);
            this.Controls.Add(this.SummaryTextBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.YearTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.MonthComboBox);
            this.Controls.Add(this.ContractComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PositionTextBox);
            this.Name = "InputTrades";
            this.Text = "Input Trades";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InputTrades_FormClosing);
            this.Load += new System.EventHandler(this.InputTrades_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputTrades_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PositionTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ContractComboBox;
        private System.Windows.Forms.ComboBox MonthComboBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.RichTextBox SummaryTextBox;
        private System.Windows.Forms.CheckBox clearPosition_checkBox;
    }
}