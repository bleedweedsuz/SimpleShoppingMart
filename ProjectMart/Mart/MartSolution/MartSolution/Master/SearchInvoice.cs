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

namespace MartSolution.Master
{
    public partial class SearchInvoice : Form
    {
        string[] PurchaseArr = new string[] { "Bill No.", "Date", "Date Between", "Purchase Invoice No.", "Purchase Invoice Date" };
        string[] SalesArr = new string[] { "Bill No.","Date","Date Between"};
        string[] PurchaseColumnsHeaderString = { "SN","Purchase ID", "Bill No.", "Entry Date", "Supplier ID", "Supplier Name", "Purchase Invoice No.", "Purchase Invoice Date","Purchase Type","Transaction Mode","Remarks","Total Excluding VAT"," Discount Percentage","Discount Amount","Grand Total", "Status"};
        int[] PurchaseColumnWidth = { 60, 100, 100, 140, 100, 180, 180, 180, 180, 180, 180, 180, 180, 180, 100,100 };
        string[] SalesColumnHeaderString = new string[] { "SN","Bill No.", "Grand Total", "Status" ,"Date" };
        int[] SalesColumnWidth = { 60, 100, 100,100, 180};

        public SearchInvoice()
        {
            InitializeComponent();
        }
        private void SearchInvoice_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.Clone() as Icon;
            InvoiceType.SelectedIndex = 0;
            FilterBy.SelectedIndex = 0;
        }
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SearchInvoiceData();
        }
        private void SearchInvoiceData()
        {
            #region "Invoice Search"
            if (InvoiceType.SelectedIndex == 0)
            {
                #region "Column Maker"
                if (IGrid.Rows.Count > 1) { IGrid.Rows.Clear(); }
                IGrid.Columns.Clear();
                for (int i = 0; i < PurchaseColumnsHeaderString.Length; i++)
                {
                    String HeaderText = PurchaseColumnsHeaderString[i];
                    IGrid.Columns.Add(PurchaseColumnsHeaderString[i] + "_" + (i+1), PurchaseColumnsHeaderString[i].ToString());
                    IGrid.Columns[i].Width = PurchaseColumnWidth[i];
                    IGrid.Columns[i].ReadOnly = true;
                }
                #endregion
                #region "Bill No."
                if (FilterBy.SelectedIndex == 0)
                {
                    String query = "select Suppliers.Name as SName,Purchase.ID as PID,Purchase.Bill_no, Purchase.EntryDate, Purchase.SID, Purchase.Purchase_invoice_no,Purchase.Purchase_invoice_date,Purchase.Purchase_type,Purchase.Transaction_mode,Purchase.Remarks, Purchase.Total_exc_vat,Purchase.Discount_percentage,Purchase.Discount_amount,Purchase.Grand_total,Purchase.Status from Purchase LEFT OUTER JOIN Suppliers on Purchase.SID=Suppliers.ID where Purchase.Bill_no=?";
                    try
                    {
                        DBConnection.Open();
                        OleDbParameter[] pars = new OleDbParameter[] { new OleDbParameter() { Value = SearchText.Text.Trim() } };
                        OleDbDataReader reader = DBConnection._Read(query, pars);
                        int row = 0;
                        while (reader.Read())
                        {
                            row += 1;
                            String PurchaseInvoiceDate = ""; try { PurchaseInvoiceDate = DateTime.Parse(reader["Purchase_invoice_date"].ToString()).ToShortDateString(); }
                            catch { }
                            String StatusString = "CANCEL"; if (reader["Status"].ToString() == "1") { StatusString = "SAVED"; } else if (reader["Status"].ToString() == "2") { StatusString = "DRAFT"; }
                            IGrid.Rows.Add(row.ToString(), reader["PID"].ToString(), reader["Bill_no"].ToString(), reader["EntryDate"].ToString(), reader["SID"].ToString(), reader["SName"].ToString(), reader["Purchase_invoice_no"].ToString(), PurchaseInvoiceDate, reader["Purchase_type"].ToString(), reader["Transaction_mode"].ToString(), reader["Remarks"].ToString(), reader["Total_exc_vat"].ToString(), reader["Discount_percentage"].ToString(), reader["Discount_amount"].ToString(), reader["Grand_total"].ToString(), StatusString);
                        }
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
                #endregion
                #region "Single Date"
                else if (FilterBy.SelectedIndex == 1)
                {
                    String query = "select Suppliers.Name as SName,Purchase.ID as PID,Purchase.Bill_no, Purchase.EntryDate, Purchase.SID, Purchase.Purchase_invoice_no,Purchase.Purchase_invoice_date,Purchase.Purchase_type,Purchase.Transaction_mode,Purchase.Remarks, Purchase.Total_exc_vat,Purchase.Discount_percentage,Purchase.Discount_amount,Purchase.Grand_total,Purchase.Status from Purchase LEFT OUTER JOIN Suppliers on Purchase.SID=Suppliers.ID where Purchase.EntryDate between ? and ?";
                    String DateStr1 =  SingleDate.Value.ToShortDateString() + ResourceClass.FIRST_TIME;
                    String DateStr2 = SingleDate.Value.ToShortDateString() + ResourceClass.LAST_TIME;
                    try
                    {
                        DBConnection.Open();
                        OleDbParameter[] pars = new OleDbParameter[] { new OleDbParameter() { Value = DateStr1 }, new OleDbParameter() { Value = DateStr2 } };
                        OleDbDataReader reader = DBConnection._Read(query, pars);
                        int row = 0;
                        while (reader.Read())
                        {
                            row += 1;
                            String PurchaseInvoiceDate =""; try{ PurchaseInvoiceDate = DateTime.Parse(reader["Purchase_invoice_date"].ToString()).ToShortDateString(); } catch{}
                            String StatusString = "CANCEL";if(reader["Status"].ToString() == "1"){ StatusString ="SAVED";} else if(reader["Status"].ToString() == "2"){ StatusString ="DRAFT";}
                            IGrid.Rows.Add(row.ToString(), reader["PID"].ToString(), reader["Bill_no"].ToString(), reader["EntryDate"].ToString(), reader["SID"].ToString(), reader["SName"].ToString(), reader["Purchase_invoice_no"].ToString(), PurchaseInvoiceDate, reader["Purchase_type"].ToString(), reader["Transaction_mode"].ToString(), reader["Remarks"].ToString(), reader["Total_exc_vat"].ToString(), reader["Discount_percentage"].ToString(), reader["Discount_amount"].ToString(), reader["Grand_total"].ToString(), StatusString);
                        }
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
                #endregion
                #region "Date Between"
                else if (FilterBy.SelectedIndex == 2)
                {
                    String query = "select Suppliers.Name as SName,Purchase.ID as PID,Purchase.Bill_no, Purchase.EntryDate, Purchase.SID, Purchase.Purchase_invoice_no,Purchase.Purchase_invoice_date,Purchase.Purchase_type,Purchase.Transaction_mode,Purchase.Remarks, Purchase.Total_exc_vat,Purchase.Discount_percentage,Purchase.Discount_amount,Purchase.Grand_total,Purchase.Status from Purchase LEFT OUTER JOIN Suppliers on Purchase.SID=Suppliers.ID where (Purchase.EntryDate between ? and ?)";
                    String DateStr1 = DateBtnA.Value.ToShortDateString() + ResourceClass.FIRST_TIME;
                    String DateStr2 = DateBtnB.Value.ToShortDateString() + ResourceClass.LAST_TIME;
                    try
                    {
                        DBConnection.Open();
                        OleDbParameter[] pars = new OleDbParameter[] { new OleDbParameter() { Value = DateStr1 }, new OleDbParameter() { Value = DateStr2 } };
                        OleDbDataReader reader = DBConnection._Read(query, pars);
                        int row = 0;
                        while (reader.Read())
                        {
                            row += 1;
                            String PurchaseInvoiceDate = ""; try { PurchaseInvoiceDate = DateTime.Parse(reader["Purchase_invoice_date"].ToString()).ToShortDateString(); }
                            catch { }
                            String StatusString = "CANCEL"; if (reader["Status"].ToString() == "1") { StatusString = "SAVED"; } else if (reader["Status"].ToString() == "2") { StatusString = "DRAFT"; }
                            IGrid.Rows.Add(row.ToString(), reader["PID"].ToString(), reader["Bill_no"].ToString(), reader["EntryDate"].ToString(), reader["SID"].ToString(), reader["SName"].ToString(), reader["Purchase_invoice_no"].ToString(), PurchaseInvoiceDate, reader["Purchase_type"].ToString(), reader["Transaction_mode"].ToString(), reader["Remarks"].ToString(), reader["Total_exc_vat"].ToString(), reader["Discount_percentage"].ToString(), reader["Discount_amount"].ToString(), reader["Grand_total"].ToString(), StatusString);
                        }
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
                #endregion
                #region "Purchase Invoice No."
                else if (FilterBy.SelectedIndex == 3)
                {
                    String query = "select Suppliers.Name as SName,Purchase.ID as PID,Purchase.Bill_no, Purchase.EntryDate, Purchase.SID, Purchase.Purchase_invoice_no,Purchase.Purchase_invoice_date,Purchase.Purchase_type,Purchase.Transaction_mode,Purchase.Remarks, Purchase.Total_exc_vat,Purchase.Discount_percentage,Purchase.Discount_amount,Purchase.Grand_total,Purchase.Status from Purchase LEFT OUTER JOIN Suppliers on Purchase.SID=Suppliers.ID where Purchase.Purchase_invoice_no=?";
                    try
                    {
                        DBConnection.Open();
                        OleDbParameter[] pars = new OleDbParameter[] { new OleDbParameter() { Value = SearchText.Text.Trim() } };
                        OleDbDataReader reader = DBConnection._Read(query, pars);
                        int row = 0;
                        while (reader.Read())
                        {
                            row += 1;
                            String PurchaseInvoiceDate = ""; try { PurchaseInvoiceDate = DateTime.Parse(reader["Purchase_invoice_date"].ToString()).ToShortDateString(); }
                            catch { }
                            String StatusString = "CANCEL"; if (reader["Status"].ToString() == "1") { StatusString = "SAVED"; } else if (reader["Status"].ToString() == "2") { StatusString = "DRAFT"; }
                            IGrid.Rows.Add(row.ToString(), reader["PID"].ToString(), reader["Bill_no"].ToString(), reader["EntryDate"].ToString(), reader["SID"].ToString(), reader["SName"].ToString(), reader["Purchase_invoice_no"].ToString(), PurchaseInvoiceDate, reader["Purchase_type"].ToString(), reader["Transaction_mode"].ToString(), reader["Remarks"].ToString(), reader["Total_exc_vat"].ToString(), reader["Discount_percentage"].ToString(), reader["Discount_amount"].ToString(), reader["Grand_total"].ToString(), StatusString);
                        }
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
                #endregion
                #region "Purchase Invoice Date"
                else if (FilterBy.SelectedIndex == 4)
                {
                    String query = "select Suppliers.Name as SName,Purchase.ID as PID,Purchase.Bill_no, Purchase.EntryDate, Purchase.SID, Purchase.Purchase_invoice_no,Purchase.Purchase_invoice_date,Purchase.Purchase_type,Purchase.Transaction_mode,Purchase.Remarks, Purchase.Total_exc_vat,Purchase.Discount_percentage,Purchase.Discount_amount,Purchase.Grand_total,Purchase.Status from Purchase LEFT OUTER JOIN Suppliers on Purchase.SID=Suppliers.ID where Purchase.Purchase_invoice_date between ? and ?";
                    String DateStr1 = SingleDate.Value.ToShortDateString() + ResourceClass.FIRST_TIME;
                    String DateStr2 = SingleDate.Value.ToShortDateString() + ResourceClass.LAST_TIME;
                    try
                    {
                        DBConnection.Open();
                        OleDbParameter[] pars = new OleDbParameter[] { new OleDbParameter() { Value = DateStr1 }, new OleDbParameter() { Value = DateStr2 } };
                        OleDbDataReader reader = DBConnection._Read(query, pars);
                        int row = 0;
                        while (reader.Read())
                        {
                            row += 1;
                            String PurchaseInvoiceDate = ""; try { PurchaseInvoiceDate = DateTime.Parse(reader["Purchase_invoice_date"].ToString()).ToShortDateString(); }
                            catch { }
                            String StatusString = "CANCEL"; if (reader["Status"].ToString() == "1") { StatusString = "SAVED"; } else if (reader["Status"].ToString() == "2") { StatusString = "DRAFT"; }
                            IGrid.Rows.Add(row.ToString(), reader["PID"].ToString(), reader["Bill_no"].ToString(), reader["EntryDate"].ToString(), reader["SID"].ToString(), reader["SName"].ToString(), reader["Purchase_invoice_no"].ToString(), PurchaseInvoiceDate, reader["Purchase_type"].ToString(), reader["Transaction_mode"].ToString(), reader["Remarks"].ToString(), reader["Total_exc_vat"].ToString(), reader["Discount_percentage"].ToString(), reader["Discount_amount"].ToString(), reader["Grand_total"].ToString(), StatusString);
                        }
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
                #endregion
            }
            #endregion
            #region "Sale Search"
            else if (InvoiceType.SelectedIndex == 1)
            {
                //Sales ko sake chainna 
                HideFilterControls();
                #region "Column Maker"
                if (IGrid.Rows.Count > 1) { IGrid.Rows.Clear(); }
                IGrid.Columns.Clear();
                for (int i = 0; i < SalesColumnHeaderString.Length; i++)
                {
                    String HeaderText = SalesColumnHeaderString[i];
                    IGrid.Columns.Add(SalesColumnHeaderString[i] + "_" + (i + 1), SalesColumnHeaderString[i].ToString());
                    IGrid.Columns[i].Width = SalesColumnWidth[i];
                    IGrid.Columns[i].ReadOnly = true;
                }
                #endregion
                // "Bill No.","Date","Date Between","Status"
                #region "Bill No."
                if (FilterBy.SelectedIndex == 0)
                {
                    SearchText.Visible = true;
                    String query = "select ID, Grand_total,Date,Status from Sales where ID=?";
                    try
                    {
                        DBConnection.Open();
                        OleDbParameter[] pars = new OleDbParameter[] { new OleDbParameter() { Value = SearchText.Text.Trim() } };
                        OleDbDataReader reader = DBConnection._Read(query, pars);
                        int SN =0;
                        while (reader.Read())
                        {
                            SN++;
                            String StatusString = "";
                            if(reader["Status"].ToString().Equals("0"))
                            {
                                StatusString ="Cancel";
                            }
                            else if(reader["Status"].ToString().Equals("1"))
                            {
                                StatusString ="Sales";
                            }
                            else if(reader["Status"].ToString().Equals("2"))
                            {
                                StatusString ="Draft- Or Canceled";
                            }

                            IGrid.Rows.Add(SN.ToString(), reader["ID"].ToString(), reader["Grand_total"].ToString(), StatusString,reader["Date"].ToString());
                        }
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
                #endregion
                #region "Date [Single]"
                else if (FilterBy.SelectedIndex == 1)
                {
                    SingleDatePanel.Visible = true;
                    String query = "select Status,ID, Grand_total,Date from Sales where `Date` between ? and ?";
                    String DateStr1 = SingleDate.Value.ToShortDateString() + ResourceClass.FIRST_TIME;
                    String DateStr2 = SingleDate.Value.ToShortDateString() + ResourceClass.LAST_TIME;
                    try
                    {
                        DBConnection.Open();
                        OleDbParameter[] pars = new OleDbParameter[] { new OleDbParameter() { Value = DateStr1 }, new OleDbParameter() { Value = DateStr2 } };
                        OleDbDataReader reader = DBConnection._Read(query, pars);
                        int SN =0;
                        while (reader.Read())
                        {
                            SN++;
                            String StatusString = "";
                            if (reader["Status"].ToString().Equals("0"))
                            {
                                StatusString = "Cancel";
                            }
                            else if (reader["Status"].ToString().Equals("1"))
                            {
                                StatusString = "Sales";
                            }
                            else if (reader["Status"].ToString().Equals("2"))
                            {
                                StatusString = "Draft- Or Canceled";
                            }

                            IGrid.Rows.Add(SN.ToString(), reader["ID"].ToString(), reader["Grand_total"].ToString(), StatusString, reader["Date"].ToString());
                        }
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
                #endregion
                #region "Date Between"
                else if (FilterBy.SelectedIndex == 2)
                {
                    DateBtnPanel.Visible = true;
                    String query = "select Status, ID, Grand_total,Date from Sales where `Date` between ? and ?";
                    String DateStr1 = DateBtnA.Value.ToShortDateString() + ResourceClass.FIRST_TIME;
                    String DateStr2 = DateBtnB.Value.ToShortDateString() + ResourceClass.LAST_TIME;
                    try
                    {
                        DBConnection.Open();
                        OleDbParameter[] pars = new OleDbParameter[] { new OleDbParameter() { Value = DateStr1 }, new OleDbParameter() { Value = DateStr2 } };
                        OleDbDataReader reader = DBConnection._Read(query, pars);
                        int SN =0;
                        while (reader.Read())
                        {
                            SN++;
                            String StatusString = "";
                            if (reader["Status"].ToString().Equals("0"))
                            {
                                StatusString = "Cancel";
                            }
                            else if (reader["Status"].ToString().Equals("1"))
                            {
                                StatusString = "Sales";
                            }
                            else if (reader["Status"].ToString().Equals("2"))
                            {
                                StatusString = "Draft- Or Canceled";
                            }

                            IGrid.Rows.Add(SN.ToString(), reader["ID"].ToString(), reader["Grand_total"].ToString(), StatusString, reader["Date"].ToString());
                        }
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
                #endregion
            }
            #endregion
        }
        private void SearchText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SearchInvoiceData();
            }
        }
        private void InvoiceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InvoiceType.SelectedIndex == 0)
            {
                FilterBy.Items.Clear();
                for(int i=0;i<PurchaseArr.Length;i++){
                    FilterBy.Items.Add(PurchaseArr[i]);
                }
                FilterBy.SelectedIndex = 0;
            }
            else if (InvoiceType.SelectedIndex == 1)
            {
                FilterBy.Items.Clear();
                for (int i = 0; i < SalesArr.Length; i++)
                {
                    FilterBy.Items.Add(SalesArr[i]);
                }
                FilterBy.SelectedIndex = 0;
            }
        }
        private void FilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InvoiceType.SelectedIndex == 0)
            {
                HideFilterControls();
                //"Bill No.", "Date", "Date Between", "Purchase Invoice No.", "Purchase Invoice Date", "Purchase Type", "Transaction Mode", "Status" 
                if (FilterBy.SelectedIndex == 0)
                {
                    SearchText.Visible = true;
                }
                else if (FilterBy.SelectedIndex == 1)
                {
                    SingleDatePanel.Visible = true;
                }
                else if (FilterBy.SelectedIndex == 2)
                {
                    DateBtnPanel.Visible = true;
                }
                else if (FilterBy.SelectedIndex == 3)
                {
                    SearchText.Visible = true;
                }
                else if (FilterBy.SelectedIndex == 4)
                {
                    SingleDatePanel.Visible = true;
                }
            }
            else if (InvoiceType.SelectedIndex == 1)
            {
                //Sales ko sake chainna -------------------------------&&&&&&&&&&&&&&&*^(*&^(*&&*^*&(^&*^*(&^(&*^*&^(*&^&*(&*&**&^&*(&***************************************

                HideFilterControls();
                // "Bill No.","Date","Date Between","Status"
                if (FilterBy.SelectedIndex == 0)
                {
                    SearchText.Visible = true;
                }
                else if (FilterBy.SelectedIndex == 1)
                {
                    SingleDatePanel.Visible = true;
                }
                else if (FilterBy.SelectedIndex == 2)
                {
                    DateBtnPanel.Visible = true;
                }
                else if (FilterBy.SelectedIndex == 3)
                {
                    TSCombo.Visible = true;
                }
            }
        }
        private void HideFilterControls()
        {
            TSCombo.Visible = false;
            DateBtnPanel.Visible = false;
            SingleDatePanel.Visible = false;
            SearchText.Visible = false;
        }
        private void IGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (InvoiceType.SelectedIndex == 0)
                {
                    //Open Purchase Invoice
                    PurchaseInvoice PI = new PurchaseInvoice();
                    PI.PurchaseID = IGrid[1, e.RowIndex].Value.ToString();
                    PI.ISEDIT = true;
                    PI.MdiParent = MainForm.mainForm;
                    PI.StartPosition = FormStartPosition.CenterScreen;
                    PI.Show();
                }
                else if (InvoiceType.SelectedIndex == 1)
                {
                    //Open Bill Invoice
                    BillInvoice BInvoice = new BillInvoice();
                    BInvoice.SaleID = IGrid[1, e.RowIndex].Value.ToString();
                    BInvoice.ISEDIT = true;
                    BInvoice.MdiParent = MainForm.mainForm;
                    BInvoice.Show();
                }
            }
        }

        private void SearchInvoice_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ResourceClass.FORMMODE == 0)
            {
                ResourceClass.searchInvoice = null;
            }
        }

    }
}
