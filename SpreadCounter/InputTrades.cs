//	SpreadCounter
//	Copyright (c) 2010 Addie Bendory

using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace SpreadCounter
{
    public partial class InputTrades : Form
    {
        SpreadCounter sc;

        /// <summary>
        /// Initializes a new instance of the <see cref="InputTrades"/> class.
        /// </summary>
        public InputTrades()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputTrades"/> class.
        /// </summary>
        /// <param name="form1">The form1.</param>
        public InputTrades(SpreadCounter form1)
        {
            InitializeComponent();
            sc = new SpreadCounter();
            sc = form1;
            sc.Show();
        }

        /// <summary>
        /// Handles the Click event of the SubmitButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void BuyButton_Click(object sender, EventArgs e)
        {
            SubmitTrade(true);
            PositionTextBox.Focus();
        }

        /// <summary>
        /// Handles the Click event of the SubmitButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void SellButton_Click(object sender, EventArgs e)
        {
            SubmitTrade(false);
            PositionTextBox.Focus();
        }

        /// <summary>
        /// Submits the trade.
        /// </summary>
        private void SubmitTrade(bool buy)
        {
            if (ContractComboBox.Text == "" ||
                MonthComboBox.Text == "" ||
                YearTextBox.Text == "" ||
                PositionTextBox.Text == "" ||
                PositionTextBox.Text == "0" ||
                (YearTextBox.Text.Length != 2 && YearTextBox.Text.Length != 4))
            {
                return;
            }

            SpreadCounter.Trade input = new SpreadCounter.Trade();
            string month = GetMonthText(MonthComboBox.Text);
            string year = GetYearText(YearTextBox.Text);
            string date = String.Concat(month, year);
            DateTime dateobj;
            DateTime.TryParseExact(date, "MMMyy", new CultureInfo("en-US"), DateTimeStyles.None, out dateobj);
            int position = Convert.ToInt32(PositionTextBox.Text);
            if (buy)
            {
                string summarystring = String.Format("{0}\t{1}\t{2}{3}{4}{5}", "Long", PositionTextBox.Text, ContractComboBox.Text, MonthComboBox.Text, year, Environment.NewLine);
                ColorText(summarystring, Color.Blue);
                SummaryTextBox.AppendText(summarystring);
                input = new SpreadCounter.Trade(dateobj, position, 0);
            }
            else
            {
                string summarystring = String.Format("{0}\t{1}\t{2}{3}{4}{5}", "Short", PositionTextBox.Text, ContractComboBox.Text, MonthComboBox.Text, year, Environment.NewLine);
                ColorText(summarystring, Color.Red);
                SummaryTextBox.AppendText(summarystring);
                input = new SpreadCounter.Trade(dateobj, 0, position);
            }
            SummaryTextBox.SelectionStart = SummaryTextBox.Text.Length;
            SummaryTextBox.ScrollToCaret();
            PositionTextBox.Clear();
          
            // Determine if checkbox is checked or not
            bool clear = false;
            if (clearPosition_checkBox.CheckState == CheckState.Checked)
                clear = true;
            else
                clear = false;

            if (ContractComboBox.Text == "CL")
            {
                sc.UpdateInitialCrudePosition(input, clear);
                sc.BalanceCrudeContracts();
            }
            else if (ContractComboBox.Text == "RB")
            {
                sc.UpdateInitialGasPosition(input, clear);
                sc.BalanceGasContracts();
            }
            else if (ContractComboBox.Text == "HO")
            {
                sc.UpdateInitialHeatPosition(input, clear);
                sc.BalanceHeatContracts();
            }
            else if (ContractComboBox.Text == "NG")
            {
                sc.UpdateInitialNaturalPosition(input, clear);
                sc.BalanceNaturalContracts();
            }
            else if (ContractComboBox.Text == "BZ")
            {
                sc.UpdateInitialBrentPosition(input, clear);
                sc.BalanceNaturalContracts();
            }
            else
                return;

            // Increment displayed month and year values
            if (MonthComboBox.SelectedIndex == MonthComboBox.Items.Count - 1)
            {
                MonthComboBox.SelectedIndex = 0;
                YearTextBox.Text = Convert.ToString(Convert.ToInt32(YearTextBox.Text) + 1);
                return;
            }
            else if (MonthComboBox.SelectedIndex >= 0 && (MonthComboBox.SelectedIndex < MonthComboBox.Items.Count - 1))
            {
                MonthComboBox.SelectedIndex++;
            }
        }

        /// <summary>
        /// Colors the text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="length">The length.</param>
        /// <param name="color">The color.</param>
        private void ColorText(string text, Color color)
        {
            SummaryTextBox.SelectionStart = SummaryTextBox.TextLength;
            SummaryTextBox.SelectionLength = text.Length;
            SummaryTextBox.SelectionColor = color;
        }

        /// <summary>
        /// Clears the trades.
        /// </summary>
        private void ClearTrades()
        {
            SummaryTextBox.Clear();
        }
        
        /// <summary>
        /// Gets the month text.
        /// </summary>
        /// <param name="month">The month.</param>
        /// <returns></returns>
        private string GetMonthText(string month)
        {
            switch (month)
            {
                case "F":
                    return "Jan";
                case "G":
                    return "Feb";
                case "H":
                    return "Mar";
                case "J":
                    return "Apr";
                case "K":
                    return "May";
                case "M":
                    return "Jun";
                case "N":
                    return "Jul";
                case "Q":
                    return "Aug";
                case "U":
                    return "Sep";
                case "V":
                    return "Oct";
                case "X":
                    return "Nov";
                case "Z":
                    return "Dec";
                default:
                    return "";
            }
        }

        /// <summary>
        /// Gets the year text.
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns></returns>
        private string GetYearText(string year)
        {
            if (year.Length > 2)
                return year.Substring(year.Length - 2);
            else
                return year;
        }

        ///// <summary>
        ///// Handles the KeyDown event of the InputTrades control.
        ///// </summary>
        ///// <param name="sender">The source of the event.</param>
        ///// <param name="e">The <see cref="System.Windows.Forms.KeyEventArgs"/> instance containing the event data.</param>
        //private void InputTrades_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyData == Keys.Enter)
        //    {
        //        SubmitTrade();
        //    }
        //}

        /// <summary>
        /// Handles the FormClosing event of the InputTrades control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.FormClosingEventArgs"/> instance containing the event data.</param>
        private void InputTrades_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClearTrades();
            Hide();
            e.Cancel = true; // this cancels the close event.
        }

        /// <summary>
        /// Handles the Click event of the ClearButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearTrades();
        }
    }
}
