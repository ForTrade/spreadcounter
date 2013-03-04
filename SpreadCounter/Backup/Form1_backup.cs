using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XTAPI;
using System.Text.RegularExpressions;
using System.Globalization;

namespace SpreadCounter
{
    public partial class Form1 : Form
    {
        #region DataStructures
        public struct PositionStruct
        {
            public int net, spread, fly;
        }
        public class Trade
        {
            private DateTime date;
            private int buy;
            private int sell;

            public Trade(DateTime date, int buy, int sell)
            {
                this.date = date;
                this.buy = buy;
                this.sell = sell;
            }
            public Trade()
            {
                this.date = DateTime.FromBinary(0);
                this.buy = 0;
                this.sell = 0;
            }
            public DateTime Date
            {
                get { return date; }
                set { date = value; }
            }
            public int Buy
            {
                get { return buy; }
                set { buy = value; }
            }
            public int Sell
            {
                get { return sell; }
                set { sell = value; }
            }
        }
        public class NetTrade
        {
            private DateTime date;
            private int net;

            public NetTrade(DateTime date, int net)
            {
                this.date = date;
                this.net = net;
            }
            public NetTrade()
            {
                this.date = DateTime.FromBinary(0);
                this.net = 0;
            }
            public DateTime Date
            {
                get { return date; }
                set { date = value; }
            }
            public int Net
            {
                get { return net; }
                set { net = value; }
            }
        }
        public static class ChangeMonth
        {
            public static bool changed = false;
            public static int month = 0;
            public static int value = 0;
        }
        PositionStruct CrudePosition;
        PositionStruct GasPosition;
        PositionStruct HeatPosition;
        PositionStruct NaturalPosition;

        #endregion

        private TTGate ttGate = new TTGate();
        private TTOrderSet m_orderSet = null;
        private List<Trade> CrudeFillList = new List<Trade>();
        private List<Trade> CrudeCombinedFillList = new List<Trade>();
        private List<NetTrade> CrudeSpreadList;
        private List<Trade> GasFillList = new List<Trade>();
        private List<Trade> GasCombinedFillList = new List<Trade>();
        private List<NetTrade> GasSpreadList;
        private List<Trade> HeatFillList = new List<Trade>();
        private List<Trade> HeatCombinedFillList = new List<Trade>();
        private List<NetTrade> HeatSpreadList;
        private List<Trade> NaturalFillList = new List<Trade>();
        private List<Trade> NaturalCombinedFillList = new List<Trade>();
        private List<NetTrade> NaturalSpreadList;

        public Form1()
        {
            InitializeComponent();

            m_orderSet = new TTOrderSet();
            m_orderSet.EnableOrderSend = 0;  // application cannot submit orders
            m_orderSet.EnableOrderFillData = 1;
            m_orderSet.OnOrderFillData += new _ITTOrderSetEvents_OnOrderFillDataEventHandler(m_orderSet_OnOrderFillData);
            m_orderSet.Set("NetLimits", false);
            m_orderSet.Open(0);
        }

