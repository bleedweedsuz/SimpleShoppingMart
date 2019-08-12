using MartSolution.DataSetCollectionArchive;
using MartSolution.Master;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MartSolution.Report
{
    public partial class AllReportForm : Form
    {
        private Boolean IsCalculated = false;
        private int TransactionModeIndex = 0;
        private String OrganizationInfoString = "";
        public enum ReportType { PURCHASE_REPORT,SALES_REPORT, INVENTORY_REPORT }
        public ReportType reportType;
        public AllReportForm()
        {
            InitializeComponent();
        }
        public void ResetProgressBar()
        {
            PBar.MarqueeAnimationSpeed = 0;
            PBar.Value = 0;
            PBar.MarqueeAnimationSpeed = 2000;
        }
        private void AllReportForm_Load(object sender, EventArgs e)
        {
            ResetProgressBar();
            SelectReport();
            SelectOrg();
        }
        private void SelectOrg()
        {
            try
            {
                DBConnection.Open();
                String query = "select Name from Organization where ID=1";
                OleDbDataReader reader = DBConnection._Read(query);
                if (reader.HasRows)
                {
                    reader.Read();
                    OrganizationInfoString = reader["Name"].ToString();
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                DBConnection.Close();
            }
        }
        private void SelectReport()
        {
            if (reportType == ReportType.SALES_REPORT)
            {
                this.Text = "Sales Report";
                SalesReportUI();
            }
            else if (reportType == ReportType.PURCHASE_REPORT)
            {
                this.Text = "Purchase Report";
                PurchaseReportUI();
            }
            else if (reportType == ReportType.INVENTORY_REPORT)
            {
                this.Text = "Inventory Report";
                InventoryReportUI();
            }
        }
        private void RunBtn_Click(object sender, EventArgs e)
        {
            if (SupplierCheck.Checked== true && SupplierID.Text.Equals(String.Empty))
            {
                MessageBox.Show("Please select supplier!!", "Error");
                return;
            }
            if (ItemCheck.Checked == true && ItemID.Text.Equals(String.Empty))
            {
                MessageBox.Show("Please select Item!!", "Error");
                return;
            }
            ResetProgressBar();
            if (!MainBackgroundWorker.IsBusy)
            {
                RunBtn.Text = "Cancel";
                RunBtn.Width = 109;
                MainBackgroundWorker.RunWorkerAsync();
            }
            else
            {
                MainBackgroundWorker.CancelAsync();
            }
        }
        private void SupplierCheck_CheckedChanged(object sender, EventArgs e)
        {
            SupplierG.Enabled = SupplierCheck.Checked;
        }
        private void TransactionCheck_CheckedChanged(object sender, EventArgs e)
        {
            TransactionG.Enabled = TransactionCheck.Checked;
        }
        private void MainBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (reportType == ReportType.SALES_REPORT)
            {
                SalesReport(e);
            }
            else if (reportType == ReportType.PURCHASE_REPORT)
            {
                PurchaseReport(e);
            }
            else if (reportType == ReportType.INVENTORY_REPORT)
            {
                InventoryReport(e);
            }
        }
        private void MainBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage <= 100)
            {
                PBar.Value = e.ProgressPercentage;
            }
        }
        private void MainBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //SHOW REPORT
            if (reportType == ReportType.SALES_REPORT)
            {
                if (!IsCalculated)
                {
                    RunBtn.Text = "Run Variables";
                    RunBtn.Width = 166;
                }
                else
                {
                    DisplaySalesReport();
                }
            }
            else if (reportType == ReportType.PURCHASE_REPORT)
            {
                if (!IsCalculated)
                {
                    RunBtn.Text = "Run Variables";
                    RunBtn.Width = 166;
                }
                else 
                {
                    DisplayPurchaseReport();                  
                }
            }
            else if (reportType == ReportType.INVENTORY_REPORT)
            {
                if (!IsCalculated)
                {
                    RunBtn.Text = "Run Variables";
                    RunBtn.Width = 166;
                }
                else
                {
                    DisplayInventoryReport();
                }
            }
        }      
        private void AllReportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MainBackgroundWorker.IsBusy)
            {
                MainBackgroundWorker.CancelAsync();            
            }
        }
        private void TransactionMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            TransactionModeIndex = TransactionMode.SelectedIndex;
        }
        private void ItemCheck_CheckedChanged(object sender, EventArgs e)
        {
            ItemG.Enabled = ItemCheck.Checked;

            if (!ItemCheck.Checked)
            {
                ItemID.Clear();
                ItemName.Clear();
            }
        }
        private void browseItem_Click(object sender, EventArgs e)
        {
            ItemInformation II = new ItemInformation();
            II.ARF = this;
            II.StartPosition = FormStartPosition.CenterScreen;
            II.ShowDialog();
        }
        private void browserSupplier_Click(object sender, EventArgs e)
        {
            SupplierInformation SI = new SupplierInformation();
            SI.ARF = this;
            SI.StartPosition = FormStartPosition.CenterScreen;
            SI.ShowDialog();
        }
        //Report Engine
        #region "Purchase Report & Object"
        private void PurchaseReportUI()
        {
            this.Height = 308;
            ItemPanel.Visible = false;
            SupplierPanel.Visible = true;
            TransactionPanel.Visible = true;
            
            TransactionMode.Items.Clear();
            TransactionMode.Items.Add("All");
            TransactionMode.Items.Add("Cash");
            TransactionMode.Items.Add("Cheque");
            TransactionMode.Items.Add("Credit");
            TransactionMode.SelectedIndex = 0;
        }
        //Variables & Object
        private DataTable PurchaseReportTable = null;
        Decimal CashPurchase = 0, CreditPurchase = 0, CheckPurchase = 0;
        private void PurchaseReport(DoWorkEventArgs e)
        {
            #region "Query Region"
            String query = "";
            #region "Supplier & Transaction"
            if (SupplierCheck.Checked && TransactionCheck.Checked)
            {
                try
                {
                    CashPurchase = 0; CreditPurchase = 0; CheckPurchase = 0;
                    DataTable dataTable = new DataSetCollection().Tables["PurchaseReport"];
                    DBConnection.Open();
                    String DateStr1 = DateA.Value.ToShortDateString() + ResourceClass.FIRST_TIME;
                    String DateStr2 = DateB.Value.ToShortDateString() + ResourceClass.LAST_TIME;
                    OleDbParameter[] pars = null;

                    if (TransactionModeIndex == 0)
                    {
                        query = "select Suppliers.Name, Purchase.ID as PID, Purchase.Bill_no, Purchase.EntryDate, Purchase_invoice_no, Purchase.Purchase_invoice_date, Purchase.Purchase_type, Purchase.Transaction_mode,Purchase.Grand_total from Purchase LEFT OUTER JOIN Suppliers on Purchase.SID=Suppliers.ID where (Purchase.EntryDate between ? and ?) and Purchase.SID=? and Purchase.Status=1 order by Purchase.ID asc";
                        pars = new OleDbParameter[] { new OleDbParameter() { Value = DateStr1 }, new OleDbParameter() { Value = DateStr2 }, new OleDbParameter() { Value = SupplierID.Text } };
                    }
                    else
                    {
                        String TransactionModeString = "";
                        if (TransactionModeIndex == 1) { TransactionModeString = "Cash"; } else if (TransactionModeIndex == 2) { TransactionModeString = "Cheque"; } else if (TransactionModeIndex == 1) { TransactionModeString = "Credit"; }


                        query = "select Suppliers.Name, Purchase.ID as PID, Purchase.Bill_no, Purchase.EntryDate, Purchase_invoice_no, Purchase.Purchase_invoice_date, Purchase.Purchase_type, Purchase.Transaction_mode,Purchase.Grand_total from Purchase LEFT OUTER JOIN Suppliers on Purchase.SID=Suppliers.ID where (Purchase.EntryDate between ? and ?) and Transaction_mode=? and Purchase.SID=? and Purchase.Status=1 order by Purchase.ID asc";
                        pars = new OleDbParameter[] { new OleDbParameter() { Value = DateStr1 }, new OleDbParameter() { Value = DateStr2 }, new OleDbParameter() { Value = TransactionModeString }, new OleDbParameter() { Value = SupplierID.Text } };
                    }
                    OleDbDataReader reader = DBConnection._Read(query, pars);
                    int incVal = 0, percentageVal = 0;
                    while (reader.Read())
                    {
                        incVal += 1;
                        percentageVal += 1;
                        if (reader["Transaction_mode"].Equals("Cash"))
                        {
                            CashPurchase += Math.Round(Convert.ToDecimal(reader["Grand_total"]), 4);
                        }
                        else if (reader["Transaction_mode"].Equals("Credit"))
                        {
                            CreditPurchase += Math.Round(Convert.ToDecimal(reader["Grand_total"]), 4);
                        }
                        else if (reader["Transaction_mode"].Equals("Cheque"))
                        {
                            CheckPurchase += Math.Round(Convert.ToDecimal(reader["Grand_total"]), 4);
                        }

                        String GTotal = reader["Grand_total"].ToString().Trim();
                        if (GTotal.Equals(String.Empty))
                        {
                            GTotal = "00.00";
                        }
                        dataTable.Rows.Add(
                            incVal.ToString(),
                            reader["PID"].ToString(),
                            reader["Name"].ToString(),
                            reader["Bill_no"].ToString(),
                            reader["EntryDate"].ToString(),
                            reader["Purchase_invoice_no"].ToString(),
                            reader["Purchase_invoice_date"].ToString(),
                            reader["Purchase_type"].ToString(),
                            reader["Transaction_mode"].ToString(),
                            GTotal
                            );
                        if (percentageVal >= 100) { percentageVal = 50; }
                        MainBackgroundWorker.ReportProgress(percentageVal);
                        if (MainBackgroundWorker.CancellationPending) { e.Cancel = true; MainBackgroundWorker.ReportProgress(100); break; }
                        System.Threading.Thread.Sleep(1);
                    }
                    IsCalculated = true;
                    PurchaseReportTable = dataTable;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    DBConnection.Close();
                }
            }
            #endregion
            #region "SUPPLIER"
            else if (SupplierCheck.Checked)
            {
                try
                {
                    CashPurchase = 0; CreditPurchase = 0; CheckPurchase = 0;
                    DataTable dataTable = new DataSetCollection().Tables["PurchaseReport"];
                    DBConnection.Open();
                    String DateStr1 = DateA.Value.ToShortDateString() + ResourceClass.FIRST_TIME;
                    String DateStr2 = DateB.Value.ToShortDateString() + ResourceClass.LAST_TIME;
                    query = "select Suppliers.Name, Purchase.ID as PID, Purchase.Bill_no, Purchase.EntryDate, Purchase_invoice_no, Purchase.Purchase_invoice_date, Purchase.Purchase_type, Purchase.Transaction_mode,Purchase.Grand_total from Purchase LEFT OUTER JOIN Suppliers on Purchase.SID=Suppliers.ID where (Purchase.EntryDate between ? and ?) and Purchase.SID=? and Purchase.Status=1 order by Purchase.ID asc";
                    OleDbParameter[] pars = new OleDbParameter[] { new OleDbParameter() { Value = DateStr1 }, new OleDbParameter() { Value = DateStr2 }, new OleDbParameter() { Value = SupplierID.Text.ToString() } };
                    OleDbDataReader reader = DBConnection._Read(query, pars);
                    int incVal = 0, percentageVal = 0;
                    while (reader.Read())
                    {
                        incVal += 1;
                        percentageVal += 1;
                        if (reader["Transaction_mode"].Equals("Cash"))
                        {
                            CashPurchase += Math.Round(Convert.ToDecimal(reader["Grand_total"]), 4);
                        }
                        else if (reader["Transaction_mode"].Equals("Credit"))
                        {
                            CreditPurchase += Math.Round(Convert.ToDecimal(reader["Grand_total"]), 4);
                        }
                        else if (reader["Transaction_mode"].Equals("Cheque"))
                        {
                            CheckPurchase += Math.Round(Convert.ToDecimal(reader["Grand_total"]), 4);
                        }

                        String GTotal = reader["Grand_total"].ToString().Trim();
                        if (GTotal.Equals(String.Empty))
                        {
                            GTotal = "00.00";
                        }
                        dataTable.Rows.Add(
                            incVal.ToString(),
                            reader["PID"].ToString(),
                            reader["Name"].ToString(),
                            reader["Bill_no"].ToString(),
                            reader["EntryDate"].ToString(),
                            reader["Purchase_invoice_no"].ToString(),
                            reader["Purchase_invoice_date"].ToString(),
                            reader["Purchase_type"].ToString(),
                            reader["Transaction_mode"].ToString(),
                            GTotal
                            );
                        if (percentageVal >= 100) { percentageVal = 50; }
                        MainBackgroundWorker.ReportProgress(percentageVal);
                        if (MainBackgroundWorker.CancellationPending) { e.Cancel = true; MainBackgroundWorker.ReportProgress(100); break; }
                        System.Threading.Thread.Sleep(1);
                    }
                    IsCalculated = true;
                    PurchaseReportTable = dataTable;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    DBConnection.Close();
                }
            }
            #endregion
            #region "TRANSACTION"
            else if (TransactionCheck.Checked)
            {
                try
                {
                    CashPurchase = 0; CreditPurchase = 0; CheckPurchase = 0;
                    DataTable dataTable = new DataSetCollection().Tables["PurchaseReport"];
                    DBConnection.Open();
                    String DateStr1 = DateA.Value.ToShortDateString() + ResourceClass.FIRST_TIME;
                    String DateStr2 = DateB.Value.ToShortDateString() + ResourceClass.LAST_TIME;
                    OleDbParameter[] pars = null;

                    if (TransactionModeIndex == 0)
                    {
                        query = "select Suppliers.Name, Purchase.ID as PID, Purchase.Bill_no, Purchase.EntryDate, Purchase_invoice_no, Purchase.Purchase_invoice_date, Purchase.Purchase_type, Purchase.Transaction_mode,Purchase.Grand_total from Purchase LEFT OUTER JOIN Suppliers on Purchase.SID=Suppliers.ID where (Purchase.EntryDate between ? and ?) and Purchase.Status=1 order by Purchase.ID asc";
                        pars = new OleDbParameter[] { new OleDbParameter() { Value = DateStr1 }, new OleDbParameter() { Value = DateStr2 } };
                    }
                    else
                    {
                        String TransactionModeString = "";
                        if (TransactionModeIndex == 1) { TransactionModeString = "Cash"; } else if (TransactionModeIndex == 2) { TransactionModeString = "Cheque"; } else if (TransactionModeIndex == 1) { TransactionModeString = "Credit"; }
                        query = "select Suppliers.Name, Purchase.ID as PID, Purchase.Bill_no, Purchase.EntryDate, Purchase_invoice_no, Purchase.Purchase_invoice_date, Purchase.Purchase_type, Purchase.Transaction_mode,Purchase.Grand_total from Purchase LEFT OUTER JOIN Suppliers on Purchase.SID=Suppliers.ID where (Purchase.EntryDate between ? and ?) and Transaction_mode=? and Purchase.Status=1 order by Purchase.ID asc";
                        pars = new OleDbParameter[] { new OleDbParameter() { Value = DateStr1 }, new OleDbParameter() { Value = DateStr2 }, new OleDbParameter() { Value = TransactionModeString } };
                    }
                    OleDbDataReader reader = DBConnection._Read(query, pars);
                    int incVal = 0, percentageVal = 0;
                    while (reader.Read())
                    {
                        incVal += 1;
                        percentageVal += 1;
                        if (reader["Transaction_mode"].Equals("Cash"))
                        {
                            CashPurchase += Math.Round(Convert.ToDecimal(reader["Grand_total"]), 4);
                        }
                        else if (reader["Transaction_mode"].Equals("Credit"))
                        {
                            CreditPurchase += Math.Round(Convert.ToDecimal(reader["Grand_total"]), 4);
                        }
                        else if (reader["Transaction_mode"].Equals("Cheque"))
                        {
                            CheckPurchase += Math.Round(Convert.ToDecimal(reader["Grand_total"]), 4);
                        }

                        String GTotal = reader["Grand_total"].ToString().Trim();
                        if (GTotal.Equals(String.Empty))
                        {
                            GTotal = "00.00";
                        }
                        dataTable.Rows.Add(
                            incVal.ToString(),
                            reader["PID"].ToString(),
                            reader["Name"].ToString(),
                            reader["Bill_no"].ToString(),
                            reader["EntryDate"].ToString(),
                            reader["Purchase_invoice_no"].ToString(),
                            reader["Purchase_invoice_date"].ToString(),
                            reader["Purchase_type"].ToString(),
                            reader["Transaction_mode"].ToString(),
                            GTotal
                            );
                        if (percentageVal >= 100) { percentageVal = 50; }
                        MainBackgroundWorker.ReportProgress(percentageVal);
                        if (MainBackgroundWorker.CancellationPending) { e.Cancel = true; MainBackgroundWorker.ReportProgress(100); break; }
                        System.Threading.Thread.Sleep(1);
                    }
                    IsCalculated = true;
                    PurchaseReportTable = dataTable;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    DBConnection.Close();
                }
            }
            #endregion
            #region "ELSE"
            else
            {
                try
                {
                    CashPurchase = 0; CreditPurchase = 0; CheckPurchase = 0;
                    DataTable dataTable = new DataSetCollection().Tables["PurchaseReport"];
                    DBConnection.Open();
                    String DateStr1 = DateA.Value.ToShortDateString() + ResourceClass.FIRST_TIME;
                    String DateStr2 = DateB.Value.ToShortDateString() + ResourceClass.LAST_TIME;
                    query = "select Suppliers.Name, Purchase.ID as PID, Purchase.Bill_no, Purchase.EntryDate, Purchase_invoice_no, Purchase.Purchase_invoice_date, Purchase.Purchase_type, Purchase.Transaction_mode,Purchase.Grand_total from Purchase LEFT OUTER JOIN Suppliers on Purchase.SID=Suppliers.ID where (Purchase.EntryDate between ? and ?) and Purchase.Status=1 order by Purchase.ID asc";
                    OleDbParameter[] pars = new OleDbParameter[] { new OleDbParameter() { Value = DateStr1 }, new OleDbParameter() { Value = DateStr2 } };
                    OleDbDataReader reader = DBConnection._Read(query, pars);
                    int incVal =0, percentageVal = 0;
                    while (reader.Read())
                    {
                        incVal += 1;
                        percentageVal += 1;
                        if (reader["Transaction_mode"].Equals("Cash"))
                        {
                            CashPurchase += Math.Round(Convert.ToDecimal(reader["Grand_total"]),4);
                        }
                        else if (reader["Transaction_mode"].Equals("Credit"))
                        {
                            CreditPurchase += Math.Round(Convert.ToDecimal(reader["Grand_total"]), 4);
                        }
                        else if (reader["Transaction_mode"].Equals("Cheque"))
                        {
                            CheckPurchase += Math.Round(Convert.ToDecimal(reader["Grand_total"]), 4);
                        }

                        String GTotal =reader["Grand_total"].ToString().Trim();
                        if(GTotal.Equals(String.Empty)){
                            GTotal = "00.00";
                        }
                        dataTable.Rows.Add(
                            incVal.ToString(),
                            reader["PID"].ToString(),
                            reader["Name"].ToString(),
                            reader["Bill_no"].ToString(),
                            reader["EntryDate"].ToString(),
                            reader["Purchase_invoice_no"].ToString(),
                            reader["Purchase_invoice_date"].ToString(),
                            reader["Purchase_type"].ToString(),
                            reader["Transaction_mode"].ToString(),
                            GTotal
                            );
                        if (percentageVal >= 100) { percentageVal = 50; }
                        MainBackgroundWorker.ReportProgress(percentageVal);
                        if (MainBackgroundWorker.CancellationPending) { e.Cancel = true; MainBackgroundWorker.ReportProgress(100); break; }
                        System.Threading.Thread.Sleep(1);
                    }
                    IsCalculated = true;
                    PurchaseReportTable = dataTable;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    DBConnection.Close();
                }
            }
            #endregion
            #endregion
        }
        private void DisplayPurchaseReport()
        {
            try
            {
                PBar.Value = 100;
                ReportDisplayForm reportForm = new ReportDisplayForm();
                ReportViewer reportViewer = reportForm.reportViewerPanel;
                reportViewer.LocalReport.ReportPath = "ReportPages/PurchaseReport.rdlc";
                DataSetCollection dataSetCollection = new DataSetCollection();

                ReportDataSource reportDataSource = new ReportDataSource("PurchaseReport", PurchaseReportTable);
                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.LocalReport.DataSources.Add(reportDataSource);
                
                List<ReportParameter> reportParameters = new List<ReportParameter>();
                reportParameters.Add(new ReportParameter("OrganizationName", OrganizationInfoString));
                reportParameters.Add(new ReportParameter("CashPurchase", CashPurchase.ToString()));
                reportParameters.Add(new ReportParameter("CreditPurchase", CreditPurchase.ToString()));
                reportParameters.Add(new ReportParameter("CheckPurchase", CheckPurchase.ToString()));
                reportParameters.Add(new ReportParameter("GrandTotalPurchase", (CashPurchase + CreditPurchase + CheckPurchase).ToString()));
                reportParameters.Add(new ReportParameter("DateBetween","Date: " + DateA.Value.ToShortDateString() + " to " + DateB.Value.ToShortDateString() ));

                String FilterByStr ="Filter By.";
                if (SupplierCheck.Checked){FilterByStr += " Supplier [ " + SupplierName.Text + " ]";}
                if (SupplierCheck.Checked && TransactionCheck.Checked) { FilterByStr += " & "; }
                if (TransactionCheck.Checked) { FilterByStr += " Transaction Mode [ " + TransactionMode.Text + " ]"; }
                if (!SupplierCheck.Checked && !TransactionCheck.Checked) { FilterByStr = ""; }

                reportParameters.Add(new ReportParameter("FilterBy", FilterByStr));

                reportViewer.LocalReport.SubreportProcessing += LocalReportPurchaseSub_SubreportProcessing;

                reportViewer.LocalReport.SetParameters(reportParameters);
                reportViewer.RefreshReport();

                System.Drawing.Printing.PageSettings pSetting = new System.Drawing.Printing.PageSettings();
                pSetting.Margins.Top = 0;
                pSetting.Margins.Bottom = 0;
                pSetting.Margins.Left = 0;
                pSetting.Margins.Right = 0;
                reportViewer.SetPageSettings(pSetting);

                if (ShowPrintLayout.Checked)
                {
                    reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
                    reportForm.WindowState = FormWindowState.Maximized;
                }
                reportForm.MdiParent = MainForm.mainForm;
                reportForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        void LocalReportPurchaseSub_SubreportProcessing(object sender, SubreportProcessingEventArgs e)
        {
            int PID = int.Parse(e.Parameters["PID"].Values[0].ToString());
            DataTable dt =  GetPurchaseDataTable(PID);
            ReportDataSource ds = new ReportDataSource("PurchaseData", dt);
            e.DataSources.Add(ds);
        }
        private DataTable GetPurchaseDataTable(int PID)
        {
            DataTable dt = new DataSetCollection().Tables["PurchaseData"];
            try
            {
                DBConnection.Open();
                String query = @"SELECT Items.Name as IName, Inventory.Gross_amount, Inventory.Discount_amount, Inventory.Discount_percentage, Inventory.Rate, Inventory.Net_amount, Inventory.Quantity, Inventory.SPID, Items.Name FROM (Inventory LEFT OUTER JOIN Items ON Inventory.IID = Items.ID) WHERE (Inventory.SPID = ? and Inventory.Status=?)";
                OleDbParameter[] pars = new OleDbParameter[] { new OleDbParameter() { Value = PID }, new OleDbParameter() { Value = UtilityClass.getInventoryStatusCode("Purchase")} };
                OleDbDataReader reader = DBConnection._Read(query, pars);
                int row= 0;
                while (reader.Read())
                {
                    row++;

                    dt.Rows.Add(
                        row.ToString(),
                        //reader["IName"].ToString(),
                        reader["IName"].ToString(),
                        reader["Quantity"].ToString(),
                        "Rs. " + reader["Rate"].ToString() + " /-",
                        Math.Round(Convert.ToDecimal(reader["Discount_percentage"].ToString()),2),
                        "Rs. " + Math.Round(Convert.ToDecimal(reader["Discount_amount"].ToString()),2) + " /-",
                        "Rs. " + reader["Gross_amount"].ToString() + " /-", 
                        "Rs. " + reader["Net_amount"].ToString() + " /-"
                        );
                }

                if (row <= 0)
                {
                    dt.Rows.Add("----", "----", "----", "----", "----", "----", "----", "----");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                DBConnection.Close();
            }
            return dt;
        }
        #endregion
        #region "Sales Report & Object"
        private DataTable SalesReportTable = null;
        private void SalesReportUI()
        {
            this.Height = 235;
            ItemPanel.Visible = false;
            SupplierPanel.Visible = false;
            TransactionPanel.Visible = true;
            TransactionMode.Items.Clear();
            TransactionMode.Items.Add("Cash");
            TransactionMode.Items.Add("Credit");
            TransactionMode.SelectedIndex = 0;
        }
        private void SalesReport(DoWorkEventArgs e)
        {
            String query = "";
            try
            {
                DataTable dataTable = new DataSetCollection().Tables["SalesReport"];
                DBConnection.Open();
                String DateStr1 = DateA.Value.ToShortDateString() + ResourceClass.FIRST_TIME;
                String DateStr2 = DateB.Value.ToShortDateString() + ResourceClass.LAST_TIME;
                if (TransactionCheck.Checked)
                {
                    if (TransactionModeIndex == 0) //Cash
                    {
                        query = "select Sales.ID, Sales.Date,Sales.Transaction_mode,Sales.Discount_amount,Sales.Gross_amount,Sales.Grand_total from Sales where (Sales.Date between ? and ?) and Status=1 and Sales.Transaction_mode='Cash' order by Sales.ID asc";
                    }
                    else//credit
                    {
                        query = "select Sales.ID, Sales.Date,Sales.Transaction_mode,Sales.Discount_amount,Sales.Gross_amount,Sales.Grand_total from Sales where (Sales.Date between ? and ?) and Status=1 and Sales.Transaction_mode='Credit' order by Sales.ID asc";
                    }
                }
                else
                {
                    query = "select Sales.ID, Sales.Date,Sales.Transaction_mode,Sales.Discount_amount,Sales.Gross_amount,Sales.Grand_total from Sales where (Sales.Date between ? and ?) and Status=1 order by Sales.ID asc";
                }
                OleDbParameter[] pars = new OleDbParameter[] { new OleDbParameter() { Value = DateStr1 }, new OleDbParameter() { Value = DateStr2 } };
                OleDbDataReader reader = DBConnection._Read(query, pars);
                int incVal = 0, percentageVal = 0;
                while (reader.Read())
                {
                    incVal += 1;
                    percentageVal += 1;

                    dataTable.Rows.Add(incVal, reader["ID"].ToString(), reader["Date"].ToString(), reader["Transaction_mode"].ToString(), reader["Gross_amount"].ToString(), reader["Discount_amount"].ToString(), reader["Grand_total"].ToString());
                    
                    if (percentageVal >= 100) { percentageVal = 50; }
                    MainBackgroundWorker.ReportProgress(percentageVal);
                    if (MainBackgroundWorker.CancellationPending) { e.Cancel = true; MainBackgroundWorker.ReportProgress(100); break; }
                    System.Threading.Thread.Sleep(1);
                }
                IsCalculated = true;
                SalesReportTable = dataTable;
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            finally
            {
                DBConnection.Close();
            }
        }
        private void DisplaySalesReport()
        {
            try
            {
                PBar.Value = 100;
                ReportDisplayForm reportForm = new ReportDisplayForm();
                ReportViewer reportViewer = reportForm.reportViewerPanel;
                reportViewer.LocalReport.ReportPath = "ReportPages/SalesReport.rdlc";
                DataSetCollection dataSetCollection = new DataSetCollection();

                ReportDataSource reportDataSource = new ReportDataSource("SalesReport", SalesReportTable);
                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.LocalReport.DataSources.Add(reportDataSource);
                
                List<ReportParameter> reportParameters = new List<ReportParameter>();
                reportParameters.Add(new ReportParameter("OrganizationName", OrganizationInfoString));
                reportParameters.Add(new ReportParameter("DateBetween","Date: " + DateA.Value.ToShortDateString() + " to " + DateB.Value.ToShortDateString() ));

                String FilterByStr = "";
                if (ItemCheck.Checked) { FilterByStr = "Filter By. Item Name [ " + ItemName.Text + " ]"; }
                reportParameters.Add(new ReportParameter("FilterBy", FilterByStr));

                reportViewer.LocalReport.SubreportProcessing += LocalReportSalesreport_SubreportProcessing;

                reportViewer.LocalReport.SetParameters(reportParameters);
                reportViewer.RefreshReport();

                System.Drawing.Printing.PageSettings pSetting = new System.Drawing.Printing.PageSettings();
                pSetting.Margins.Top = 0;
                pSetting.Margins.Bottom = 0;
                pSetting.Margins.Left = 0;
                pSetting.Margins.Right = 0;
                reportViewer.SetPageSettings(pSetting);

                if (ShowPrintLayout.Checked)
                {
                    reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
                    reportForm.WindowState = FormWindowState.Maximized;
                }
                reportForm.MdiParent = MainForm.mainForm;
                reportForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        void LocalReportSalesreport_SubreportProcessing(object sender, SubreportProcessingEventArgs e)
        {
            int SID = int.Parse(e.Parameters["SID"].Values[0].ToString());
            DataTable dt = GetSalesDataTable(SID);
            ReportDataSource ds = new ReportDataSource("SalesData", dt);
            e.DataSources.Add(ds);
        }
        private DataTable GetSalesDataTable(int SID)
        {
            DataTable dt = new DataSetCollection().Tables["SalesData"];
            try
            {
                DBConnection.Open();
                String query = @"SELECT Items.Name as IName, Inventory.Rate, Inventory.Quantity, Inventory.Gross_amount FROM (Inventory LEFT OUTER JOIN Items ON Inventory.IID = Items.ID) WHERE (Inventory.SPID = ? and Inventory.Status=?)";
                OleDbParameter[] pars = new OleDbParameter[] { new OleDbParameter() { Value = SID }, new OleDbParameter() { Value = UtilityClass.getInventoryStatusCode("Sales") } };
                OleDbDataReader reader = DBConnection._Read(query, pars);
                int row = 0;
                while (reader.Read())
                {
                    row++;
                    dt.Rows.Add(row.ToString(), reader["IName"].ToString(), reader["Quantity"].ToString(), reader["Rate"].ToString(), reader["Gross_amount"].ToString());
                }
                if (row <= 0)
                {
                    dt.Rows.Add("----", "----", "----", "----", "----");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                DBConnection.Close();
            }
            return dt;
        }
        #endregion
        #region "Inventory Section"
        //Variables & Object
        private DataTable InventoryItemDataReportDatatable = null;
        private String SelectedItemID = "";
        private void InventoryReportUI()
        {
            this.Height = 250;
            ItemPanel.Visible = true;
            SupplierPanel.Visible = false;
            TransactionPanel.Visible = false;
        }
        private void InventoryReport(DoWorkEventArgs e)
        {
            try
            {
                SelectedItemID = ItemID.Text.Trim();
                DataTable dataTable = new DataSetCollection().Tables["InventoryItemDataReport"];
                String DateStr1 = DateA.Value.ToShortDateString() + ResourceClass.FIRST_TIME;
                String DateStr2 = DateB.Value.ToShortDateString() + ResourceClass.LAST_TIME;
                
                DBConnection.Open();
                String query = "select FORMAT(ClosingTable.Date,'mm/dd/yyyy') as CDate from ClosingTable where (ClosingTable.Date between ? and ?) group by ClosingTable.Date";
                OleDbParameter[] pars = new OleDbParameter[] { new OleDbParameter() { Value = DateStr1 }, new OleDbParameter() { Value = DateStr2 } };
                OleDbDataReader reader = DBConnection._Read(query, pars);
                int row = 0, percentageVal=0;
                while (reader.Read())
                {
                    row++;
                    percentageVal++;

                    dataTable.Rows.Add(row.ToString(), reader["CDate"]);

                    if (percentageVal >= 100) { percentageVal = 50; }
                    MainBackgroundWorker.ReportProgress(percentageVal);
                    if (MainBackgroundWorker.CancellationPending) { e.Cancel = true; MainBackgroundWorker.ReportProgress(100); break; }
                    System.Threading.Thread.Sleep(1);
                }
                IsCalculated = true;
                InventoryItemDataReportDatatable = dataTable;
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
            finally
            {
                DBConnection.Close();
            }
        }
        private void DisplayInventoryReport()
        {
            try
            {
                String I = ItemID.Text.Trim();

                PBar.Value = 100;
                ReportDisplayForm reportForm = new ReportDisplayForm();
                ReportViewer reportViewer = reportForm.reportViewerPanel;
                reportViewer.LocalReport.ReportPath = "ReportPages/InventoryReport.rdlc";
                DataSetCollection dataSetCollection = new DataSetCollection();

                ReportDataSource reportDataSource = new ReportDataSource("InventoryItemDataReport", InventoryItemDataReportDatatable);
                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.LocalReport.DataSources.Add(reportDataSource);

                List<ReportParameter> reportParameters = new List<ReportParameter>();
                reportParameters.Add(new ReportParameter("OrganizationName", OrganizationInfoString));
                reportParameters.Add(new ReportParameter("DateBetween", "Date: " + DateA.Value.ToShortDateString() + " to " + DateB.Value.ToShortDateString()));

                String FilterByStr = "";
                if (ItemCheck.Checked) { FilterByStr = "Filter By. Item Name [ " + ItemName.Text + " ]"; }
                reportParameters.Add(new ReportParameter("FilterBy", FilterByStr));

                reportViewer.LocalReport.SubreportProcessing += LocalReportInventoryReport_SubreportProcessing;

                reportViewer.LocalReport.SetParameters(reportParameters);
                reportViewer.RefreshReport();

                System.Drawing.Printing.PageSettings pSetting = new System.Drawing.Printing.PageSettings();
                pSetting.Margins.Top = 0;
                pSetting.Margins.Bottom = 0;
                pSetting.Margins.Left = 0;
                pSetting.Margins.Right = 0;
                reportViewer.SetPageSettings(pSetting);

                if (ShowPrintLayout.Checked)
                {
                    reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
                    reportForm.WindowState = FormWindowState.Maximized;
                }
                reportForm.MdiParent = MainForm.mainForm;
                reportForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        private void LocalReportInventoryReport_SubreportProcessing(object sender, SubreportProcessingEventArgs e)
        {
            String CDate = e.Parameters["DatePar"].Values[0].ToString();
            DataTable dt = GetInventoryDataTable(CDate, SelectedItemID);
            ReportDataSource ds = new ReportDataSource("InventoryDataReport", dt);
            e.DataSources.Add(ds);
        }
        private DataTable GetInventoryDataTable(string CDate, string _IID)
        {
            DataTable dt = new DataSetCollection().Tables["InventoryDataReport"];
            String Query = String.Empty;
            try
            {
                String DateStr1 = CDate + ResourceClass.FIRST_TIME;
                String DateStr2 = CDate + ResourceClass.LAST_TIME;
                DBConnection.Open();
                #region "List"
                //selecting items from item lists
                if (ItemCheck.Checked)
                {
                    Query = "select ID,Name from Items where Status =1 and ID="+_IID+" order by Name asc";
                }
                else
                {
                    Query = "select ID,Name from Items where Status =1 order by Name asc";
                }
                OleDbDataReader reader = DBConnection._Read(Query);
                int SN = 0;
                while (reader.Read())
                {
                    SN++;
                    //Quantity
                    Decimal OpeningStock = 0, Damage = 0, Expired = 0, InitialStock = 0, Lost = 0, Purchase = 0, Sales = 0, SalesReturn = 0, TotalQTY = 0;
                    //Amount
                    Decimal PurchaseAmount = 0, SalesAmount = 0;
                    String ID = reader["ID"].ToString(), IName = reader["Name"].ToString();
                    {//Opening Stocks
                        String Query2 = "select Quantity from ClosingTable where IID=@ID and SN=(select MAX(SN) from ClosingTable where IID=@ID and ClosingTable.Date < ?)";
                        OleDbParameter[] pars2 = new OleDbParameter[] { new OleDbParameter() { Value = ID }, new OleDbParameter() { Value = DateStr1 } };
                        //OleDbParameter[] pars2 = new OleDbParameter[] { new OleDbParameter() { Value = DateStr1 }, new OleDbParameter() { Value = DateStr2 }, new OleDbParameter() { Value = ID } };
                        OleDbDataReader reader2 = DBConnection._Read(Query2, pars2);
                        if (reader2.HasRows)
                        {
                            reader2.Read();
                            OpeningStock = Convert.ToDecimal(reader2["Quantity"]);
                            reader2.Close();
                        }
                    }
                    {//Inventory Stocks
                        String Query2 = "select * from Inventory where Inventory.IID=? and (Inventory.Date between ? and ?)";
                        OleDbParameter[] pars2 = new OleDbParameter[] { new OleDbParameter() { Value = ID }, new OleDbParameter() { Value = DateStr1 }, new OleDbParameter() { Value = DateStr2 } };
                        OleDbDataReader reader2 = DBConnection._Read(Query2, pars2);
                        while (reader2.Read())
                        {
                            int StatusCode = Convert.ToInt16(reader2["Status"].ToString());
                            decimal QTY = Convert.ToDecimal(reader2["Quantity"].ToString());
                            #region "MATHs"
                            if (StatusCode == 1)
                            {
                                //"Damage";
                                Damage += QTY;
                            }
                            else if (StatusCode == 2)
                            {
                                //"Expired";
                                Expired += QTY;
                            }
                            else if (StatusCode == 3)
                            {
                                //"Initial Stock";
                                InitialStock += QTY;
                            }
                            else if (StatusCode == 4)
                            {
                                //"Lost";
                                Lost += QTY;
                            }
                            else if (StatusCode == 5)
                            {
                                //"Purchase";
                                Purchase += QTY;
                                PurchaseAmount += Convert.ToDecimal(reader2["Net_amount"].ToString());
                            }
                            else if (StatusCode == 6)
                            {
                                //"Sales";
                                Sales += QTY;
                                SalesAmount += Convert.ToDecimal(reader2["Gross_amount"].ToString());
                            }
                            else if (StatusCode == 7)
                            {
                                //"Sales Return";
                                SalesReturn += QTY;
                            }
                            #endregion
                        }
                    }
                    TotalQTY = (OpeningStock + Damage + Expired + InitialStock + Purchase + SalesReturn) - (Lost + Sales);
                    dt.Rows.Add(SN.ToString(), IName, OpeningStock.ToString(), Purchase.ToString(), Damage.ToString(), Expired.ToString(), SalesReturn.ToString(), Lost.ToString(), Sales.ToString(), TotalQTY.ToString());
                }
                #endregion
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                DBConnection.Close();
            }
            return dt;
        }
        #endregion
    }
}
