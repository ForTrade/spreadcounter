﻿//	SpreadCounter
//	Copyright (c) 2013 Addie Bendory

using LumenWorks.Framework.IO.Csv;
using OpenPOP.POP3;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Tamir.SharpSsh.jsch;
using XTAPI;

namespace SpreadCounter
{
    /// <summary>
    /// Represents the main SpreadCounter class.
    /// </summary>
    public partial class SpreadCounter : Form
    {
        #region Form Instances

        /// <summary>
        /// Represents the InputTrades class.  
        /// </summary>
        private InputTrades inputtrades;

        /// <summary>
        /// Represents the Butterfly class.  
        /// </summary>
        private Butterfly butterfly;

        /// <summary>
        /// Represents the Loading class.  
        /// </summary>
        private Loading loading;

        #endregion

        #region Statics

        /// <summary>
        /// Set to keep InputTrades class open.  
        /// </summary>
        private static bool isTradesShown = false;

        /// <summary>
        /// Set to keep InputTrades class open.  
        /// </summary>
        public static bool IsTradesShown
        {
            get { return isTradesShown; }
            set { isTradesShown = value; }
        }

        /// <summary>
        /// Set to keep Butterfly class open.  
        /// </summary>
        private static bool isButterflyShown = false;
        
        /// <summary>
        /// Set to keep Butterfly class open.  
        /// </summary>
        public static bool IsButterflyShown
        {
            get { return isButterflyShown; }
            set { isButterflyShown = value; }
        }

        #endregion

        #region Structures

        /// <summary>
        /// Stucture representing position.  
        /// </summary>
        public struct PositionStruct
        {
            public int net, spread, fly;
        }

        #endregion 
        
        enum Fly
        {
	        Single,
	        Double,
	        Triple
        };
        
        #region Classes

        /// <summary>
        /// Represents a trade with buy and sell data.  
        /// </summary>
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

        /// <summary>
        /// Represents a trade with one var holding quantity.  
        /// </summary>
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

        #endregion

        #region Global Structure Instances

        /// <summary>
        /// Holds the Crude net, spread, and fly positions.  
        /// </summary>
        PositionStruct CrudePosition;

        /// <summary>
        /// Holds the Gas net, spread, and fly positions.  
        /// </summary>
        PositionStruct GasPosition;

        /// <summary>
        /// Holds the Heat net, spread, and fly positions.  
        /// </summary>
        PositionStruct HeatPosition;

        /// <summary>
        /// Holds the Natural net, spread, and fly positions.  
        /// </summary>
        PositionStruct NaturalPosition;

        /// <summary>
        /// Holds the  Brent net, spread, and fly positions.  
        /// </summary>
        PositionStruct BrentPosition;

        #endregion

        #region TT Objects

        /// <summary>
        /// Object used to connect to TT.  
        /// </summary>
        private TTGate ttGate = new TTGate();

        /// <summary>
        /// Object used to receive fill notifications.  
        /// </summary>
        private TTOrderSet m_orderSet = null;

        #endregion

        #region Fill List Objects

        /// <summary>
        /// List of individual crude fills.  
        /// </summary>
        public List<Trade> CrudeFillList = new List<Trade>();

        /// <summary>
        /// List of individual gas fills. 
        /// </summary>
        public List<Trade> GasFillList = new List<Trade>();

        /// <summary>
        /// List of individual heat fills. 
        /// </summary>
        public List<Trade> HeatFillList = new List<Trade>();

        /// <summary>
        /// List of individual natural fills. 
        /// </summary>
        public List<Trade> NaturalFillList = new List<Trade>();

        /// <summary>
        /// List of individual brent fills. 
        /// </summary>
        public List<Trade> BrentFillList = new List<Trade>();

        #endregion

        #region Combined List Objects
        /// <summary>
        /// List of combined crude fills. 
        /// </summary>
        public List<Trade> CrudeCombinedFillList = new List<Trade>();

        /// <summary>
        /// List of individual gas fills. 
        /// </summary>
        public List<Trade> GasCombinedFillList = new List<Trade>();

        /// <summary>
        /// List of individual heat fills. 
        /// </summary>
        public List<Trade> HeatCombinedFillList = new List<Trade>();

        /// <summary>
        /// List of individual natural fills. 
        /// </summary>
        public List<Trade> NaturalCombinedFillList = new List<Trade>();

        /// <summary>
        /// List of individual brent fills. 
        /// </summary>
        public List<Trade> BrentCombinedFillList = new List<Trade>();

        #endregion

        #region Combined Net Objects

        /// <summary>
        /// List of combined crude fills. 
        /// </summary>
        public List<NetTrade> CrudeNetList = new List<NetTrade>();

        /// <summary>
        /// List of combined gas fills. 
        /// </summary>
        public List<NetTrade> GasNetList = new List<NetTrade>();

        /// <summary>
        /// List of combined heat fills. 
        /// </summary>
        public List<NetTrade> HeatNetList = new List<NetTrade>();

        /// <summary>
        /// List of individual natural fills. 
        /// </summary>
        public List<NetTrade> NaturalNetList = new List<NetTrade>();

        /// <summary>
        /// List of individual brent fills. 
        /// </summary>
        public List<NetTrade> BrentNetList = new List<NetTrade>();
        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the SpreadCounter class.
        /// </summary>
        public SpreadCounter()
        {
            InitializeComponent();

            m_orderSet = new TTOrderSet();
            m_orderSet.EnableOrderSend = 0;  // application cannot submit orders
            m_orderSet.EnableOrderFillData = 1;
            m_orderSet.OnOrderFillData += new _ITTOrderSetEvents_OnOrderFillDataEventHandler(m_orderSet_OnOrderFillData);
            m_orderSet.Set("NetLimits", false);
            m_orderSet.Open(0);
        }

        #endregion

        #region OnOrderFill Method

        /// <summary>
        /// Handles the order fill data.
        /// </summary>
        /// <param name="pFillObj">The fill object.</param>
        private void m_orderSet_OnOrderFillData(TTFillObj pFillObj)
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

        #endregion

        #region UpdateFillDisplay

