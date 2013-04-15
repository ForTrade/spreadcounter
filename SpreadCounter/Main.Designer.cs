#region DEFINES
#define BUTTERFLY
#endregion

using System.Windows.Forms;
namespace SpreadCounter
{
    partial class SpreadCounter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.clNetShortBox = new System.Windows.Forms.TextBox();
            this.clFlyPosition = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.clNetPosition = new System.Windows.Forms.TextBox();
            this.clNetLongBox = new System.Windows.Forms.TextBox();
            this.clOptionNetComboBox = new System.Windows.Forms.ComboBox();
            this.clOptionSpreadComboBox = new System.Windows.Forms.ComboBox();
            this.clSpreadPosition = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.rbSpreadPosition = new System.Windows.Forms.TextBox();
            this.rbOptionSpreadComboBox = new System.Windows.Forms.ComboBox();
            this.rbOptionNetComboBox = new System.Windows.Forms.ComboBox();
            this.rbNetPosition = new System.Windows.Forms.TextBox();
            this.rbFlyPosition = new System.Windows.Forms.TextBox();
            this.rbNetShortBox = new System.Windows.Forms.TextBox();
            this.rbNetLongBox = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.hoSpreadPosition = new System.Windows.Forms.TextBox();
            this.hoOptionSpreadComboBox = new System.Windows.Forms.ComboBox();
            this.hoOptionNetComboBox = new System.Windows.Forms.ComboBox();
            this.hoNetPosition = new System.Windows.Forms.TextBox();
            this.hoFlyPosition = new System.Windows.Forms.TextBox();
            this.hoNetShortBox = new System.Windows.Forms.TextBox();
            this.hoNetLongBox = new System.Windows.Forms.TextBox();
            this.label64 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.ngSpreadPosition = new System.Windows.Forms.TextBox();
            this.ngOptionSpreadComboBox = new System.Windows.Forms.ComboBox();
            this.ngOptionNetComboBox = new System.Windows.Forms.ComboBox();
            this.ngNetPosition = new System.Windows.Forms.TextBox();
            this.ngFlyPosition = new System.Windows.Forms.TextBox();
            this.ngNetShortBox = new System.Windows.Forms.TextBox();
            this.ngNetLongBox = new System.Windows.Forms.TextBox();
            this.label69 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.crudeGrid = new System.Windows.Forms.ListView();
            this.gasGrid = new System.Windows.Forms.ListView();
            this.heatGrid = new System.Windows.Forms.ListView();
            this.naturalGrid = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputTradesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.butterflyChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CrudeClearButton = new System.Windows.Forms.Button();
            this.NaturalClearButton = new System.Windows.Forms.Button();
            this.HeatClearButton = new System.Windows.Forms.Button();
            this.GasClearButton = new System.Windows.Forms.Button();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.LoadFile = new System.Windows.Forms.Button();
            this.accountComboBox = new System.Windows.Forms.ComboBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.BrentClearButton = new System.Windows.Forms.Button();
            this.brentGrid = new System.Windows.Forms.ListView();
            this.bzSpreadPosition = new System.Windows.Forms.TextBox();
            this.bzOptionSpreadComboBox = new System.Windows.Forms.ComboBox();
            this.bzOptionNetComboBox = new System.Windows.Forms.ComboBox();
            this.bzNetPosition = new System.Windows.Forms.TextBox();
            this.bzFlyPosition = new System.Windows.Forms.TextBox();
            this.bzNetShortBox = new System.Windows.Forms.TextBox();
            this.bzNetLongBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "CL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Net";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 447);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Spreads";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 473);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Flies";
            // 
            // clNetShortBox
            // 
            this.clNetShortBox.Location = new System.Drawing.Point(123, 419);
            this.clNetShortBox.Name = "clNetShortBox";
            this.clNetShortBox.ReadOnly = true;
            this.clNetShortBox.Size = new System.Drawing.Size(45, 20);
            this.clNetShortBox.TabIndex = 10;
            this.clNetShortBox.TabStop = false;
            this.clNetShortBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clFlyPosition
            // 
            this.clFlyPosition.Location = new System.Drawing.Point(123, 468);
            this.clFlyPosition.Name = "clFlyPosition";
            this.clFlyPosition.ReadOnly = true;
            this.clFlyPosition.Size = new System.Drawing.Size(45, 20);
            this.clFlyPosition.TabIndex = 13;
            this.clFlyPosition.TabStop = false;
            this.clFlyPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(261, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 18);
            this.label14.TabIndex = 22;
            this.label14.Text = "RB";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(440, 38);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(31, 18);
            this.label19.TabIndex = 35;
            this.label19.Text = "HO";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clNetPosition
            // 
            this.clNetPosition.Location = new System.Drawing.Point(73, 419);
            this.clNetPosition.Name = "clNetPosition";
            this.clNetPosition.ReadOnly = true;
            this.clNetPosition.Size = new System.Drawing.Size(45, 20);
            this.clNetPosition.TabIndex = 48;
            this.clNetPosition.TabStop = false;
            this.clNetPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clNetLongBox
            // 
            this.clNetLongBox.Location = new System.Drawing.Point(23, 419);
            this.clNetLongBox.Name = "clNetLongBox";
            this.clNetLongBox.ReadOnly = true;
            this.clNetLongBox.Size = new System.Drawing.Size(45, 20);
            this.clNetLongBox.TabIndex = 9;
            this.clNetLongBox.TabStop = false;
            this.clNetLongBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clOptionNetComboBox
            // 
            this.clOptionNetComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clOptionNetComboBox.FormattingEnabled = true;
            this.clOptionNetComboBox.Items.AddRange(new object[] {
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
            this.clOptionNetComboBox.Location = new System.Drawing.Point(72, 443);
            this.clOptionNetComboBox.Name = "clOptionNetComboBox";
            this.clOptionNetComboBox.Size = new System.Drawing.Size(45, 21);
            this.clOptionNetComboBox.TabIndex = 5;
            this.clOptionNetComboBox.SelectedIndexChanged += new System.EventHandler(this.clOptionNetComboBox_SelectedIndexChanged);
            // 
            // clOptionSpreadComboBox
            // 
            this.clOptionSpreadComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clOptionSpreadComboBox.FormattingEnabled = true;
            this.clOptionSpreadComboBox.Items.AddRange(new object[] {
            "FG",
            "GH",
            "HJ",
            "JK",
            "KM",
            "MN",
            "NQ",
            "QU",
            "UV",
            "VX",
            "XZ",
            "ZF"});
            this.clOptionSpreadComboBox.Location = new System.Drawing.Point(72, 468);
            this.clOptionSpreadComboBox.Name = "clOptionSpreadComboBox";
            this.clOptionSpreadComboBox.Size = new System.Drawing.Size(45, 21);
            this.clOptionSpreadComboBox.TabIndex = 6;
            this.clOptionSpreadComboBox.SelectedIndexChanged += new System.EventHandler(this.clOptionSpreadComboBox_SelectedIndexChanged);
            // 
            // clSpreadPosition
            // 
            this.clSpreadPosition.Location = new System.Drawing.Point(123, 443);
            this.clSpreadPosition.Name = "clSpreadPosition";
            this.clSpreadPosition.ReadOnly = true;
            this.clSpreadPosition.Size = new System.Drawing.Size(45, 20);
            this.clSpreadPosition.TabIndex = 53;
            this.clSpreadPosition.TabStop = false;
            this.clSpreadPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(617, 38);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(31, 18);
            this.label25.TabIndex = 56;
            this.label25.Text = "NG";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbSpreadPosition
            // 
            this.rbSpreadPosition.Location = new System.Drawing.Point(305, 443);
            this.rbSpreadPosition.Name = "rbSpreadPosition";
            this.rbSpreadPosition.ReadOnly = true;
            this.rbSpreadPosition.Size = new System.Drawing.Size(45, 20);
            this.rbSpreadPosition.TabIndex = 177;
            this.rbSpreadPosition.TabStop = false;
            this.rbSpreadPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rbOptionSpreadComboBox
            // 
            this.rbOptionSpreadComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rbOptionSpreadComboBox.FormattingEnabled = true;
            this.rbOptionSpreadComboBox.Items.AddRange(new object[] {
            "FG",
            "GH",
            "HJ",
            "JK",
            "KM",
            "MN",
            "NQ",
            "QU",
            "UV",
            "VX",
            "XZ",
            "ZF"});
            this.rbOptionSpreadComboBox.Location = new System.Drawing.Point(254, 468);
            this.rbOptionSpreadComboBox.Name = "rbOptionSpreadComboBox";
            this.rbOptionSpreadComboBox.Size = new System.Drawing.Size(45, 21);
            this.rbOptionSpreadComboBox.TabIndex = 8;
            this.rbOptionSpreadComboBox.SelectedIndexChanged += new System.EventHandler(this.rbOptionSpreadComboBox_SelectedIndexChanged);
            // 
            // rbOptionNetComboBox
            // 
            this.rbOptionNetComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rbOptionNetComboBox.FormattingEnabled = true;
            this.rbOptionNetComboBox.Items.AddRange(new object[] {
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
            this.rbOptionNetComboBox.Location = new System.Drawing.Point(254, 443);
            this.rbOptionNetComboBox.Name = "rbOptionNetComboBox";
            this.rbOptionNetComboBox.Size = new System.Drawing.Size(45, 21);
            this.rbOptionNetComboBox.TabIndex = 7;
            this.rbOptionNetComboBox.SelectedIndexChanged += new System.EventHandler(this.rbOptionNetComboBox_SelectedIndexChanged);
            // 
            // rbNetPosition
            // 
            this.rbNetPosition.Location = new System.Drawing.Point(254, 419);
            this.rbNetPosition.Name = "rbNetPosition";
            this.rbNetPosition.ReadOnly = true;
            this.rbNetPosition.Size = new System.Drawing.Size(45, 20);
            this.rbNetPosition.TabIndex = 173;
            this.rbNetPosition.TabStop = false;
            this.rbNetPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rbFlyPosition
            // 
            this.rbFlyPosition.Location = new System.Drawing.Point(305, 468);
            this.rbFlyPosition.Name = "rbFlyPosition";
            this.rbFlyPosition.ReadOnly = true;
            this.rbFlyPosition.Size = new System.Drawing.Size(45, 20);
            this.rbFlyPosition.TabIndex = 172;
            this.rbFlyPosition.TabStop = false;
            this.rbFlyPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rbNetShortBox
            // 
            this.rbNetShortBox.Location = new System.Drawing.Point(305, 419);
            this.rbNetShortBox.Name = "rbNetShortBox";
            this.rbNetShortBox.ReadOnly = true;
            this.rbNetShortBox.Size = new System.Drawing.Size(45, 20);
            this.rbNetShortBox.TabIndex = 170;
            this.rbNetShortBox.TabStop = false;
            this.rbNetShortBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rbNetLongBox
            // 
            this.rbNetLongBox.Location = new System.Drawing.Point(203, 419);
            this.rbNetLongBox.Name = "rbNetLongBox";
            this.rbNetLongBox.ReadOnly = true;
            this.rbNetLongBox.Size = new System.Drawing.Size(45, 20);
            this.rbNetLongBox.TabIndex = 169;
            this.rbNetLongBox.TabStop = false;
            this.rbNetLongBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(205, 473);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(28, 13);
            this.label59.TabIndex = 168;
            this.label59.Text = "Flies";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(205, 447);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(46, 13);
            this.label61.TabIndex = 166;
            this.label61.Text = "Spreads";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(264, 403);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(24, 13);
            this.label62.TabIndex = 165;
            this.label62.Text = "Net";
            // 
            // hoSpreadPosition
            // 
            this.hoSpreadPosition.Location = new System.Drawing.Point(484, 443);
            this.hoSpreadPosition.Name = "hoSpreadPosition";
            this.hoSpreadPosition.ReadOnly = true;
            this.hoSpreadPosition.Size = new System.Drawing.Size(45, 20);
            this.hoSpreadPosition.TabIndex = 192;
            this.hoSpreadPosition.TabStop = false;
            this.hoSpreadPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hoOptionSpreadComboBox
            // 
            this.hoOptionSpreadComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hoOptionSpreadComboBox.FormattingEnabled = true;
            this.hoOptionSpreadComboBox.Items.AddRange(new object[] {
            "FG",
            "GH",
            "HJ",
            "JK",
            "KM",
            "MN",
            "NQ",
            "QU",
            "UV",
            "VX",
            "XZ",
            "ZF"});
            this.hoOptionSpreadComboBox.Location = new System.Drawing.Point(433, 468);
            this.hoOptionSpreadComboBox.Name = "hoOptionSpreadComboBox";
            this.hoOptionSpreadComboBox.Size = new System.Drawing.Size(45, 21);
            this.hoOptionSpreadComboBox.TabIndex = 10;
            this.hoOptionSpreadComboBox.SelectedIndexChanged += new System.EventHandler(this.hoOptionSpreadComboBox_SelectedIndexChanged);
            // 
            // hoOptionNetComboBox
            // 
            this.hoOptionNetComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hoOptionNetComboBox.FormattingEnabled = true;
            this.hoOptionNetComboBox.Items.AddRange(new object[] {
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
            this.hoOptionNetComboBox.Location = new System.Drawing.Point(433, 443);
            this.hoOptionNetComboBox.Name = "hoOptionNetComboBox";
            this.hoOptionNetComboBox.Size = new System.Drawing.Size(45, 21);
            this.hoOptionNetComboBox.TabIndex = 9;
            this.hoOptionNetComboBox.SelectedIndexChanged += new System.EventHandler(this.hoOptionNetComboBox_SelectedIndexChanged);
            // 
            // hoNetPosition
            // 
            this.hoNetPosition.Location = new System.Drawing.Point(433, 419);
            this.hoNetPosition.Name = "hoNetPosition";
            this.hoNetPosition.ReadOnly = true;
            this.hoNetPosition.Size = new System.Drawing.Size(45, 20);
            this.hoNetPosition.TabIndex = 188;
            this.hoNetPosition.TabStop = false;
            this.hoNetPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hoFlyPosition
            // 
            this.hoFlyPosition.Location = new System.Drawing.Point(484, 468);
            this.hoFlyPosition.Name = "hoFlyPosition";
            this.hoFlyPosition.ReadOnly = true;
            this.hoFlyPosition.Size = new System.Drawing.Size(45, 20);
            this.hoFlyPosition.TabIndex = 187;
            this.hoFlyPosition.TabStop = false;
            this.hoFlyPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hoNetShortBox
            // 
            this.hoNetShortBox.Location = new System.Drawing.Point(484, 419);
            this.hoNetShortBox.Name = "hoNetShortBox";
            this.hoNetShortBox.ReadOnly = true;
            this.hoNetShortBox.Size = new System.Drawing.Size(45, 20);
            this.hoNetShortBox.TabIndex = 185;
            this.hoNetShortBox.TabStop = false;
            this.hoNetShortBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hoNetLongBox
            // 
            this.hoNetLongBox.Location = new System.Drawing.Point(382, 419);
            this.hoNetLongBox.Name = "hoNetLongBox";
            this.hoNetLongBox.ReadOnly = true;
            this.hoNetLongBox.Size = new System.Drawing.Size(45, 20);
            this.hoNetLongBox.TabIndex = 184;
            this.hoNetLongBox.TabStop = false;
            this.hoNetLongBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(383, 473);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(28, 13);
            this.label64.TabIndex = 183;
            this.label64.Text = "Flies";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(381, 447);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(46, 13);
            this.label66.TabIndex = 181;
            this.label66.Text = "Spreads";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(444, 403);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(24, 13);
            this.label67.TabIndex = 180;
            this.label67.Text = "Net";
            // 
            // ngSpreadPosition
            // 
            this.ngSpreadPosition.Location = new System.Drawing.Point(664, 443);
            this.ngSpreadPosition.Name = "ngSpreadPosition";
            this.ngSpreadPosition.ReadOnly = true;
            this.ngSpreadPosition.Size = new System.Drawing.Size(45, 20);
            this.ngSpreadPosition.TabIndex = 207;
            this.ngSpreadPosition.TabStop = false;
            this.ngSpreadPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ngOptionSpreadComboBox
            // 
            this.ngOptionSpreadComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ngOptionSpreadComboBox.FormattingEnabled = true;
            this.ngOptionSpreadComboBox.Items.AddRange(new object[] {
            "FG",
            "GH",
            "HJ",
            "JK",
            "KM",
            "MN",
            "NQ",
            "QU",
            "UV",
            "VX",
            "XZ",
            "ZF"});
            this.ngOptionSpreadComboBox.Location = new System.Drawing.Point(613, 468);
            this.ngOptionSpreadComboBox.Name = "ngOptionSpreadComboBox";
            this.ngOptionSpreadComboBox.Size = new System.Drawing.Size(45, 21);
            this.ngOptionSpreadComboBox.TabIndex = 12;
            this.ngOptionSpreadComboBox.SelectedIndexChanged += new System.EventHandler(this.ngOptionSpreadComboBox_SelectedIndexChanged);
            // 
            // ngOptionNetComboBox
            // 
            this.ngOptionNetComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ngOptionNetComboBox.FormattingEnabled = true;
            this.ngOptionNetComboBox.Items.AddRange(new object[] {
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
            this.ngOptionNetComboBox.Location = new System.Drawing.Point(613, 443);
            this.ngOptionNetComboBox.Name = "ngOptionNetComboBox";
            this.ngOptionNetComboBox.Size = new System.Drawing.Size(45, 21);
            this.ngOptionNetComboBox.TabIndex = 11;
            this.ngOptionNetComboBox.SelectedIndexChanged += new System.EventHandler(this.ngOptionNetComboBox_SelectedIndexChanged);
            // 
            // ngNetPosition
            // 
            this.ngNetPosition.Location = new System.Drawing.Point(613, 419);
            this.ngNetPosition.Name = "ngNetPosition";
            this.ngNetPosition.ReadOnly = true;
            this.ngNetPosition.Size = new System.Drawing.Size(45, 20);
            this.ngNetPosition.TabIndex = 203;
            this.ngNetPosition.TabStop = false;
            this.ngNetPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ngFlyPosition
            // 
            this.ngFlyPosition.Location = new System.Drawing.Point(664, 468);
            this.ngFlyPosition.Name = "ngFlyPosition";
            this.ngFlyPosition.ReadOnly = true;
            this.ngFlyPosition.Size = new System.Drawing.Size(45, 20);
            this.ngFlyPosition.TabIndex = 202;
            this.ngFlyPosition.TabStop = false;
            this.ngFlyPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ngNetShortBox
            // 
            this.ngNetShortBox.Location = new System.Drawing.Point(664, 419);
            this.ngNetShortBox.Name = "ngNetShortBox";
            this.ngNetShortBox.ReadOnly = true;
            this.ngNetShortBox.Size = new System.Drawing.Size(45, 20);
            this.ngNetShortBox.TabIndex = 200;
            this.ngNetShortBox.TabStop = false;
            this.ngNetShortBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ngNetLongBox
            // 
            this.ngNetLongBox.Location = new System.Drawing.Point(562, 419);
            this.ngNetLongBox.Name = "ngNetLongBox";
            this.ngNetLongBox.ReadOnly = true;
            this.ngNetLongBox.Size = new System.Drawing.Size(45, 20);
            this.ngNetLongBox.TabIndex = 199;
            this.ngNetLongBox.TabStop = false;
            this.ngNetLongBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(562, 473);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(28, 13);
            this.label69.TabIndex = 198;
            this.label69.Text = "Flies";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(561, 447);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(46, 13);
            this.label71.TabIndex = 196;
            this.label71.Text = "Spreads";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(624, 403);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(24, 13);
            this.label72.TabIndex = 195;
            this.label72.Text = "Net";
            // 
            // crudeGrid
            // 
            this.crudeGrid.FullRowSelect = true;
            this.crudeGrid.GridLines = true;
            this.crudeGrid.Location = new System.Drawing.Point(17, 59);
            this.crudeGrid.Name = "crudeGrid";
            this.crudeGrid.Size = new System.Drawing.Size(173, 292);
            this.crudeGrid.TabIndex = 210;
            this.crudeGrid.TabStop = false;
            this.crudeGrid.UseCompatibleStateImageBehavior = false;
            this.crudeGrid.View = System.Windows.Forms.View.Details;
            // 
            // gasGrid
            // 
            this.gasGrid.FullRowSelect = true;
            this.gasGrid.GridLines = true;
            this.gasGrid.Location = new System.Drawing.Point(196, 59);
            this.gasGrid.Name = "gasGrid";
            this.gasGrid.Size = new System.Drawing.Size(173, 292);
            this.gasGrid.TabIndex = 211;
            this.gasGrid.TabStop = false;
            this.gasGrid.UseCompatibleStateImageBehavior = false;
            this.gasGrid.View = System.Windows.Forms.View.Details;
            // 
            // heatGrid
            // 
            this.heatGrid.FullRowSelect = true;
            this.heatGrid.GridLines = true;
            this.heatGrid.Location = new System.Drawing.Point(375, 59);
            this.heatGrid.Name = "heatGrid";
            this.heatGrid.Size = new System.Drawing.Size(173, 292);
            this.heatGrid.TabIndex = 212;
            this.heatGrid.TabStop = false;
            this.heatGrid.UseCompatibleStateImageBehavior = false;
            this.heatGrid.View = System.Windows.Forms.View.Details;
            // 
            // naturalGrid
            // 
            this.naturalGrid.FullRowSelect = true;
            this.naturalGrid.GridLines = true;
            this.naturalGrid.Location = new System.Drawing.Point(554, 59);
            this.naturalGrid.Name = "naturalGrid";
            this.naturalGrid.Size = new System.Drawing.Size(173, 292);
            this.naturalGrid.TabIndex = 213;
            this.naturalGrid.TabStop = false;
            this.naturalGrid.UseCompatibleStateImageBehavior = false;
            this.naturalGrid.View = System.Windows.Forms.View.Details;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(921, 24);
            this.menuStrip1.TabIndex = 214;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputTradesToolStripMenuItem,
            this.butterflyChartToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // inputTradesToolStripMenuItem
            // 
            this.inputTradesToolStripMenuItem.Name = "inputTradesToolStripMenuItem";
            this.inputTradesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.inputTradesToolStripMenuItem.Text = "Input Trades";
            this.inputTradesToolStripMenuItem.Click += new System.EventHandler(this.inputTradesToolStripMenuItem_Click);
            // 
            // butterflyChartToolStripMenuItem
            // 
            this.butterflyChartToolStripMenuItem.Name = "butterflyChartToolStripMenuItem";
            this.butterflyChartToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.butterflyChartToolStripMenuItem.Text = "Butterfly Chart";
            this.butterflyChartToolStripMenuItem.Click += new System.EventHandler(this.butterflyChartToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearAllToolStripMenuItem});
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.clearAllToolStripMenuItem.Text = "Clear All";
            this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click_1);
            // 
            // CrudeClearButton
            // 
            this.CrudeClearButton.Location = new System.Drawing.Point(62, 362);
            this.CrudeClearButton.Name = "CrudeClearButton";
            this.CrudeClearButton.Size = new System.Drawing.Size(75, 23);
            this.CrudeClearButton.TabIndex = 13;
            this.CrudeClearButton.Text = "Clear";
            this.CrudeClearButton.UseVisualStyleBackColor = true;
            this.CrudeClearButton.Click += new System.EventHandler(this.CrudeClearButton_Click);
            // 
            // NaturalClearButton
            // 
            this.NaturalClearButton.Location = new System.Drawing.Point(599, 362);
            this.NaturalClearButton.Name = "NaturalClearButton";
            this.NaturalClearButton.Size = new System.Drawing.Size(75, 23);
            this.NaturalClearButton.TabIndex = 16;
            this.NaturalClearButton.Text = "Clear";
            this.NaturalClearButton.UseVisualStyleBackColor = true;
            this.NaturalClearButton.Click += new System.EventHandler(this.NaturalClearButton_Click);
            // 
            // HeatClearButton
            // 
            this.HeatClearButton.Location = new System.Drawing.Point(418, 362);
            this.HeatClearButton.Name = "HeatClearButton";
            this.HeatClearButton.Size = new System.Drawing.Size(75, 23);
            this.HeatClearButton.TabIndex = 15;
            this.HeatClearButton.Text = "Clear";
            this.HeatClearButton.UseVisualStyleBackColor = true;
            this.HeatClearButton.Click += new System.EventHandler(this.HeatClearButton_Click);
            // 
            // GasClearButton
            // 
            this.GasClearButton.Location = new System.Drawing.Point(239, 362);
            this.GasClearButton.Name = "GasClearButton";
            this.GasClearButton.Size = new System.Drawing.Size(75, 23);
            this.GasClearButton.TabIndex = 14;
            this.GasClearButton.Text = "Clear";
            this.GasClearButton.UseVisualStyleBackColor = true;
            this.GasClearButton.Click += new System.EventHandler(this.GasClearButton_Click);
            // 
            // openFD
            // 
            this.openFD.FileName = "openFileDialog1";
            // 
            // LoadFile
            // 
            this.LoadFile.Location = new System.Drawing.Point(305, 1);
            this.LoadFile.Name = "LoadFile";
            this.LoadFile.Size = new System.Drawing.Size(133, 23);
            this.LoadFile.TabIndex = 2;
            this.LoadFile.Text = "Load FC Stone Position";
            this.LoadFile.UseVisualStyleBackColor = true;
            this.LoadFile.Click += new System.EventHandler(this.LoadFile_Click);
            // 
            // accountComboBox
            // 
            this.accountComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accountComboBox.DropDownWidth = 121;
            this.accountComboBox.FormattingEnabled = true;
            this.accountComboBox.Items.AddRange(new object[] {
            "PAXY81"});
            this.accountComboBox.Location = new System.Drawing.Point(107, 2);
            this.accountComboBox.Name = "accountComboBox";
            this.accountComboBox.Size = new System.Drawing.Size(83, 21);
            this.accountComboBox.TabIndex = 215;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.AcceptsReturn = true;
            this.passwordTextBox.Location = new System.Drawing.Point(199, 3);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 216;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // BrentClearButton
            // 
            this.BrentClearButton.Location = new System.Drawing.Point(778, 362);
            this.BrentClearButton.Name = "BrentClearButton";
            this.BrentClearButton.Size = new System.Drawing.Size(75, 23);
            this.BrentClearButton.TabIndex = 219;
            this.BrentClearButton.Text = "Clear";
            this.BrentClearButton.UseVisualStyleBackColor = true;
            this.BrentClearButton.Click += new System.EventHandler(this.BrentClearButton_Click);
            // 
            // brentGrid
            // 
            this.brentGrid.FullRowSelect = true;
            this.brentGrid.GridLines = true;
            this.brentGrid.Location = new System.Drawing.Point(733, 59);
            this.brentGrid.Name = "brentGrid";
            this.brentGrid.Size = new System.Drawing.Size(173, 292);
            this.brentGrid.TabIndex = 229;
            this.brentGrid.TabStop = false;
            this.brentGrid.UseCompatibleStateImageBehavior = false;
            this.brentGrid.View = System.Windows.Forms.View.Details;
            // 
            // bzSpreadPosition
            // 
            this.bzSpreadPosition.Location = new System.Drawing.Point(843, 443);
            this.bzSpreadPosition.Name = "bzSpreadPosition";
            this.bzSpreadPosition.ReadOnly = true;
            this.bzSpreadPosition.Size = new System.Drawing.Size(45, 20);
            this.bzSpreadPosition.TabIndex = 228;
            this.bzSpreadPosition.TabStop = false;
            this.bzSpreadPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bzOptionSpreadComboBox
            // 
            this.bzOptionSpreadComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bzOptionSpreadComboBox.FormattingEnabled = true;
            this.bzOptionSpreadComboBox.Items.AddRange(new object[] {
            "FG",
            "GH",
            "HJ",
            "JK",
            "KM",
            "MN",
            "NQ",
            "QU",
            "UV",
            "VX",
            "XZ",
            "ZF"});
            this.bzOptionSpreadComboBox.Location = new System.Drawing.Point(792, 468);
            this.bzOptionSpreadComboBox.Name = "bzOptionSpreadComboBox";
            this.bzOptionSpreadComboBox.Size = new System.Drawing.Size(45, 21);
            this.bzOptionSpreadComboBox.TabIndex = 218;
            // 
            // bzOptionNetComboBox
            // 
            this.bzOptionNetComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bzOptionNetComboBox.FormattingEnabled = true;
            this.bzOptionNetComboBox.Items.AddRange(new object[] {
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
            this.bzOptionNetComboBox.Location = new System.Drawing.Point(792, 443);
            this.bzOptionNetComboBox.Name = "bzOptionNetComboBox";
            this.bzOptionNetComboBox.Size = new System.Drawing.Size(45, 21);
            this.bzOptionNetComboBox.TabIndex = 217;
            // 
            // bzNetPosition
            // 
            this.bzNetPosition.Location = new System.Drawing.Point(792, 419);
            this.bzNetPosition.Name = "bzNetPosition";
            this.bzNetPosition.ReadOnly = true;
            this.bzNetPosition.Size = new System.Drawing.Size(45, 20);
            this.bzNetPosition.TabIndex = 227;
            this.bzNetPosition.TabStop = false;
            this.bzNetPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bzFlyPosition
            // 
            this.bzFlyPosition.Location = new System.Drawing.Point(843, 468);
            this.bzFlyPosition.Name = "bzFlyPosition";
            this.bzFlyPosition.ReadOnly = true;
            this.bzFlyPosition.Size = new System.Drawing.Size(45, 20);
            this.bzFlyPosition.TabIndex = 226;
            this.bzFlyPosition.TabStop = false;
            this.bzFlyPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bzNetShortBox
            // 
            this.bzNetShortBox.Location = new System.Drawing.Point(843, 419);
            this.bzNetShortBox.Name = "bzNetShortBox";
            this.bzNetShortBox.ReadOnly = true;
            this.bzNetShortBox.Size = new System.Drawing.Size(45, 20);
            this.bzNetShortBox.TabIndex = 225;
            this.bzNetShortBox.TabStop = false;
            this.bzNetShortBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bzNetLongBox
            // 
            this.bzNetLongBox.Location = new System.Drawing.Point(741, 419);
            this.bzNetLongBox.Name = "bzNetLongBox";
            this.bzNetLongBox.ReadOnly = true;
            this.bzNetLongBox.Size = new System.Drawing.Size(45, 20);
            this.bzNetLongBox.TabIndex = 224;
            this.bzNetLongBox.TabStop = false;
            this.bzNetLongBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(741, 473);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 223;
            this.label2.Text = "Flies";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(740, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 222;
            this.label3.Text = "Spreads";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(803, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 221;
            this.label4.Text = "Net";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(796, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 18);
            this.label5.TabIndex = 220;
            this.label5.Text = "BZ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SpreadCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 505);
            this.Controls.Add(this.BrentClearButton);
            this.Controls.Add(this.brentGrid);
            this.Controls.Add(this.bzSpreadPosition);
            this.Controls.Add(this.bzOptionSpreadComboBox);
            this.Controls.Add(this.bzOptionNetComboBox);
            this.Controls.Add(this.bzNetPosition);
            this.Controls.Add(this.bzFlyPosition);
            this.Controls.Add(this.bzNetShortBox);
            this.Controls.Add(this.bzNetLongBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.accountComboBox);
            this.Controls.Add(this.LoadFile);
            this.Controls.Add(this.GasClearButton);
            this.Controls.Add(this.HeatClearButton);
            this.Controls.Add(this.NaturalClearButton);
            this.Controls.Add(this.CrudeClearButton);
            this.Controls.Add(this.naturalGrid);
            this.Controls.Add(this.heatGrid);
            this.Controls.Add(this.gasGrid);
            this.Controls.Add(this.crudeGrid);
            this.Controls.Add(this.ngSpreadPosition);
            this.Controls.Add(this.ngOptionSpreadComboBox);
            this.Controls.Add(this.ngOptionNetComboBox);
            this.Controls.Add(this.ngNetPosition);
            this.Controls.Add(this.ngFlyPosition);
            this.Controls.Add(this.ngNetShortBox);
            this.Controls.Add(this.ngNetLongBox);
            this.Controls.Add(this.label69);
            this.Controls.Add(this.label71);
            this.Controls.Add(this.label72);
            this.Controls.Add(this.hoSpreadPosition);
            this.Controls.Add(this.hoOptionSpreadComboBox);
            this.Controls.Add(this.hoOptionNetComboBox);
            this.Controls.Add(this.hoNetPosition);
            this.Controls.Add(this.hoFlyPosition);
            this.Controls.Add(this.hoNetShortBox);
            this.Controls.Add(this.hoNetLongBox);
            this.Controls.Add(this.label64);
            this.Controls.Add(this.label66);
            this.Controls.Add(this.label67);
            this.Controls.Add(this.rbSpreadPosition);
            this.Controls.Add(this.rbOptionSpreadComboBox);
            this.Controls.Add(this.rbOptionNetComboBox);
            this.Controls.Add(this.rbNetPosition);
            this.Controls.Add(this.rbFlyPosition);
            this.Controls.Add(this.rbNetShortBox);
            this.Controls.Add(this.rbNetLongBox);
            this.Controls.Add(this.label59);
            this.Controls.Add(this.label61);
            this.Controls.Add(this.label62);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.clSpreadPosition);
            this.Controls.Add(this.clOptionSpreadComboBox);
            this.Controls.Add(this.clOptionNetComboBox);
            this.Controls.Add(this.clNetPosition);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.clFlyPosition);
            this.Controls.Add(this.clNetShortBox);
            this.Controls.Add(this.clNetLongBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SpreadCounter";
            this.Text = "Spread Counter Pro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SpreadCounter_FormClosing);
            this.Load += new System.EventHandler(this.SpreadCounter_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SpreadCounter_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox clNetShortBox;
        private System.Windows.Forms.TextBox clFlyPosition;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox clNetPosition;
        private System.Windows.Forms.TextBox clNetLongBox;
        private System.Windows.Forms.ComboBox clOptionNetComboBox;
        private System.Windows.Forms.ComboBox clOptionSpreadComboBox;
        private System.Windows.Forms.TextBox clSpreadPosition;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox rbSpreadPosition;
        private System.Windows.Forms.ComboBox rbOptionSpreadComboBox;
        private System.Windows.Forms.ComboBox rbOptionNetComboBox;
        private System.Windows.Forms.TextBox rbNetPosition;
        private System.Windows.Forms.TextBox rbFlyPosition;
        private System.Windows.Forms.TextBox rbNetShortBox;
        private System.Windows.Forms.TextBox rbNetLongBox;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.TextBox hoSpreadPosition;
        private System.Windows.Forms.ComboBox hoOptionSpreadComboBox;
        private System.Windows.Forms.ComboBox hoOptionNetComboBox;
        private System.Windows.Forms.TextBox hoNetPosition;
        private System.Windows.Forms.TextBox hoFlyPosition;
        private System.Windows.Forms.TextBox hoNetShortBox;
        private System.Windows.Forms.TextBox hoNetLongBox;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.TextBox ngSpreadPosition;
        private System.Windows.Forms.ComboBox ngOptionSpreadComboBox;
        private System.Windows.Forms.ComboBox ngOptionNetComboBox;
        private System.Windows.Forms.TextBox ngNetPosition;
        private System.Windows.Forms.TextBox ngFlyPosition;
        private System.Windows.Forms.TextBox ngNetShortBox;
        private System.Windows.Forms.TextBox ngNetLongBox;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.ListView crudeGrid;
        private System.Windows.Forms.ListView gasGrid;
        private System.Windows.Forms.ListView heatGrid;
        private System.Windows.Forms.ListView naturalGrid;
        private System.Windows.Forms.ListView brentGrid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button CrudeClearButton;
        private System.Windows.Forms.Button NaturalClearButton;
        private System.Windows.Forms.Button HeatClearButton;
        private System.Windows.Forms.Button GasClearButton;
        private System.Windows.Forms.Button BrentClearButton;
        private System.Windows.Forms.TextBox bzSpreadPosition;
        private System.Windows.Forms.ComboBox bzOptionSpreadComboBox;
        private System.Windows.Forms.ComboBox bzOptionNetComboBox;
        private System.Windows.Forms.TextBox bzNetPosition;
        private System.Windows.Forms.TextBox bzFlyPosition;
        private System.Windows.Forms.TextBox bzNetShortBox;
        private System.Windows.Forms.TextBox bzNetLongBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.Button LoadFile;
        private ComboBox accountComboBox;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem butterflyChartToolStripMenuItem;
        private ToolStripMenuItem inputTradesToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem clearAllToolStripMenuItem;
        private TextBox passwordTextBox;
    }
}