        void m_orderSet_OnOrderFillData(TTFillObj pFillObj)
        {
            try
            {
                UpdateFillDisplay(pFillObj);
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void UpdateFillDisplay(TTFillObj pFillObj)
        {
            try
            {
                string szContract = (string)pFillObj.get_Get("Contract");
                string szContractType = szContract.Split(' ')[0]; // CL
                switch (szContractType)
                {
                    case "CL":
                        UpdateCrudePosition(pFillObj);
                        break;
                    case "RB":
                        UpdateGasPosition(pFillObj);
                        break;
                    case "HO":
                        UpdateHeatPosition(pFillObj);
                        break;
                    case "NG":
                        UpdateNaturalPosition(pFillObj);
                        break;
                    default:
                        return;
                }
                BalanceContracts();
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void UpdateCrudePosition(TTFillObj pFillObj)
        {
            try
            {
                DateTime date;
                Array fillData = (Array)pFillObj.get_Get("Buy,Sell,Contract");
                int buy = (int)fillData.GetValue(0);
                int sell = (int)fillData.GetValue(1);
                string szContract = (string)fillData.GetValue(2);
                string szContractType = szContract.Split(' ')[0]; // CL
                string szContractDate = szContract.Split(' ')[1]; // Mar10
                DateTime.TryParseExact(szContractDate, "MMMyy", new CultureInfo("en-US"), DateTimeStyles.None, out date);
                CrudePosition.net += (buy - sell);
                Trade CurrentTrade = new Trade(date, buy, sell);

                // Add fill to list
                CrudeFillList.Add(CurrentTrade);
                CrudeFillList.Sort(DateCompare);
                CombineCrudeTrade(CrudeFillList);
                PrintCrudeTrade(CrudeCombinedFillList);

                // Calculate Net Position
                clNetPosition.Text = Convert.ToString(CrudePosition.net);
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void UpdateGasPosition(TTFillObj pFillObj)
        {
            try
            {
                DateTime date;
                Array fillData = (Array)pFillObj.get_Get("Buy,Sell,Contract");
                int buy = (int)fillData.GetValue(0);
                int sell = (int)fillData.GetValue(1);
                string szContract = (string)fillData.GetValue(2);
                string szContractType = szContract.Split(' ')[0]; // RB
                string szContractDate = szContract.Split(' ')[1]; // Mar10
                DateTime.TryParseExact(szContractDate, "MMMyy", new CultureInfo("en-US"), DateTimeStyles.None, out date);
                GasPosition.net += (buy - sell);
                Trade CurrentTrade = new Trade(date, buy, sell);

                // Add fill to list
                GasFillList.Add(CurrentTrade);
                GasFillList.Sort(DateCompare);
                CombineGasTrade(GasFillList);
                PrintGasTrade(GasCombinedFillList);

                // Calculate Net Position
                rbNetPosition.Text = Convert.ToString(GasPosition.net);
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void UpdateHeatPosition(TTFillObj pFillObj)
        {
            try
            {
                DateTime date;
                Array fillData = (Array)pFillObj.get_Get("Buy,Sell,Contract");
                int buy = (int)fillData.GetValue(0);
                int sell = (int)fillData.GetValue(1);
                string szContract = (string)fillData.GetValue(2);
                string szContractType = szContract.Split(' ')[0]; // HO
                string szContractDate = szContract.Split(' ')[1]; // Mar10
                DateTime.TryParseExact(szContractDate, "MMMyy", new CultureInfo("en-US"), DateTimeStyles.None, out date);
                HeatPosition.net += (buy - sell);
                Trade CurrentTrade = new Trade(date, buy, sell);

                // Add fill to list
                HeatFillList.Add(CurrentTrade);
                HeatFillList.Sort(DateCompare);
                CombineHeatTrade(HeatFillList);
                PrintHeatTrade(HeatCombinedFillList);

                // Calculate Net Position
                hoNetPosition.Text = Convert.ToString(HeatPosition.net);
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void UpdateNaturalPosition(TTFillObj pFillObj)
        {
            try
            {
                DateTime date;
                Array fillData = (Array)pFillObj.get_Get("Buy,Sell,Contract");
                int buy = (int)fillData.GetValue(0);
                int sell = (int)fillData.GetValue(1);
                string szContract = (string)fillData.GetValue(2);
                string szContractType = szContract.Split(' ')[0]; // NG
                string szContractDate = szContract.Split(' ')[1]; // Mar10
                DateTime.TryParseExact(szContractDate, "MMMyy", new CultureInfo("en-US"), DateTimeStyles.None, out date);
                NaturalPosition.net += (buy - sell);
                Trade CurrentTrade = new Trade(date, buy, sell);

                // Add fill to list
                NaturalFillList.Add(CurrentTrade);
                NaturalFillList.Sort(DateCompare);
                CombineNaturalTrade(NaturalFillList);
                PrintNaturalTrade(NaturalCombinedFillList);

                // Calculate Net Position
                ngNetPosition.Text = Convert.ToString(NaturalPosition.net);
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void CombineCrudeTrade(List<Trade> CrudeFillList)
        {
            try
            {
                CrudeCombinedFillList = (
                    from trade in CrudeFillList
                    group trade by trade.Date.Date into g
                    select new Trade { Date = g.Key, Buy = g.Sum(t => t.Buy), Sell = g.Sum(t => t.Sell) }
                ).ToList();
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void PrintCrudeTrade(List<Trade> fillList)
        {
            int netposlong = 0, netposshort = 0;

            var newList = fillList.Select(x => new NetTrade
            {
                Net = x.Buy - x.Sell,
                Date = x.Date
            }).ToList();

            crudeGrid.Items.Clear();

            foreach (NetTrade trade in newList)
            {
                ListViewItem item1 = new ListViewItem();

                if (trade.Net > 0)
                {
                    item1.Text = Convert.ToString(trade.Net);
                    item1.SubItems.Add(trade.Date.ToString("MMMyy"));
                    item1.SubItems.Add("");
                }
                else if (trade.Net < 0)
                {
                    item1.Text = "";
                    item1.SubItems.Add(trade.Date.ToString("MMMyy"));
                    item1.SubItems.Add(Convert.ToString(Math.Abs(trade.Net)));
                }
                else if (trade.Net == 0)
                {
                    item1.Text = "";
                    item1.SubItems.Add(trade.Date.ToString("MMMyy"));
                    item1.SubItems.Add("");
                }

                crudeGrid.Items.Add(item1);
            }

            foreach (NetTrade trade in newList)
            {
                if (trade.Net > 0)
                {
                    netposlong += trade.Net;
                }
                else if (trade.Net < 0)
                {
                    netposshort -= trade.Net;
                }
            }
            clNetLongBox.Text = Convert.ToString(netposlong);
            clNetShortBox.Text = Convert.ToString(netposshort);
        }

        private void CombineGasTrade(List<Trade> GasFillList)
        {
            try
            {
                GasCombinedFillList = (
                    from trade in GasFillList
                    group trade by trade.Date.Date into g
                    select new Trade { Date = g.Key, Buy = g.Sum(t => t.Buy), Sell = g.Sum(t => t.Sell) }
                ).ToList();
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void PrintGasTrade(List<Trade> fillList)
        {
            int netposlong = 0, netposshort = 0;

            var newList = fillList.Select(x => new NetTrade
            {
                Net = x.Buy - x.Sell,
                Date = x.Date
            }).ToList();

            gasGrid.Items.Clear();

            foreach (NetTrade trade in newList)
            {
                ListViewItem item1 = new ListViewItem();

                if (trade.Net > 0)
                {
                    item1.Text = Convert.ToString(trade.Net);
                    item1.SubItems.Add(trade.Date.ToString("MMMyy"));
                    item1.SubItems.Add("");
                }
                else if (trade.Net < 0)
                {
                    item1.Text = "";
                    item1.SubItems.Add(trade.Date.ToString("MMMyy"));
                    item1.SubItems.Add(Convert.ToString(Math.Abs(trade.Net)));
                }
                else if (trade.Net == 0)
                {
                    item1.Text = "";
                    item1.SubItems.Add(trade.Date.ToString("MMMyy"));
                    item1.SubItems.Add("");
                }

                gasGrid.Items.Add(item1);
            }

            foreach (NetTrade trade in newList)
            {
                if (trade.Net > 0)
                {
                    netposlong += trade.Net;
                }
                else if (trade.Net < 0)
                {
                    netposshort -= trade.Net;
                }
            }
            rbNetLongBox.Text = Convert.ToString(netposlong);
            rbNetShortBox.Text = Convert.ToString(netposshort);
        }

        private void CombineHeatTrade(List<Trade> HeatFillList)
        {
            try
            {
                HeatCombinedFillList = (
                    from trade in HeatFillList
                    group trade by trade.Date.Date into g
                    select new Trade { Date = g.Key, Buy = g.Sum(t => t.Buy), Sell = g.Sum(t => t.Sell) }
                ).ToList();
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void PrintHeatTrade(List<Trade> fillList)
        {
            int netposlong = 0, netposshort = 0;

            var newList = fillList.Select(x => new NetTrade
            {
                Net = x.Buy - x.Sell,
                Date = x.Date
            }).ToList();

            heatGrid.Items.Clear();

            foreach (NetTrade trade in newList)
            {
                ListViewItem item1 = new ListViewItem();

                if (trade.Net > 0)
                {
                    item1.Text = Convert.ToString(trade.Net);
                    item1.SubItems.Add(trade.Date.ToString("MMMyy"));
                    item1.SubItems.Add("");
                }
                else if (trade.Net < 0)
                {
                    item1.Text = "";
                    item1.SubItems.Add(trade.Date.ToString("MMMyy"));
                    item1.SubItems.Add(Convert.ToString(Math.Abs(trade.Net)));
                }
                else if (trade.Net == 0)
                {
                    item1.Text = "";
                    item1.SubItems.Add(trade.Date.ToString("MMMyy"));
                    item1.SubItems.Add("");
                }

                heatGrid.Items.Add(item1);
            }

            foreach (NetTrade trade in newList)
            {
                if (trade.Net > 0)
                {
                    netposlong += trade.Net;
                }
                else if (trade.Net < 0)
                {
                    netposshort -= trade.Net;
                }
            }
            hoNetLongBox.Text = Convert.ToString(netposlong);
            hoNetShortBox.Text = Convert.ToString(netposshort);
        }

        private void CombineNaturalTrade(List<Trade> NaturalFillList)
        {
            try
            {
                NaturalCombinedFillList = (
                    from trade in NaturalFillList
                    group trade by trade.Date.Date into g
                    select new Trade { Date = g.Key, Buy = g.Sum(t => t.Buy), Sell = g.Sum(t => t.Sell) }
                ).ToList();
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void PrintNaturalTrade(List<Trade> fillList)
        {
            int netposlong = 0, netposshort = 0;

            var newList = fillList.Select(x => new NetTrade
            {
                Net = x.Buy - x.Sell,
                Date = x.Date
            }).ToList();

            naturalGrid.Items.Clear();

            foreach (NetTrade trade in newList)
            {
                ListViewItem item1 = new ListViewItem();

                if (trade.Net > 0)
                {
                    item1.Text = Convert.ToString(trade.Net);
                    item1.SubItems.Add(trade.Date.ToString("MMMyy"));
                    item1.SubItems.Add("");
                }
                else if (trade.Net < 0)
                {
                    item1.Text = "";
                    item1.SubItems.Add(trade.Date.ToString("MMMyy"));
                    item1.SubItems.Add(Convert.ToString(Math.Abs(trade.Net)));
                }
                else if (trade.Net == 0)
                {
                    item1.Text = "";
                    item1.SubItems.Add(trade.Date.ToString("MMMyy"));
                    item1.SubItems.Add("");
                }

                naturalGrid.Items.Add(item1);
            }

            foreach (NetTrade trade in newList)
            {
                if (trade.Net > 0)
                {
                    netposlong += trade.Net;
                }
                else if (trade.Net < 0)
                {
                    netposshort -= trade.Net;
                }
            }
            ngNetLongBox.Text = Convert.ToString(netposlong);
            ngNetShortBox.Text = Convert.ToString(netposshort);
        }

        private static int DateCompare(Trade o1, Trade o2)
        {
            return o1.Date.CompareTo(o2.Date);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            crudeGrid.Columns.Add("Long", 50, HorizontalAlignment.Center);
            crudeGrid.Columns.Add("Month", 65, HorizontalAlignment.Center);
            crudeGrid.Columns.Add("Short", 50, HorizontalAlignment.Center);

            gasGrid.Columns.Add("Long", 50, HorizontalAlignment.Center);
            gasGrid.Columns.Add("Month", 65, HorizontalAlignment.Center);
            gasGrid.Columns.Add("Short", 50, HorizontalAlignment.Center);

            heatGrid.Columns.Add("Long", 50, HorizontalAlignment.Center);
            heatGrid.Columns.Add("Month", 65, HorizontalAlignment.Center);
            heatGrid.Columns.Add("Short", 50, HorizontalAlignment.Center);

            naturalGrid.Columns.Add("Long", 50, HorizontalAlignment.Center);
            naturalGrid.Columns.Add("Month", 65, HorizontalAlignment.Center);
            naturalGrid.Columns.Add("Short", 50, HorizontalAlignment.Center);

            PutInitialDataIntoGrids();
        }

        // Stub
        private void PutInitialDataIntoGrids()
        {
            // Get manual input of position.
        }

        #region Event_Handlers
        private void clOptionNetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BalanceContracts();
        }

        private void BalanceContracts()
        {
            if (clNetPosition.Text == "N/A" || clNetPosition.Text == "")
            {
                return;
            }

            try
            {
                int monthIndex;
                int optionQty;

                optionQty = Convert.ToInt32(clNetPosition.Text);
                monthIndex = GetMonthIndex(clOptionNetComboBox.Text);
                List<Trade> balancedList = new List<Trade>(CrudeCombinedFillList);
                if (monthIndex < balancedList[0].Date.Month)
                {
                    clSpreadPosition.Text = "N/A";
                    return;
                }

                var newList = balancedList.Select(x => new Trade
                {
                    Buy = x.Buy > x.Sell ? x.Buy - x.Sell : 0,
                    Sell = x.Buy < x.Sell ? x.Sell - x.Buy : 0,
                    Date = x.Date
                }).ToList();

                if (optionQty > 0)
                {
                    (from trade in newList
                     where trade.Date.Month == monthIndex
                     select trade).ToList().ForEach(trade => trade.Sell += optionQty);
                }
                else if (optionQty < 0)
                {
                    (from trade in newList
                     where trade.Date.Month == monthIndex
                     select trade).ToList().ForEach(trade => trade.Buy -= optionQty);
                }

                CalculateSpreadCount(newList);
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void CalculateSpreadCount(List<Trade> list)
        {
            CrudeSpreadList = new List<NetTrade>();

            clSpreadPosition.Clear();

            var netList = list.Select(x => new NetTrade
                {
                    Net = x.Buy - x.Sell,
                    Date = x.Date
                }).ToList();

            CrudeSpreadList.Add(netList[0]);
            for (int i = 0, total = netList[0].Net; i < netList.Count - 1; i++)
            {
                total += netList[i + 1].Net;
                NetTrade x = new NetTrade(netList[i + 1].Date, total);

                CrudeSpreadList.Add(x);
            }

            for (int i = 0; i < CrudeSpreadList.Count; i++)
            {
                CrudePosition.spread += CrudeSpreadList[i].Net;
            }

            clSpreadPosition.Text = Convert.ToString(CrudePosition.spread);
        }

        private void clOptionSpreadComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BalanceSpreads();
        }

        private void BalanceSpreads()
        {
            try
            {
            	if (clNetPosition.Text == "N/A" || clNetPosition.Text == "")
        	    {
    	            return;
	            }

				int monthIndex;
                int optionQty;

                optionQty = Convert.ToInt32(clSpreadPosition.Text);
                monthIndex = GetMonthIndex(clOptionSpreadComboBox.Text);
                if (monthIndex < CrudeSpreadList[0].Date.Month)
                {
                    clFlyPosition.Text = "N/A";
                    return;
                }

                if (optionQty > 0)
                {
                    (from trade in CrudeSpreadList
                     where trade.Date.Month == monthIndex
                     select trade).ToList().ForEach(trade => trade.Net += optionQty);
                }
                else if (optionQty < 0)
                {
                    (from trade in CrudeSpreadList
                     where trade.Date.Month == monthIndex
                     select trade).ToList().ForEach(trade => trade.Net -= optionQty);
                }

                CalculateFlyCount(CrudeSpreadList);


            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        private void CalculateFlyCount(List<NetTrade> list)
        {
            List<NetTrade> CrudeFlyList = new List<NetTrade>();

            clSpreadPosition.Clear();

            CrudeFlyList.Add(list[0]);
            for (int i = 0, total = list[0].Net; i < list.Count - 1; i++)
            {
                total -= 2 * (list[i + 1].Net);
                total += list[i + 2].Net;
                NetTrade x = new NetTrade(list[i + 1].Date, total);

                CrudeFlyList.Add(x);
            }

            for (int i = 0; i < CrudeFlyList.Count; i++)
            {
                CrudePosition.fly += CrudeFlyList[i].Net;
            }

            clSpreadPosition.Text = Convert.ToString(CrudePosition.fly);
        }
        private void rbOptionNetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void rbOptionSpreadComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void hoOptionNetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void hoOptionSpreadComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ngOptionNetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ngOptionSpreadComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private int GetMonthIndex(string monthVal)
        {
            switch (monthVal)
            {
                case "F":
                    return 1;
                case "G":
                    return 2;
                case "H":
                    return 3;
                case "J":
                    return 4;
                case "K":
                    return 5;
                case "M":
                    return 6;
                case "N":
                    return 7;
                case "Q":
                    return 8;
                case "U":
                    return 9;
                case "V":
                    return 10;
                case "X":
                    return 11;
                case "Z":
                    return 12;
                default:
                    return 0;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ttGate.XTAPITerminate();
        }
    }
}