        /// <summary>
        /// Processes a new fill and splits it according to contract.
        /// </summary>
        /// <param name="pFillObj">The fill coming from TT.</param>
        private void UpdateFillDisplay(TTFillObj pFillObj)
        {
            try
            {
                string szContract = (string)pFillObj.get_Get("Contract");
                string szContractType = szContract.Split(' ')[0]; // CL
                switch (szContractType)
                {
                    case "CL":
                    case "CLT":
                        UpdateCrudePosition(pFillObj);
                        BalanceCrudeContracts();
                        break;
                    case "RB":
                    case "RBT":
                        UpdateGasPosition(pFillObj);
                        BalanceGasContracts();
                        break;
                    case "HO":
                    case "HOT":
                        UpdateHeatPosition(pFillObj);
                        BalanceHeatContracts();
                        break;
                    case "NG":
                    case "NGT":
                        UpdateNaturalPosition(pFillObj);
                        BalanceNaturalContracts();
                        break;
                    case "BZ":
                    case "BZT":
                        UpdateBrentPosition(pFillObj);
                        BalanceBrentContracts();
                        break;
                    default:
                        return;
                }
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        #endregion

        #region Update Position Methods

        #region UpdateCrudePosition

        /// <summary>
        /// Processes and parses a new crude fill.
        /// </summary>
        /// <param name="pFillObj">The fill coming from TT.</param>
        private void UpdateCrudePosition(TTFillObj pFillObj)
        {
            try
            {
                DateTime date;
                Array fillData = (Array)pFillObj.get_Get("Buy,Sell,Contract");
                int buy = (int)fillData.GetValue(0);
                int sell = (int)fillData.GetValue(1);
                string szContract = (string)fillData.GetValue(2);
                string szContractDate = szContract.Split(' ')[1]; // Mar10
                DateTime.TryParseExact(szContractDate, "MMMyy", new CultureInfo("en-US"), DateTimeStyles.None, out date);
                CrudePosition.net += buy - sell;
                Trade trade = new Trade(date, buy, sell);

                // Add fill to list
                CrudeFillList.Add(trade);
                CrudeFillList.Sort(DateCompare);
                CombineCrudeTrade(CrudeFillList);
                PrintCrudeTrade(CrudeCombinedFillList);

                // Calculate Net Position
                if (CrudePosition.net > 0)
                    clNetPosition.Text = "+" + CrudePosition.net.ToString();
                else
                    clNetPosition.Text = CrudePosition.net.ToString();
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        #endregion

        #region UpdateGasPosition

        /// <summary>
        /// Processes and parses a new gas fill.
        /// </summary>
        /// <param name="pFillObj">The fill coming from TT.</param>
        private void UpdateGasPosition(TTFillObj pFillObj)
        {
            try
            {
                DateTime date;
                Array fillData = (Array)pFillObj.get_Get("Buy,Sell,Contract");
                int buy = (int)fillData.GetValue(0);
                int sell = (int)fillData.GetValue(1);
                string szContract = (string)fillData.GetValue(2);
                string szContractDate = szContract.Split(' ')[1]; // Mar10
                DateTime.TryParseExact(szContractDate, "MMMyy", new CultureInfo("en-US"), DateTimeStyles.None, out date);
                GasPosition.net += buy - sell;
                Trade trade = new Trade(date, buy, sell);

                // Add fill to list
                GasFillList.Add(trade);
                GasFillList.Sort(DateCompare);
                CombineGasTrade(GasFillList);
                PrintGasTrade(GasCombinedFillList);

                // Calculate Net Position
                if (GasPosition.net > 0)
                    rbNetPosition.Text = "+" + GasPosition.net.ToString();
                else
                    rbNetPosition.Text = GasPosition.net.ToString();
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        #endregion

        #region UpdateHeatPosition

        /// <summary>
        /// Processes and parses a new heat fill.
        /// </summary>
        /// <param name="pFillObj">The fill coming from TT.</param>
        private void UpdateHeatPosition(TTFillObj pFillObj)
        {
            try
            {
                DateTime date;
                Array fillData = (Array)pFillObj.get_Get("Buy,Sell,Contract");
                int buy = (int)fillData.GetValue(0);
                int sell = (int)fillData.GetValue(1);
                string szContract = (string)fillData.GetValue(2);
                string szContractDate = szContract.Split(' ')[1]; // Mar10
                DateTime.TryParseExact(szContractDate, "MMMyy", new CultureInfo("en-US"), DateTimeStyles.None, out date);
                HeatPosition.net += buy - sell;
                Trade trade = new Trade(date, buy, sell);

                // Add fill to list
                HeatFillList.Add(trade);
                HeatFillList.Sort(DateCompare);
                CombineHeatTrade(HeatFillList);
                PrintHeatTrade(HeatCombinedFillList);

                // Calculate Net Position
                if (HeatPosition.net > 0)
                    hoNetPosition.Text = "+" + HeatPosition.net.ToString();
                else
                    hoNetPosition.Text = HeatPosition.net.ToString();
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        #endregion

        #region UpdateNaturalPosition

        /// <summary>
        /// Processes and parses a new natural fill.
        /// </summary>
        /// <param name="pFillObj">The fill coming from TT.</param>
        private void UpdateNaturalPosition(TTFillObj pFillObj)
        {
            try
            {
                DateTime date;
                Array fillData = (Array)pFillObj.get_Get("Buy,Sell,Contract");
                int buy = (int)fillData.GetValue(0);
                int sell = (int)fillData.GetValue(1);
                string szContract = (string)fillData.GetValue(2);
                string szContractDate = szContract.Split(' ')[1]; // Mar10
                DateTime.TryParseExact(szContractDate, "MMMyy", new CultureInfo("en-US"), DateTimeStyles.None, out date);
                NaturalPosition.net += buy - sell;
                Trade trade = new Trade(date, buy, sell);

                // Add fill to list
                NaturalFillList.Add(trade);
                NaturalFillList.Sort(DateCompare);
                CombineNaturalTrade(NaturalFillList);
                PrintNaturalTrade(NaturalCombinedFillList);

                // Calculate Net Position
                if (NaturalPosition.net > 0)
                    ngNetPosition.Text = "+" + NaturalPosition.net.ToString();
                else
                    ngNetPosition.Text = NaturalPosition.net.ToString();
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        #endregion

        #region UpdateBrentPosition

        /// <summary>
        /// Processes and parses a new brent fill.
        /// </summary>
        /// <param name="pFillObj">The fill coming from TT.</param>
        private void UpdateBrentPosition(TTFillObj pFillObj)
        {
            try
            {
                DateTime date;
                Array fillData = (Array)pFillObj.get_Get("Buy,Sell,Contract");
                int buy = (int)fillData.GetValue(0);
                int sell = (int)fillData.GetValue(1);
                string szContract = (string)fillData.GetValue(2);
                string szContractDate = szContract.Split(' ')[1]; // Mar10
                DateTime.TryParseExact(szContractDate, "MMMyy", new CultureInfo("en-US"), DateTimeStyles.None, out date);
                BrentPosition.net += buy - sell;
                Trade trade = new Trade(date, buy, sell);

                // Add fill to list
                BrentFillList.Add(trade);
                BrentFillList.Sort(DateCompare);
                CombineBrentTrade(BrentFillList);
                PrintBrentTrade(BrentCombinedFillList);

                // Calculate Net Position
                if (BrentPosition.net > 0)
                    bzNetPosition.Text = "+" + BrentPosition.net.ToString();
                else
                    bzNetPosition.Text = BrentPosition.net.ToString();
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        #endregion

        #endregion

        #region Manual Entry Methods

        #region UpdateInitialCrudePosition

        /// <summary>
        /// Processes and parses a manually input crude trade.
        /// </summary>
        /// <param name="trade">The fill coming from TT.</param>
        /// <param name="clear">if set to <c>true</c> clears list and updates position else adds to existing position.</param>
        public void UpdateInitialCrudePosition(Trade trade, bool clear)
        {
            try
            {
                // Add fill to list
                if (clear)
                {
                    for (int i = 0; i < CrudeFillList.Count; i++)
                    {
                        if (CrudeFillList[i].Date.Month == trade.Date.Month && CrudeFillList[i].Date.Year == trade.Date.Year)
                            CrudeFillList.Remove(CrudeFillList[i]);
                    }
                    for (int i = 0; i < CrudeCombinedFillList.Count; i++)
                    {
                        if (CrudeCombinedFillList[i].Date.Month == trade.Date.Month && CrudeCombinedFillList[i].Date.Year == trade.Date.Year)
                            CrudeCombinedFillList.Remove(CrudeCombinedFillList[i]);
                    }
                }
                CrudeFillList.Add(trade);
                CrudeFillList.Sort(DateCompare);
                CombineCrudeTrade(CrudeFillList);
                PrintCrudeTrade(CrudeCombinedFillList);

                // Calculate Net Position
                CrudePosition.net = Convert.ToInt32(clNetLongBox.Text) - Convert.ToInt32(clNetShortBox.Text);
                if (CrudePosition.net > 0)
                    clNetPosition.Text = "+" + CrudePosition.net.ToString();
                else
                    clNetPosition.Text = CrudePosition.net.ToString();
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        #endregion

        #region UpdateInitialGasPosition

        /// <summary>
        /// Processes and parses a manually input gas trade.
        /// </summary>
        /// <param name="trade">The trade.</param>
        /// <param name="clear">if set to <c>true</c> clears list and updates position else adds to existing position.</param>
        public void UpdateInitialGasPosition(Trade trade, bool clear)
        {
            try
            {
                // Add fill to list
                if (clear)
                {
                    for (int i = 0; i < GasFillList.Count; i++)
                    {
                        if (GasFillList[i].Date.Month == trade.Date.Month && GasFillList[i].Date.Year == trade.Date.Year)
                            GasFillList.Remove(GasFillList[i]);
                    }
                    for (int i = 0; i < GasCombinedFillList.Count; i++)
                    {
                        if (GasCombinedFillList[i].Date.Month == trade.Date.Month && GasCombinedFillList[i].Date.Year == trade.Date.Year)
                            GasCombinedFillList.Remove(GasCombinedFillList[i]);
                    }
                }

                GasFillList.Add(trade);
                GasFillList.Sort(DateCompare);
                CombineGasTrade(GasFillList);
                PrintGasTrade(GasCombinedFillList);

                // Calculate Net Position
                GasPosition.net = Convert.ToInt32(rbNetLongBox.Text) - Convert.ToInt32(rbNetShortBox.Text);
                if (GasPosition.net > 0)
                    rbNetPosition.Text = "+" + GasPosition.net.ToString();
                else
                    rbNetPosition.Text = GasPosition.net.ToString();
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        #endregion

        #region UpdateInitialHeatPosition

        /// <summary>
        /// Processes and parses a manually input heat trade.
        /// </summary>
        /// <param name="trade">The fill coming from TT.</param>
        /// <param name="clear">if set to <c>true</c> clears list and updates position else adds to existing position.</param>
        public void UpdateInitialHeatPosition(Trade trade, bool clear)
        {
            try
            {
                // Add fill to list
                if (clear)
                {
                    for (int i = 0; i < HeatFillList.Count; i++)
                    {
                        if (HeatFillList[i].Date.Month == trade.Date.Month && HeatFillList[i].Date.Year == trade.Date.Year)
                            HeatFillList.Remove(HeatFillList[i]);
                    }
                    for (int i = 0; i < HeatCombinedFillList.Count; i++)
                    {
                        if (HeatCombinedFillList[i].Date.Month == trade.Date.Month && HeatCombinedFillList[i].Date.Year == trade.Date.Year)
                            HeatCombinedFillList.Remove(HeatCombinedFillList[i]);
                    }
                }
                HeatFillList.Add(trade);
                HeatFillList.Sort(DateCompare);
                CombineHeatTrade(HeatFillList);
                PrintHeatTrade(HeatCombinedFillList);

                // Calculate Net Position
                HeatPosition.net = Convert.ToInt32(hoNetLongBox.Text) - Convert.ToInt32(hoNetShortBox.Text);
                if (HeatPosition.net > 0)
                    hoNetPosition.Text = "+" + HeatPosition.net.ToString();
                else
                    hoNetPosition.Text = HeatPosition.net.ToString();
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        #endregion

        #region UpdateInitialNaturalPosition

        /// <summary>
        /// Processes and parses a manually input natural trade.
        /// </summary>
        /// <param name="trade">The fill coming from TT.</param>
        /// <param name="clear">if set to <c>true</c> clears list and updates position else adds to existing position.</param>
        public void UpdateInitialNaturalPosition(Trade trade, bool clear)
        {
            try
            {
                // Add fill to list
                if (clear)
                {
                    for (int i = 0; i < NaturalFillList.Count; i++)
                    {
                        if (NaturalFillList[i].Date.Month == trade.Date.Month && NaturalFillList[i].Date.Year == trade.Date.Year)
                            NaturalFillList.Remove(NaturalFillList[i]);
                    }
                    for (int i = 0; i < NaturalCombinedFillList.Count; i++)
                    {
                        if (NaturalCombinedFillList[i].Date.Month == trade.Date.Month && NaturalCombinedFillList[i].Date.Year == trade.Date.Year)
                            NaturalCombinedFillList.Remove(NaturalCombinedFillList[i]);
                    }
                }

                NaturalFillList.Add(trade);
                NaturalFillList.Sort(DateCompare);
                CombineNaturalTrade(NaturalFillList);
                PrintNaturalTrade(NaturalCombinedFillList);

                // Calculate Net Position
                NaturalPosition.net = Convert.ToInt32(ngNetLongBox.Text) - Convert.ToInt32(ngNetShortBox.Text);
                if (NaturalPosition.net > 0)
                    ngNetPosition.Text = "+" + NaturalPosition.net.ToString();
                else
                    ngNetPosition.Text = NaturalPosition.net.ToString();
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        #endregion

        #region UpdateInitialBrentPosition

        /// <summary>
        /// Processes and parses a manually input brent trade.
        /// </summary>
        /// <param name="trade">The fill coming from TT.</param>
        /// <param name="clear">if set to <c>true</c> clears list and updates position else adds to existing position.</param>
        public void UpdateInitialBrentPosition(Trade trade, bool clear)
        {
            try
            {
                // Add fill to list
                if (clear)
                {
                    for (int i = 0; i < BrentFillList.Count; i++)
                    {
                        if (BrentFillList[i].Date.Month == trade.Date.Month && BrentFillList[i].Date.Year == trade.Date.Year)
                            BrentFillList.Remove(BrentFillList[i]);
                    }
                    for (int i = 0; i < BrentCombinedFillList.Count; i++)
                    {
                        if (BrentCombinedFillList[i].Date.Month == trade.Date.Month && BrentCombinedFillList[i].Date.Year == trade.Date.Year)
                            BrentCombinedFillList.Remove(BrentCombinedFillList[i]);
                    }
                }

                BrentFillList.Add(trade);
                BrentFillList.Sort(DateCompare);
                CombineBrentTrade(BrentFillList);
                PrintBrentTrade(BrentCombinedFillList);

                // Calculate Net Position
                BrentPosition.net = Convert.ToInt32(bzNetLongBox.Text) - Convert.ToInt32(bzNetShortBox.Text);
                if (BrentPosition.net > 0)
                    bzNetPosition.Text = "+" + BrentPosition.net.ToString();
                else
                    bzNetPosition.Text = BrentPosition.net.ToString();
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        #endregion

        #endregion

        #region Combine Methods

        #region CombineCrudeTrade

        /// <summary>
        /// Combines the crude trades.
        /// </summary>
        /// <param name="list">The crude fill list.</param>
        private void CombineCrudeTrade(List<Trade> list)
        {
            try
            {
                CrudeCombinedFillList = (
                    from trade in list
                    group trade by trade.Date.Date into g
                    select new Trade { Date = g.Key, Buy = g.Sum(t => t.Buy), Sell = g.Sum(t => t.Sell) }
                ).ToList();
                CrudeFillList = new List<Trade>(CrudeCombinedFillList);
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        #endregion

        #region CombineGasTrade

        /// <summary>
        /// Combines the gas trades.
        /// </summary>
        /// <param name="list">The gas fill list.</param>
        private void CombineGasTrade(List<Trade> list)
        {
            try
            {
                GasCombinedFillList = (
                    from trade in list
                    group trade by trade.Date.Date into g
                    select new Trade { Date = g.Key, Buy = g.Sum(t => t.Buy), Sell = g.Sum(t => t.Sell) }
                ).ToList();
                GasFillList = new List<Trade>(GasCombinedFillList);
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        #endregion

        #region CombineHeatTrade

        /// <summary>
        /// Combines the heat trades.
        /// </summary>
        /// <param name="GasFillList">The gas fill list.</param>
        private void CombineHeatTrade(List<Trade> list)
        {
            try
            {
                HeatCombinedFillList = (
                    from trade in list
                    group trade by trade.Date.Date into g
                    select new Trade { Date = g.Key, Buy = g.Sum(t => t.Buy), Sell = g.Sum(t => t.Sell) }
                ).ToList();
                HeatFillList = new List<Trade>(HeatCombinedFillList);
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        #endregion

        #region CombineNaturalTrade

        /// <summary>
        /// Combines the natural trades.
        /// </summary>
        /// <param name="GasFillList">The natural fill list.</param>
        private void CombineNaturalTrade(List<Trade> list)
        {
            try
            {
                NaturalCombinedFillList = (
                    from trade in list
                    group trade by trade.Date.Date into g
                    select new Trade { Date = g.Key, Buy = g.Sum(t => t.Buy), Sell = g.Sum(t => t.Sell) }
                ).ToList();
                NaturalFillList = new List<Trade>(NaturalCombinedFillList);
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        #endregion

        #region CombineBrentTrade

        /// <summary>
        /// Combines the brent trades.
        /// </summary>
        /// <param name="BrentFillList">The brent fill list.</param>
        private void CombineBrentTrade(List<Trade> list)
        {
            try
            {
                BrentCombinedFillList = (
                    from trade in list
                    group trade by trade.Date.Date into g
                    select new Trade { Date = g.Key, Buy = g.Sum(t => t.Buy), Sell = g.Sum(t => t.Sell) }
                ).ToList();
                BrentFillList = new List<Trade>(BrentCombinedFillList);
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        #endregion

        #endregion


        // TODO: Combine all of the print methods into one print method.  
        // Pass in the commodity type and the Fly number as args
        #region Print Trade

        #region PrintCrudeTrade

        /// <summary>
        /// Prints the crude trade.
        /// </summary>
        /// <param name="fillList">The fill list.</param>
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
                    item1.ForeColor = Color.Blue;
                    item1.Text = trade.Net.ToString();
                    item1.SubItems.Add(trade.Date.ToString("MMMyy"));
                    item1.SubItems.Add("");
                }
                else if (trade.Net < 0)
                {
                    item1.ForeColor = Color.Red;
                    item1.Text = "";
                    item1.SubItems.Add(trade.Date.ToString("MMMyy"));
                    item1.SubItems.Add((-trade.Net).ToString());
                }
                else if (trade.Net == 0)
                {
                    continue;
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
            clNetLongBox.Text = netposlong.ToString();
            clNetShortBox.Text = netposshort.ToString();
        }

        #endregion

        #region PrintGasTrade

        /// <summary>
        /// Prints the gas trade.
        /// </summary>
        /// <param name="fillList">The fill list.</param>
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
                    item1.ForeColor = Color.Blue;
                    item1.Text = trade.Net.ToString();
                    item1.SubItems.Add(trade.Date.ToString("MMMyy"));
                    item1.SubItems.Add("");
                }
                else if (trade.Net < 0)
                {
                    item1.ForeColor = Color.Red;
                    item1.Text = "";
                    item1.SubItems.Add(trade.Date.ToString("MMMyy"));
                    item1.SubItems.Add((-trade.Net).ToString());
                }
                else if (trade.Net == 0)
                {
                    continue;
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
            rbNetLongBox.Text = netposlong.ToString();
            rbNetShortBox.Text = netposshort.ToString();
        }

        #endregion

        #region PrintHeatTrade

        /// <summary>
        /// Prints the heat trade.
        /// </summary>
        /// <param name="fillList">The fill list.</param>
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
                    item1.ForeColor = Color.Blue;
                    item1.Text = trade.Net.ToString();
                    item1.SubItems.Add(trade.Date.ToString("MMMyy"));
                    item1.SubItems.Add("");
                }
                else if (trade.Net < 0)
                {
                    item1.ForeColor = Color.Red;
                    item1.Text = "";
                    item1.SubItems.Add(trade.Date.ToString("MMMyy"));
                    item1.SubItems.Add((-trade.Net).ToString());
                }
                else if (trade.Net == 0)
                {
                    continue;
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
            hoNetLongBox.Text = netposlong.ToString();
            hoNetShortBox.Text = netposshort.ToString();
        }

        #endregion

        #region PrintNaturalTrade

        /// <summary>
        /// Prints the natural trade.
        /// </summary>
        /// <param name="fillList">The fill list.</param>
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
                    item1.ForeColor = Color.Blue;
                    item1.Text = trade.Net.ToString();
                    item1.SubItems.Add(trade.Date.ToString("MMMyy"));
                    item1.SubItems.Add("");
                }
                else if (trade.Net < 0)
                {
                    item1.ForeColor = Color.Red;
                    item1.Text = "";
                    item1.SubItems.Add(trade.Date.ToString("MMMyy"));
                    item1.SubItems.Add((-trade.Net).ToString());
                }
                else if (trade.Net == 0)
                {
                    continue;
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
            ngNetLongBox.Text = netposlong.ToString();
            ngNetShortBox.Text = netposshort.ToString();
        }

        #endregion

        #region PrintBrentTrade

        /// <summary>
        /// Prints the brent trade.
        /// </summary>
        /// <param name="fillList">The fill list.</param>
        private void PrintBrentTrade(List<Trade> fillList)
        {
            int netposlong = 0, netposshort = 0;

            var newList = fillList.Select(x => new NetTrade
            {
                Net = x.Buy - x.Sell,
                Date = x.Date
            }).ToList();

            brentGrid.Items.Clear();

            foreach (NetTrade trade in newList)
            {
                ListViewItem item1 = new ListViewItem();

                if (trade.Net > 0)
                {
                    item1.ForeColor = Color.Blue;
                    item1.Text = trade.Net.ToString();
                    item1.SubItems.Add(trade.Date.ToString("MMMyy"));
                    item1.SubItems.Add("");
                }
                else if (trade.Net < 0)
                {
                    item1.ForeColor = Color.Red;
                    item1.Text = "";
                    item1.SubItems.Add(trade.Date.ToString("MMMyy"));
                    item1.SubItems.Add((-trade.Net).ToString());
                }
                else if (trade.Net == 0)
                {
                    continue;
                }

                brentGrid.Items.Add(item1);
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
            bzNetLongBox.Text = netposlong.ToString();
            bzNetShortBox.Text = netposshort.ToString();
        }

        #endregion

        #endregion

        #region Print Fly

        #region PrintCrudeFly

        /// <summary>
        /// Prints the crude fly.
        /// </summary>
        /// <param name="fillList">The fill list.</param>
        private void PrintCrudeFly(List<NetTrade> newList)
        {
            crudeFlyGrid.Items.Clear();

            foreach (NetTrade trade in newList)
            {
                ListViewItem item1 = new ListViewItem();
                string fly = FlyDate(trade.Date.ToString("MMM"), Fly.Single);
                string year = trade.Date.ToString("yy");
                if (DateTime.Now.Year.ToString().TrimStart('2', '0') != year)
                    fly += year;

                if (trade.Net > 0)
                {
                    item1.ForeColor = Color.Blue;
                    item1.Text = trade.Net.ToString();
                    item1.SubItems.Add(fly);
                    item1.SubItems.Add("");
                }
                else if (trade.Net < 0)
                {
                    item1.ForeColor = Color.Red;
                    item1.Text = "";
                    item1.SubItems.Add(fly);
                    item1.SubItems.Add((-trade.Net).ToString());
                }
                else if (trade.Net == 0)
                {
                    continue;
                }

                crudeFlyGrid.Items.Add(item1);
            }
        }

        #endregion

        #region PrintGasFly

        /// <summary>
        /// Prints the gas fly.
        /// </summary>
        /// <param name="fillList">The fill list.</param>
        private void PrintGasFly(List<NetTrade> newList)
        {
            gasFlyGrid.Items.Clear();

            foreach (NetTrade trade in newList)
            {
                ListViewItem item1 = new ListViewItem();
                string fly = FlyDate(trade.Date.ToString("MMM"), Fly.Single);
                string year = trade.Date.ToString("yy");
                if (DateTime.Now.Year.ToString().TrimStart('2', '0') != year)
                    fly += year;

                if (trade.Net > 0)
                {
                    item1.ForeColor = Color.Blue;
                    item1.Text = trade.Net.ToString();
                    item1.SubItems.Add(fly);
                    item1.SubItems.Add("");
                }
                else if (trade.Net < 0)
                {
                    item1.ForeColor = Color.Red;
                    item1.Text = "";
                    item1.SubItems.Add(fly);
                    item1.SubItems.Add((-trade.Net).ToString());
                }
                else if (trade.Net == 0)
                {
                    continue;
                }

                gasFlyGrid.Items.Add(item1);
            }

            //foreach (NetTrade trade in newList)
            //{
            //    if (trade.Net > 0)
            //    {
            //        netposlong += trade.Net;
            //    }
            //    else if (trade.Net < 0)
            //    {
            //        netposshort -= trade.Net;
            //    }
            //}
            //clNetLongBox.Text = netposlong.ToString();
            //clNetShortBox.Text = netposshort.ToString();
        }

        #endregion

        #region PrintHeatFly

        /// <summary>
        /// Prints the heat fly.
        /// </summary>
        /// <param name="fillList">The fill list.</param>
        private void PrintHeatFly(List<NetTrade> newList)
        {
            heatFlyGrid.Items.Clear();

            foreach (NetTrade trade in newList)
            {
                ListViewItem item1 = new ListViewItem();
                string fly = FlyDate(trade.Date.ToString("MMM"), Fly.Single);
                string year = trade.Date.ToString("yy");
                if (DateTime.Now.Year.ToString().TrimStart('2', '0') != year)
                    fly += year;

                if (trade.Net > 0)
                {
                    item1.ForeColor = Color.Blue;
                    item1.Text = trade.Net.ToString();
                    item1.SubItems.Add(fly);
                    item1.SubItems.Add("");
                }
                else if (trade.Net < 0)
                {
                    item1.ForeColor = Color.Red;
                    item1.Text = "";
                    item1.SubItems.Add(fly);
                    item1.SubItems.Add((-trade.Net).ToString());
                }
                else if (trade.Net == 0)
                {
                    continue;
                }

                heatFlyGrid.Items.Add(item1);
            }

            //foreach (NetTrade trade in newList)
            //{
            //    if (trade.Net > 0)
            //    {
            //        netposlong += trade.Net;
            //    }
            //    else if (trade.Net < 0)
            //    {
            //        netposshort -= trade.Net;
            //    }
            //}
            //clNetLongBox.Text = netposlong.ToString();
            //clNetShortBox.Text = netposshort.ToString();
        }

        #endregion

        #region PrintNaturalFly

        /// <summary>
        /// Prints the natural fly.
        /// </summary>
        /// <param name="fillList">The fill list.</param>
        private void PrintNaturalFly(List<NetTrade> newList)
        {
            naturalFlyGrid.Items.Clear();

            foreach (NetTrade trade in newList)
            {
                ListViewItem item1 = new ListViewItem();
                string fly = FlyDate(trade.Date.ToString("MMM"), Fly.Single);
                string year = trade.Date.ToString("yy");
                if (DateTime.Now.Year.ToString().TrimStart('2', '0') != year)
                    fly += year;

                if (trade.Net > 0)
                {
                    item1.ForeColor = Color.Blue;
                    item1.Text = trade.Net.ToString();
                    item1.SubItems.Add(fly);
                    item1.SubItems.Add("");
                }
                else if (trade.Net < 0)
                {
                    item1.ForeColor = Color.Red;
                    item1.Text = "";
                    item1.SubItems.Add(fly);
                    item1.SubItems.Add((-trade.Net).ToString());
                }
                else if (trade.Net == 0)
                {
                    continue;
                }

                naturalFlyGrid.Items.Add(item1);
            }

            //foreach (NetTrade trade in newList)
            //{
            //    if (trade.Net > 0)
            //    {
            //        netposlong += trade.Net;
            //    }
            //    else if (trade.Net < 0)
            //    {
            //        netposshort -= trade.Net;
            //    }
            //}
            //clNetLongBox.Text = netposlong.ToString();
            //clNetShortBox.Text = netposshort.ToString();
        }

        #endregion

        #region PrintBrentFly

        /// <summary>
        /// Prints the brent fly.
        /// </summary>
        /// <param name="fillList">The fill list.</param>
        private void PrintBrentFly(List<NetTrade> newList)
        {
            brentFlyGrid.Items.Clear();

            foreach (NetTrade trade in newList)
            {
                ListViewItem item1 = new ListViewItem();
                string fly = FlyDate(trade.Date.ToString("MMM"), Fly.Single);
                string year = trade.Date.ToString("yy");
                if (DateTime.Now.Year.ToString().TrimStart('2', '0') != year)
                    fly += year;

                if (trade.Net > 0)
                {
                    item1.ForeColor = Color.Blue;
                    item1.Text = trade.Net.ToString();
                    item1.SubItems.Add(fly);
                    item1.SubItems.Add("");
                }
                else if (trade.Net < 0)
                {
                    item1.ForeColor = Color.Red;
                    item1.Text = "";
                    item1.SubItems.Add(fly);
                    item1.SubItems.Add((-trade.Net).ToString());
                }
                else if (trade.Net == 0)
                {
                    continue;
                }

                brentFlyGrid.Items.Add(item1);
            }

            //foreach (NetTrade trade in newList)
            //{
            //    if (trade.Net > 0)
            //    {
            //        netposlong += trade.Net;
            //    }
            //    else if (trade.Net < 0)
            //    {
            //        netposshort -= trade.Net;
            //    }
            //}
            //clNetLongBox.Text = netposlong.ToString();
            //clNetShortBox.Text = netposshort.ToString();
        }

        #endregion

        #endregion

        #region Print Double Fly

        #region PrintCrudeDouble

        private void PrintCrudeDoubleFly(List<NetTrade> newList)
        {
            crudeDoubleFlyGrid.Items.Clear();

            foreach (NetTrade trade in newList)
            {
                ListViewItem item1 = new ListViewItem();
                string fly = FlyDate(trade.Date.ToString("MMM"), Fly.Double);
                string year = trade.Date.ToString("yy");
                if (DateTime.Now.Year.ToString().TrimStart('2', '0') != year)
                    fly += year;

                if (trade.Net > 0)
                {
                    item1.ForeColor = Color.Blue;
                    item1.Text = trade.Net.ToString();
                    item1.SubItems.Add(fly);
                    item1.SubItems.Add("");
                }
                else if (trade.Net < 0)
                {
                    item1.ForeColor = Color.Red;
                    item1.Text = "";
                    item1.SubItems.Add(fly);
                    item1.SubItems.Add((-trade.Net).ToString());
                }
                else if (trade.Net == 0)
                {
                    continue;
                }

                crudeDoubleFlyGrid.Items.Add(item1);
            }
        }
        #endregion

        #region PrintGasDouble

        private void PrintGasDouble(List<NetTrade> newList)
        {

        }
        #endregion

        #region PrintHeatDouble

        private void PrintHeatDouble(List<NetTrade> newList)
        {

        }
        #endregion

        #region PrintNaturalDouble

        private void PrintNaturalDouble(List<NetTrade> newList)
        {

        }
        #endregion

        #region PrintBrentDouble

        private void PrintBrentDouble(List<NetTrade> newList)
        {

        }
        #endregion

        #endregion

        #region Print Triple Fly

        #region PrintCrudeTripleFly

        private void PrintCrudeTripleFly(List<NetTrade> newList)
        {
            crudeTripleFlyGrid.Items.Clear();

            foreach (NetTrade trade in newList)
            {
                ListViewItem item1 = new ListViewItem();
                string fly = FlyDate(trade.Date.ToString("MMM"), Fly.Double);
                string year = trade.Date.ToString("yy");
                if (DateTime.Now.Year.ToString().TrimStart('2', '0') != year)
                    fly += year;

                if (trade.Net > 0)
                {
                    item1.ForeColor = Color.Blue;
                    item1.Text = trade.Net.ToString();
                    item1.SubItems.Add(fly);
                    item1.SubItems.Add("");
                }
                else if (trade.Net < 0)
                {
                    item1.ForeColor = Color.Red;
                    item1.Text = "";
                    item1.SubItems.Add(fly);
                    item1.SubItems.Add((-trade.Net).ToString());
                }
                else if (trade.Net == 0)
                {
                    continue;
                }

                crudeTripleFlyGrid.Items.Add(item1);
            }
        }
        #endregion

        #region PrintGasTriple

        private void PrintGasTriple(List<NetTrade> newList)
        {

        }
        #endregion

        #region PrintHeatTriple

        private void PrintHeatTriple(List<NetTrade> newList)
        {

        }
        #endregion

        #region PrintNaturalTriplee

        private void PrintNaturalTriple(List<NetTrade> newList)
        {

        }
        #endregion

        #region PrintBrentTriple

        private void PrintBrentTriple(List<NetTrade> newList)
        {

        }
        #endregion

        #endregion

        private string FlyDate(string date, Fly type)
        {
            switch (date)
            {
                case "Jan":
                    if (type == Fly.Single)
                        return "FGH";
                    else if (type == Fly.Double)
                        return "FGHJ";
                    else if (type == Fly.Triple)
                        return "FGHJK";
                    else return date;
                case "Feb": 
                    if (type == Fly.Single)
                        return "GHJ";
                    else if (type == Fly.Double)
                        return "GHJK";
                    else if (type == Fly.Triple)
                        return "GHJKM";
                    else return date;
                case "Mar":
                    if (type == Fly.Single)
                        return "HJK";
                    else if (type == Fly.Double)
                        return "HJKM";
                    else if (type == Fly.Triple)
                        return "HJKMN";
                    else return date;
                case "Apr":
                    if (type == Fly.Single)
                        return "JKM";
                    else if (type == Fly.Double)
                        return "JKMN";
                    else if (type == Fly.Triple)
                        return "JKMNQ";
                    else return date;
                case "May":
                    if (type == Fly.Single)
                        return "KMN";
                    else if (type == Fly.Double)
                        return "KMNQ";
                    else if (type == Fly.Triple)
                        return "KMNQU";
                    else return date;
                case "Jun":
                    if (type == Fly.Single)
                        return "MNQ";
                    else if (type == Fly.Double)
                        return "MNQU";
                    else if (type == Fly.Triple)
                        return "MNQUV";
                    else return date;
                case "Jul":
                    if (type == Fly.Single)
                        return "NQU";
                    else if (type == Fly.Double)
                        return "NQUV";
                    else if (type == Fly.Triple)
                        return "NQUVX";
                    else return date;
                case "Aug":
                    if (type == Fly.Single)
                        return "QUV";
                    else if (type == Fly.Double)
                        return "QUVX";
                    else if (type == Fly.Triple)
                        return "QUVXZ";
                    else return date;
                case "Sep":
                    if (type == Fly.Single)
                        return "UVX";
                    else if (type == Fly.Double)
                        return "UVXZ";
                    else if (type == Fly.Triple)
                        return "UVXZF";
                    else return date;
                case "Oct":
                    if (type == Fly.Single)
                        return "VXZ";
                    else if (type == Fly.Double)
                        return "VXZF";
                    else if (type == Fly.Triple)
                        return "VXZFG";
                    else return date;
                case "Nov":
                    if (type == Fly.Single)
                        return "XZF";
                    else if (type == Fly.Double)
                        return "XZFG";
                    else if (type == Fly.Triple)
                        return "XZFGH";
                    else return date;
                case "Dec":
                    if (type == Fly.Single)
                        return "ZFG";
                    else if (type == Fly.Double)
                        return "ZFGH";
                    else if (type == Fly.Triple)
                        return "ZFGHJ";
                    else return date;
                default:
                    return "XXX";
            }
        }

        #region Balance Contract Methods

        #region BalanceCrudeContracts

        /// <summary>
        /// Balances the crude contracts.
        /// </summary>
        public void BalanceCrudeContracts()
        {
            if (clNetPosition.Text == "N/A" || clNetPosition.Text == "" || CrudeCombinedFillList.Count == 1)
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
                if (clNetPosition.Text != "0")
                {
                    if (monthIndex < balancedList[0].Date.Month)
                    {
                        clSpreadPosition.Text = "N/A";
                        return;
                    }
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

                CalculateCrudeSpreadCount(newList);
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        #endregion

        #region BalanceGasContracts

        /// <summary>
        /// Balances the gas contracts.
        /// </summary>
        public void BalanceGasContracts()
        {
            if (rbNetPosition.Text == "N/A" || rbNetPosition.Text == "")
            {
                return;
            }

            try
            {
                int monthIndex;
                int optionQty;

                optionQty = Convert.ToInt32(rbNetPosition.Text);
                monthIndex = GetMonthIndex(rbOptionNetComboBox.Text);
                List<Trade> balancedList = new List<Trade>(GasCombinedFillList);
                if (rbNetPosition.Text != "0")
                {
                    if (monthIndex < balancedList[0].Date.Month)
                    {
                        rbSpreadPosition.Text = "N/A";
                        return;
                    }
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

                CalculateGasSpreadCount(newList);
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        #endregion

        #region BalanceHeatContracts

        /// <summary>
        /// Balances the heat contracts.
        /// </summary>
        public void BalanceHeatContracts()
        {
            if (hoNetPosition.Text == "N/A" || hoNetPosition.Text == "" || HeatCombinedFillList.Count == 1)
            {
                return;
            }

            try
            {
                int monthIndex;
                int optionQty;

                optionQty = Convert.ToInt32(hoNetPosition.Text);
                monthIndex = GetMonthIndex(hoOptionNetComboBox.Text);
                List<Trade> balancedList = new List<Trade>(HeatCombinedFillList);
                if (hoNetPosition.Text != "0")
                {
                    if (monthIndex < balancedList[0].Date.Month)
                    {
                        hoSpreadPosition.Text = "N/A";
                        return;
                    }
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

                CalculateHeatSpreadCount(newList);
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        #endregion

        #region BalanceNaturalContracts

        /// <summary>
        /// Balances the natural contracts.
        /// </summary>
        public void BalanceNaturalContracts()
        {
            if (ngNetPosition.Text == "N/A" || ngNetPosition.Text == "" || NaturalCombinedFillList.Count == 1)
            {
                return;
            }

            try
            {
                int monthIndex;
                int optionQty;

                optionQty = Convert.ToInt32(ngNetPosition.Text);
                monthIndex = GetMonthIndex(ngOptionNetComboBox.Text);
                List<Trade> balancedList = new List<Trade>(NaturalCombinedFillList);
                if (ngNetPosition.Text != "0")
                {
                    if (monthIndex < balancedList[0].Date.Month)
                    {
                        ngSpreadPosition.Text = "N/A";
                        return;
                    }
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

                CalculateNaturalSpreadCount(newList);
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        #endregion

        #region BalanceBrentContracts

        /// <summary>
        /// Balances the brent contracts.
        /// </summary>
        public void BalanceBrentContracts()
        {
            if (bzNetPosition.Text == "N/A" || bzNetPosition.Text == "" || BrentCombinedFillList.Count == 1)
            {
                return;
            }

            try
            {
                int monthIndex;
                int optionQty;

                optionQty = Convert.ToInt32(ngNetPosition.Text);
                monthIndex = GetMonthIndex(ngOptionNetComboBox.Text);
                List<Trade> balancedList = new List<Trade>(BrentCombinedFillList);
                if (bzNetPosition.Text != "0")
                {
                    if (monthIndex < balancedList[0].Date.Month)
                    {
                        bzSpreadPosition.Text = "N/A";
                        return;
                    }
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

                CalculateBrentSpreadCount(newList);
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        #endregion
        #endregion

        #region Calculate Spread Methods

        #region CalculateCrudeSpreadCount

        /// <summary>
        /// Calculates the crude spread count.
        /// </summary>
        /// <param name="list">The list.</param>
        private void CalculateCrudeSpreadCount(List<Trade> list)
        {
            int spreadcount = 0;
            List<NetTrade> spreadlist = new List<NetTrade>();

            clSpreadPosition.Clear();

            var netList = list.Select(x => new NetTrade
            {
                Net = x.Buy - x.Sell,
                Date = x.Date
            }).ToList();

            //Fill in blank months
            NetTrade prev = netList.First();
            List<NetTrade> result = new List<NetTrade> { prev };
            foreach (NetTrade trade in netList.Skip(1))
            {
                DateTime month = prev.Date;
                while (true)
                {
                    month = month.AddMonths(1);
                    if (month >= trade.Date)
                    {
                        break;
                    }
                    result.Add(new NetTrade { Date = month, Net = 0 });
                }
                result.Add(trade);
                prev = trade;
            }

            spreadlist.Add(result[0]);
            for (int i = 0, total = result[0].Net; i < result.Count - 1; i++)
            {
                total += result[i + 1].Net;
                spreadlist.Add(new NetTrade(result[i + 1].Date, total));
            }

            for (int i = 0; i < spreadlist.Count; i++)
            {
                spreadcount += spreadlist[i].Net;
            }

            CrudePosition.spread = spreadcount;
            
            if (CrudePosition.spread > 0)
                clSpreadPosition.Text = "+" + spreadcount.ToString();
            else
                clSpreadPosition.Text = spreadcount.ToString();
            
            BalanceCrudeSpreads(result);
        }

        #endregion

        #region CalculateGasSpreadCount

        /// <summary>
        /// Calculates the gas spread count.
        /// </summary>
        /// <param name="list">The list.</param>
        private void CalculateGasSpreadCount(List<Trade> list)
        {
            int spreadcount = 0;
            List<NetTrade> spreadlist = new List<NetTrade>();
            rbSpreadPosition.Clear();

            var netList = list.Select(x => new NetTrade
            {
                Net = x.Buy - x.Sell,
                Date = x.Date
            }).ToList();

            NetTrade prev = netList.First();
            List<NetTrade> result = new List<NetTrade> { prev };
            foreach (NetTrade trade in netList.Skip(1))
            {
                DateTime month = prev.Date;
                while (true)
                {
                    month = month.AddMonths(1);
                    if (month >= trade.Date)
                    {
                        break;
                    }
                    result.Add(new NetTrade { Date = month, Net = 0 });
                }
                result.Add(trade);
                prev = trade;
            }

            spreadlist.Add(result[0]);
            for (int i = 0, total = result[0].Net; i < result.Count - 1; i++)
            {
                total += result[i + 1].Net;
                spreadlist.Add(new NetTrade(result[i + 1].Date, total));
            }

            for (int i = 0; i < spreadlist.Count; i++)
            {
                spreadcount += spreadlist[i].Net;
            }

            GasPosition.spread = spreadcount;
            rbSpreadPosition.Text = spreadcount.ToString();
            if (GasPosition.spread > 0)
                rbSpreadPosition.Text = "+" + spreadcount.ToString();
            else
                rbSpreadPosition.Text = spreadcount.ToString();
            BalanceGasSpreads(result);
        }

        #endregion

        #region CalculateHeatSpreadCount

        /// <summary>
        /// Calculates the heat spread count.
        /// </summary>
        /// <param name="list">The list.</param>
        private void CalculateHeatSpreadCount(List<Trade> list)
        {
            int spreadcount = 0;
            List<NetTrade> spreadlist = new List<NetTrade>();
            hoSpreadPosition.Clear();

            var netList = list.Select(x => new NetTrade
            {
                Net = x.Buy - x.Sell,
                Date = x.Date
            }).ToList();

            NetTrade prev = netList.First();
            List<NetTrade> result = new List<NetTrade> { prev };
            foreach (NetTrade trade in netList.Skip(1))
            {
                DateTime month = prev.Date;
                while (true)
                {
                    month = month.AddMonths(1);
                    if (month >= trade.Date)
                    {
                        break;
                    }
                    result.Add(new NetTrade { Date = month, Net = 0 });
                }
                result.Add(trade);
                prev = trade;
            }

            spreadlist.Add(result[0]);
            for (int i = 0, total = result[0].Net; i < result.Count - 1; i++)
            {
                total += result[i + 1].Net;
                spreadlist.Add(new NetTrade(result[i + 1].Date, total));
            }

            for (int i = 0; i < spreadlist.Count; i++)
            {
                spreadcount += spreadlist[i].Net;
            }

            hoSpreadPosition.Text = spreadcount.ToString();
            HeatPosition.spread = spreadcount;
            if (HeatPosition.spread > 0)
                hoSpreadPosition.Text = "+" + spreadcount.ToString();
            else
                hoSpreadPosition.Text = spreadcount.ToString();

            BalanceHeatSpreads(result);
        }

        #endregion

        #region CalculateNaturalSpreadCount

        /// <summary>
        /// Calculates the natural spread count.
        /// </summary>
        /// <param name="list">The list.</param>
        private void CalculateNaturalSpreadCount(List<Trade> list)
        {
            int spreadcount = 0;
            List<NetTrade> spreadlist = new List<NetTrade>();
            ngSpreadPosition.Clear();

            var netList = list.Select(x => new NetTrade
            {
                Net = x.Buy - x.Sell,
                Date = x.Date
            }).ToList();

            NetTrade prev = netList.First();
            List<NetTrade> result = new List<NetTrade> { prev };
            foreach (NetTrade trade in netList.Skip(1))
            {
                DateTime month = prev.Date;
                while (true)
                {
                    month = month.AddMonths(1);
                    if (month >= trade.Date)
                    {
                        break;
                    }
                    result.Add(new NetTrade { Date = month, Net = 0 });
                }
                result.Add(trade);
                prev = trade;
            }

            spreadlist.Add(result[0]);
            for (int i = 0, total = result[0].Net; i < result.Count - 1; i++)
            {
                total += result[i + 1].Net;
                spreadlist.Add(new NetTrade(result[i + 1].Date, total));
            }

            for (int i = 0; i < spreadlist.Count; i++)
            {
                spreadcount += spreadlist[i].Net;
            }

            NaturalPosition.spread = spreadcount;
            if (NaturalPosition.spread > 0)
                ngSpreadPosition.Text = "+" + spreadcount.ToString();
            else
                ngSpreadPosition.Text = spreadcount.ToString();
            BalanceNaturalSpreads(result);
        }

        #endregion

        #region CalculateBrentSpreadCount

        /// <summary>
        /// Calculates the brent spread count.
        /// </summary>
        /// <param name="list">The list.</param>
        private void CalculateBrentSpreadCount(List<Trade> list)
        {
            int spreadcount = 0;
            List<NetTrade> spreadlist = new List<NetTrade>();
            bzSpreadPosition.Clear();

            var netList = list.Select(x => new NetTrade
            {
                Net = x.Buy - x.Sell,
                Date = x.Date
            }).ToList();

            NetTrade prev = netList.First();
            List<NetTrade> result = new List<NetTrade> { prev };
            foreach (NetTrade trade in netList.Skip(1))
            {
                DateTime month = prev.Date;
                while (true)
                {
                    month = month.AddMonths(1);
                    if (month >= trade.Date)
                    {
                        break;
                    }
                    result.Add(new NetTrade { Date = month, Net = 0 });
                }
                result.Add(trade);
                prev = trade;
            }

            spreadlist.Add(result[0]);
            for (int i = 0, total = result[0].Net; i < result.Count - 1; i++)
            {
                total += result[i + 1].Net;
                spreadlist.Add(new NetTrade(result[i + 1].Date, total));
            }

            for (int i = 0; i < spreadlist.Count; i++)
            {
                spreadcount += spreadlist[i].Net;
            }

            BrentPosition.spread = spreadcount;
            if (BrentPosition.spread > 0)
                bzSpreadPosition.Text = "+" + spreadcount.ToString();
            else
                bzSpreadPosition.Text = spreadcount.ToString();
            BalanceBrentSpreads(result);
        }

        #endregion

        #endregion

        #region Balance Spread Methods

        #region BalanceCrudeSpreads

        /// <summary>
        /// Balances the crude spreads.
        /// </summary>
        /// <param name="spreadlist">The spreadlist.</param>
        private void BalanceCrudeSpreads(List<NetTrade> spreadlist)
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
                if (monthIndex < spreadlist[0].Date.Month)
                {
                    clFlyPosition.Text = "N/A";
                    return;
                }

                (from trade in spreadlist
                 where trade.Date.Month == monthIndex
                 select trade).ToList().ForEach(trade => trade.Net -= optionQty);
                
                (from trade in spreadlist
                 where trade.Date.Month == monthIndex + 1
                 select trade).ToList().ForEach(trade => trade.Net += optionQty);

                CalculateCrudeFlyCount(spreadlist);
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        #endregion

        #region BalanceGasSpreads

        /// <summary>
        /// Balances the gas spreads.
        /// </summary>
        /// <param name="spreadlist">The spreadlist.</param>
        private void BalanceGasSpreads(List<NetTrade> spreadlist)
        {
            try
            {
                if (rbNetPosition.Text == "N/A" || rbNetPosition.Text == "" || GasCombinedFillList.Count == 1)
                {
                    return;
                }

                int monthIndex;
                int optionQty;

                optionQty = Convert.ToInt32(rbSpreadPosition.Text);
                monthIndex = GetMonthIndex(rbOptionSpreadComboBox.Text);
                if (monthIndex < spreadlist[0].Date.Month)
                {
                    rbFlyPosition.Text = "N/A";
                    return;
                }

                (from trade in spreadlist
                 where trade.Date.Month == monthIndex
                 select trade).ToList().ForEach(trade => trade.Net -= optionQty);
                (from trade in spreadlist
                 where trade.Date.Month == monthIndex + 1
                 select trade).ToList().ForEach(trade => trade.Net += optionQty);

                CalculateGasFlyCount(spreadlist);
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        #endregion

        #region BalanceHeatSpreads

        /// <summary>
        /// Balances the heat spreads.
        /// </summary>
        /// <param name="spreadlist">The spreadlist.</param>
        private void BalanceHeatSpreads(List<NetTrade> spreadlist)
        {
            try
            {
                if (hoNetPosition.Text == "N/A" || hoNetPosition.Text == "")
                {
                    return;
                }

                int monthIndex;
                int optionQty;

                optionQty = Convert.ToInt32(hoSpreadPosition.Text);
                monthIndex = GetMonthIndex(hoOptionSpreadComboBox.Text);
                if (monthIndex < spreadlist[0].Date.Month)
                {
                    hoFlyPosition.Text = "N/A";
                    return;
                }

                (from trade in spreadlist
                 where trade.Date.Month == monthIndex
                 select trade).ToList().ForEach(trade => trade.Net -= optionQty);
                (from trade in spreadlist
                 where trade.Date.Month == monthIndex + 1
                 select trade).ToList().ForEach(trade => trade.Net += optionQty);

                CalculateHeatFlyCount(spreadlist);


            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        #endregion

        #region BalanceNaturalSpreads

        /// <summary>
        /// Balances the natural spreads.
        /// </summary>
        /// <param name="spreadlist">The spreadlist.</param>
        private void BalanceNaturalSpreads(List<NetTrade> spreadlist)
        {
            try
            {
                if (ngNetPosition.Text == "N/A" || ngNetPosition.Text == "")
                {
                    return;
                }

                int monthIndex;
                int optionQty;

                optionQty = Convert.ToInt32(ngSpreadPosition.Text);
                monthIndex = GetMonthIndex(ngOptionSpreadComboBox.Text);
                if (monthIndex < spreadlist[0].Date.Month)
                {
                    ngFlyPosition.Text = "N/A";
                    return;
                }

                (from trade in spreadlist
                 where trade.Date.Month == monthIndex
                 select trade).ToList().ForEach(trade => trade.Net -= optionQty);
                (from trade in spreadlist
                 where trade.Date.Month == monthIndex + 1
                 select trade).ToList().ForEach(trade => trade.Net += optionQty);

                CalculateNaturalFlyCount(spreadlist);
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        #endregion

        #region BalanceBrentSpreads

        /// <summary>
        /// Balances the brent spreads.
        /// </summary>
        /// <param name="spreadlist">The spreadlist.</param>
        private void BalanceBrentSpreads(List<NetTrade> spreadlist)
        {
            try
            {
                if (bzNetPosition.Text == "N/A" || bzNetPosition.Text == "")
                {
                    return;
                }

                int monthIndex;
                int optionQty;

                optionQty = Convert.ToInt32(bzSpreadPosition.Text);
                monthIndex = GetMonthIndex(bzOptionSpreadComboBox.Text);
                if (monthIndex < spreadlist[0].Date.Month)
                {
                    bzFlyPosition.Text = "N/A";
                    return;
                }

                (from trade in spreadlist
                 where trade.Date.Month == monthIndex
                 select trade).ToList().ForEach(trade => trade.Net -= optionQty);
                (from trade in spreadlist
                 where trade.Date.Month == monthIndex + 1
                 select trade).ToList().ForEach(trade => trade.Net += optionQty);

                CalculateBrentFlyCount(spreadlist);
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        #endregion

        #endregion

        #region Calculate Fly Methods

        #region CalculateCrudeFlyCount

        /// <summary>
        /// Calculates the crude fly count.
        /// </summary>
        /// <param name="list">The list.</param>
        private void CalculateCrudeFlyCount(List<NetTrade> list)
        {
            try
            {
                List<NetTrade> flylist = new List<NetTrade>();
                int flyposition = 0;

                clFlyPosition.Clear();

                flylist.Add(list[0]);
                for (int i = 0; i < list.Count - 2; i++)
                {
                    list[i + 1].Net += 2 * list[i].Net;
                    list[i + 2].Net -= list[i].Net;
                    flylist.Add(new NetTrade(list[i + 1].Date, list[i + 1].Net));
                }

                for (int i = 0; i < flylist.Count; i++)
                {
                    flyposition += flylist[i].Net;
                }

                CrudePosition.fly = flyposition;

                if (CrudePosition.fly > 0)
                    clFlyPosition.Text = "+" + flyposition.ToString();
                else
                    clFlyPosition.Text = flyposition.ToString();
                
                PrintCrudeFly(flylist);
                CalculateCrudeDoubleFlyCount(flylist);
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        #endregion

        #region CalculateGasFlyCount

        /// <summary>
        /// Calculates the gas fly count.
        /// </summary>
        /// <param name="list">The list.</param>
        private void CalculateGasFlyCount(List<NetTrade> list)
        {
            try
            {
                List<NetTrade> flylist = new List<NetTrade>();
                int flyposition = 0;

                rbFlyPosition.Clear();

                flylist.Add(list[0]);
                for (int i = 0; i < list.Count - 2; i++)
                {
                    list[i + 1].Net += 2 * list[i].Net;
                    list[i + 2].Net -= list[i].Net;
                    flylist.Add(new NetTrade(list[i + 1].Date, list[i + 1].Net));
                }

                for (int i = 0; i < flylist.Count; i++)
                {
                    flyposition += flylist[i].Net;
                }
                PrintGasFly(flylist);
                GasPosition.fly = flyposition;
                if (GasPosition.fly > 0)
                    rbFlyPosition.Text = "+" + flyposition.ToString();
                else
                    rbFlyPosition.Text = flyposition.ToString();

            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        #endregion

        #region CalculateHeatFlyCount

        /// <summary>
        /// Calculates the heat fly count.
        /// </summary>
        /// <param name="list">The list.</param>
        private void CalculateHeatFlyCount(List<NetTrade> list)
        {
            try
            {
                List<NetTrade> flylist = new List<NetTrade>();
                int flyposition = 0;

                hoFlyPosition.Clear();

                flylist.Add(list[0]);
                for (int i = 0; i < list.Count - 2; i++)
                {
                    list[i + 1].Net += 2 * list[i].Net;
                    list[i + 2].Net -= list[i].Net;
                    flylist.Add(new NetTrade(list[i + 1].Date, list[i + 1].Net));
                }

                for (int i = 0; i < flylist.Count; i++)
                {
                    flyposition += flylist[i].Net;
                }
                PrintHeatFly(flylist);
                HeatPosition.fly = flyposition;
                if (HeatPosition.fly > 0)
                    hoFlyPosition.Text = "+" + flyposition.ToString();
                else
                    hoFlyPosition.Text = flyposition.ToString();
                hoFlyPosition.Text = flyposition.ToString();
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        #endregion

        #region CalculateNaturalFlyCount

        /// <summary>
        /// Calculates the natural fly count.
        /// </summary>
        /// <param name="list">The list.</param>
        private void CalculateNaturalFlyCount(List<NetTrade> list)
        {
            try
            {
                List<NetTrade> flylist = new List<NetTrade>();
                int flyposition = 0;

                ngFlyPosition.Clear();

                flylist.Add(list[0]);
                for (int i = 0; i < list.Count - 2; i++)
                {
                    list[i + 1].Net += 2 * list[i].Net;
                    list[i + 2].Net -= list[i].Net;
                    flylist.Add(new NetTrade(list[i + 1].Date, list[i + 1].Net));
                }

                for (int i = 0; i < flylist.Count; i++)
                {
                    flyposition += flylist[i].Net;
                }
                PrintNaturalFly(flylist);
                NaturalPosition.fly = flyposition;
                if (NaturalPosition.fly > 0)
                    ngFlyPosition.Text = "+" + flyposition.ToString();
                else
                    ngFlyPosition.Text = flyposition.ToString();
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        #endregion

        #region CalculateBrentFlyCount

        /// <summary>
        /// Calculates the brent fly count.
        /// </summary>
        /// <param name="list">The list.</param>
        private void CalculateBrentFlyCount(List<NetTrade> list)
        {
            try
            {
                List<NetTrade> flylist = new List<NetTrade>();
                int flyposition = 0;

                bzFlyPosition.Clear();

                flylist.Add(list[0]);
                for (int i = 0; i < list.Count - 2; i++)
                {
                    list[i + 1].Net += 2 * list[i].Net;
                    list[i + 2].Net -= list[i].Net;
                    flylist.Add(new NetTrade(list[i + 1].Date, list[i + 1].Net));
                }

                for (int i = 0; i < flylist.Count; i++)
                {
                    flyposition += flylist[i].Net;
                }
                PrintBrentFly(flylist);
                BrentPosition.fly = flyposition;
                if (BrentPosition.fly > 0)
                    bzFlyPosition.Text = "+" + flyposition.ToString();
                else
                    bzFlyPosition.Text = flyposition.ToString();
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        #endregion

        #endregion

        #region Calculate Double Fly

        #region CalculateCrudeDoubleFlyCount

        /// <summary>
        /// Calculates the crude double fly count.
        /// </summary>
        /// <param name="list">The list.</param>
        private void CalculateCrudeDoubleFlyCount(List<NetTrade> list)
        {
            try
            {
                List<NetTrade> doubleflylist = new List<NetTrade>();

                doubleflylist.Add(list[0]);
                for (int i = 0; i < list.Count - 3; i++)
                {
                    list[i + 1].Net += list[i].Net;
                    doubleflylist.Add(new NetTrade(list[i + 1].Date, list[i + 1].Net));
                }

                PrintCrudeDoubleFly(doubleflylist);
                CalculateCrudeTripleFlyCount(doubleflylist);
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        #endregion

        #endregion

        #region Calculate Triple Fly

        #region CalculateCrudeTripleFlyCount

        /// <summary>
        /// Calculates the crude triple fly count.
        /// </summary>
        /// <param name="list">The list.</param>
        private void CalculateCrudeTripleFlyCount(List<NetTrade> list)
        {
            try
            {
                List<NetTrade> tripleflylist = new List<NetTrade>();

                tripleflylist.Add(list[0]);
                for (int i = 0; i < list.Count - 3; i++)
                {
                    list[i + 1].Net += list[i].Net;
                    tripleflylist.Add(new NetTrade(list[i + 1].Date, list[i + 1].Net));
                }

                PrintCrudeTripleFly(tripleflylist);
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        #endregion

        #endregion


        #region FTP
        //private void LoadCsvData()
        //{
        //    // query csv from sftp
        //    string path = null;
        //    ClearAll();
        //    if (QueryFtp(out path)) ParseFtpCsv(path);
        //}
        
        //private bool QueryFtp(out string lpath)
        //{
        //    JSch jsch = new JSch();

        //    string host = "";
        //    string user = "";
        //    string rfile = DateTime.Now.ToString("yyyyMMdd") + "midaspos.txt";
        //    lpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + rfile;

        //    // Displaying a new loading form with master thread rather than spinning a new thread here
        //    loading = new Loading();
        //    loading.Show();
        //    loading.BringToFront();
        //    Application.DoEvents();
        //    // Show or load the main form.
        //    //this.ShowDialog();

        //    ciphertext = ReadRegistry();

        //    if(ciphertext)
        //        //To get access to the original data, use ProtectedData.Unprotect():
        //        byte[] plaintext= ProtectedData.Unprotect(ciphertext, entropy,
        //            DataProtectionScope.CurrentUser);

        //    else if (passwordTextBox.Text && String.IsNullOrEmpty(ciphertext))
        //        // Data to protect. Convert a string to a byte[] using Encoding.UTF8.GetBytes().
        //        byte[] plaintext = Encoding.UTF8.GetBytes(passwordTextBox.Text);

        //        // Generate additional entropy (will be used as the Initialization vector)
        //        byte[] entropy = new byte[20];
        //        using(RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
        //        {
        //            rng.GetBytes(entropy);
        //        }

        //        // Store the entropy and ciphertext securely, such as in a file or registry key 
        //        // with permissions set so only the current user can read it. 
        //        byte[] ciphertext = ProtectedData.Protect(plaintext, entropy,
        //            DataProtectionScope.CurrentUser);

        //        WriteRegistry(ciphertext);
            
        //    else  // there is no password text and nothing in registry
        //        return false;


        //    Session session = jsch.getSession(user, host, 22);
        //    session.setPassword(System.Text.ASCIIEncoding.ASCII.GetString(password));
        //    session.connect();
        //    Channel channel = session.openChannel("sftp");
        //    channel.connect();
        //    ChannelSftp c = (ChannelSftp)channel;

        //    try
        //    {
        //        c.get(rfile, lpath, null, ChannelSftp.OVERWRITE);
        //    }
        //    catch
        //    {
        //        try
        //        {
        //            rfile = DateTime.Now.AddDays(-1).ToString("yyyyMMdd") + "midaspos.txt";
        //            lpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + rfile;
        //            c.get(rfile, lpath, null, ChannelSftp.OVERWRITE);
        //        }
        //        catch
        //        {
        //            try
        //            {
        //                rfile = DateTime.Now.AddDays(-2).ToString("yyyyMMdd") + "midaspos.txt";
        //                lpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + rfile;
        //                c.get(rfile, lpath, null, ChannelSftp.OVERWRITE);
        //            }
        //            catch
        //            {
        //                try
        //                {
        //                    rfile = DateTime.Now.AddDays(-3).ToString("yyyyMMdd") + "midaspos.txt";
        //                    lpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + rfile;
        //                    c.get(rfile, lpath, null, ChannelSftp.OVERWRITE);
        //                }
        //                catch (SftpException e)
        //                {
        //                    MessageBox.Show(e.message);
        //                }
        //            }
        //        }
        //    }
           
        //    session.disconnect();
        //    loading.Hide();

        //    return true;
        //}

    //    private string ReadRegistry()
    //    {
    //        string strpath = "path_to_password";
    //        RegistryKey regKeyAppRoot = Registry.CurrentUser.CreateSubKey(strPath); 
    //        string ciphertext = (string)regKeyAppRoot.GetValue("Password"); 
    //        return ciphertext;
    //    }

    //private void WriteRegistry(ciphertext)
    //    {
    //        string strpath = "path_to_password";
    //        RegistryKey regKeyAppRoot = Registry.CurrentUser.CreateSubKey(strPath); 
    //        regKeyAppRoot.SetValue("Password", ciphertext);
    //        return;
    //    }

        //private void ParseFtpCsv(string lpath)
        //{
        //    try
        //    {
        //        using (CsvReader csv = new CsvReader(new StreamReader(lpath), false))
        //        {
        //            while (csv.ReadNextRecord())
        //            {
        //                string account = csv[3];
        //                if (account != accountComboBox.Text)
        //                    continue;
        //                Trade trade = new Trade();
        //                int net = (int)Convert.ToDecimal(csv[18]);
        //                string monthyear = string.Concat(csv[33].Split(' ')[0], csv[33].Split(' ')[1]);
        //                string contract = csv[5];
        //                DateTime date;
        //                DateTime.TryParseExact(monthyear, "MMMyy", new CultureInfo("en-US"), DateTimeStyles.None, out date);
        //                if (csv[17] == "1")
        //                {
        //                    trade = new Trade(date, net, 0);
        //                }
        //                else if (csv[17] == "2")
        //                {
        //                    trade = new Trade(date, 0, net);
        //                }
        //                else if (net == 0)
        //                {
        //                    trade = new SpreadCounter.Trade(date, 0, 0);
        //                }
        //                if (contract == "CU")
        //                    UpdateInitialCrudePosition(trade, false);
        //                else if (contract == "RB")
        //                    UpdateInitialGasPosition(trade, false);
        //                else if (contract == "HO")
        //                    UpdateInitialHeatPosition(trade, false);
        //                else if (contract == "NG")
        //                    UpdateInitialNaturalPosition(trade, false);
        //                else
        //                    continue;
        //                // gold or currencies
        //            }
        //        }
        //        File.Delete(lpath);
        //        string[] digits = Regex.Split(lpath, @"\D+");
        //        DateTime dateout;
        //        DateTime.TryParseExact(digits[1], "yyyyMMdd", new CultureInfo("en-US"), DateTimeStyles.None, out dateout);
        //        MessageBoxEx.Show("Position from close of " + dateout.DayOfWeek + ", " + dateout.ToString("MMMM") + " " + dateout.Day + " " + dateout.Year.ToString(), "Data Retrieved", 5000);
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message);
        //    }
        //}

        #endregion

        #region GetMonthIndex

        /// <summary>
        /// Gets the index of the month.
        /// </summary>
        /// <param name="monthVal">The month string.</param>
        /// <returns></returns>
        private static int GetMonthIndex(string monthVal)
        {
            switch (monthVal)
            {
                case "F":
                case "FG":
                    return 1;
                case "G":
                case "GH":
                    return 2;
                case "H":
                case "HJ":
                    return 3;
                case "J":
                case "JK":
                    return 4;
                case "K":
                case "KM":
                    return 5;
                case "M":
                case "MN":
                    return 6;
                case "N":
                case "NQ":
                    return 7;
                case "Q":
                case "QU":
                    return 8;
                case "U":
                case "UV":
                    return 9;
                case "V":
                case "VX":
                    return 10;
                case "X":
                case "XZ":
                    return 11;
                case "Z":
                case "ZF":
                    return 12;
                default:
                    return 0;
            }
        }

        #endregion

        #region Date Compare Methods

        /// <summary>
        /// Compares the date in two trades. Used to sort list of trades.
        /// </summary>
        /// <param name="o1">First Trade.</param>
        /// <param name="o2">Second Trade.</param>
        /// <returns>Returns an integer indicating whether the first trade is earlier than, the same as, or later than the second trade.</returns>
        private static int DateCompare(Trade o1, Trade o2)
        {
            return o1.Date.CompareTo(o2.Date);
        }

        /// <summary>
        /// Compares the date in two trades. Used to sort list of trades.
        /// </summary>
        /// <param name="o1">First Trade.</param>
        /// <param name="o2">Second Trade.</param>
        /// <returns>Returns an integer indicating whether the first trade is earlier than, the same as, or later than the second trade.</returns>
        private static int DateCompare(NetTrade o1, NetTrade o2)
        {
            return o1.Date.CompareTo(o2.Date);
        }

        #endregion

        #region Clear Methods

        /// <summary>
        /// Clears the crude position.
        /// </summary>
        private void ClearCrudePosition()
        {
            crudeGrid.Items.Clear();
            crudeFlyGrid.Items.Clear();
            CrudeFillList.Clear();
            CrudeCombinedFillList.Clear();
            CrudePosition.net = 0;
            CrudePosition.spread = 0;
            CrudePosition.fly = 0;
            clNetLongBox.Clear();
            clNetPosition.Clear();
            clNetShortBox.Clear();
            clSpreadPosition.Clear();
            clFlyPosition.Clear();
            clOptionNetComboBox.SelectedIndex = -1;
            clOptionSpreadComboBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Clears the gas position.
        /// </summary>
        private void ClearGasPosition()
        {
            gasGrid.Items.Clear();
            gasFlyGrid.Items.Clear();
            GasFillList.Clear();
            GasCombinedFillList.Clear();
            GasPosition.net = 0;
            GasPosition.spread = 0;
            GasPosition.fly = 0;
            rbNetLongBox.Clear();
            rbNetPosition.Clear();
            rbNetShortBox.Clear();
            rbSpreadPosition.Clear();
            rbFlyPosition.Clear();
            rbOptionNetComboBox.SelectedIndex = -1;
            rbOptionSpreadComboBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Clears the heat position.
        /// </summary>
        private void ClearHeatPosition()
        {
            heatGrid.Items.Clear();
            heatFlyGrid.Items.Clear(); 
            HeatFillList.Clear();
            HeatCombinedFillList.Clear();
            HeatPosition.net = 0;
            HeatPosition.spread = 0;
            HeatPosition.fly = 0;
            hoNetLongBox.Clear();
            hoNetPosition.Clear();
            hoNetShortBox.Clear();
            hoSpreadPosition.Clear();
            hoFlyPosition.Clear();
            hoOptionNetComboBox.SelectedIndex = -1;
            hoOptionSpreadComboBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Clears the natural position.
        /// </summary>
        private void ClearNaturalPosition()
        {
            naturalGrid.Items.Clear();
            naturalFlyGrid.Items.Clear();
            NaturalFillList.Clear();
            NaturalCombinedFillList.Clear();
            NaturalPosition.net = 0;
            NaturalPosition.spread = 0;
            NaturalPosition.fly = 0;
            ngNetLongBox.Clear();
            ngNetPosition.Clear();
            ngNetShortBox.Clear(); ;
            ngSpreadPosition.Clear();
            ngFlyPosition.Clear();
            ngOptionNetComboBox.SelectedIndex = -1;
            ngOptionSpreadComboBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Clears the brent position.
        /// </summary>
        private void ClearBrentPosition()
        {
            brentGrid.Items.Clear();
            brentFlyGrid.Items.Clear();
            BrentFillList.Clear();
            BrentCombinedFillList.Clear();
            BrentPosition.net = 0;
            BrentPosition.spread = 0;
            BrentPosition.fly = 0;
            bzNetLongBox.Clear();
            bzNetPosition.Clear();
            bzNetShortBox.Clear(); ;
            bzSpreadPosition.Clear();
            bzFlyPosition.Clear();
            bzOptionNetComboBox.SelectedIndex = -1;
            bzOptionSpreadComboBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Clears all position data.
        /// </summary>
        private void ClearAll()
        {
            ClearCrudePosition();
            ClearGasPosition();
            ClearHeatPosition();
            ClearNaturalPosition();
            ClearBrentPosition();
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Handles the SelectedIndexChanged event of the clOptionNetComboBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void clOptionNetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BalanceCrudeContracts();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the clOptionSpreadComboBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void clOptionSpreadComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BalanceCrudeContracts();
        }
        /// <summary>
        /// Handles the SelectedIndexChanged event of the rbOptionNetComboBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>

        private void rbOptionNetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BalanceGasContracts();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the rbOptionSpreadComboBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void rbOptionSpreadComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BalanceGasContracts();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the hoOptionNetComboBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void hoOptionNetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BalanceHeatContracts();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the hoOptionSpreadComboBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void hoOptionSpreadComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BalanceHeatContracts();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the ngOptionNetComboBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ngOptionNetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BalanceNaturalContracts();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the hoOptionSpreadComboBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ngOptionSpreadComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BalanceNaturalContracts();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the bzOptionNetComboBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void bzOptionNetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BalanceBrentContracts();
        }
        
        /// <summary>
        /// Handles the SelectedIndexChanged event of the hoOptionSpreadComboBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void bzOptionSpreadComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BalanceBrentContracts();
        }

        /// <summary>
        /// Handles the FormClosing event of the SpreadCounter control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.FormClosingEventArgs"/> instance containing the event data.</param>
        private void SpreadCounter_FormClosing(object sender, FormClosingEventArgs e)
        {
            ttGate.XTAPITerminate();
            Application.Exit();
        }

        /// <summary>
        /// Handles the Click event of the aboutToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright \x00a9 " + DateTime.Now.Year + " Addie A. Bendory. All rights reserved.", "Spread Counter", MessageBoxButtons.OK);
        }

        /// <summary>
        /// Handles the Click event of the CrudeClearButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void CrudeClearButton_Click(object sender, EventArgs e)
        {
            ClearCrudePosition();
        }

        /// <summary>
        /// Handles the Click event of the GasClearButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void GasClearButton_Click(object sender, EventArgs e)
        {
            ClearGasPosition();
        }

        /// <summary>
        /// Handles the Click event of the HeatClearButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void HeatClearButton_Click(object sender, EventArgs e)
        {
            ClearHeatPosition();
        }

        /// <summary>
        /// Handles the Click event of the NaturalClearButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void NaturalClearButton_Click(object sender, EventArgs e)
        {
            ClearNaturalPosition();
        }

        /// <summary>
        /// Handles the Click event of the BrentClearButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void BrentClearButton_Click(object sender, EventArgs e)
        {
            ClearBrentPosition();
        }

        /// <summary>
        /// Handles the Click event of the LoadFile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void LoadFile_Click(object sender, EventArgs e)
        {
            //LoadCsvData();
        }

        /// <summary>
        /// Handles the Load event of the SpreadCounter control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void SpreadCounter_Load(object sender, EventArgs e)
        {
            accountComboBox.Text = "PAXY81";
        }

        private void butterflyChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsButterflyShown)
            {
                butterfly = new Butterfly();
                IsButterflyShown = true;
            }
            butterfly.Show();
            butterfly.BringToFront();
        }

        private void inputTradesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsTradesShown)
            {
                inputtrades = new InputTrades(this);
                IsTradesShown = true;
            }
            inputtrades.Show();
            inputtrades.BringToFront();
        }
        
        private void SpreadCounter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                //LoadCsvData();
            }
        }
       
        private void clearAllToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ClearAll();
        }

        #endregion
    }
}

