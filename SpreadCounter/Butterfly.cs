//	SpreadCounter
//	Copyright (c) 2010 Addie Bendory

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpreadCounter
{
    public partial class Butterfly : Form
    {
        bool isElectronic = false;

        public Butterfly()
        {
            InitializeComponent();
            this.settlement_button.Select();
            this.productBox.Text = "RB";
            this.monthBox.Text = "F";
            this.yearBox.Text = "13";
            this.flyBox.Text = "1x";
        }
        private void Butterfly_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true; // this cancels the close event.
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright \x00a9 " + DateTime.Now.Year + " Addie A. Bendory. All rights reserved.", "Butterfly Constructor", MessageBoxButtons.OK);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isElectronic)
                ElectronicCalculations();
            else
                SettlementCalculations();
        }

        private void settlement_button_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton button = (RadioButton)sender;
            if (button.Checked)
                isElectronic = false;
        }

        private void electronic_button_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton button = (RadioButton)sender;
            if (button.Checked)
                isElectronic = true;
        }

        private void SettlementCalculations()
        {
            switch (flyBox.Text)
            {
                case "1x":
                    OneFlySettlement();
                    break;
                case "2x":
                    TwoFlySettlement();
                    break;
                case "3x":
                    ThreeFlySettlement();
                    break;
                case "4x":
                    FourFlySettlement();
                    break;
                case "5x":
                    FiveFlySettlement();
                    break;
                case "6x":
                    SixFlySettlement();
                    break;
                default:
                    break;
            }
        }

        private void OneFlySettlement()
        {
            string clipboardText = String.Empty;               //months: FGHJKMNQUVXZ  
            char monthOne, monthTwo, monthThree = '\0';
            int yearOne = Convert.ToInt32(yearBox.Text);
            int yearTwo = Convert.ToInt32(yearBox.Text) + 1;

            // (hoz-hof)-(hof-hog)

            Clipboard.Clear();

            switch (monthBox.Text)
            {
                case "F":
                    monthOne = 'F';
                    monthTwo = 'G';
                    monthThree = 'H';
                    clipboardText = "(" + productBox.Text + monthOne + yearBox.Text
                    + "-" + productBox.Text + monthTwo + yearBox.Text + ")-("
                    + productBox.Text + monthTwo + yearBox.Text
                    + "-" + productBox.Text + monthThree + yearBox.Text + ")";
                    break;
                case "G":
                    monthOne = 'G';
                    monthTwo = 'H';
                    monthThree = 'J';
                    clipboardText = "(" + productBox.Text + monthOne + yearBox.Text
                    + "-" + productBox.Text + monthTwo + yearBox.Text + ")-("
                    + productBox.Text + monthTwo + yearBox.Text
                    + "-" + productBox.Text + monthThree + yearBox.Text + ")";
                    break;
                case "H":
                    monthOne = 'H';
                    monthTwo = 'J';
                    monthThree = 'K';
                    clipboardText = "(" + productBox.Text + monthOne + yearBox.Text
                    + "-" + productBox.Text + monthTwo + yearBox.Text + ")-("
                    + productBox.Text + monthTwo + yearBox.Text
                    + "-" + productBox.Text + monthThree + yearBox.Text + ")";
                    break;
                case "J":
                    monthOne = 'J';
                    monthTwo = 'K';
                    monthThree = 'M';
                    clipboardText = "(" + productBox.Text + monthOne + yearBox.Text
                    + "-" + productBox.Text + monthTwo + yearBox.Text + ")-("
                    + productBox.Text + monthTwo + yearBox.Text
                    + "-" + productBox.Text + monthThree + yearBox.Text + ")";
                    break;
                case "K":
                    monthOne = 'K';
                    monthTwo = 'M';
                    monthThree = 'N';
                    clipboardText = "(" + productBox.Text + monthOne + yearBox.Text
                    + "-" + productBox.Text + monthTwo + yearBox.Text + ")-("
                    + productBox.Text + monthTwo + yearBox.Text
                    + "-" + productBox.Text + monthThree + yearBox.Text + ")";
                    break;
                case "M":
                    monthOne = 'M';
                    monthTwo = 'N';
                    monthThree = 'Q';
                    clipboardText = "(" + productBox.Text + monthOne + yearBox.Text
                    + "-" + productBox.Text + monthTwo + yearBox.Text + ")-("
                    + productBox.Text + monthTwo + yearBox.Text
                    + "-" + productBox.Text + monthThree + yearBox.Text + ")";
                    break;
                case "N":
                    monthOne = 'N';
                    monthTwo = 'Q';
                    monthThree = 'U';
                    clipboardText = "(" + productBox.Text + monthOne + yearBox.Text
                    + "-" + productBox.Text + monthTwo + yearBox.Text + ")-("
                    + productBox.Text + monthTwo + yearBox.Text
                    + "-" + productBox.Text + monthThree + yearBox.Text + ")";
                    break;
                case "Q":
                    monthOne = 'Q';
                    monthTwo = 'U';
                    monthThree = 'V';
                    clipboardText = "(" + productBox.Text + monthOne + yearBox.Text
                    + "-" + productBox.Text + monthTwo + yearBox.Text + ")-("
                    + productBox.Text + monthTwo + yearBox.Text
                    + "-" + productBox.Text + monthThree + yearBox.Text + ")";
                    break;
                case "U":
                    monthOne = 'U';
                    monthTwo = 'V';
                    monthThree = 'X';
                    clipboardText = "(" + productBox.Text + monthOne + yearBox.Text
                    + "-" + productBox.Text + monthTwo + yearBox.Text + ")-("
                    + productBox.Text + monthTwo + yearBox.Text
                    + "-" + productBox.Text + monthThree + yearBox.Text + ")";
                    break;
                case "V":
                    monthOne = 'V';
                    monthTwo = 'X';
                    monthThree = 'Z';
                    clipboardText = "(" + productBox.Text + monthOne + yearBox.Text
                    + "-" + productBox.Text + monthTwo + yearBox.Text + ")-("
                    + productBox.Text + monthTwo + yearBox.Text
                    + "-" + productBox.Text + monthThree + yearBox.Text + ")";
                    break;
                case "X":
                    monthOne = 'X';
                    monthTwo = 'Z';
                    monthThree = 'F';
                    if (yearOne < 9)
                    {
                        clipboardText = "(" + productBox.Text + monthOne + "0" + yearOne.ToString()
                        + "-" + productBox.Text + monthTwo + "0" + yearOne.ToString() + ")-("
                        + productBox.Text + monthTwo + "0" + yearOne.ToString()
                        + "-" + productBox.Text + monthThree + "0" + yearTwo.ToString() + ")";
                    }
                    else if (yearOne == 9)
                    {
                        clipboardText = "(" + productBox.Text + monthOne + "0" + yearOne.ToString()
                        + "-" + productBox.Text + monthTwo + "0" + yearOne.ToString() + ")-("
                        + productBox.Text + monthTwo + "0" + yearOne.ToString()
                        + "-" + productBox.Text + monthThree + yearTwo.ToString() + ")";
                    }
                    else if (yearOne > 9)
                    {
                        clipboardText = "(" + productBox.Text + monthOne + yearOne.ToString()
                        + "-" + productBox.Text + monthTwo + yearOne.ToString() + ")-("
                        + productBox.Text + monthTwo + yearOne.ToString()
                        + "-" + productBox.Text + monthThree + yearTwo.ToString() + ")";
                    }
                    break;
                case "Z":
                    monthOne = 'Z';
                    monthTwo = 'F';
                    monthThree = 'G';
                    if (yearOne < 9)
                    {
                        clipboardText = "(" + productBox.Text + monthOne + "0" + yearOne.ToString()
                        + "-" + productBox.Text + monthTwo + "0" + yearOne.ToString() + ")-("
                        + productBox.Text + monthTwo + "0" + yearOne.ToString()
                        + "-" + productBox.Text + monthThree + "0" + yearTwo.ToString() + ")";
                    }
                    else if (yearOne == 9)
                    {
                        clipboardText = "(" + productBox.Text + monthOne + "0" + yearOne.ToString()
                        + "-" + productBox.Text + monthTwo + yearTwo.ToString() + ")-("
                        + productBox.Text + monthTwo + yearTwo.ToString()
                        + "-" + productBox.Text + monthThree + yearTwo.ToString() + ")";
                    }
                    else if (yearOne > 9)
                    {
                        clipboardText = "(" + productBox.Text + monthOne + yearOne.ToString()
                        + "-" + productBox.Text + monthTwo + yearTwo.ToString() + ")-("
                        + productBox.Text + monthTwo + yearTwo.ToString()
                        + "-" + productBox.Text + monthThree + yearTwo.ToString() + ")";
                    }
                    break;
                default:
                    break;
            }

            Clipboard.SetText(clipboardText);
            //MessageBox.Show("Single Fly Copied.", "Copy Successful",
            //MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void TwoFlySettlement()
        {
            string clipboardText = String.Empty;               //months: FGHJKMNQUVXZ  
            char monthOne, monthTwo, monthThree, monthFour = '\0';
            int yearOne = Convert.ToInt32(yearBox.Text);
            int yearTwo = Convert.ToInt32(yearBox.Text) + 1;

            // ((hoz-hof)-(hof-hog))-((hof-hog)-(Hog-hoh))

            Clipboard.Clear();

            switch (monthBox.Text)
            {
                case "F":
                    monthOne = 'F';
                    monthTwo = 'G';
                    monthThree = 'H';
                    monthFour = 'J';
                    clipboardText = "((" + productBox.Text + monthOne + yearBox.Text
                    + "-" + productBox.Text + monthTwo + yearBox.Text + ")-("
                    + productBox.Text + monthTwo + yearBox.Text
                    + "-" + productBox.Text + monthThree + yearBox.Text + "))-(("
                    + productBox.Text + monthTwo + yearBox.Text
                    + "-" + productBox.Text + monthThree + yearBox.Text + ")-("
                    + productBox.Text + monthThree + yearBox.Text
                    + "-" + productBox.Text + monthFour + yearBox.Text + "))";
                    break;
                case "G":
                    monthOne = 'G';
                    monthTwo = 'H';
                    monthThree = 'J';
                    monthFour = 'K';
                    clipboardText = "((" + productBox.Text + monthOne + yearBox.Text
                    + "-" + productBox.Text + monthTwo + yearBox.Text + ")-("
                    + productBox.Text + monthTwo + yearBox.Text
                    + "-" + productBox.Text + monthThree + yearBox.Text + "))-(("
                    + productBox.Text + monthTwo + yearBox.Text
                    + "-" + productBox.Text + monthThree + yearBox.Text + ")-("
                    + productBox.Text + monthThree + yearBox.Text
                    + "-" + productBox.Text + monthFour + yearBox.Text + "))";
                    break;
                case "H":
                    monthOne = 'H';
                    monthTwo = 'J';
                    monthThree = 'K';
                    monthFour = 'M';
                    clipboardText = "((" + productBox.Text + monthOne + yearBox.Text
                    + "-" + productBox.Text + monthTwo + yearBox.Text + ")-("
                    + productBox.Text + monthTwo + yearBox.Text
                    + "-" + productBox.Text + monthThree + yearBox.Text + "))-(("
                    + productBox.Text + monthTwo + yearBox.Text
                    + "-" + productBox.Text + monthThree + yearBox.Text + ")-("
                    + productBox.Text + monthThree + yearBox.Text
                    + "-" + productBox.Text + monthFour + yearBox.Text + "))";
                    break;
                case "J":
                    monthOne = 'J';
                    monthTwo = 'K';
                    monthThree = 'M';
                    monthFour = 'N';
                    clipboardText = "((" + productBox.Text + monthOne + yearBox.Text
                    + "-" + productBox.Text + monthTwo + yearBox.Text + ")-("
                    + productBox.Text + monthTwo + yearBox.Text
                    + "-" + productBox.Text + monthThree + yearBox.Text + "))-(("
                    + productBox.Text + monthTwo + yearBox.Text
                    + "-" + productBox.Text + monthThree + yearBox.Text + ")-("
                    + productBox.Text + monthThree + yearBox.Text
                    + "-" + productBox.Text + monthFour + yearBox.Text + "))";
                    break;
                case "K":
                    monthOne = 'K';
                    monthTwo = 'M';
                    monthThree = 'N';
                    monthFour = 'Q';
                    clipboardText = "((" + productBox.Text + monthOne + yearBox.Text
                    + "-" + productBox.Text + monthTwo + yearBox.Text + ")-("
                    + productBox.Text + monthTwo + yearBox.Text
                    + "-" + productBox.Text + monthThree + yearBox.Text + "))-(("
                    + productBox.Text + monthTwo + yearBox.Text
                    + "-" + productBox.Text + monthThree + yearBox.Text + ")-("
                    + productBox.Text + monthThree + yearBox.Text
                    + "-" + productBox.Text + monthFour + yearBox.Text + "))";
                    break;
                case "M":
                    monthOne = 'M';
                    monthTwo = 'N';
                    monthThree = 'Q';
                    monthFour = 'U';
                    clipboardText = "((" + productBox.Text + monthOne + yearBox.Text
                    + "-" + productBox.Text + monthTwo + yearBox.Text + ")-("
                    + productBox.Text + monthTwo + yearBox.Text
                    + "-" + productBox.Text + monthThree + yearBox.Text + "))-(("
                    + productBox.Text + monthTwo + yearBox.Text
                    + "-" + productBox.Text + monthThree + yearBox.Text + ")-("
                    + productBox.Text + monthThree + yearBox.Text
                    + "-" + productBox.Text + monthFour + yearBox.Text + "))";
                    break;
                case "N":
                    monthOne = 'N';
                    monthTwo = 'Q';
                    monthThree = 'U';
                    monthFour = 'V';
                    clipboardText = "((" + productBox.Text + monthOne + yearBox.Text
                    + "-" + productBox.Text + monthTwo + yearBox.Text + ")-("
                    + productBox.Text + monthTwo + yearBox.Text
                    + "-" + productBox.Text + monthThree + yearBox.Text + "))-(("
                    + productBox.Text + monthTwo + yearBox.Text
                    + "-" + productBox.Text + monthThree + yearBox.Text + ")-("
                    + productBox.Text + monthThree + yearBox.Text
                    + "-" + productBox.Text + monthFour + yearBox.Text + "))";
                    break;
                case "Q":
                    monthOne = 'Q';
                    monthTwo = 'U';
                    monthThree = 'V';
                    monthFour = 'X';
                    clipboardText = "((" + productBox.Text + monthOne + yearBox.Text
                    + "-" + productBox.Text + monthTwo + yearBox.Text + ")-("
                    + productBox.Text + monthTwo + yearBox.Text
                    + "-" + productBox.Text + monthThree + yearBox.Text + "))-(("
                    + productBox.Text + monthTwo + yearBox.Text
                    + "-" + productBox.Text + monthThree + yearBox.Text + ")-("
                    + productBox.Text + monthThree + yearBox.Text
                    + "-" + productBox.Text + monthFour + yearBox.Text + "))";
                    break;
                case "U":
                    monthOne = 'U';
                    monthTwo = 'V';
                    monthThree = 'X';
                    monthFour = 'Z';
                    clipboardText = "((" + productBox.Text + monthOne + yearBox.Text
                    + "-" + productBox.Text + monthTwo + yearBox.Text + ")-("
                    + productBox.Text + monthTwo + yearBox.Text
                    + "-" + productBox.Text + monthThree + yearBox.Text + "))-(("
                    + productBox.Text + monthTwo + yearBox.Text
                    + "-" + productBox.Text + monthThree + yearBox.Text + ")-("
                    + productBox.Text + monthThree + yearBox.Text
                    + "-" + productBox.Text + monthFour + yearBox.Text + "))";
                    break;
                case "V":
                    monthOne = 'V';
                    monthTwo = 'X';
                    monthThree = 'Z';
                    monthFour = 'F';
                    if (yearOne < 9)
                    {
                        clipboardText = "((" + productBox.Text + monthOne + "0" + yearOne.ToString()
                        + "-" + productBox.Text + monthTwo + "0" + yearOne.ToString() + ")-("
                        + productBox.Text + monthTwo + "0" + yearOne.ToString()
                        + "-" + productBox.Text + monthThree + "0" + yearOne.ToString() + "))-(("
                        + productBox.Text + monthTwo + "0" + yearOne.ToString()
                        + "-" + productBox.Text + monthThree + "0" + yearOne.ToString() + ")-("
                        + productBox.Text + monthThree + "0" + yearOne.ToString()
                        + "-" + productBox.Text + monthFour + "0" + yearTwo.ToString() + "))";
                    }
                    else if (yearOne == 9)
                    {
                        clipboardText = "((" + productBox.Text + monthOne + "0" + yearOne.ToString()
                        + "-" + productBox.Text + monthTwo + "0" + yearOne.ToString() + ")-("
                        + productBox.Text + monthTwo + "0" + yearOne.ToString()
                        + "-" + productBox.Text + monthThree + "0" + yearOne.ToString() + "))-(("
                        + productBox.Text + monthTwo + "0" + yearOne.ToString()
                        + "-" + productBox.Text + monthThree + "0" + yearOne.ToString() + ")-("
                        + productBox.Text + monthThree + "0" + yearOne.ToString()
                        + "-" + productBox.Text + monthFour + yearTwo.ToString() + "))";
                    }
                    else if (yearOne > 9)
                    {
                        clipboardText = "((" + productBox.Text + monthOne + yearOne.ToString()
                        + "-" + productBox.Text + monthTwo + yearOne.ToString() + ")-("
                        + productBox.Text + monthTwo + yearOne.ToString()
                        + "-" + productBox.Text + monthThree + yearOne.ToString() + "))-(("
                        + productBox.Text + monthTwo + yearOne.ToString()
                        + "-" + productBox.Text + monthThree + yearOne.ToString() + ")-("
                        + productBox.Text + monthThree + yearOne.ToString()
                        + "-" + productBox.Text + monthFour + yearTwo.ToString() + "))";
                    }
                    break;
                case "X":
                    monthOne = 'X';
                    monthTwo = 'Z';
                    monthThree = 'F';
                    monthFour = 'G';
                    if (yearOne < 9)
                    {
                        clipboardText = "((" + productBox.Text + monthOne + "0" + yearOne.ToString()
                        + "-" + productBox.Text + monthTwo + "0" + yearOne.ToString() + ")-("
                        + productBox.Text + monthTwo + "0" + yearOne.ToString()
                        + "-" + productBox.Text + monthThree + "0" + yearTwo.ToString() + "))-(("
                        + productBox.Text + monthTwo + "0" + yearOne.ToString()
                        + "-" + productBox.Text + monthThree + "0" + yearTwo.ToString() + ")-("
                        + productBox.Text + monthThree + "0" + yearTwo.ToString()
                        + "-" + productBox.Text + monthFour + "0" + yearTwo.ToString() + "))";
                    }
                    else if (yearOne == 9)
                    {
                        clipboardText = "((" + productBox.Text + monthOne + "0" + yearOne.ToString()
                        + "-" + productBox.Text + monthTwo + "0" + yearOne.ToString() + ")-("
                        + productBox.Text + monthTwo + "0" + yearOne.ToString()
                        + "-" + productBox.Text + monthThree + yearTwo.ToString() + "))-(("
                        + productBox.Text + monthTwo + "0" + yearOne.ToString()
                        + "-" + productBox.Text + monthThree + yearTwo.ToString() + ")-("
                        + productBox.Text + monthThree + yearTwo.ToString()
                        + "-" + productBox.Text + monthFour + yearTwo.ToString() + "))";
                    }
                    else if (yearOne > 9)
                    {
                        clipboardText = "((" + productBox.Text + monthOne + yearOne.ToString()
                        + "-" + productBox.Text + monthTwo + yearOne.ToString() + ")-("
                        + productBox.Text + monthTwo + yearOne.ToString()
                        + "-" + productBox.Text + monthThree + yearTwo.ToString() + "))-(("
                        + productBox.Text + monthTwo + yearOne.ToString()
                        + "-" + productBox.Text + monthThree + yearTwo.ToString() + ")-("
                        + productBox.Text + monthThree + yearTwo.ToString()
                        + "-" + productBox.Text + monthFour + yearTwo.ToString() + "))";
                    }
                    break;
                case "Z":
                    monthOne = 'Z';
                    monthTwo = 'F';
                    monthThree = 'G';
                    monthFour = 'H';
                    if (yearOne < 9)
                    {
                        clipboardText = "((" + productBox.Text + monthOne + "0" + yearOne.ToString()
                        + "-" + productBox.Text + monthTwo + "0" + yearTwo.ToString() + ")-("
                        + productBox.Text + monthTwo + "0" + yearTwo.ToString()
                        + "-" + productBox.Text + monthThree + "0" + yearTwo.ToString() + "))-(("
                        + productBox.Text + monthTwo + "0" + yearTwo.ToString()
                        + "-" + productBox.Text + monthThree + "0" + yearTwo.ToString() + ")-("
                        + productBox.Text + monthThree + "0" + yearTwo.ToString()
                        + "-" + productBox.Text + monthFour + "0" + yearTwo.ToString() + "))";
                    }
                    else if (yearOne == 9)
                    {
                        clipboardText = "((" + productBox.Text + monthOne + "0" + yearOne.ToString()
                        + "-" + productBox.Text + monthTwo + yearTwo.ToString() + ")-("
                        + productBox.Text + monthTwo + yearTwo.ToString()
                        + "-" + productBox.Text + monthThree + yearTwo.ToString() + "))-(("
                        + productBox.Text + monthTwo + yearTwo.ToString()
                        + "-" + productBox.Text + monthThree + yearTwo.ToString() + ")-("
                        + productBox.Text + monthThree + yearTwo.ToString()
                        + "-" + productBox.Text + monthFour + yearTwo.ToString() + "))";
                    }
                    else if (yearOne > 9)
                    {
                        clipboardText = "((" + productBox.Text + monthOne + yearOne.ToString()
                        + "-" + productBox.Text + monthTwo + yearTwo.ToString() + ")-("
                        + productBox.Text + monthTwo + yearTwo.ToString()
                        + "-" + productBox.Text + monthThree + yearTwo.ToString() + "))-(("
                        + productBox.Text + monthTwo + yearTwo.ToString()
                        + "-" + productBox.Text + monthThree + yearTwo.ToString() + ")-("
                        + productBox.Text + monthThree + yearTwo.ToString()
                        + "-" + productBox.Text + monthFour + yearTwo.ToString() + "))";
                    }
                    break;
                default:
                    break;
            }

            Clipboard.SetText(clipboardText);
            //MessageBox.Show("Double Fly Copied.", "Copy Successful",
            //MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ThreeFlySettlement()
        {
            string clipboardText = String.Empty;               //months: FGHJKMNQUVXZ  
            char monthOne, monthTwo, monthThree, monthFour, monthFive = '\0';
            int yearOne = Convert.ToInt32(yearBox.Text);
            int yearTwo = Convert.ToInt32(yearBox.Text) + 1;

            // (((hoz-hof)-(hof-hog))-((hof-hog)-(hog-hoh)))-(((hof-hog)-(hog-hoh))-((hog-hoh)-(hoh-hoj)))


            Clipboard.Clear();

            if ((monthBox.Text == "F") || (monthBox.Text == "G") || (monthBox.Text == "H")
                            || (monthBox.Text == "J") || (monthBox.Text == "K") || (monthBox.Text == "M")
                            || (monthBox.Text == "N") || (monthBox.Text == "Q"))
            {
                switch (monthBox.Text)
                {
                    case "F":
                        monthOne = 'F';
                        monthTwo = 'G';
                        monthThree = 'H';
                        monthFour = 'J';
                        monthFive = 'K';
                        break;
                    case "G":
                        monthOne = 'G';
                        monthTwo = 'H';
                        monthThree = 'J';
                        monthFour = 'K';
                        monthFive = 'M';
                        break;
                    case "H":
                        monthOne = 'H';
                        monthTwo = 'J';
                        monthThree = 'K';
                        monthFour = 'M';
                        monthFive = 'N';
                        break;
                    case "J":
                        monthOne = 'J';
                        monthTwo = 'K';
                        monthThree = 'M';
                        monthFour = 'N';
                        monthFive = 'Q';
                        break;
                    case "K":
                        monthOne = 'K';
                        monthTwo = 'M';
                        monthThree = 'N';
                        monthFour = 'Q';
                        monthFive = 'U';
                        break;
                    case "M":
                        monthOne = 'M';
                        monthTwo = 'N';
                        monthThree = 'Q';
                        monthFour = 'U';
                        monthFive = 'V';
                        break;
                    case "N":
                        monthOne = 'N';
                        monthTwo = 'Q';
                        monthThree = 'U';
                        monthFour = 'V';
                        monthFive = 'X';
                        break;
                    case "Q":
                        monthOne = 'Q';
                        monthTwo = 'U';
                        monthThree = 'V';
                        monthFour = 'X';
                        monthFive = 'Z';
                        break;
                    default:
                        monthOne = 'F';
                        monthTwo = 'F';
                        monthThree = 'F';
                        monthFour = 'F';
                        monthFive = 'F';
                        break;
                }
                clipboardText = "(((" + productBox.Text + monthOne + yearBox.Text
                                    + "-" + productBox.Text + monthTwo + yearBox.Text + ")-("
                                    + productBox.Text + monthTwo + yearBox.Text
                                    + "-" + productBox.Text + monthThree + yearBox.Text + "))-(("
                                    + productBox.Text + monthTwo + yearBox.Text
                                    + "-" + productBox.Text + monthThree + yearBox.Text + ")-("
                                    + productBox.Text + monthThree + yearBox.Text
                                    + "-" + productBox.Text + monthFour + yearBox.Text + ")))-((("
                                    + productBox.Text + monthTwo + yearBox.Text
                                    + "-" + productBox.Text + monthThree + yearBox.Text + ")-("
                                    + productBox.Text + monthThree + yearBox.Text
                                    + "-" + productBox.Text + monthFour + yearBox.Text + "))-(("
                                    + productBox.Text + monthThree + yearBox.Text
                                    + "-" + productBox.Text + monthFour + yearBox.Text + ")-("
                                    + productBox.Text + monthFour + yearBox.Text
                                    + "-" + productBox.Text + monthFive + yearBox.Text + ")))";

            }
            else if ((monthBox.Text == "U") || (monthBox.Text == "V")
                || (monthBox.Text == "X") || (monthBox.Text == "Z"))
            {

                switch (monthBox.Text)
                {
                    case "U":
                        monthOne = 'U';
                        monthTwo = 'V';
                        monthThree = 'X';
                        monthFour = 'Z';
                        monthFive = 'F';
                        if (yearOne < 9)
                        {
                            clipboardText = "(((" + productBox.Text + monthOne + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthTwo + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthTwo + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + "0" + yearOne.ToString() + "))-(("
                            + productBox.Text + monthTwo + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthThree + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearOne.ToString() + ")))-((("
                            + productBox.Text + monthTwo + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthThree + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearOne.ToString() + "))-(("
                            + productBox.Text + monthThree + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthFour + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFive + "0" + yearTwo.ToString() + ")))";
                        }
                        else if (yearOne == 9)
                        {
                            clipboardText = "(((" + productBox.Text + monthOne + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthTwo + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthTwo + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + "0" + yearOne.ToString() + "))-(("
                            + productBox.Text + monthTwo + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthThree + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearOne.ToString() + ")))-((("
                            + productBox.Text + monthTwo + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthThree + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearOne.ToString() + "))-(("
                            + productBox.Text + monthThree + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthFour + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFive + yearTwo.ToString() + ")))";
                        }
                        else if (yearOne > 9)
                        {
                            clipboardText = "(((" + productBox.Text + monthOne + yearOne.ToString()
                            + "-" + productBox.Text + monthTwo + yearOne.ToString() + ")-("
                            + productBox.Text + monthTwo + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + yearOne.ToString() + "))-(("
                            + productBox.Text + monthTwo + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + yearOne.ToString() + ")-("
                            + productBox.Text + monthThree + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + yearOne.ToString() + ")))-((("
                            + productBox.Text + monthTwo + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + yearOne.ToString() + ")-("
                            + productBox.Text + monthThree + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + yearOne.ToString() + "))-(("
                            + productBox.Text + monthThree + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + yearOne.ToString() + ")-("
                            + productBox.Text + monthFour + yearOne.ToString()
                            + "-" + productBox.Text + monthFive + yearTwo.ToString() + ")))";
                        }
                        break;
                    case "V":
                        monthOne = 'V';
                        monthTwo = 'X';
                        monthThree = 'Z';
                        monthFour = 'F';
                        monthFive = 'G';
                        if (yearOne < 9)
                        {
                            clipboardText = "(((" + productBox.Text + monthOne + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthTwo + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthTwo + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + "0" + yearOne.ToString() + "))-(("
                            + productBox.Text + monthTwo + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthThree + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearTwo.ToString() + ")))-((("
                            + productBox.Text + monthTwo + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthThree + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearTwo.ToString() + "))-(("
                            + productBox.Text + monthThree + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearTwo.ToString() + ")-("
                            + productBox.Text + monthFour + "0" + yearTwo.ToString()
                            + "-" + productBox.Text + monthFive + "0" + yearTwo.ToString() + ")))";
                        }
                        else if (yearOne == 9)
                        {
                            clipboardText = "(((" + productBox.Text + monthOne + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthTwo + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthTwo + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + "0" + yearOne.ToString() + "))-(("
                            + productBox.Text + monthTwo + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthThree + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + ")))-((("
                            + productBox.Text + monthTwo + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthThree + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + "))-(("
                            + productBox.Text + monthThree + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + ")-("
                            + productBox.Text + monthFour + yearTwo.ToString()
                            + "-" + productBox.Text + monthFive + yearTwo.ToString() + ")))";
                        }
                        else if (yearOne > 9)
                        {
                            clipboardText = "(((" + productBox.Text + monthOne + yearOne.ToString()
                            + "-" + productBox.Text + monthTwo + yearOne.ToString() + ")-("
                            + productBox.Text + monthTwo + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + yearOne.ToString() + "))-(("
                            + productBox.Text + monthTwo + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + yearOne.ToString() + ")-("
                            + productBox.Text + monthThree + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + ")))-((("
                            + productBox.Text + monthTwo + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + yearOne.ToString() + ")-("
                            + productBox.Text + monthThree + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + "))-(("
                            + productBox.Text + monthThree + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + ")-("
                            + productBox.Text + monthFour + yearTwo.ToString()
                            + "-" + productBox.Text + monthFive + yearTwo.ToString() + ")))";
                        }
                        break;
                    case "X":
                        monthOne = 'X';
                        monthTwo = 'Z';
                        monthThree = 'F';
                        monthFour = 'G';
                        monthFive = 'H';
                        if (yearOne < 9)
                        {
                            clipboardText = "(((" + productBox.Text + monthOne + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthTwo + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthTwo + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + "0" + yearTwo.ToString() + "))-(("
                            + productBox.Text + monthTwo + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + "0" + yearTwo.ToString() + ")-("
                            + productBox.Text + monthThree + "0" + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearTwo.ToString() + ")))-((("
                            + productBox.Text + monthTwo + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + "0" + yearTwo.ToString() + ")-("
                            + productBox.Text + monthThree + "0" + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearTwo.ToString() + "))-(("
                            + productBox.Text + monthThree + "0" + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearTwo.ToString() + ")-("
                            + productBox.Text + monthFour + "0" + yearTwo.ToString()
                            + "-" + productBox.Text + monthFive + "0" + yearTwo.ToString() + ")))";
                        }
                        else if (yearOne == 9)
                        {
                            clipboardText = "(((" + productBox.Text + monthOne + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthTwo + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthTwo + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + yearTwo.ToString() + "))-(("
                            + productBox.Text + monthTwo + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + yearTwo.ToString() + ")-("
                            + productBox.Text + monthThree + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + ")))-((("
                            + productBox.Text + monthTwo + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + yearTwo.ToString() + ")-("
                            + productBox.Text + monthThree + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + "))-(("
                            + productBox.Text + monthThree + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + ")-("
                            + productBox.Text + monthFour + yearTwo.ToString()
                            + "-" + productBox.Text + monthFive + yearTwo.ToString() + ")))";
                        }
                        else if (yearOne > 9)
                        {
                            clipboardText = "(((" + productBox.Text + monthOne + yearOne.ToString()
                            + "-" + productBox.Text + monthTwo + yearOne.ToString() + ")-("
                            + productBox.Text + monthTwo + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + yearTwo.ToString() + "))-(("
                            + productBox.Text + monthTwo + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + yearTwo.ToString() + ")-("
                            + productBox.Text + monthThree + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + ")))-((("
                            + productBox.Text + monthTwo + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + yearTwo.ToString() + ")-("
                            + productBox.Text + monthThree + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + "))-(("
                            + productBox.Text + monthThree + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + ")-("
                            + productBox.Text + monthFour + yearTwo.ToString()
                            + "-" + productBox.Text + monthFive + yearTwo.ToString() + ")))";
                        }
                        break;
                    case "Z":
                        monthOne = 'Z';
                        monthTwo = 'F';
                        monthThree = 'G';
                        monthFour = 'H';
                        monthFive = 'J';
                        if (yearOne < 9)
                        {
                            clipboardText = "(((" + productBox.Text + monthOne + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthTwo + "0" + yearTwo.ToString() + ")-("
                            + productBox.Text + monthTwo + "0" + yearTwo.ToString()
                            + "-" + productBox.Text + monthThree + "0" + yearTwo.ToString() + "))-(("
                            + productBox.Text + monthTwo + "0" + yearTwo.ToString()
                            + "-" + productBox.Text + monthThree + "0" + yearTwo.ToString() + ")-("
                            + productBox.Text + monthThree + "0" + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearTwo.ToString() + ")))-((("
                            + productBox.Text + monthTwo + "0" + yearTwo.ToString()
                            + "-" + productBox.Text + monthThree + "0" + yearTwo.ToString() + ")-("
                            + productBox.Text + monthThree + "0" + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearTwo.ToString() + "))-(("
                            + productBox.Text + monthThree + "0" + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearTwo.ToString() + ")-("
                            + productBox.Text + monthFour + "0" + yearTwo.ToString()
                            + "-" + productBox.Text + monthFive + "0" + yearTwo.ToString() + ")))";
                        }
                        else if (yearOne == 9)
                        {
                            clipboardText = "(((" + productBox.Text + monthOne + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthTwo + yearTwo.ToString() + ")-("
                            + productBox.Text + monthTwo + yearTwo.ToString()
                            + "-" + productBox.Text + monthThree + yearTwo.ToString() + "))-(("
                            + productBox.Text + monthTwo + yearTwo.ToString()
                            + "-" + productBox.Text + monthThree + yearTwo.ToString() + ")-("
                            + productBox.Text + monthThree + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + ")))-((("
                            + productBox.Text + monthTwo + yearTwo.ToString()
                            + "-" + productBox.Text + monthThree + yearTwo.ToString() + ")-("
                            + productBox.Text + monthThree + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + "))-(("
                            + productBox.Text + monthThree + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + ")-("
                            + productBox.Text + monthFour + yearTwo.ToString()
                            + "-" + productBox.Text + monthFive + yearTwo.ToString() + ")))";
                        }
                        else if (yearOne > 9)
                        {
                            clipboardText = "(((" + productBox.Text + monthOne + yearOne.ToString()
                            + "-" + productBox.Text + monthTwo + yearTwo.ToString() + ")-("
                            + productBox.Text + monthTwo + yearTwo.ToString()
                            + "-" + productBox.Text + monthThree + yearTwo.ToString() + "))-(("
                            + productBox.Text + monthTwo + yearTwo.ToString()
                            + "-" + productBox.Text + monthThree + yearTwo.ToString() + ")-("
                            + productBox.Text + monthThree + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + ")))-((("
                            + productBox.Text + monthTwo + yearTwo.ToString()
                            + "-" + productBox.Text + monthThree + yearTwo.ToString() + ")-("
                            + productBox.Text + monthThree + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + "))-(("
                            + productBox.Text + monthThree + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + ")-("
                            + productBox.Text + monthFour + yearTwo.ToString()
                            + "-" + productBox.Text + monthFive + yearTwo.ToString() + ")))";
                        }
                        break;
                    default:
                        break;
                }
            }
            //triple fly example:(((hoz-hof)-(hof-hog))-((hof-hog)-(Hog-hoh)))-(((hof-hog)-(hog-hoh))-((hog-hoh)-(hoh-hoj)))

            Clipboard.SetText(clipboardText);
            //MessageBox.Show("Triple Fly Copied.", "Copy Successful",
            //MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FourFlySettlement()
        {
            string clipboardText = String.Empty;               //months: FGHJKMNQUVXZ  
            char monthOne, monthTwo, monthThree, monthFour, monthFive, monthSix = '\0';
            int yearOne = Convert.ToInt32(yearBox.Text);
            int yearTwo = Convert.ToInt32(yearBox.Text) + 1;

            //  ((((hoz-hof)-(hof-hog))-((hof-hog)-(hog-hoh)))-(((hof-hog)-(hog-hoh))-((hog-hoh)-(hoh-hoj))))
            // -((((hof-hog)-(hog-hoh))-((hog-hoh)-(hoh-hoj)))-(((hog-hoh)-(hoh-hoj))-((hoh-hoj)-(hoj-hok))))

            Clipboard.Clear();

            if ((monthBox.Text == "F") || (monthBox.Text == "G") || (monthBox.Text == "H")
                || (monthBox.Text == "J") || (monthBox.Text == "K") || (monthBox.Text == "M")
                || (monthBox.Text == "N"))
            {
                switch (monthBox.Text)
                {
                    case "F":
                        monthOne = 'F';
                        monthTwo = 'G';
                        monthThree = 'H';
                        monthFour = 'J';
                        monthFive = 'K';
                        monthSix = 'M';
                        break;
                    case "G":
                        monthOne = 'G';
                        monthTwo = 'H';
                        monthThree = 'J';
                        monthFour = 'K';
                        monthFive = 'M';
                        monthSix = 'N';
                        break;
                    case "H":
                        monthOne = 'H';
                        monthTwo = 'J';
                        monthThree = 'K';
                        monthFour = 'M';
                        monthFive = 'N';
                        monthSix = 'Q';
                        break;
                    case "J":
                        monthOne = 'J';
                        monthTwo = 'K';
                        monthThree = 'M';
                        monthFour = 'N';
                        monthFive = 'Q';
                        monthSix = 'U';
                        break;
                    case "K":
                        monthOne = 'K';
                        monthTwo = 'M';
                        monthThree = 'N';
                        monthFour = 'Q';
                        monthFive = 'U';
                        monthSix = 'V';
                        break;
                    case "M":
                        monthOne = 'M';
                        monthTwo = 'N';
                        monthThree = 'Q';
                        monthFour = 'U';
                        monthFive = 'V';
                        monthSix = 'X';
                        break;
                    case "N":
                        monthOne = 'N';
                        monthTwo = 'Q';
                        monthThree = 'U';
                        monthFour = 'V';
                        monthFive = 'X';
                        monthSix = 'Z';
                        break;
                    default:
                        monthOne = 'F';
                        monthTwo = 'F';
                        monthThree = 'F';
                        monthFour = 'F';
                        monthFive = 'F';
                        monthSix = 'F';
                        break;
                }

                clipboardText = "((((" + productBox.Text + monthOne + yearBox.Text
                + "-" + productBox.Text + monthTwo + yearBox.Text + ")-("
                + productBox.Text + monthTwo + yearBox.Text
                + "-" + productBox.Text + monthThree + yearBox.Text + "))-(("
                + productBox.Text + monthTwo + yearBox.Text
                + "-" + productBox.Text + monthThree + yearBox.Text + ")-("
                + productBox.Text + monthThree + yearBox.Text
                + "-" + productBox.Text + monthFour + yearBox.Text + ")))-((("
                + productBox.Text + monthTwo + yearBox.Text
                + "-" + productBox.Text + monthThree + yearBox.Text + ")-("
                + productBox.Text + monthThree + yearBox.Text
                + "-" + productBox.Text + monthFour + yearBox.Text + "))-(("
                + productBox.Text + monthThree + yearBox.Text
                + "-" + productBox.Text + monthFour + yearBox.Text + ")-("
                + productBox.Text + monthFour + yearBox.Text
                + "-" + productBox.Text + monthFive + yearBox.Text + "))))-(((("
                + productBox.Text + monthTwo + yearBox.Text
                + "-" + productBox.Text + monthThree + yearBox.Text + ")-("
                + productBox.Text + monthThree + yearBox.Text
                + "-" + productBox.Text + monthFour + yearBox.Text + "))-(("
                + productBox.Text + monthThree + yearBox.Text
                + "-" + productBox.Text + monthFour + yearBox.Text + ")-("
                + productBox.Text + monthFour + yearBox.Text
                + "-" + productBox.Text + monthFive + yearBox.Text + ")))-((("
                + productBox.Text + monthThree + yearBox.Text
                + "-" + productBox.Text + monthFour + yearBox.Text + ")-("
                + productBox.Text + monthFour + yearBox.Text
                + "-" + productBox.Text + monthFive + yearBox.Text + "))-(("
                + productBox.Text + monthFour + yearBox.Text
                + "-" + productBox.Text + monthFive + yearBox.Text + ")-("
                + productBox.Text + monthFive + yearBox.Text
                + "-" + productBox.Text + monthSix + yearBox.Text + "))))";


            }
            else if ((monthBox.Text == "Q") || (monthBox.Text == "U") || (monthBox.Text == "V")
                || (monthBox.Text == "X") || (monthBox.Text == "Z"))
            {

                switch (monthBox.Text)
                {
                    case "Q":
                        monthOne = 'Q';
                        monthTwo = 'U';
                        monthThree = 'V';
                        monthFour = 'X';
                        monthFive = 'Z';
                        monthSix = 'F';
                        if (yearOne < 9)
                        {
                            clipboardText = "((((" + productBox.Text + monthOne + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthTwo + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthTwo + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + "0" + yearOne.ToString() + "))-(("
                            + productBox.Text + monthTwo + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthThree + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearOne.ToString() + ")))-((("
                            + productBox.Text + monthTwo + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthThree + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearOne.ToString() + "))-(("
                            + productBox.Text + monthThree + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthFour + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFive + "0" + yearOne.ToString() + "))))-(((("
                            + productBox.Text + monthTwo + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthThree + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearOne.ToString() + "))-(("
                            + productBox.Text + monthThree + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthFour + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFive + "0" + yearOne.ToString() + ")))-((("
                            + productBox.Text + monthThree + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthFour + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFive + "0" + yearOne.ToString() + "))-(("
                            + productBox.Text + monthFour + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFive + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthFive + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthSix + "0" + yearTwo.ToString() + "))))";
                        }
                        else if (yearOne == 9)
                        {
                            clipboardText = "((((" + productBox.Text + monthOne + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthTwo + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthTwo + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + "0" + yearOne.ToString() + "))-(("
                            + productBox.Text + monthTwo + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthThree + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearOne.ToString() + ")))-((("
                            + productBox.Text + monthTwo + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthThree + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearOne.ToString() + "))-(("
                            + productBox.Text + monthThree + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthFour + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFive + "0" + yearOne.ToString() + "))))-(((("
                            + productBox.Text + monthTwo + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthThree + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearOne.ToString() + "))-(("
                            + productBox.Text + monthThree + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthFour + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFive + "0" + yearOne.ToString() + ")))-((("
                            + productBox.Text + monthThree + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthFour + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFive + "0" + yearOne.ToString() + "))-(("
                            + productBox.Text + monthFour + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFive + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthFive + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthSix + yearTwo.ToString() + "))))";
                        }
                        else if (yearOne > 9)
                        {
                            clipboardText = "((((" + productBox.Text + monthOne + yearOne.ToString()
                            + "-" + productBox.Text + monthTwo + yearOne.ToString() + ")-("
                            + productBox.Text + monthTwo + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + yearOne.ToString() + "))-(("
                            + productBox.Text + monthTwo + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + yearOne.ToString() + ")-("
                            + productBox.Text + monthThree + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + yearOne.ToString() + ")))-((("
                            + productBox.Text + monthTwo + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + yearOne.ToString() + ")-("
                            + productBox.Text + monthThree + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + yearOne.ToString() + "))-(("
                            + productBox.Text + monthThree + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + yearOne.ToString() + ")-("
                            + productBox.Text + monthFour + yearOne.ToString()
                            + "-" + productBox.Text + monthFive + yearOne.ToString() + "))))-(((("
                            + productBox.Text + monthTwo + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + yearOne.ToString() + ")-("
                            + productBox.Text + monthThree + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + yearOne.ToString() + "))-(("
                            + productBox.Text + monthThree + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + yearOne.ToString() + ")-("
                            + productBox.Text + monthFour + yearOne.ToString()
                            + "-" + productBox.Text + monthFive + yearOne.ToString() + ")))-((("
                            + productBox.Text + monthThree + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + yearOne.ToString() + ")-("
                            + productBox.Text + monthFour + yearOne.ToString()
                            + "-" + productBox.Text + monthFive + yearOne.ToString() + "))-(("
                            + productBox.Text + monthFour + yearOne.ToString()
                            + "-" + productBox.Text + monthFive + yearOne.ToString() + ")-("
                            + productBox.Text + monthFive + yearOne.ToString()
                            + "-" + productBox.Text + monthSix + yearTwo.ToString() + "))))";
                        }
                        break;
                    case "U":
                        monthOne = 'U';
                        monthTwo = 'V';
                        monthThree = 'X';
                        monthFour = 'Z';
                        monthFive = 'F';
                        monthSix = 'G';
                        if (yearOne < 9)
                        {
                            clipboardText = "((((" + productBox.Text + monthOne + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthTwo + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthTwo + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + "0" + yearOne.ToString() + "))-(("
                            + productBox.Text + monthTwo + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthThree + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearOne.ToString() + ")))-((("
                            + productBox.Text + monthTwo + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthThree + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearOne.ToString() + "))-(("
                            + productBox.Text + monthThree + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthFour + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFive + "0" + yearTwo.ToString() + "))))-(((("
                            + productBox.Text + monthTwo + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthThree + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearOne.ToString() + "))-(("
                            + productBox.Text + monthThree + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthFour + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFive + "0" + yearTwo.ToString() + ")))-((("
                            + productBox.Text + monthThree + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthFour + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFive + "0" + yearTwo.ToString() + "))-(("
                            + productBox.Text + monthFour + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFive + "0" + yearTwo.ToString() + ")-("
                            + productBox.Text + monthFive + "0" + yearTwo.ToString()
                            + "-" + productBox.Text + monthSix + "0" + yearTwo.ToString() + "))))";
                        }
                        else if (yearOne == 9)
                        {
                            clipboardText = "((((" + productBox.Text + monthOne + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthTwo + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthTwo + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + "0" + yearOne.ToString() + "))-(("
                            + productBox.Text + monthTwo + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthThree + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearOne.ToString() + ")))-((("
                            + productBox.Text + monthTwo + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthThree + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearOne.ToString() + "))-(("
                            + productBox.Text + monthThree + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthFour + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFive + yearTwo.ToString() + "))))-(((("
                            + productBox.Text + monthTwo + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthThree + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearOne.ToString() + "))-(("
                            + productBox.Text + monthThree + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthFour + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFive + yearTwo.ToString() + ")))-((("
                            + productBox.Text + monthThree + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthFour + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFive + yearTwo.ToString() + "))-(("
                            + productBox.Text + monthFour + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFive + yearTwo.ToString() + ")-("
                            + productBox.Text + monthFive + yearTwo.ToString()
                            + "-" + productBox.Text + monthSix + yearTwo.ToString() + "))))";
                        }
                        else if (yearOne > 9)
                        {
                            clipboardText = "((((" + productBox.Text + monthOne + yearOne.ToString()
                            + "-" + productBox.Text + monthTwo + yearOne.ToString() + ")-("
                            + productBox.Text + monthTwo + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + yearOne.ToString() + "))-(("
                            + productBox.Text + monthTwo + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + yearOne.ToString() + ")-("
                            + productBox.Text + monthThree + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + yearOne.ToString() + ")))-((("
                            + productBox.Text + monthTwo + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + yearOne.ToString() + ")-("
                            + productBox.Text + monthThree + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + yearOne.ToString() + "))-(("
                            + productBox.Text + monthThree + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + yearOne.ToString() + ")-("
                            + productBox.Text + monthFour + yearOne.ToString()
                            + "-" + productBox.Text + monthFive + yearTwo.ToString() + "))))-(((("
                            + productBox.Text + monthTwo + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + yearOne.ToString() + ")-("
                            + productBox.Text + monthThree + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + yearOne.ToString() + "))-(("
                            + productBox.Text + monthThree + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + yearOne.ToString() + ")-("
                            + productBox.Text + monthFour + yearOne.ToString()
                            + "-" + productBox.Text + monthFive + yearTwo.ToString() + ")))-((("
                            + productBox.Text + monthThree + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + yearOne.ToString() + ")-("
                            + productBox.Text + monthFour + yearOne.ToString()
                            + "-" + productBox.Text + monthFive + yearTwo.ToString() + "))-(("
                            + productBox.Text + monthFour + yearOne.ToString()
                            + "-" + productBox.Text + monthFive + yearTwo.ToString() + ")-("
                            + productBox.Text + monthFive + yearTwo.ToString()
                            + "-" + productBox.Text + monthSix + yearTwo.ToString() + "))))";
                        }
                        break;
                    case "V":
                        monthOne = 'V';
                        monthTwo = 'X';
                        monthThree = 'Z';
                        monthFour = 'F';
                        monthFive = 'G';
                        monthSix = 'H';
                        if (yearOne < 9)
                        {
                            clipboardText = "((((" + productBox.Text + monthOne + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthTwo + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthTwo + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + "0" + yearOne.ToString() + "))-(("
                            + productBox.Text + monthTwo + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthThree + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearTwo.ToString() + ")))-((("
                            + productBox.Text + monthTwo + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthThree + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearTwo.ToString() + "))-(("
                            + productBox.Text + monthThree + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearTwo.ToString() + ")-("
                            + productBox.Text + monthFour + "0" + yearTwo.ToString()
                            + "-" + productBox.Text + monthFive + "0" + yearTwo.ToString() + "))))-(((("
                            + productBox.Text + monthTwo + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthThree + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearTwo.ToString() + "))-(("
                            + productBox.Text + monthThree + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearTwo.ToString() + ")-("
                            + productBox.Text + monthFour + "0" + yearTwo.ToString()
                            + "-" + productBox.Text + monthFive + "0" + yearTwo.ToString() + ")))-((("
                            + productBox.Text + monthThree + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearTwo.ToString() + ")-("
                            + productBox.Text + monthFour + "0" + yearTwo.ToString()
                            + "-" + productBox.Text + monthFive + "0" + yearTwo.ToString() + "))-(("
                            + productBox.Text + monthFour + "0" + yearTwo.ToString()
                            + "-" + productBox.Text + monthFive + "0" + yearTwo.ToString() + ")-("
                            + productBox.Text + monthFive + "0" + yearTwo.ToString()
                            + "-" + productBox.Text + monthSix + "0" + yearTwo.ToString() + "))))";
                        }
                        else if (yearOne == 9)
                        {
                            clipboardText = "((((" + productBox.Text + monthOne + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthTwo + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthTwo + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + "0" + yearOne.ToString() + "))-(("
                            + productBox.Text + monthTwo + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthThree + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + ")))-((("
                            + productBox.Text + monthTwo + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthThree + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + "))-(("
                            + productBox.Text + monthThree + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + ")-("
                            + productBox.Text + monthFour + yearTwo.ToString()
                            + "-" + productBox.Text + monthFive + yearTwo.ToString() + "))))-(((("
                            + productBox.Text + monthTwo + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthThree + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + "))-(("
                            + productBox.Text + monthThree + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + ")-("
                            + productBox.Text + monthFour + yearTwo.ToString()
                            + "-" + productBox.Text + monthFive + yearTwo.ToString() + ")))-((("
                            + productBox.Text + monthThree + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + ")-("
                            + productBox.Text + monthFour + yearTwo.ToString()
                            + "-" + productBox.Text + monthFive + yearTwo.ToString() + "))-(("
                            + productBox.Text + monthFour + yearTwo.ToString()
                            + "-" + productBox.Text + monthFive + yearTwo.ToString() + ")-("
                            + productBox.Text + monthFive + yearTwo.ToString()
                            + "-" + productBox.Text + monthSix + yearTwo.ToString() + "))))";
                        }
                        else if (yearOne > 9)
                        {
                            clipboardText = "((((" + productBox.Text + monthOne + yearOne.ToString()
                            + "-" + productBox.Text + monthTwo + yearOne.ToString() + ")-("
                            + productBox.Text + monthTwo + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + yearOne.ToString() + "))-(("
                            + productBox.Text + monthTwo + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + yearOne.ToString() + ")-("
                            + productBox.Text + monthThree + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + ")))-((("
                            + productBox.Text + monthTwo + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + yearOne.ToString() + ")-("
                            + productBox.Text + monthThree + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + "))-(("
                            + productBox.Text + monthThree + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + ")-("
                            + productBox.Text + monthFour + yearTwo.ToString()
                            + "-" + productBox.Text + monthFive + yearTwo.ToString() + "))))-(((("
                            + productBox.Text + monthTwo + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + yearOne.ToString() + ")-("
                            + productBox.Text + monthThree + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + "))-(("
                            + productBox.Text + monthThree + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + ")-("
                            + productBox.Text + monthFour + yearTwo.ToString()
                            + "-" + productBox.Text + monthFive + yearTwo.ToString() + ")))-((("
                            + productBox.Text + monthThree + yearOne.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + ")-("
                            + productBox.Text + monthFour + yearTwo.ToString()
                            + "-" + productBox.Text + monthFive + yearTwo.ToString() + "))-(("
                            + productBox.Text + monthFour + yearTwo.ToString()
                            + "-" + productBox.Text + monthFive + yearTwo.ToString() + ")-("
                            + productBox.Text + monthFive + yearTwo.ToString()
                            + "-" + productBox.Text + monthSix + yearTwo.ToString() + "))))";
                        }
                        break;
                    case "X":
                        monthOne = 'X';
                        monthTwo = 'Z';
                        monthThree = 'F';
                        monthFour = 'G';
                        monthFive = 'H';
                        monthSix = 'J';
                        if (yearOne < 9)
                        {
                            clipboardText = "((((" + productBox.Text + monthOne + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthTwo + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthTwo + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + "0" + yearTwo.ToString() + "))-(("
                            + productBox.Text + monthTwo + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + "0" + yearTwo.ToString() + ")-("
                            + productBox.Text + monthThree + "0" + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearTwo.ToString() + ")))-((("
                            + productBox.Text + monthTwo + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + "0" + yearTwo.ToString() + ")-("
                            + productBox.Text + monthThree + "0" + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearTwo.ToString() + "))-(("
                            + productBox.Text + monthThree + "0" + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearTwo.ToString() + ")-("
                            + productBox.Text + monthFour + "0" + yearTwo.ToString()
                            + "-" + productBox.Text + monthFive + "0" + yearTwo.ToString() + "))))-(((("
                            + productBox.Text + monthTwo + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + "0" + yearTwo.ToString() + ")-("
                            + productBox.Text + monthThree + "0" + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearTwo.ToString() + "))-(("
                            + productBox.Text + monthThree + "0" + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearTwo.ToString() + ")-("
                            + productBox.Text + monthFour + "0" + yearTwo.ToString()
                            + "-" + productBox.Text + monthFive + "0" + yearTwo.ToString() + ")))-((("
                            + productBox.Text + monthThree + "0" + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearTwo.ToString() + ")-("
                            + productBox.Text + monthFour + "0" + yearTwo.ToString()
                            + "-" + productBox.Text + monthFive + "0" + yearTwo.ToString() + "))-(("
                            + productBox.Text + monthFour + "0" + yearTwo.ToString()
                            + "-" + productBox.Text + monthFive + "0" + yearTwo.ToString() + ")-("
                            + productBox.Text + monthFive + "0" + yearTwo.ToString()
                            + "-" + productBox.Text + monthSix + "0" + yearTwo.ToString() + "))))";
                        }
                        else if (yearOne == 9)
                        {
                            clipboardText = "((((" + productBox.Text + monthOne + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthTwo + "0" + yearOne.ToString() + ")-("
                            + productBox.Text + monthTwo + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + yearTwo.ToString() + "))-(("
                            + productBox.Text + monthTwo + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + yearTwo.ToString() + ")-("
                            + productBox.Text + monthThree + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + ")))-((("
                            + productBox.Text + monthTwo + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + yearTwo.ToString() + ")-("
                            + productBox.Text + monthThree + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + "))-(("
                            + productBox.Text + monthThree + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + ")-("
                            + productBox.Text + monthFour + yearTwo.ToString()
                            + "-" + productBox.Text + monthFive + yearTwo.ToString() + "))))-(((("
                            + productBox.Text + monthTwo + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + yearTwo.ToString() + ")-("
                            + productBox.Text + monthThree + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + "))-(("
                            + productBox.Text + monthThree + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + ")-("
                            + productBox.Text + monthFour + yearTwo.ToString()
                            + "-" + productBox.Text + monthFive + yearTwo.ToString() + ")))-((("
                            + productBox.Text + monthThree + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + ")-("
                            + productBox.Text + monthFour + yearTwo.ToString()
                            + "-" + productBox.Text + monthFive + yearTwo.ToString() + "))-(("
                            + productBox.Text + monthFour + yearTwo.ToString()
                            + "-" + productBox.Text + monthFive + yearTwo.ToString() + ")-("
                            + productBox.Text + monthFive + yearTwo.ToString()
                            + "-" + productBox.Text + monthSix + yearTwo.ToString() + "))))";
                        }
                        else if (yearOne > 9)
                        {
                            clipboardText = "((((" + productBox.Text + monthOne + yearOne.ToString()
                            + "-" + productBox.Text + monthTwo + yearOne.ToString() + ")-("
                            + productBox.Text + monthTwo + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + yearTwo.ToString() + "))-(("
                            + productBox.Text + monthTwo + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + yearTwo.ToString() + ")-("
                            + productBox.Text + monthThree + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + ")))-((("
                            + productBox.Text + monthTwo + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + yearTwo.ToString() + ")-("
                            + productBox.Text + monthThree + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + "))-(("
                            + productBox.Text + monthThree + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + ")-("
                            + productBox.Text + monthFour + yearTwo.ToString()
                            + "-" + productBox.Text + monthFive + yearTwo.ToString() + "))))-(((("
                            + productBox.Text + monthTwo + yearOne.ToString()
                            + "-" + productBox.Text + monthThree + yearTwo.ToString() + ")-("
                            + productBox.Text + monthThree + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + "))-(("
                            + productBox.Text + monthThree + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + ")-("
                            + productBox.Text + monthFour + yearTwo.ToString()
                            + "-" + productBox.Text + monthFive + yearTwo.ToString() + ")))-((("
                            + productBox.Text + monthThree + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + ")-("
                            + productBox.Text + monthFour + yearTwo.ToString()
                            + "-" + productBox.Text + monthFive + yearTwo.ToString() + "))-(("
                            + productBox.Text + monthFour + yearTwo.ToString()
                            + "-" + productBox.Text + monthFive + yearTwo.ToString() + ")-("
                            + productBox.Text + monthFive + yearTwo.ToString()
                            + "-" + productBox.Text + monthSix + yearTwo.ToString() + "))))";
                        }
                        break;
                    case "Z":
                        monthOne = 'Z';
                        monthTwo = 'F';
                        monthThree = 'G';
                        monthFour = 'H';
                        monthFive = 'J';
                        monthSix = 'K';
                        if (yearOne < 9)
                        {
                            clipboardText = "((((" + productBox.Text + monthOne + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthTwo + "0" + yearTwo.ToString() + ")-("
                            + productBox.Text + monthTwo + "0" + yearTwo.ToString()
                            + "-" + productBox.Text + monthThree + "0" + yearTwo.ToString() + "))-(("
                            + productBox.Text + monthTwo + "0" + yearTwo.ToString()
                            + "-" + productBox.Text + monthThree + "0" + yearTwo.ToString() + ")-("
                            + productBox.Text + monthThree + "0" + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearTwo.ToString() + ")))-((("
                            + productBox.Text + monthTwo + "0" + yearTwo.ToString()
                            + "-" + productBox.Text + monthThree + "0" + yearTwo.ToString() + ")-("
                            + productBox.Text + monthThree + "0" + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearTwo.ToString() + "))-(("
                            + productBox.Text + monthThree + "0" + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearTwo.ToString() + ")-("
                            + productBox.Text + monthFour + "0" + yearTwo.ToString()
                            + "-" + productBox.Text + monthFive + "0" + yearTwo.ToString() + "))))-(((("
                            + productBox.Text + monthTwo + "0" + yearTwo.ToString()
                            + "-" + productBox.Text + monthThree + "0" + yearTwo.ToString() + ")-("
                            + productBox.Text + monthThree + "0" + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearTwo.ToString() + "))-(("
                            + productBox.Text + monthThree + "0" + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearTwo.ToString() + ")-("
                            + productBox.Text + monthFour + "0" + yearTwo.ToString()
                            + "-" + productBox.Text + monthFive + "0" + yearTwo.ToString() + ")))-((("
                            + productBox.Text + monthThree + "0" + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + "0" + yearTwo.ToString() + ")-("
                            + productBox.Text + monthFour + "0" + yearTwo.ToString()
                            + "-" + productBox.Text + monthFive + "0" + yearTwo.ToString() + "))-(("
                            + productBox.Text + monthFour + "0" + yearTwo.ToString()
                            + "-" + productBox.Text + monthFive + "0" + yearTwo.ToString() + ")-("
                            + productBox.Text + monthFive + "0" + yearTwo.ToString()
                            + "-" + productBox.Text + monthSix + "0" + yearTwo.ToString() + "))))";
                        }
                        else if (yearOne == 9)
                        {
                            clipboardText = "((((" + productBox.Text + monthOne + "0" + yearOne.ToString()
                            + "-" + productBox.Text + monthTwo + yearTwo.ToString() + ")-("
                            + productBox.Text + monthTwo + yearTwo.ToString()
                            + "-" + productBox.Text + monthThree + yearTwo.ToString() + "))-(("
                            + productBox.Text + monthTwo + yearTwo.ToString()
                            + "-" + productBox.Text + monthThree + yearTwo.ToString() + ")-("
                            + productBox.Text + monthThree + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + ")))-((("
                            + productBox.Text + monthTwo + yearTwo.ToString()
                            + "-" + productBox.Text + monthThree + yearTwo.ToString() + ")-("
                            + productBox.Text + monthThree + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + "))-(("
                            + productBox.Text + monthThree + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + ")-("
                            + productBox.Text + monthFour + yearTwo.ToString()
                            + "-" + productBox.Text + monthFive + yearTwo.ToString() + "))))-(((("
                            + productBox.Text + monthTwo + yearTwo.ToString()
                            + "-" + productBox.Text + monthThree + yearTwo.ToString() + ")-("
                            + productBox.Text + monthThree + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + "))-(("
                            + productBox.Text + monthThree + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + ")-("
                            + productBox.Text + monthFour + yearTwo.ToString()
                            + "-" + productBox.Text + monthFive + yearTwo.ToString() + ")))-((("
                            + productBox.Text + monthThree + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + ")-("
                            + productBox.Text + monthFour + yearTwo.ToString()
                            + "-" + productBox.Text + monthFive + yearTwo.ToString() + "))-(("
                            + productBox.Text + monthFour + yearTwo.ToString()
                            + "-" + productBox.Text + monthFive + yearTwo.ToString() + ")-("
                            + productBox.Text + monthFive + yearTwo.ToString()
                            + "-" + productBox.Text + monthSix + yearTwo.ToString() + "))))";
                        }
                        else if (yearOne > 9)
                        {
                            clipboardText = "((((" + productBox.Text + monthOne + yearOne.ToString()
                            + "-" + productBox.Text + monthTwo + yearTwo.ToString() + ")-("
                            + productBox.Text + monthTwo + yearTwo.ToString()
                            + "-" + productBox.Text + monthThree + yearTwo.ToString() + "))-(("
                            + productBox.Text + monthTwo + yearTwo.ToString()
                            + "-" + productBox.Text + monthThree + yearTwo.ToString() + ")-("
                            + productBox.Text + monthThree + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + ")))-((("
                            + productBox.Text + monthTwo + yearTwo.ToString()
                            + "-" + productBox.Text + monthThree + yearTwo.ToString() + ")-("
                            + productBox.Text + monthThree + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + "))-(("
                            + productBox.Text + monthThree + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + ")-("
                            + productBox.Text + monthFour + yearTwo.ToString()
                            + "-" + productBox.Text + monthFive + yearTwo.ToString() + "))))-(((("
                            + productBox.Text + monthTwo + yearTwo.ToString()
                            + "-" + productBox.Text + monthThree + yearTwo.ToString() + ")-("
                            + productBox.Text + monthThree + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + "))-(("
                            + productBox.Text + monthThree + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + ")-("
                            + productBox.Text + monthFour + yearTwo.ToString()
                            + "-" + productBox.Text + monthFive + yearTwo.ToString() + ")))-((("
                            + productBox.Text + monthThree + yearTwo.ToString()
                            + "-" + productBox.Text + monthFour + yearTwo.ToString() + ")-("
                            + productBox.Text + monthFour + yearTwo.ToString()
                            + "-" + productBox.Text + monthFive + yearTwo.ToString() + "))-(("
                            + productBox.Text + monthFour + yearTwo.ToString()
                            + "-" + productBox.Text + monthFive + yearTwo.ToString() + ")-("
                            + productBox.Text + monthFive + yearTwo.ToString()
                            + "-" + productBox.Text + monthSix + yearTwo.ToString() + "))))";
                        }
                        break;
                    default:
                        break;
                }
            }


            Clipboard.SetText(clipboardText);
            //MessageBox.Show("Quad Fly Copied.", "Copy Successful",
            //MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void FiveFlySettlement()
        {

            MessageBox.Show("Not yet implemented.");
        }

        private void SixFlySettlement()
        {

            MessageBox.Show("Not yet implemented.");
        }

        private void ElectronicCalculations()
        {
            switch (flyBox.Text)
            {
                case "1x":
                    OneFlyElectronic();
                    break;
                case "2x":
                    TwoFlyElectronic();
                    break;
                case "3x":
                    ThreeFlyElectronic();
                    break;
                case "4x":
                    FourFlyElectronic();
                    break;
                case "5x":
                    FiveFlyElectronic();
                    break;
                case "6x":
                    SixFlyElectronic();
                    break;
                default:
                    break;
            }
        }

        private void OneFlyElectronic()
        {
            string clipboardText = string.Empty;               //months: FGHJKMNQUVXZ  
            char monthOne, monthTwo = '\0';
            int yearOne = Convert.ToInt32(yearBox.Text);
            int yearTwo = Convert.ToInt32(yearBox.Text) + 1;

            // RBES1F0-RBES1G0

            Clipboard.Clear();

            string electronicProduct = productBox.Text + "ES1";

            switch (monthBox.Text)
            {
                case "F":
                    monthOne = 'F';
                    monthTwo = 'G';
                    clipboardText = "(" + electronicProduct + monthOne + yearBox.Text + ")-("
                    + electronicProduct + monthTwo + yearBox.Text + ")";
                    break;
                case "G":
                    monthOne = 'G';
                    monthTwo = 'H';
                    clipboardText = "(" + electronicProduct + monthOne + yearBox.Text + ")-("
                    + electronicProduct + monthTwo + yearBox.Text + ")";
                    break;
                case "H":
                    monthOne = 'H';
                    monthTwo = 'J';
                    clipboardText = "(" + electronicProduct + monthOne + yearBox.Text + ")-("
                    + electronicProduct + monthTwo + yearBox.Text + ")";
                    break;
                case "J":
                    monthOne = 'J';
                    monthTwo = 'K';
                    clipboardText = "(" + electronicProduct + monthOne + yearBox.Text + ")-("
                    + electronicProduct + monthTwo + yearBox.Text + ")";
                    break;
                case "K":
                    monthOne = 'K';
                    monthTwo = 'M';
                    clipboardText = "(" + electronicProduct + monthOne + yearBox.Text + ")-("
                    + electronicProduct + monthTwo + yearBox.Text + ")";
                    break;
                case "M":
                    monthOne = 'M';
                    monthTwo = 'N';
                    clipboardText = "(" + electronicProduct + monthOne + yearBox.Text + ")-("
                    + electronicProduct + monthTwo + yearBox.Text + ")";
                    break;
                case "N":
                    monthOne = 'N';
                    monthTwo = 'Q';
                    clipboardText = "(" + electronicProduct + monthOne + yearBox.Text + ")-("
                    + electronicProduct + monthTwo + yearBox.Text + ")";
                    break;
                case "Q":
                    monthOne = 'Q';
                    monthTwo = 'U';
                    clipboardText = "(" + electronicProduct + monthOne + yearBox.Text + ")-("
                    + electronicProduct + monthTwo + yearBox.Text + ")";
                    break;
                case "U":
                    monthOne = 'U';
                    monthTwo = 'V';
                    clipboardText = "(" + electronicProduct + monthOne + yearBox.Text + ")-("
                    + electronicProduct + monthTwo + yearBox.Text + ")";
                    break;
                case "V":
                    monthOne = 'V';
                    monthTwo = 'X';
                    clipboardText = "(" + electronicProduct + monthOne + yearBox.Text + ")-("
                    + electronicProduct + monthTwo + yearBox.Text + ")";
                    break;
                case "X":
                    monthOne = 'X';
                    monthTwo = 'Z';
                    clipboardText = "(" + electronicProduct + monthOne + yearBox.Text + ")-("
                    + electronicProduct + monthTwo + yearBox.Text + ")";
                    break;
                case "Z":
                    //RBES1Z0-RBES1F1
                    monthOne = 'Z';
                    monthTwo = 'F';
                    if (yearOne < 9)
                    {
                        clipboardText = "(" + electronicProduct + monthOne + yearBox.Text + ")-("
                        + electronicProduct + monthTwo + "0" + yearTwo.ToString() + ")";
                    }
                    else
                    {
                        clipboardText = "(" + electronicProduct + monthOne + yearBox.Text + ")-("
                        + electronicProduct + monthTwo + yearTwo.ToString() + ")";
                    }
                    break;
                default:
                    break;
            }

            Clipboard.SetText(clipboardText);
            //MessageBox.Show("Single Fly Copied.", "Copy Successful",
            //MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void TwoFlyElectronic()
        {
            string clipboardText = string.Empty;               //months: FGHJKMNQUVXZ  
            char monthOne, monthTwo, monthThree = '\0';
            int yearOne = Convert.ToInt32(yearBox.Text);
            int yearTwo = Convert.ToInt32(yearBox.Text) + 1;

            // (RBES1F0-RBES1G0)-(RBES1G0-RBES1H0)

            Clipboard.Clear();

            string electronicProduct = productBox.Text + "ES1";

            switch (monthBox.Text)
            {
                case "F":
                    monthOne = 'F';
                    monthTwo = 'G';
                    monthThree = 'H';
                    clipboardText = "(" + electronicProduct + monthOne + yearBox.Text
                    + "-" + electronicProduct + monthTwo + yearBox.Text + ")-("
                    + electronicProduct + monthTwo + yearBox.Text
                    + "-" + electronicProduct + monthThree + yearBox.Text + ")";
                    break;
                case "G":
                    monthOne = 'G';
                    monthTwo = 'H';
                    monthThree = 'J';
                    clipboardText = "(" + electronicProduct + monthOne + yearBox.Text
                    + "-" + electronicProduct + monthTwo + yearBox.Text + ")-("
                    + electronicProduct + monthTwo + yearBox.Text
                    + "-" + electronicProduct + monthThree + yearBox.Text + ")";
                    break;
                case "H":
                    monthOne = 'H';
                    monthTwo = 'J';
                    monthThree = 'K';
                    clipboardText = "(" + electronicProduct + monthOne + yearBox.Text
                    + "-" + electronicProduct + monthTwo + yearBox.Text + ")-("
                    + electronicProduct + monthTwo + yearBox.Text
                    + "-" + electronicProduct + monthThree + yearBox.Text + ")";
                    break;
                case "J":
                    monthOne = 'J';
                    monthTwo = 'K';
                    monthThree = 'M';
                    clipboardText = "(" + electronicProduct + monthOne + yearBox.Text
                    + "-" + electronicProduct + monthTwo + yearBox.Text + ")-("
                    + electronicProduct + monthTwo + yearBox.Text
                    + "-" + electronicProduct + monthThree + yearBox.Text + ")";
                    break;
                case "K":
                    monthOne = 'K';
                    monthTwo = 'M';
                    monthThree = 'N';
                    clipboardText = "(" + electronicProduct + monthOne + yearBox.Text
                    + "-" + electronicProduct + monthTwo + yearBox.Text + ")-("
                    + electronicProduct + monthTwo + yearBox.Text
                    + "-" + electronicProduct + monthThree + yearBox.Text + ")";
                    break;
                case "M":
                    monthOne = 'M';
                    monthTwo = 'N';
                    monthThree = 'Q';
                    clipboardText = "(" + electronicProduct + monthOne + yearBox.Text
                    + "-" + electronicProduct + monthTwo + yearBox.Text + ")-("
                    + electronicProduct + monthTwo + yearBox.Text
                    + "-" + electronicProduct + monthThree + yearBox.Text + ")";
                    break;
                case "N":
                    monthOne = 'N';
                    monthTwo = 'Q';
                    monthThree = 'U';
                    clipboardText = "(" + electronicProduct + monthOne + yearBox.Text
                    + "-" + electronicProduct + monthTwo + yearBox.Text + ")-("
                    + electronicProduct + monthTwo + yearBox.Text
                    + "-" + electronicProduct + monthThree + yearBox.Text + ")";
                    break;
                case "Q":
                    monthOne = 'Q';
                    monthTwo = 'U';
                    monthThree = 'V';
                    clipboardText = "(" + electronicProduct + monthOne + yearBox.Text
                    + "-" + electronicProduct + monthTwo + yearBox.Text + ")-("
                    + electronicProduct + monthTwo + yearBox.Text
                    + "-" + electronicProduct + monthThree + yearBox.Text + ")";
                    break;
                case "U":
                    monthOne = 'U';
                    monthTwo = 'V';
                    monthThree = 'X';
                    clipboardText = "(" + electronicProduct + monthOne + yearBox.Text
                    + "-" + electronicProduct + monthTwo + yearBox.Text + ")-("
                    + electronicProduct + monthTwo + yearBox.Text
                    + "-" + electronicProduct + monthThree + yearBox.Text + ")";
                    break;
                case "V":
                    monthOne = 'V';
                    monthTwo = 'X';
                    monthThree = 'Z';
                    clipboardText = "(" + electronicProduct + monthOne + yearBox.Text
                    + "-" + electronicProduct + monthTwo + yearBox.Text + ")-("
                    + electronicProduct + monthTwo + yearBox.Text
                    + "-" + electronicProduct + monthThree + yearBox.Text + ")";
                    break;
                case "X":
                    monthOne = 'X';
                    monthTwo = 'Z';
                    monthThree = 'F';
                    if (yearOne < 9)
                    {
                        clipboardText = "(" + electronicProduct + monthOne + yearBox.Text
                        + "-" + electronicProduct + monthTwo + yearBox.Text + ")-("
                        + electronicProduct + monthTwo + yearBox.Text
                        + "-" + electronicProduct + monthThree + "0" + yearTwo.ToString() + ")";
                    }
                    else
                    {
                        clipboardText = "(" + electronicProduct + monthOne + yearBox.Text
                        + "-" + electronicProduct + monthTwo + yearBox.Text + ")-("
                        + electronicProduct + monthTwo + yearBox.Text
                        + "-" + electronicProduct + monthThree + yearTwo.ToString() + ")";
                    }
                    break;
                case "Z":
                    //RBES1Z0-RBES1F1
                    monthOne = 'Z';
                    monthTwo = 'F';
                    monthThree = 'G';
                    if (yearOne < 9)
                    {
                        clipboardText = "(" + electronicProduct + monthOne + yearBox.Text
                        + "-" + electronicProduct + monthTwo + "0" + yearTwo.ToString() + ")-("
                        + electronicProduct + monthTwo + "0" + yearTwo.ToString()
                        + "-" + electronicProduct + monthThree + "0" + yearTwo.ToString() + ")";
                    }
                    else
                    {
                        clipboardText = "(" + electronicProduct + monthOne + yearBox.Text
                        + "-" + electronicProduct + monthTwo + yearTwo.ToString() + ")-("
                        + electronicProduct + monthTwo + yearTwo.ToString()
                        + "-" + electronicProduct + monthThree + yearTwo.ToString() + ")";
                    }
                    break;
                default:
                    break;
            }

            Clipboard.SetText(clipboardText);
            //MessageBox.Show("Double Fly Copied.", "Copy Successful",
            //MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ThreeFlyElectronic()
        {
            string clipboardText = string.Empty;               //months: FGHJKMNQUVXZ  
            char monthOne, monthTwo, monthThree, monthFour = '\0';
            int yearOne = Convert.ToInt32(yearBox.Text);
            int yearTwo = Convert.ToInt32(yearBox.Text) + 1;

            // ((RBES1V0-RBES1X0)-(RBES1X0-RBES1Z0))-((RBES1X0-RBES1Z0)-(RBES1Z0-RBES1F0))

            Clipboard.Clear();

            string electronicProduct = productBox.Text + "ES1";

            switch (monthBox.Text)
            {
                case "F":
                    monthOne = 'F';
                    monthTwo = 'G';
                    monthThree = 'H';
                    monthFour = 'J';
                    clipboardText = "((" + electronicProduct + monthOne + yearBox.Text
                    + "-" + electronicProduct + monthTwo + yearBox.Text + ")-("
                    + electronicProduct + monthTwo + yearBox.Text
                    + "-" + electronicProduct + monthThree + yearBox.Text + "))-(("
                    + electronicProduct + monthTwo + yearBox.Text
                    + "-" + electronicProduct + monthThree + yearBox.Text + ")-("
                    + electronicProduct + monthThree + yearBox.Text
                    + "-" + electronicProduct + monthFour + yearBox.Text + "))";
                    break;
                case "G":
                    monthOne = 'G';
                    monthTwo = 'H';
                    monthThree = 'J';
                    monthFour = 'K';
                    clipboardText = "((" + electronicProduct + monthOne + yearBox.Text
                    + "-" + electronicProduct + monthTwo + yearBox.Text + ")-("
                    + electronicProduct + monthTwo + yearBox.Text
                    + "-" + electronicProduct + monthThree + yearBox.Text + "))-(("
                    + electronicProduct + monthTwo + yearBox.Text
                    + "-" + electronicProduct + monthThree + yearBox.Text + ")-("
                    + electronicProduct + monthThree + yearBox.Text
                    + "-" + electronicProduct + monthFour + yearBox.Text + "))";
                    break;
                case "H":
                    monthOne = 'H';
                    monthTwo = 'J';
                    monthThree = 'K';
                    monthFour = 'M';
                    clipboardText = "((" + electronicProduct + monthOne + yearBox.Text
                    + "-" + electronicProduct + monthTwo + yearBox.Text + ")-("
                    + electronicProduct + monthTwo + yearBox.Text
                    + "-" + electronicProduct + monthThree + yearBox.Text + "))-(("
                    + electronicProduct + monthTwo + yearBox.Text
                    + "-" + electronicProduct + monthThree + yearBox.Text + ")-("
                    + electronicProduct + monthThree + yearBox.Text
                    + "-" + electronicProduct + monthFour + yearBox.Text + "))";
                    break;
                case "J":
                    monthOne = 'J';
                    monthTwo = 'K';
                    monthThree = 'M';
                    monthFour = 'N';
                    clipboardText = "((" + electronicProduct + monthOne + yearBox.Text
                    + "-" + electronicProduct + monthTwo + yearBox.Text + ")-("
                    + electronicProduct + monthTwo + yearBox.Text
                    + "-" + electronicProduct + monthThree + yearBox.Text + "))-(("
                    + electronicProduct + monthTwo + yearBox.Text
                    + "-" + electronicProduct + monthThree + yearBox.Text + ")-("
                    + electronicProduct + monthThree + yearBox.Text
                    + "-" + electronicProduct + monthFour + yearBox.Text + "))";
                    break;
                case "K":
                    monthOne = 'K';
                    monthTwo = 'M';
                    monthThree = 'N';
                    monthFour = 'Q';
                    clipboardText = "((" + electronicProduct + monthOne + yearBox.Text
                    + "-" + electronicProduct + monthTwo + yearBox.Text + ")-("
                    + electronicProduct + monthTwo + yearBox.Text
                    + "-" + electronicProduct + monthThree + yearBox.Text + "))-(("
                    + electronicProduct + monthTwo + yearBox.Text
                    + "-" + electronicProduct + monthThree + yearBox.Text + ")-("
                    + electronicProduct + monthThree + yearBox.Text
                    + "-" + electronicProduct + monthFour + yearBox.Text + "))";
                    break;
                case "M":
                    monthOne = 'M';
                    monthTwo = 'N';
                    monthThree = 'Q';
                    monthFour = 'U';
                    clipboardText = "((" + electronicProduct + monthOne + yearBox.Text
                    + "-" + electronicProduct + monthTwo + yearBox.Text + ")-("
                    + electronicProduct + monthTwo + yearBox.Text
                    + "-" + electronicProduct + monthThree + yearBox.Text + "))-(("
                    + electronicProduct + monthTwo + yearBox.Text
                    + "-" + electronicProduct + monthThree + yearBox.Text + ")-("
                    + electronicProduct + monthThree + yearBox.Text
                    + "-" + electronicProduct + monthFour + yearBox.Text + "))";
                    break;
                case "N":
                    monthOne = 'N';
                    monthTwo = 'Q';
                    monthThree = 'U';
                    monthFour = 'V';
                    clipboardText = "((" + electronicProduct + monthOne + yearBox.Text
                    + "-" + electronicProduct + monthTwo + yearBox.Text + ")-("
                    + electronicProduct + monthTwo + yearBox.Text
                    + "-" + electronicProduct + monthThree + yearBox.Text + "))-(("
                    + electronicProduct + monthTwo + yearBox.Text
                    + "-" + electronicProduct + monthThree + yearBox.Text + ")-("
                    + electronicProduct + monthThree + yearBox.Text
                    + "-" + electronicProduct + monthFour + yearBox.Text + "))";
                    break;
                case "Q":
                    monthOne = 'Q';
                    monthTwo = 'U';
                    monthThree = 'V';
                    monthFour = 'X';
                    clipboardText = "((" + electronicProduct + monthOne + yearBox.Text
                    + "-" + electronicProduct + monthTwo + yearBox.Text + ")-("
                    + electronicProduct + monthTwo + yearBox.Text
                    + "-" + electronicProduct + monthThree + yearBox.Text + "))-(("
                    + electronicProduct + monthTwo + yearBox.Text
                    + "-" + electronicProduct + monthThree + yearBox.Text + ")-("
                    + electronicProduct + monthThree + yearBox.Text
                    + "-" + electronicProduct + monthFour + yearBox.Text + "))";
                    break;
                case "U":
                    monthOne = 'U';
                    monthTwo = 'V';
                    monthThree = 'X';
                    monthFour = 'Z';
                    clipboardText = "((" + electronicProduct + monthOne + yearBox.Text
                    + "-" + electronicProduct + monthTwo + yearBox.Text + ")-("
                    + electronicProduct + monthTwo + yearBox.Text
                    + "-" + electronicProduct + monthThree + yearBox.Text + "))-(("
                    + electronicProduct + monthTwo + yearBox.Text
                    + "-" + electronicProduct + monthThree + yearBox.Text + ")-("
                    + electronicProduct + monthThree + yearBox.Text
                    + "-" + electronicProduct + monthFour + yearBox.Text + "))";
                    break;
                case "V":
                    monthOne = 'V';
                    monthTwo = 'X';
                    monthThree = 'Z';
                    monthFour = 'F';
                    if (yearOne < 9)
                    {
                        clipboardText = "((" + electronicProduct + monthOne + yearBox.Text
                        + "-" + electronicProduct + monthTwo + yearBox.Text + ")-("
                        + electronicProduct + monthTwo + yearBox.Text
                        + "-" + electronicProduct + monthThree + yearBox.Text + "))-(("
                        + electronicProduct + monthTwo + yearBox.Text
                        + "-" + electronicProduct + monthThree + yearBox.Text + ")-("
                        + electronicProduct + monthThree + yearBox.Text
                        + "-" + electronicProduct + monthFour + "0" + yearTwo.ToString() + "))";
                    }
                    else
                    {
                        clipboardText = "((" + electronicProduct + monthOne + yearBox.Text
                        + "-" + electronicProduct + monthTwo + yearBox.Text + ")-("
                        + electronicProduct + monthTwo + yearBox.Text
                        + "-" + electronicProduct + monthThree + yearBox.Text + "))-(("
                        + electronicProduct + monthTwo + yearBox.Text
                        + "-" + electronicProduct + monthThree + yearBox.Text + ")-("
                        + electronicProduct + monthThree + yearBox.Text
                        + "-" + electronicProduct + monthFour + yearTwo.ToString() + "))";
                    }
                    break;
                case "X":
                    monthOne = 'X';
                    monthTwo = 'Z';
                    monthThree = 'F';
                    monthFour = 'G';
                    if (yearOne < 9)
                    {
                        clipboardText = "((" + electronicProduct + monthOne + yearBox.Text
                        + "-" + electronicProduct + monthTwo + yearBox.Text + ")-("
                        + electronicProduct + monthTwo + yearBox.Text
                        + "-" + electronicProduct + monthThree + "0" + yearTwo.ToString() + "))-(("
                        + electronicProduct + monthTwo + yearBox.Text
                        + "-" + electronicProduct + monthThree + "0" + yearTwo.ToString() + ")-("
                        + electronicProduct + monthThree + "0" + yearTwo.ToString()
                        + "-" + electronicProduct + monthFour + "0" + yearTwo.ToString() + "))";
                    }
                    else
                    {
                        clipboardText = "((" + electronicProduct + monthOne + yearBox.Text
                        + "-" + electronicProduct + monthTwo + yearBox.Text + ")-("
                        + electronicProduct + monthTwo + yearBox.Text
                        + "-" + electronicProduct + monthThree + yearTwo.ToString() + "))-(("
                        + electronicProduct + monthTwo + yearBox.Text
                        + "-" + electronicProduct + monthThree + yearTwo.ToString() + ")-("
                        + electronicProduct + monthThree + yearTwo.ToString()
                        + "-" + electronicProduct + monthFour + yearTwo.ToString() + "))";
                    }
                    break;
                case "Z":
                    //RBES1Z0-RBES1F1
                    monthOne = 'Z';
                    monthTwo = 'F';
                    monthThree = 'G';
                    monthFour = 'H';
                    if (yearOne < 9)
                    {
                        clipboardText = "((" + electronicProduct + monthOne + yearBox.Text
                        + "-" + electronicProduct + monthTwo + "0" + yearTwo.ToString() + ")-("
                        + electronicProduct + monthTwo + "0" + yearTwo.ToString()
                        + "-" + electronicProduct + monthThree + "0" + yearTwo.ToString() + "))-(("
                        + electronicProduct + monthTwo + "0" + yearTwo.ToString()
                        + "-" + electronicProduct + monthThree + "0" + yearTwo.ToString() + ")-("
                        + electronicProduct + monthThree + "0" + yearTwo.ToString()
                        + "-" + electronicProduct + monthFour + "0" + yearTwo.ToString() + "))";
                    }
                    else
                    {
                        clipboardText = "((" + electronicProduct + monthOne + yearBox.Text
                        + "-" + electronicProduct + monthTwo + yearTwo.ToString() + ")-("
                        + electronicProduct + monthTwo + yearTwo.ToString()
                        + "-" + electronicProduct + monthThree + yearTwo.ToString() + "))-(("
                        + electronicProduct + monthTwo + yearTwo.ToString()
                        + "-" + electronicProduct + monthThree + yearTwo.ToString() + ")-("
                        + electronicProduct + monthThree + yearTwo.ToString()
                        + "-" + electronicProduct + monthFour + yearTwo.ToString() + "))";
                    }
                    break;
                default:
                    break;
            }

            Clipboard.SetText(clipboardText);
            //MessageBox.Show("Triple Fly Copied.", "Copy Successful",
            //MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void FourFlyElectronic()
        {
            string clipboardText = string.Empty;               //months: FGHJKMNQUVXZ  
            char monthOne, monthTwo, monthThree, monthFour, monthFive = '\0';
            int yearOne = Convert.ToInt32(yearBox.Text);
            int yearTwo = Convert.ToInt32(yearBox.Text) + 1;

            // (((RBES1V0-RBES1X0)-(RBES1X0-RBES1Z0))-((RBES1X0-RBES1Z0)-(RBES1Z0-RBES1F0)))-
            // (((RBES1X0-RBES1Z0)-(RBES1Z0-RBES1F0))-((RBES1Z0-RBES1F0)-(RBES1F0-RBES1G0)))

            Clipboard.Clear();

            string electronicProduct = productBox.Text + "ES1";

            switch (monthBox.Text)
            {
                case "F":
                    monthOne = 'F';
                    monthTwo = 'G';
                    monthThree = 'H';
                    monthFour = 'J';
                    monthFive = 'K';
                    clipboardText = "(((" + electronicProduct + monthOne + yearBox.Text
                    + "-" + electronicProduct + monthTwo + yearBox.Text + ")-("
                    + electronicProduct + monthTwo + yearBox.Text
                    + "-" + electronicProduct + monthThree + yearBox.Text + "))-(("
                    + electronicProduct + monthTwo + yearBox.Text
                    + "-" + electronicProduct + monthThree + yearBox.Text + ")-("
                    + electronicProduct + monthThree + yearBox.Text
                    + "-" + electronicProduct + monthFour + yearBox.Text + ")))-((("
                    + electronicProduct + monthTwo + yearBox.Text
                    + "-" + electronicProduct + monthThree + yearBox.Text + ")-("
                    + electronicProduct + monthThree + yearBox.Text
                    + "-" + electronicProduct + monthFour + yearBox.Text + "))-(("
                    + electronicProduct + monthThree + yearBox.Text
                    + "-" + electronicProduct + monthFour + yearBox.Text + ")-("
                    + electronicProduct + monthFour + yearBox.Text
                    + "-" + electronicProduct + monthFive + yearBox.Text + ")))";
                    break;
                case "G":
                    monthOne = 'G';
                    monthTwo = 'H';
                    monthThree = 'J';
                    monthFour = 'K';
                    monthFive = 'M';
                    clipboardText = "(((" + electronicProduct + monthOne + yearBox.Text
                    + "-" + electronicProduct + monthTwo + yearBox.Text + ")-("
                    + electronicProduct + monthTwo + yearBox.Text
                    + "-" + electronicProduct + monthThree + yearBox.Text + "))-(("
                    + electronicProduct + monthTwo + yearBox.Text
                    + "-" + electronicProduct + monthThree + yearBox.Text + ")-("
                    + electronicProduct + monthThree + yearBox.Text
                    + "-" + electronicProduct + monthFour + yearBox.Text + ")))-((("
                    + electronicProduct + monthTwo + yearBox.Text
                    + "-" + electronicProduct + monthThree + yearBox.Text + ")-("
                    + electronicProduct + monthThree + yearBox.Text
                    + "-" + electronicProduct + monthFour + yearBox.Text + "))-(("
                    + electronicProduct + monthThree + yearBox.Text
                    + "-" + electronicProduct + monthFour + yearBox.Text + ")-("
                    + electronicProduct + monthFour + yearBox.Text
                    + "-" + electronicProduct + monthFive + yearBox.Text + ")))";
                    break;
                case "H":
                    monthOne = 'H';
                    monthTwo = 'J';
                    monthThree = 'K';
                    monthFour = 'M';
                    monthFive = 'N';
                    clipboardText = "(((" + electronicProduct + monthOne + yearBox.Text
                    + "-" + electronicProduct + monthTwo + yearBox.Text + ")-("
                    + electronicProduct + monthTwo + yearBox.Text
                    + "-" + electronicProduct + monthThree + yearBox.Text + "))-(("
                    + electronicProduct + monthTwo + yearBox.Text
                    + "-" + electronicProduct + monthThree + yearBox.Text + ")-("
                    + electronicProduct + monthThree + yearBox.Text
                    + "-" + electronicProduct + monthFour + yearBox.Text + ")))-((("
                    + electronicProduct + monthTwo + yearBox.Text
                    + "-" + electronicProduct + monthThree + yearBox.Text + ")-("
                    + electronicProduct + monthThree + yearBox.Text
                    + "-" + electronicProduct + monthFour + yearBox.Text + "))-(("
                    + electronicProduct + monthThree + yearBox.Text
                    + "-" + electronicProduct + monthFour + yearBox.Text + ")-("
                    + electronicProduct + monthFour + yearBox.Text
                    + "-" + electronicProduct + monthFive + yearBox.Text + ")))";
                    break;
                case "J":
                    monthOne = 'J';
                    monthTwo = 'K';
                    monthThree = 'M';
                    monthFour = 'N';
                    monthFive = 'Q';
                    clipboardText = "(((" + electronicProduct + monthOne + yearBox.Text
                    + "-" + electronicProduct + monthTwo + yearBox.Text + ")-("
                    + electronicProduct + monthTwo + yearBox.Text
                    + "-" + electronicProduct + monthThree + yearBox.Text + "))-(("
                    + electronicProduct + monthTwo + yearBox.Text
                    + "-" + electronicProduct + monthThree + yearBox.Text + ")-("
                    + electronicProduct + monthThree + yearBox.Text
                    + "-" + electronicProduct + monthFour + yearBox.Text + ")))-((("
                    + electronicProduct + monthTwo + yearBox.Text
                    + "-" + electronicProduct + monthThree + yearBox.Text + ")-("
                    + electronicProduct + monthThree + yearBox.Text
                    + "-" + electronicProduct + monthFour + yearBox.Text + "))-(("
                    + electronicProduct + monthThree + yearBox.Text
                    + "-" + electronicProduct + monthFour + yearBox.Text + ")-("
                    + electronicProduct + monthFour + yearBox.Text
                    + "-" + electronicProduct + monthFive + yearBox.Text + ")))";
                    break;
                case "K":
                    monthOne = 'K';
                    monthTwo = 'M';
                    monthThree = 'N';
                    monthFour = 'Q';
                    monthFive = 'U';
                    clipboardText = "(((" + electronicProduct + monthOne + yearBox.Text
                    + "-" + electronicProduct + monthTwo + yearBox.Text + ")-("
                    + electronicProduct + monthTwo + yearBox.Text
                    + "-" + electronicProduct + monthThree + yearBox.Text + "))-(("
                    + electronicProduct + monthTwo + yearBox.Text
                    + "-" + electronicProduct + monthThree + yearBox.Text + ")-("
                    + electronicProduct + monthThree + yearBox.Text
                    + "-" + electronicProduct + monthFour + yearBox.Text + ")))-((("
                    + electronicProduct + monthTwo + yearBox.Text
                    + "-" + electronicProduct + monthThree + yearBox.Text + ")-("
                    + electronicProduct + monthThree + yearBox.Text
                    + "-" + electronicProduct + monthFour + yearBox.Text + "))-(("
                    + electronicProduct + monthThree + yearBox.Text
                    + "-" + electronicProduct + monthFour + yearBox.Text + ")-("
                    + electronicProduct + monthFour + yearBox.Text
                    + "-" + electronicProduct + monthFive + yearBox.Text + ")))";
                    break;
                case "M":
                    monthOne = 'M';
                    monthTwo = 'N';
                    monthThree = 'Q';
                    monthFour = 'U';
                    monthFive = 'V';
                    clipboardText = "(((" + electronicProduct + monthOne + yearBox.Text
                    + "-" + electronicProduct + monthTwo + yearBox.Text + ")-("
                    + electronicProduct + monthTwo + yearBox.Text
                    + "-" + electronicProduct + monthThree + yearBox.Text + "))-(("
                    + electronicProduct + monthTwo + yearBox.Text
                    + "-" + electronicProduct + monthThree + yearBox.Text + ")-("
                    + electronicProduct + monthThree + yearBox.Text
                    + "-" + electronicProduct + monthFour + yearBox.Text + ")))-((("
                    + electronicProduct + monthTwo + yearBox.Text
                    + "-" + electronicProduct + monthThree + yearBox.Text + ")-("
                    + electronicProduct + monthThree + yearBox.Text
                    + "-" + electronicProduct + monthFour + yearBox.Text + "))-(("
                    + electronicProduct + monthThree + yearBox.Text
                    + "-" + electronicProduct + monthFour + yearBox.Text + ")-("
                    + electronicProduct + monthFour + yearBox.Text
                    + "-" + electronicProduct + monthFive + yearBox.Text + ")))";
                    break;
                case "N":
                    monthOne = 'N';
                    monthTwo = 'Q';
                    monthThree = 'U';
                    monthFour = 'V';
                    monthFive = 'X';
                    clipboardText = "(((" + electronicProduct + monthOne + yearBox.Text
                    + "-" + electronicProduct + monthTwo + yearBox.Text + ")-("
                    + electronicProduct + monthTwo + yearBox.Text
                    + "-" + electronicProduct + monthThree + yearBox.Text + "))-(("
                    + electronicProduct + monthTwo + yearBox.Text
                    + "-" + electronicProduct + monthThree + yearBox.Text + ")-("
                    + electronicProduct + monthThree + yearBox.Text
                    + "-" + electronicProduct + monthFour + yearBox.Text + ")))-((("
                    + electronicProduct + monthTwo + yearBox.Text
                    + "-" + electronicProduct + monthThree + yearBox.Text + ")-("
                    + electronicProduct + monthThree + yearBox.Text
                    + "-" + electronicProduct + monthFour + yearBox.Text + "))-(("
                    + electronicProduct + monthThree + yearBox.Text
                    + "-" + electronicProduct + monthFour + yearBox.Text + ")-("
                    + electronicProduct + monthFour + yearBox.Text
                    + "-" + electronicProduct + monthFive + yearBox.Text + ")))";
                    break;
                case "Q":
                    monthOne = 'Q';
                    monthTwo = 'U';
                    monthThree = 'V';
                    monthFour = 'X';
                    monthFive = 'Z';
                    clipboardText = "(((" + electronicProduct + monthOne + yearBox.Text
                    + "-" + electronicProduct + monthTwo + yearBox.Text + ")-("
                    + electronicProduct + monthTwo + yearBox.Text
                    + "-" + electronicProduct + monthThree + yearBox.Text + "))-(("
                    + electronicProduct + monthTwo + yearBox.Text
                    + "-" + electronicProduct + monthThree + yearBox.Text + ")-("
                    + electronicProduct + monthThree + yearBox.Text
                    + "-" + electronicProduct + monthFour + yearBox.Text + ")))-((("
                    + electronicProduct + monthTwo + yearBox.Text
                    + "-" + electronicProduct + monthThree + yearBox.Text + ")-("
                    + electronicProduct + monthThree + yearBox.Text
                    + "-" + electronicProduct + monthFour + yearBox.Text + "))-(("
                    + electronicProduct + monthThree + yearBox.Text
                    + "-" + electronicProduct + monthFour + yearBox.Text + ")-("
                    + electronicProduct + monthFour + yearBox.Text
                    + "-" + electronicProduct + monthFive + yearBox.Text + ")))";
                    break;
                case "U":
                    monthOne = 'U';
                    monthTwo = 'V';
                    monthThree = 'X';
                    monthFour = 'Z';
                    monthFive = 'F';
                    if (yearOne < 9)
                    {
                        clipboardText = "(((" + electronicProduct + monthOne + yearBox.Text
                        + "-" + electronicProduct + monthTwo + yearBox.Text + ")-("
                        + electronicProduct + monthTwo + yearBox.Text
                        + "-" + electronicProduct + monthThree + yearBox.Text + "))-(("
                        + electronicProduct + monthTwo + yearBox.Text
                        + "-" + electronicProduct + monthThree + yearBox.Text + ")-("
                        + electronicProduct + monthThree + yearBox.Text
                        + "-" + electronicProduct + monthFour + yearBox.Text + ")))-((("
                        + electronicProduct + monthTwo + yearBox.Text
                        + "-" + electronicProduct + monthThree + yearBox.Text + ")-("
                        + electronicProduct + monthThree + yearBox.Text
                        + "-" + electronicProduct + monthFour + yearBox.Text + "))-(("
                        + electronicProduct + monthThree + yearBox.Text
                        + "-" + electronicProduct + monthFour + yearBox.Text + ")-("
                        + electronicProduct + monthFour + yearBox.Text
                        + "-" + electronicProduct + monthFive + "0" + yearTwo.ToString() + ")))";
                    }
                    else
                    {
                        clipboardText = "(((" + electronicProduct + monthOne + yearBox.Text
                        + "-" + electronicProduct + monthTwo + yearBox.Text + ")-("
                        + electronicProduct + monthTwo + yearBox.Text
                        + "-" + electronicProduct + monthThree + yearBox.Text + "))-(("
                        + electronicProduct + monthTwo + yearBox.Text
                        + "-" + electronicProduct + monthThree + yearBox.Text + ")-("
                        + electronicProduct + monthThree + yearBox.Text
                        + "-" + electronicProduct + monthFour + yearBox.Text + ")))-((("
                        + electronicProduct + monthTwo + yearBox.Text
                        + "-" + electronicProduct + monthThree + yearBox.Text + ")-("
                        + electronicProduct + monthThree + yearBox.Text
                        + "-" + electronicProduct + monthFour + yearBox.Text + "))-(("
                        + electronicProduct + monthThree + yearBox.Text
                        + "-" + electronicProduct + monthFour + yearBox.Text + ")-("
                        + electronicProduct + monthFour + yearBox.Text
                        + "-" + electronicProduct + monthFive + yearTwo.ToString() + ")))";
                    }
                    break;
                case "V":
                    monthOne = 'V';
                    monthTwo = 'X';
                    monthThree = 'Z';
                    monthFour = 'F';
                    monthFive = 'G';
                    if (yearOne < 9)
                    {
                        clipboardText = "(((" + electronicProduct + monthOne + yearBox.Text
                        + "-" + electronicProduct + monthTwo + yearBox.Text + ")-("
                        + electronicProduct + monthTwo + yearBox.Text
                        + "-" + electronicProduct + monthThree + yearBox.Text + "))-(("
                        + electronicProduct + monthTwo + yearBox.Text
                        + "-" + electronicProduct + monthThree + yearBox.Text + ")-("
                        + electronicProduct + monthThree + yearBox.Text
                        + "-" + electronicProduct + monthFour + "0" + yearTwo.ToString() + ")))-((("
                        + electronicProduct + monthTwo + yearBox.Text
                        + "-" + electronicProduct + monthThree + yearBox.Text + ")-("
                        + electronicProduct + monthThree + yearBox.Text
                        + "-" + electronicProduct + monthFour + "0" + yearTwo.ToString() + "))-(("
                        + electronicProduct + monthThree + yearBox.Text
                        + "-" + electronicProduct + monthFour + "0" + yearTwo.ToString() + ")-("
                        + electronicProduct + monthFour + "0" + yearTwo.ToString()
                        + "-" + electronicProduct + monthFive + "0" + yearTwo.ToString() + ")))";
                    }
                    else
                    {
                        clipboardText = "(((" + electronicProduct + monthOne + yearBox.Text
                        + "-" + electronicProduct + monthTwo + yearBox.Text + ")-("
                        + electronicProduct + monthTwo + yearBox.Text
                        + "-" + electronicProduct + monthThree + yearBox.Text + "))-(("
                        + electronicProduct + monthTwo + yearBox.Text
                        + "-" + electronicProduct + monthThree + yearBox.Text + ")-("
                        + electronicProduct + monthThree + yearBox.Text
                        + "-" + electronicProduct + monthFour + yearTwo.ToString() + ")))-((("
                        + electronicProduct + monthTwo + yearBox.Text
                        + "-" + electronicProduct + monthThree + yearBox.Text + ")-("
                        + electronicProduct + monthThree + yearBox.Text
                        + "-" + electronicProduct + monthFour + yearTwo.ToString() + "))-(("
                        + electronicProduct + monthThree + yearBox.Text
                        + "-" + electronicProduct + monthFour + yearTwo.ToString() + ")-("
                        + electronicProduct + monthFour + yearTwo.ToString()
                        + "-" + electronicProduct + monthFive + yearTwo.ToString() + ")))";
                    }
                    break;
                case "X":
                    monthOne = 'X';
                    monthTwo = 'Z';
                    monthThree = 'F';
                    monthFour = 'G';
                    monthFive = 'H';
                    if (yearOne < 9)
                    {
                        clipboardText = "(((" + electronicProduct + monthOne + yearBox.Text
                        + "-" + electronicProduct + monthTwo + yearBox.Text + ")-("
                        + electronicProduct + monthTwo + yearBox.Text
                        + "-" + electronicProduct + monthThree + "0" + yearTwo.ToString() + "))-(("
                        + electronicProduct + monthTwo + yearBox.Text
                        + "-" + electronicProduct + monthThree + "0" + yearTwo.ToString() + ")-("
                        + electronicProduct + monthThree + "0" + yearTwo.ToString()
                        + "-" + electronicProduct + monthFour + "0" + yearTwo.ToString() + ")))-((("
                        + electronicProduct + monthTwo + yearBox.Text
                        + "-" + electronicProduct + monthThree + "0" + yearTwo.ToString() + ")-("
                        + electronicProduct + monthThree + "0" + yearTwo.ToString()
                        + "-" + electronicProduct + monthFour + "0" + yearTwo.ToString() + "))-(("
                        + electronicProduct + monthThree + "0" + yearTwo.ToString()
                        + "-" + electronicProduct + monthFour + "0" + yearTwo.ToString() + ")-("
                        + electronicProduct + monthFour + "0" + yearTwo.ToString()
                        + "-" + electronicProduct + monthFive + "0" + yearTwo.ToString() + ")))";
                    }
                    else
                    {
                        clipboardText = "(((" + electronicProduct + monthOne + yearBox.Text
                        + "-" + electronicProduct + monthTwo + yearBox.Text + ")-("
                        + electronicProduct + monthTwo + yearBox.Text
                        + "-" + electronicProduct + monthThree + yearTwo.ToString() + "))-(("
                        + electronicProduct + monthTwo + yearBox.Text
                        + "-" + electronicProduct + monthThree + yearTwo.ToString() + ")-("
                        + electronicProduct + monthThree + yearTwo.ToString()
                        + "-" + electronicProduct + monthFour + yearTwo.ToString() + ")))-((("
                        + electronicProduct + monthTwo + yearBox.Text
                        + "-" + electronicProduct + monthThree + yearTwo.ToString() + ")-("
                        + electronicProduct + monthThree + yearTwo.ToString()
                        + "-" + electronicProduct + monthFour + yearTwo.ToString() + "))-(("
                        + electronicProduct + monthThree + yearTwo.ToString()
                        + "-" + electronicProduct + monthFour + yearTwo.ToString() + ")-("
                        + electronicProduct + monthFour + yearTwo.ToString()
                        + "-" + electronicProduct + monthFive + yearTwo.ToString() + ")))";
                    }
                    break;
                case "Z":
                    //RBES1Z0-RBES1F1
                    monthOne = 'Z';
                    monthTwo = 'F';
                    monthThree = 'G';
                    monthFour = 'H';
                    monthFive = 'J';
                    if (yearOne < 9)
                    {
                        clipboardText = "(((" + electronicProduct + monthOne + yearBox.Text
                        + "-" + electronicProduct + monthTwo + "0" + yearTwo.ToString() + ")-("
                        + electronicProduct + monthTwo + "0" + yearTwo.ToString()
                        + "-" + electronicProduct + monthThree + "0" + yearTwo.ToString() + "))-(("
                        + electronicProduct + monthTwo + "0" + yearTwo.ToString()
                        + "-" + electronicProduct + monthThree + "0" + yearTwo.ToString() + ")-("
                        + electronicProduct + monthThree + "0" + yearTwo.ToString()
                        + "-" + electronicProduct + monthFour + "0" + yearTwo.ToString() + ")))-((("
                        + electronicProduct + monthTwo + "0" + yearTwo.ToString()
                        + "-" + electronicProduct + monthThree + "0" + yearTwo.ToString() + ")-("
                        + electronicProduct + monthThree + "0" + yearTwo.ToString()
                        + "-" + electronicProduct + monthFour + "0" + yearTwo.ToString() + "))-(("
                        + electronicProduct + monthThree + "0" + yearTwo.ToString()
                        + "-" + electronicProduct + monthFour + "0" + yearTwo.ToString() + ")-("
                        + electronicProduct + monthFour + "0" + yearTwo.ToString()
                        + "-" + electronicProduct + monthFive + "0" + yearTwo.ToString() + ")))";
                    }
                    else
                    {
                        clipboardText = "(((" + electronicProduct + monthOne + yearBox.Text
                        + "-" + electronicProduct + monthTwo + yearTwo.ToString() + ")-("
                        + electronicProduct + monthTwo + yearTwo.ToString()
                        + "-" + electronicProduct + monthThree + yearTwo.ToString() + "))-(("
                        + electronicProduct + monthTwo + yearTwo.ToString()
                        + "-" + electronicProduct + monthThree + yearTwo.ToString() + ")-("
                        + electronicProduct + monthThree + yearTwo.ToString()
                        + "-" + electronicProduct + monthFour + yearTwo.ToString() + ")))-((("
                        + electronicProduct + monthTwo + yearTwo.ToString()
                        + "-" + electronicProduct + monthThree + yearTwo.ToString() + ")-("
                        + electronicProduct + monthThree + yearTwo.ToString()
                        + "-" + electronicProduct + monthFour + yearTwo.ToString() + "))-(("
                        + electronicProduct + monthThree + yearTwo.ToString()
                        + "-" + electronicProduct + monthFour + yearTwo.ToString() + ")-("
                        + electronicProduct + monthFour + yearTwo.ToString()
                        + "-" + electronicProduct + monthFive + yearTwo.ToString() + ")))";
                    }
                    break;
                default:
                    break;
            }

            Clipboard.SetText(clipboardText);
            //MessageBox.Show("Quad Fly Copied.", "Copy Successful",
            //MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void FiveFlyElectronic()
        {

            MessageBox.Show("Not yet implemented.");
        }
        private void SixFlyElectronic()
        {

            MessageBox.Show("Not yet implemented.");
        }

        private char GetNextMonth(char currentMonth)
        {
            switch (currentMonth)
            {
                case 'F':
                    return 'G';
                case 'G':
                    return 'H';
                case 'H':
                    return 'J';
                case 'J':
                    return 'K';
                case 'K':
                    return 'M';
                case 'M':
                    return 'N';
                case 'N':
                    return 'Q';
                case 'Q':
                    return 'U';
                case 'U':
                    return 'V';
                case 'V':
                    return 'X';
                case 'X':
                    return 'Z';
                case 'Z':
                    return 'F';
                default:
                    break;
            }
            return '\0';
        }
    }
}
