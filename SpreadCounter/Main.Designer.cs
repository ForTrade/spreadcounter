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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpreadCounter));
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
            this.long_cl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.month_cl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.short_cl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gasGrid = new System.Windows.Forms.ListView();
            this.long_rb = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.month_rb = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.short_rb = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.heatGrid = new System.Windows.Forms.ListView();
            this.long_ho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.month_ho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.short_ho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.naturalGrid = new System.Windows.Forms.ListView();
            this.long_ng = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.month_ng = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.short_ng = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.brentGrid = new System.Windows.Forms.ListView();
            this.long_bz = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.month_bz = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.short_bz = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.crudeFlyGrid = new System.Windows.Forms.ListView();
            this.long_cl_fly = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.month_cl_fly = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.short_cl_fly = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.crudeDoubleFlyGrid = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.crudeTripleFlyGrid = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gasTripleFlyGrid = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gasDoubleFlyGrid = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.heatTripleFlyGrid = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.heatDoubleFlyGrid = new System.Windows.Forms.ListView();
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.naturalTripleFlyGrid = new System.Windows.Forms.ListView();
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.naturalDoubleFlyGrid = new System.Windows.Forms.ListView();
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.brentTripleFlyGrid = new System.Windows.Forms.ListView();
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader27 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.brentDoubleFlyGrid = new System.Windows.Forms.ListView();
            this.columnHeader28 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader29 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader30 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gasFlyGrid = new System.Windows.Forms.ListView();
            this.columnHeader31 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader32 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader33 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.heatFlyGrid = new System.Windows.Forms.ListView();
            this.columnHeader34 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader35 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader36 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.naturalFlyGrid = new System.Windows.Forms.ListView();
            this.columnHeader37 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader38 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader39 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.brentFlyGrid = new System.Windows.Forms.ListView();
            this.columnHeader40 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader41 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader42 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "CL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Net";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Spreads";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 385);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Flies";
            // 
            // clNetShortBox
            // 
            this.clNetShortBox.Location = new System.Drawing.Point(132, 328);
            this.clNetShortBox.Name = "clNetShortBox";
            this.clNetShortBox.ReadOnly = true;
            this.clNetShortBox.Size = new System.Drawing.Size(45, 20);
            this.clNetShortBox.TabIndex = 10;
            this.clNetShortBox.TabStop = false;
            this.clNetShortBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clFlyPosition
            // 
            this.clFlyPosition.Location = new System.Drawing.Point(132, 380);
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
            this.clNetPosition.Location = new System.Drawing.Point(82, 328);
            this.clNetPosition.Name = "clNetPosition";
            this.clNetPosition.ReadOnly = true;
            this.clNetPosition.Size = new System.Drawing.Size(45, 20);
            this.clNetPosition.TabIndex = 48;
            this.clNetPosition.TabStop = false;
            this.clNetPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clNetLongBox
            // 
            this.clNetLongBox.Location = new System.Drawing.Point(32, 328);
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
            this.clOptionNetComboBox.Location = new System.Drawing.Point(81, 355);
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
            this.clOptionSpreadComboBox.Location = new System.Drawing.Point(81, 380);
            this.clOptionSpreadComboBox.Name = "clOptionSpreadComboBox";
            this.clOptionSpreadComboBox.Size = new System.Drawing.Size(45, 21);
            this.clOptionSpreadComboBox.TabIndex = 6;
            this.clOptionSpreadComboBox.SelectedIndexChanged += new System.EventHandler(this.clOptionSpreadComboBox_SelectedIndexChanged);
            // 
            // clSpreadPosition
            // 
            this.clSpreadPosition.Location = new System.Drawing.Point(132, 355);
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
            this.rbSpreadPosition.Location = new System.Drawing.Point(314, 355);
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
            this.rbOptionSpreadComboBox.Location = new System.Drawing.Point(263, 380);
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
            this.rbOptionNetComboBox.Location = new System.Drawing.Point(263, 355);
            this.rbOptionNetComboBox.Name = "rbOptionNetComboBox";
            this.rbOptionNetComboBox.Size = new System.Drawing.Size(45, 21);
            this.rbOptionNetComboBox.TabIndex = 7;
            this.rbOptionNetComboBox.SelectedIndexChanged += new System.EventHandler(this.rbOptionNetComboBox_SelectedIndexChanged);
            // 
            // rbNetPosition
            // 
            this.rbNetPosition.Location = new System.Drawing.Point(263, 328);
            this.rbNetPosition.Name = "rbNetPosition";
            this.rbNetPosition.ReadOnly = true;
            this.rbNetPosition.Size = new System.Drawing.Size(45, 20);
            this.rbNetPosition.TabIndex = 173;
            this.rbNetPosition.TabStop = false;
            this.rbNetPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rbFlyPosition
            // 
            this.rbFlyPosition.Location = new System.Drawing.Point(314, 380);
            this.rbFlyPosition.Name = "rbFlyPosition";
            this.rbFlyPosition.ReadOnly = true;
            this.rbFlyPosition.Size = new System.Drawing.Size(45, 20);
            this.rbFlyPosition.TabIndex = 172;
            this.rbFlyPosition.TabStop = false;
            this.rbFlyPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rbNetShortBox
            // 
            this.rbNetShortBox.Location = new System.Drawing.Point(314, 328);
            this.rbNetShortBox.Name = "rbNetShortBox";
            this.rbNetShortBox.ReadOnly = true;
            this.rbNetShortBox.Size = new System.Drawing.Size(45, 20);
            this.rbNetShortBox.TabIndex = 170;
            this.rbNetShortBox.TabStop = false;
            this.rbNetShortBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rbNetLongBox
            // 
            this.rbNetLongBox.Location = new System.Drawing.Point(212, 328);
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
            this.label59.Location = new System.Drawing.Point(214, 385);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(28, 13);
            this.label59.TabIndex = 168;
            this.label59.Text = "Flies";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(214, 359);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(46, 13);
            this.label61.TabIndex = 166;
            this.label61.Text = "Spreads";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(273, 312);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(24, 13);
            this.label62.TabIndex = 165;
            this.label62.Text = "Net";
            // 
            // hoSpreadPosition
            // 
            this.hoSpreadPosition.Location = new System.Drawing.Point(493, 355);
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
            this.hoOptionSpreadComboBox.Location = new System.Drawing.Point(442, 380);
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
            this.hoOptionNetComboBox.Location = new System.Drawing.Point(442, 355);
            this.hoOptionNetComboBox.Name = "hoOptionNetComboBox";
            this.hoOptionNetComboBox.Size = new System.Drawing.Size(45, 21);
            this.hoOptionNetComboBox.TabIndex = 9;
            this.hoOptionNetComboBox.SelectedIndexChanged += new System.EventHandler(this.hoOptionNetComboBox_SelectedIndexChanged);
            // 
            // hoNetPosition
            // 
            this.hoNetPosition.Location = new System.Drawing.Point(442, 328);
            this.hoNetPosition.Name = "hoNetPosition";
            this.hoNetPosition.ReadOnly = true;
            this.hoNetPosition.Size = new System.Drawing.Size(45, 20);
            this.hoNetPosition.TabIndex = 188;
            this.hoNetPosition.TabStop = false;
            this.hoNetPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hoFlyPosition
            // 
            this.hoFlyPosition.Location = new System.Drawing.Point(493, 380);
            this.hoFlyPosition.Name = "hoFlyPosition";
            this.hoFlyPosition.ReadOnly = true;
            this.hoFlyPosition.Size = new System.Drawing.Size(45, 20);
            this.hoFlyPosition.TabIndex = 187;
            this.hoFlyPosition.TabStop = false;
            this.hoFlyPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hoNetShortBox
            // 
            this.hoNetShortBox.Location = new System.Drawing.Point(493, 328);
            this.hoNetShortBox.Name = "hoNetShortBox";
            this.hoNetShortBox.ReadOnly = true;
            this.hoNetShortBox.Size = new System.Drawing.Size(45, 20);
            this.hoNetShortBox.TabIndex = 185;
            this.hoNetShortBox.TabStop = false;
            this.hoNetShortBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hoNetLongBox
            // 
            this.hoNetLongBox.Location = new System.Drawing.Point(391, 328);
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
            this.label64.Location = new System.Drawing.Point(392, 385);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(28, 13);
            this.label64.TabIndex = 183;
            this.label64.Text = "Flies";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(390, 359);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(46, 13);
            this.label66.TabIndex = 181;
            this.label66.Text = "Spreads";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(453, 312);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(24, 13);
            this.label67.TabIndex = 180;
            this.label67.Text = "Net";
            // 
            // ngSpreadPosition
            // 
            this.ngSpreadPosition.Location = new System.Drawing.Point(673, 355);
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
            this.ngOptionSpreadComboBox.Location = new System.Drawing.Point(622, 380);
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
            this.ngOptionNetComboBox.Location = new System.Drawing.Point(622, 355);
            this.ngOptionNetComboBox.Name = "ngOptionNetComboBox";
            this.ngOptionNetComboBox.Size = new System.Drawing.Size(45, 21);
            this.ngOptionNetComboBox.TabIndex = 11;
            this.ngOptionNetComboBox.SelectedIndexChanged += new System.EventHandler(this.ngOptionNetComboBox_SelectedIndexChanged);
            // 
            // ngNetPosition
            // 
            this.ngNetPosition.Location = new System.Drawing.Point(622, 328);
            this.ngNetPosition.Name = "ngNetPosition";
            this.ngNetPosition.ReadOnly = true;
            this.ngNetPosition.Size = new System.Drawing.Size(45, 20);
            this.ngNetPosition.TabIndex = 203;
            this.ngNetPosition.TabStop = false;
            this.ngNetPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ngFlyPosition
            // 
            this.ngFlyPosition.Location = new System.Drawing.Point(673, 380);
            this.ngFlyPosition.Name = "ngFlyPosition";
            this.ngFlyPosition.ReadOnly = true;
            this.ngFlyPosition.Size = new System.Drawing.Size(45, 20);
            this.ngFlyPosition.TabIndex = 202;
            this.ngFlyPosition.TabStop = false;
            this.ngFlyPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ngNetShortBox
            // 
            this.ngNetShortBox.Location = new System.Drawing.Point(673, 328);
            this.ngNetShortBox.Name = "ngNetShortBox";
            this.ngNetShortBox.ReadOnly = true;
            this.ngNetShortBox.Size = new System.Drawing.Size(45, 20);
            this.ngNetShortBox.TabIndex = 200;
            this.ngNetShortBox.TabStop = false;
            this.ngNetShortBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ngNetLongBox
            // 
            this.ngNetLongBox.Location = new System.Drawing.Point(571, 328);
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
            this.label69.Location = new System.Drawing.Point(571, 385);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(28, 13);
            this.label69.TabIndex = 198;
            this.label69.Text = "Flies";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(570, 359);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(46, 13);
            this.label71.TabIndex = 196;
            this.label71.Text = "Spreads";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(633, 312);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(24, 13);
            this.label72.TabIndex = 195;
            this.label72.Text = "Net";
            // 
            // crudeGrid
            // 
            this.crudeGrid.BackgroundImageTiled = true;
            this.crudeGrid.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.long_cl,
            this.month_cl,
            this.short_cl});
            this.crudeGrid.FullRowSelect = true;
            this.crudeGrid.GridLines = true;
            this.crudeGrid.Location = new System.Drawing.Point(17, 59);
            this.crudeGrid.Name = "crudeGrid";
            this.crudeGrid.Size = new System.Drawing.Size(171, 250);
            this.crudeGrid.TabIndex = 210;
            this.crudeGrid.TabStop = false;
            this.crudeGrid.UseCompatibleStateImageBehavior = false;
            this.crudeGrid.View = System.Windows.Forms.View.Details;
            // 
            // long_cl
            // 
            this.long_cl.Text = "Long";
            this.long_cl.Width = 49;
            // 
            // month_cl
            // 
            this.month_cl.Text = "Month";
            this.month_cl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.month_cl.Width = 57;
            // 
            // short_cl
            // 
            this.short_cl.Text = "Short";
            this.short_cl.Width = 61;
            // 
            // gasGrid
            // 
            this.gasGrid.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.long_rb,
            this.month_rb,
            this.short_rb});
            this.gasGrid.FullRowSelect = true;
            this.gasGrid.GridLines = true;
            this.gasGrid.Location = new System.Drawing.Point(196, 59);
            this.gasGrid.Name = "gasGrid";
            this.gasGrid.Size = new System.Drawing.Size(171, 250);
            this.gasGrid.TabIndex = 211;
            this.gasGrid.TabStop = false;
            this.gasGrid.UseCompatibleStateImageBehavior = false;
            this.gasGrid.View = System.Windows.Forms.View.Details;
            // 
            // long_rb
            // 
            this.long_rb.Text = "Long";
            this.long_rb.Width = 57;
            // 
            // month_rb
            // 
            this.month_rb.Text = "Month";
            this.month_rb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.month_rb.Width = 57;
            // 
            // short_rb
            // 
            this.short_rb.Text = "Short";
            this.short_rb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.short_rb.Width = 57;
            // 
            // heatGrid
            // 
            this.heatGrid.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.long_ho,
            this.month_ho,
            this.short_ho});
            this.heatGrid.FullRowSelect = true;
            this.heatGrid.GridLines = true;
            this.heatGrid.Location = new System.Drawing.Point(377, 59);
            this.heatGrid.Name = "heatGrid";
            this.heatGrid.Size = new System.Drawing.Size(171, 250);
            this.heatGrid.TabIndex = 212;
            this.heatGrid.TabStop = false;
            this.heatGrid.UseCompatibleStateImageBehavior = false;
            this.heatGrid.View = System.Windows.Forms.View.Details;
            // 
            // long_ho
            // 
            this.long_ho.Text = "Long";
            this.long_ho.Width = 57;
            // 
            // month_ho
            // 
            this.month_ho.Text = "Month";
            this.month_ho.Width = 57;
            // 
            // short_ho
            // 
            this.short_ho.Text = "Short";
            this.short_ho.Width = 57;
            // 
            // naturalGrid
            // 
            this.naturalGrid.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.long_ng,
            this.month_ng,
            this.short_ng});
            this.naturalGrid.FullRowSelect = true;
            this.naturalGrid.GridLines = true;
            this.naturalGrid.Location = new System.Drawing.Point(554, 59);
            this.naturalGrid.Name = "naturalGrid";
            this.naturalGrid.Size = new System.Drawing.Size(171, 250);
            this.naturalGrid.TabIndex = 213;
            this.naturalGrid.TabStop = false;
            this.naturalGrid.UseCompatibleStateImageBehavior = false;
            this.naturalGrid.View = System.Windows.Forms.View.Details;
            // 
            // long_ng
            // 
            this.long_ng.Text = "Long";
            this.long_ng.Width = 57;
            // 
            // month_ng
            // 
            this.month_ng.Text = "Month";
            this.month_ng.Width = 57;
            // 
            // short_ng
            // 
            this.short_ng.Text = "Short";
            this.short_ng.Width = 57;
            // 
            // brentGrid
            // 
            this.brentGrid.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.long_bz,
            this.month_bz,
            this.short_bz});
            this.brentGrid.FullRowSelect = true;
            this.brentGrid.GridLines = true;
            this.brentGrid.Location = new System.Drawing.Point(733, 59);
            this.brentGrid.Name = "brentGrid";
            this.brentGrid.Size = new System.Drawing.Size(171, 250);
            this.brentGrid.TabIndex = 229;
            this.brentGrid.TabStop = false;
            this.brentGrid.UseCompatibleStateImageBehavior = false;
            this.brentGrid.View = System.Windows.Forms.View.Details;
            // 
            // long_bz
            // 
            this.long_bz.Text = "Long";
            this.long_bz.Width = 57;
            // 
            // month_bz
            // 
            this.month_bz.Text = "Month";
            this.month_bz.Width = 57;
            // 
            // short_bz
            // 
            this.short_bz.Text = "Short";
            this.short_bz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.short_bz.Width = 57;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(917, 24);
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
            this.inputTradesToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.inputTradesToolStripMenuItem.Text = "Input Trades";
            this.inputTradesToolStripMenuItem.Click += new System.EventHandler(this.inputTradesToolStripMenuItem_Click);
            // 
            // butterflyChartToolStripMenuItem
            // 
            this.butterflyChartToolStripMenuItem.Name = "butterflyChartToolStripMenuItem";
            this.butterflyChartToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
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
            this.CrudeClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.CrudeClearButton.Location = new System.Drawing.Point(153, 38);
            this.CrudeClearButton.Name = "CrudeClearButton";
            this.CrudeClearButton.Size = new System.Drawing.Size(35, 18);
            this.CrudeClearButton.TabIndex = 13;
            this.CrudeClearButton.Text = "Clear";
            this.CrudeClearButton.UseVisualStyleBackColor = true;
            this.CrudeClearButton.Click += new System.EventHandler(this.CrudeClearButton_Click);
            // 
            // NaturalClearButton
            // 
            this.NaturalClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.NaturalClearButton.Location = new System.Drawing.Point(690, 39);
            this.NaturalClearButton.Name = "NaturalClearButton";
            this.NaturalClearButton.Size = new System.Drawing.Size(35, 18);
            this.NaturalClearButton.TabIndex = 16;
            this.NaturalClearButton.Text = "Clear";
            this.NaturalClearButton.UseVisualStyleBackColor = true;
            this.NaturalClearButton.Click += new System.EventHandler(this.NaturalClearButton_Click);
            // 
            // HeatClearButton
            // 
            this.HeatClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.HeatClearButton.Location = new System.Drawing.Point(511, 39);
            this.HeatClearButton.Name = "HeatClearButton";
            this.HeatClearButton.Size = new System.Drawing.Size(35, 18);
            this.HeatClearButton.TabIndex = 15;
            this.HeatClearButton.Text = "Clear";
            this.HeatClearButton.UseVisualStyleBackColor = true;
            this.HeatClearButton.Click += new System.EventHandler(this.HeatClearButton_Click);
            // 
            // GasClearButton
            // 
            this.GasClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.GasClearButton.Location = new System.Drawing.Point(334, 41);
            this.GasClearButton.Name = "GasClearButton";
            this.GasClearButton.Size = new System.Drawing.Size(35, 18);
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
            this.LoadFile.Location = new System.Drawing.Point(525, 0);
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
            this.accountComboBox.Location = new System.Drawing.Point(271, 1);
            this.accountComboBox.Name = "accountComboBox";
            this.accountComboBox.Size = new System.Drawing.Size(83, 21);
            this.accountComboBox.TabIndex = 215;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.AcceptsReturn = true;
            this.passwordTextBox.Location = new System.Drawing.Point(419, 1);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 216;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // BrentClearButton
            // 
            this.BrentClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.BrentClearButton.Location = new System.Drawing.Point(869, 39);
            this.BrentClearButton.Name = "BrentClearButton";
            this.BrentClearButton.Size = new System.Drawing.Size(35, 18);
            this.BrentClearButton.TabIndex = 219;
            this.BrentClearButton.Text = "Clear";
            this.BrentClearButton.UseVisualStyleBackColor = true;
            this.BrentClearButton.Click += new System.EventHandler(this.BrentClearButton_Click);
            // 
            // bzSpreadPosition
            // 
            this.bzSpreadPosition.Location = new System.Drawing.Point(852, 355);
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
            this.bzOptionSpreadComboBox.Location = new System.Drawing.Point(801, 380);
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
            this.bzOptionNetComboBox.Location = new System.Drawing.Point(801, 355);
            this.bzOptionNetComboBox.Name = "bzOptionNetComboBox";
            this.bzOptionNetComboBox.Size = new System.Drawing.Size(45, 21);
            this.bzOptionNetComboBox.TabIndex = 217;
            // 
            // bzNetPosition
            // 
            this.bzNetPosition.Location = new System.Drawing.Point(801, 328);
            this.bzNetPosition.Name = "bzNetPosition";
            this.bzNetPosition.ReadOnly = true;
            this.bzNetPosition.Size = new System.Drawing.Size(45, 20);
            this.bzNetPosition.TabIndex = 227;
            this.bzNetPosition.TabStop = false;
            this.bzNetPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bzFlyPosition
            // 
            this.bzFlyPosition.Location = new System.Drawing.Point(852, 380);
            this.bzFlyPosition.Name = "bzFlyPosition";
            this.bzFlyPosition.ReadOnly = true;
            this.bzFlyPosition.Size = new System.Drawing.Size(45, 20);
            this.bzFlyPosition.TabIndex = 226;
            this.bzFlyPosition.TabStop = false;
            this.bzFlyPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bzNetShortBox
            // 
            this.bzNetShortBox.Location = new System.Drawing.Point(852, 328);
            this.bzNetShortBox.Name = "bzNetShortBox";
            this.bzNetShortBox.ReadOnly = true;
            this.bzNetShortBox.Size = new System.Drawing.Size(45, 20);
            this.bzNetShortBox.TabIndex = 225;
            this.bzNetShortBox.TabStop = false;
            this.bzNetShortBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bzNetLongBox
            // 
            this.bzNetLongBox.Location = new System.Drawing.Point(750, 328);
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
            this.label2.Location = new System.Drawing.Point(750, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 223;
            this.label2.Text = "Flies";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(749, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 222;
            this.label3.Text = "Spreads";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(812, 312);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(360, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 230;
            this.label8.Text = "Password";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(218, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 231;
            this.label10.Text = "Account";
            // 
            // crudeFlyGrid
            // 
            this.crudeFlyGrid.BackgroundImageTiled = true;
            this.crudeFlyGrid.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.long_cl_fly,
            this.month_cl_fly,
            this.short_cl_fly});
            this.crudeFlyGrid.FullRowSelect = true;
            this.crudeFlyGrid.GridLines = true;
            this.crudeFlyGrid.Location = new System.Drawing.Point(16, 414);
            this.crudeFlyGrid.Name = "crudeFlyGrid";
            this.crudeFlyGrid.Size = new System.Drawing.Size(171, 166);
            this.crudeFlyGrid.TabIndex = 232;
            this.crudeFlyGrid.TabStop = false;
            this.crudeFlyGrid.UseCompatibleStateImageBehavior = false;
            this.crudeFlyGrid.View = System.Windows.Forms.View.Details;
            // 
            // long_cl_fly
            // 
            this.long_cl_fly.Text = "Long";
            this.long_cl_fly.Width = 57;
            // 
            // month_cl_fly
            // 
            this.month_cl_fly.Text = "Month";
            this.month_cl_fly.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.month_cl_fly.Width = 57;
            // 
            // short_cl_fly
            // 
            this.short_cl_fly.Text = "Short";
            this.short_cl_fly.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.short_cl_fly.Width = 57;
            // 
            // crudeDoubleFlyGrid
            // 
            this.crudeDoubleFlyGrid.BackgroundImageTiled = true;
            this.crudeDoubleFlyGrid.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.crudeDoubleFlyGrid.FullRowSelect = true;
            this.crudeDoubleFlyGrid.GridLines = true;
            this.crudeDoubleFlyGrid.Location = new System.Drawing.Point(16, 586);
            this.crudeDoubleFlyGrid.Name = "crudeDoubleFlyGrid";
            this.crudeDoubleFlyGrid.Size = new System.Drawing.Size(171, 142);
            this.crudeDoubleFlyGrid.TabIndex = 233;
            this.crudeDoubleFlyGrid.TabStop = false;
            this.crudeDoubleFlyGrid.UseCompatibleStateImageBehavior = false;
            this.crudeDoubleFlyGrid.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Long";
            this.columnHeader1.Width = 47;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Month";
            this.columnHeader2.Width = 57;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Short";
            // 
            // crudeTripleFlyGrid
            // 
            this.crudeTripleFlyGrid.BackgroundImageTiled = true;
            this.crudeTripleFlyGrid.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.crudeTripleFlyGrid.FullRowSelect = true;
            this.crudeTripleFlyGrid.GridLines = true;
            this.crudeTripleFlyGrid.Location = new System.Drawing.Point(18, 734);
            this.crudeTripleFlyGrid.Name = "crudeTripleFlyGrid";
            this.crudeTripleFlyGrid.Size = new System.Drawing.Size(169, 142);
            this.crudeTripleFlyGrid.TabIndex = 234;
            this.crudeTripleFlyGrid.TabStop = false;
            this.crudeTripleFlyGrid.UseCompatibleStateImageBehavior = false;
            this.crudeTripleFlyGrid.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Long";
            this.columnHeader4.Width = 57;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Month";
            this.columnHeader5.Width = 57;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Short";
            this.columnHeader6.Width = 57;
            // 
            // gasTripleFlyGrid
            // 
            this.gasTripleFlyGrid.BackgroundImageTiled = true;
            this.gasTripleFlyGrid.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.gasTripleFlyGrid.FullRowSelect = true;
            this.gasTripleFlyGrid.GridLines = true;
            this.gasTripleFlyGrid.Location = new System.Drawing.Point(195, 734);
            this.gasTripleFlyGrid.Name = "gasTripleFlyGrid";
            this.gasTripleFlyGrid.Size = new System.Drawing.Size(171, 142);
            this.gasTripleFlyGrid.TabIndex = 236;
            this.gasTripleFlyGrid.TabStop = false;
            this.gasTripleFlyGrid.UseCompatibleStateImageBehavior = false;
            this.gasTripleFlyGrid.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Long";
            this.columnHeader7.Width = 57;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Month";
            this.columnHeader8.Width = 57;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Short";
            this.columnHeader9.Width = 57;
            // 
            // gasDoubleFlyGrid
            // 
            this.gasDoubleFlyGrid.BackgroundImageTiled = true;
            this.gasDoubleFlyGrid.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.gasDoubleFlyGrid.FullRowSelect = true;
            this.gasDoubleFlyGrid.GridLines = true;
            this.gasDoubleFlyGrid.Location = new System.Drawing.Point(195, 586);
            this.gasDoubleFlyGrid.Name = "gasDoubleFlyGrid";
            this.gasDoubleFlyGrid.Size = new System.Drawing.Size(171, 142);
            this.gasDoubleFlyGrid.TabIndex = 235;
            this.gasDoubleFlyGrid.TabStop = false;
            this.gasDoubleFlyGrid.UseCompatibleStateImageBehavior = false;
            this.gasDoubleFlyGrid.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Long";
            this.columnHeader10.Width = 57;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Month";
            this.columnHeader11.Width = 57;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Short";
            this.columnHeader12.Width = 57;
            // 
            // heatTripleFlyGrid
            // 
            this.heatTripleFlyGrid.BackgroundImageTiled = true;
            this.heatTripleFlyGrid.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.heatTripleFlyGrid.FullRowSelect = true;
            this.heatTripleFlyGrid.GridLines = true;
            this.heatTripleFlyGrid.Location = new System.Drawing.Point(374, 734);
            this.heatTripleFlyGrid.Name = "heatTripleFlyGrid";
            this.heatTripleFlyGrid.Size = new System.Drawing.Size(171, 142);
            this.heatTripleFlyGrid.TabIndex = 238;
            this.heatTripleFlyGrid.TabStop = false;
            this.heatTripleFlyGrid.UseCompatibleStateImageBehavior = false;
            this.heatTripleFlyGrid.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Long";
            this.columnHeader13.Width = 57;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Month";
            this.columnHeader14.Width = 57;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Short";
            this.columnHeader15.Width = 57;
            // 
            // heatDoubleFlyGrid
            // 
            this.heatDoubleFlyGrid.BackgroundImageTiled = true;
            this.heatDoubleFlyGrid.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18});
            this.heatDoubleFlyGrid.FullRowSelect = true;
            this.heatDoubleFlyGrid.GridLines = true;
            this.heatDoubleFlyGrid.Location = new System.Drawing.Point(374, 586);
            this.heatDoubleFlyGrid.Name = "heatDoubleFlyGrid";
            this.heatDoubleFlyGrid.Size = new System.Drawing.Size(171, 142);
            this.heatDoubleFlyGrid.TabIndex = 237;
            this.heatDoubleFlyGrid.TabStop = false;
            this.heatDoubleFlyGrid.UseCompatibleStateImageBehavior = false;
            this.heatDoubleFlyGrid.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Long";
            this.columnHeader16.Width = 57;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Month";
            this.columnHeader17.Width = 57;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Short";
            this.columnHeader18.Width = 57;
            // 
            // naturalTripleFlyGrid
            // 
            this.naturalTripleFlyGrid.BackgroundImageTiled = true;
            this.naturalTripleFlyGrid.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21});
            this.naturalTripleFlyGrid.FullRowSelect = true;
            this.naturalTripleFlyGrid.GridLines = true;
            this.naturalTripleFlyGrid.Location = new System.Drawing.Point(553, 734);
            this.naturalTripleFlyGrid.Name = "naturalTripleFlyGrid";
            this.naturalTripleFlyGrid.Size = new System.Drawing.Size(171, 142);
            this.naturalTripleFlyGrid.TabIndex = 240;
            this.naturalTripleFlyGrid.TabStop = false;
            this.naturalTripleFlyGrid.UseCompatibleStateImageBehavior = false;
            this.naturalTripleFlyGrid.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Long";
            this.columnHeader19.Width = 57;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Month";
            this.columnHeader20.Width = 57;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Short";
            this.columnHeader21.Width = 57;
            // 
            // naturalDoubleFlyGrid
            // 
            this.naturalDoubleFlyGrid.BackgroundImageTiled = true;
            this.naturalDoubleFlyGrid.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader22,
            this.columnHeader23,
            this.columnHeader24});
            this.naturalDoubleFlyGrid.FullRowSelect = true;
            this.naturalDoubleFlyGrid.GridLines = true;
            this.naturalDoubleFlyGrid.Location = new System.Drawing.Point(553, 586);
            this.naturalDoubleFlyGrid.Name = "naturalDoubleFlyGrid";
            this.naturalDoubleFlyGrid.Size = new System.Drawing.Size(171, 142);
            this.naturalDoubleFlyGrid.TabIndex = 239;
            this.naturalDoubleFlyGrid.TabStop = false;
            this.naturalDoubleFlyGrid.UseCompatibleStateImageBehavior = false;
            this.naturalDoubleFlyGrid.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Long";
            this.columnHeader22.Width = 57;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "Month";
            this.columnHeader23.Width = 57;
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "Short";
            this.columnHeader24.Width = 57;
            // 
            // brentTripleFlyGrid
            // 
            this.brentTripleFlyGrid.BackgroundImageTiled = true;
            this.brentTripleFlyGrid.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader25,
            this.columnHeader26,
            this.columnHeader27});
            this.brentTripleFlyGrid.FullRowSelect = true;
            this.brentTripleFlyGrid.GridLines = true;
            this.brentTripleFlyGrid.Location = new System.Drawing.Point(732, 734);
            this.brentTripleFlyGrid.Name = "brentTripleFlyGrid";
            this.brentTripleFlyGrid.Size = new System.Drawing.Size(171, 142);
            this.brentTripleFlyGrid.TabIndex = 242;
            this.brentTripleFlyGrid.TabStop = false;
            this.brentTripleFlyGrid.UseCompatibleStateImageBehavior = false;
            this.brentTripleFlyGrid.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "Long";
            this.columnHeader25.Width = 57;
            // 
            // columnHeader26
            // 
            this.columnHeader26.Text = "Month";
            this.columnHeader26.Width = 57;
            // 
            // columnHeader27
            // 
            this.columnHeader27.Text = "Short";
            this.columnHeader27.Width = 57;
            // 
            // brentDoubleFlyGrid
            // 
            this.brentDoubleFlyGrid.BackgroundImageTiled = true;
            this.brentDoubleFlyGrid.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader28,
            this.columnHeader29,
            this.columnHeader30});
            this.brentDoubleFlyGrid.FullRowSelect = true;
            this.brentDoubleFlyGrid.GridLines = true;
            this.brentDoubleFlyGrid.Location = new System.Drawing.Point(732, 586);
            this.brentDoubleFlyGrid.Name = "brentDoubleFlyGrid";
            this.brentDoubleFlyGrid.Size = new System.Drawing.Size(171, 142);
            this.brentDoubleFlyGrid.TabIndex = 241;
            this.brentDoubleFlyGrid.TabStop = false;
            this.brentDoubleFlyGrid.UseCompatibleStateImageBehavior = false;
            this.brentDoubleFlyGrid.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader28
            // 
            this.columnHeader28.Text = "Long";
            this.columnHeader28.Width = 57;
            // 
            // columnHeader29
            // 
            this.columnHeader29.Text = "Month";
            this.columnHeader29.Width = 57;
            // 
            // columnHeader30
            // 
            this.columnHeader30.Text = "Short";
            this.columnHeader30.Width = 57;
            // 
            // gasFlyGrid
            // 
            this.gasFlyGrid.BackgroundImageTiled = true;
            this.gasFlyGrid.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader31,
            this.columnHeader32,
            this.columnHeader33});
            this.gasFlyGrid.FullRowSelect = true;
            this.gasFlyGrid.GridLines = true;
            this.gasFlyGrid.Location = new System.Drawing.Point(195, 414);
            this.gasFlyGrid.Name = "gasFlyGrid";
            this.gasFlyGrid.Size = new System.Drawing.Size(173, 166);
            this.gasFlyGrid.TabIndex = 243;
            this.gasFlyGrid.TabStop = false;
            this.gasFlyGrid.UseCompatibleStateImageBehavior = false;
            this.gasFlyGrid.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader31
            // 
            this.columnHeader31.Text = "Long";
            this.columnHeader31.Width = 57;
            // 
            // columnHeader32
            // 
            this.columnHeader32.Text = "Month";
            this.columnHeader32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader32.Width = 57;
            // 
            // columnHeader33
            // 
            this.columnHeader33.Text = "Short";
            this.columnHeader33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader33.Width = 57;
            // 
            // heatFlyGrid
            // 
            this.heatFlyGrid.BackgroundImageTiled = true;
            this.heatFlyGrid.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader34,
            this.columnHeader35,
            this.columnHeader36});
            this.heatFlyGrid.FullRowSelect = true;
            this.heatFlyGrid.GridLines = true;
            this.heatFlyGrid.Location = new System.Drawing.Point(374, 414);
            this.heatFlyGrid.Name = "heatFlyGrid";
            this.heatFlyGrid.Size = new System.Drawing.Size(171, 166);
            this.heatFlyGrid.TabIndex = 244;
            this.heatFlyGrid.TabStop = false;
            this.heatFlyGrid.UseCompatibleStateImageBehavior = false;
            this.heatFlyGrid.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader34
            // 
            this.columnHeader34.Text = "Long";
            this.columnHeader34.Width = 57;
            // 
            // columnHeader35
            // 
            this.columnHeader35.Text = "Month";
            this.columnHeader35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader35.Width = 57;
            // 
            // columnHeader36
            // 
            this.columnHeader36.Text = "Short";
            this.columnHeader36.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader36.Width = 57;
            // 
            // naturalFlyGrid
            // 
            this.naturalFlyGrid.BackgroundImageTiled = true;
            this.naturalFlyGrid.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader37,
            this.columnHeader38,
            this.columnHeader39});
            this.naturalFlyGrid.FullRowSelect = true;
            this.naturalFlyGrid.GridLines = true;
            this.naturalFlyGrid.Location = new System.Drawing.Point(553, 414);
            this.naturalFlyGrid.Name = "naturalFlyGrid";
            this.naturalFlyGrid.Size = new System.Drawing.Size(171, 166);
            this.naturalFlyGrid.TabIndex = 245;
            this.naturalFlyGrid.TabStop = false;
            this.naturalFlyGrid.UseCompatibleStateImageBehavior = false;
            this.naturalFlyGrid.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader37
            // 
            this.columnHeader37.Text = "Long";
            this.columnHeader37.Width = 57;
            // 
            // columnHeader38
            // 
            this.columnHeader38.Text = "Month";
            this.columnHeader38.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader38.Width = 57;
            // 
            // columnHeader39
            // 
            this.columnHeader39.Text = "Short";
            this.columnHeader39.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader39.Width = 57;
            // 
            // brentFlyGrid
            // 
            this.brentFlyGrid.BackgroundImageTiled = true;
            this.brentFlyGrid.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader40,
            this.columnHeader41,
            this.columnHeader42});
            this.brentFlyGrid.FullRowSelect = true;
            this.brentFlyGrid.GridLines = true;
            this.brentFlyGrid.Location = new System.Drawing.Point(732, 414);
            this.brentFlyGrid.Name = "brentFlyGrid";
            this.brentFlyGrid.Size = new System.Drawing.Size(171, 166);
            this.brentFlyGrid.TabIndex = 246;
            this.brentFlyGrid.TabStop = false;
            this.brentFlyGrid.UseCompatibleStateImageBehavior = false;
            this.brentFlyGrid.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader40
            // 
            this.columnHeader40.Text = "Long";
            this.columnHeader40.Width = 57;
            // 
            // columnHeader41
            // 
            this.columnHeader41.Text = "Month";
            this.columnHeader41.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader41.Width = 57;
            // 
            // columnHeader42
            // 
            this.columnHeader42.Text = "Short";
            this.columnHeader42.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader42.Width = 57;
            // 
            // SpreadCounter
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(917, 891);
            this.Controls.Add(this.brentFlyGrid);
            this.Controls.Add(this.naturalFlyGrid);
            this.Controls.Add(this.heatFlyGrid);
            this.Controls.Add(this.gasFlyGrid);
            this.Controls.Add(this.brentTripleFlyGrid);
            this.Controls.Add(this.brentDoubleFlyGrid);
            this.Controls.Add(this.naturalTripleFlyGrid);
            this.Controls.Add(this.naturalDoubleFlyGrid);
            this.Controls.Add(this.heatTripleFlyGrid);
            this.Controls.Add(this.heatDoubleFlyGrid);
            this.Controls.Add(this.gasTripleFlyGrid);
            this.Controls.Add(this.gasDoubleFlyGrid);
            this.Controls.Add(this.crudeTripleFlyGrid);
            this.Controls.Add(this.crudeDoubleFlyGrid);
            this.Controls.Add(this.crudeFlyGrid);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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

        private Label label1;
        private Label label6;
        private Label label7;
        private Label label9;
        private TextBox clNetShortBox;
        private TextBox clFlyPosition;
        private Label label14;
        private Label label19;
        private TextBox clNetPosition;
        private TextBox clNetLongBox;
        private ComboBox clOptionNetComboBox;
        private ComboBox clOptionSpreadComboBox;
        private TextBox clSpreadPosition;
        private Label label25;
        private TextBox rbSpreadPosition;
        private ComboBox rbOptionSpreadComboBox;
        private ComboBox rbOptionNetComboBox;
        private TextBox rbNetPosition;
        private TextBox rbFlyPosition;
        private TextBox rbNetShortBox;
        private TextBox rbNetLongBox;
        private Label label59;
        private Label label61;
        private Label label62;
        private TextBox hoSpreadPosition;
        private ComboBox hoOptionSpreadComboBox;
        private ComboBox hoOptionNetComboBox;
        private TextBox hoNetPosition;
        private TextBox hoFlyPosition;
        private TextBox hoNetShortBox;
        private TextBox hoNetLongBox;
        private Label label64;
        private Label label66;
        private Label label67;
        private TextBox ngSpreadPosition;
        private ComboBox ngOptionSpreadComboBox;
        private ComboBox ngOptionNetComboBox;
        private TextBox ngNetPosition;
        private TextBox ngFlyPosition;
        private TextBox ngNetShortBox;
        private TextBox ngNetLongBox;
        private Label label69;
        private Label label71;
        private Label label72;
        private ListView crudeGrid;
        private ListView gasGrid;
        private ListView heatGrid;
        private ListView naturalGrid;
        private ListView brentGrid;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button CrudeClearButton;
        private Button NaturalClearButton;
        private Button HeatClearButton;
        private Button GasClearButton;
        private Button BrentClearButton;
        private TextBox bzSpreadPosition;
        private ComboBox bzOptionSpreadComboBox;
        private ComboBox bzOptionNetComboBox;
        private TextBox bzNetPosition;
        private TextBox bzFlyPosition;
        private TextBox bzNetShortBox;
        private TextBox bzNetLongBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private OpenFileDialog openFD;
        private Button LoadFile;
        private ComboBox accountComboBox;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem butterflyChartToolStripMenuItem;
        private ToolStripMenuItem inputTradesToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem clearAllToolStripMenuItem;
        private TextBox passwordTextBox;
        private Label label8;
        private Label label10;
        private ListView crudeFlyGrid;
        private ColumnHeader long_cl;
        private ColumnHeader month_cl;
        private ColumnHeader short_cl;
        private ColumnHeader long_rb;
        private ColumnHeader month_rb;
        private ColumnHeader short_rb;
        private ColumnHeader long_ho;
        private ColumnHeader month_ho;
        private ColumnHeader short_ho;
        private ColumnHeader long_ng;
        private ColumnHeader month_ng;
        private ColumnHeader short_ng;
        private ColumnHeader long_bz;
        private ColumnHeader month_bz;
        private ColumnHeader short_bz;
        private ColumnHeader long_cl_fly;
        private ColumnHeader month_cl_fly;
        private ColumnHeader short_cl_fly;
        private ListView crudeDoubleFlyGrid;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ListView crudeTripleFlyGrid;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ListView gasTripleFlyGrid;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ListView gasDoubleFlyGrid;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ListView heatTripleFlyGrid;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private ListView heatDoubleFlyGrid;
        private ColumnHeader columnHeader16;
        private ColumnHeader columnHeader17;
        private ColumnHeader columnHeader18;
        private ListView naturalTripleFlyGrid;
        private ColumnHeader columnHeader19;
        private ColumnHeader columnHeader20;
        private ColumnHeader columnHeader21;
        private ListView naturalDoubleFlyGrid;
        private ColumnHeader columnHeader22;
        private ColumnHeader columnHeader23;
        private ColumnHeader columnHeader24;
        private ListView brentTripleFlyGrid;
        private ColumnHeader columnHeader25;
        private ColumnHeader columnHeader26;
        private ColumnHeader columnHeader27;
        private ListView brentDoubleFlyGrid;
        private ColumnHeader columnHeader28;
        private ColumnHeader columnHeader29;
        private ColumnHeader columnHeader30;
        private ListView gasFlyGrid;
        private ColumnHeader columnHeader31;
        private ColumnHeader columnHeader32;
        private ColumnHeader columnHeader33;
        private ListView heatFlyGrid;
        private ColumnHeader columnHeader34;
        private ColumnHeader columnHeader35;
        private ColumnHeader columnHeader36;
        private ListView naturalFlyGrid;
        private ColumnHeader columnHeader37;
        private ColumnHeader columnHeader38;
        private ColumnHeader columnHeader39;
        private ListView brentFlyGrid;
        private ColumnHeader columnHeader40;
        private ColumnHeader columnHeader41;
        private ColumnHeader columnHeader42;
    }
}

