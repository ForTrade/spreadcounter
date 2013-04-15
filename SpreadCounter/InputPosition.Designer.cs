namespace SpreadCounter
{
    partial class InputPosition
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
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.MonthComboBox = new System.Windows.Forms.ComboBox();
            this.ContractComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PositionTextBox = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SummaryTextBox = new System.Windows.Forms.RichTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // YearTextBox
            // 
            this.YearTextBox.Location = new System.Drawing.Point(118, 25);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(41, 20);
            this.YearTextBox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Year";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(212, 23);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(73, 22);
            this.SubmitButton.TabIndex = 15;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
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
            this.MonthComboBox.TabIndex = 10;
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
            this.ContractComboBox.TabIndex = 8;
            this.ContractComboBox.SelectedIndexChanged += new System.EventHandler(this.ContractComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Contract";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Position";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Month";
            // 
            // PositionTextBox
            // 
            this.PositionTextBox.Location = new System.Drawing.Point(165, 25);
            this.PositionTextBox.Name = "PositionTextBox";
            this.PositionTextBox.Size = new System.Drawing.Size(41, 20);
            this.PositionTextBox.TabIndex = 14;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(212, 50);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(73, 23);
            this.ClearButton.TabIndex = 17;
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
            this.SummaryTextBox.TabIndex = 18;
            this.SummaryTextBox.TabStop = false;
            this.SummaryTextBox.Text = "";
            this.SummaryTextBox.TextChanged += new System.EventHandler(this.SummaryTextBox_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(212, 79);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(90, 17);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Clear Position";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // InputPosition
            // 
            this.AcceptButton = this.SubmitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 207);
            this.Controls.Add(this.checkBox1);
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
            this.Name = "InputPosition";
            this.Text = "Input Position";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InputPosition_FormClosing);
            this.Load += new System.EventHandler(this.InputPosition_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.ComboBox MonthComboBox;
        private System.Windows.Forms.ComboBox ContractComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PositionTextBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.RichTextBox SummaryTextBox;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}