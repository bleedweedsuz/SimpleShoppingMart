using E2NEngineFactory;
using MartSolution.DataSetCollectionArchive;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MartSolution.Master
{
    public partial class BillInvoice : Form
    {
        public enum InputCodeMode { BARCODE, ITEMCODE, ITEMNAME}
        private InputCodeMode iCode = InputCodeMode.BARCODE;
        public Boolean ISEDIT = false;
        public String SaleID = String.Empty;
        public Boolean BillFinish = false;
        public bool formTerminate = false;
        AutoCompleteStringCollection ItemNameCollection;
        public BillInvoice()
        {
            InitializeComponent();
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            ClearField();
        }
        private void PrintPreview_Click(object sender, EventArgs e)
        {
            PrintDoc(false);
        }
        private void Save_Click(object sender, EventArgs e)
        {
            SaveData();
        }
        private void DisPercentage_CheckedChanged(object sender, EventArgs e)
        {
            ToggleDisCheckBox();
        }
        private void DisAmount_CheckedChanged(object sender, EventArgs e)
        {
            ToggleDisCheckBox();
        }
        private void ToggleDisCheckBox()
        {
            if (DisAmount.Checked)
            {
                DisAmountVal.Enabled = true;
                DisPercentageVal.Enabled = false;
            }
            else
            {
                DisAmountVal.Enabled = false;
                DisPercentageVal.Enabled = true;
            }
        }
        private void BillInvoice_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.Clone() as Icon;
            if (ISEDIT)
            {
                //EDIT MODE
                Save.Enabled = false;
                Clear.Enabled = false;
                AutoTransaction.Visible = false;
                TransactionMode.Enabled = false;
                _InputCode.Enabled = false;
                Remarks.ReadOnly = true;
                TenderAmount.ReadOnly = true;
                ReturnAmount.ReadOnly = true;
                DisAmountVal.Enabled = false;
                DisPercentageVal.Enabled = false;
                DisPercentage.Enabled = false;
                DisAmount.Enabled = false;

                SelectInvoiceUsingID();
            }
            else
            {
                //New Invoice
                InitNewInvoice();//Insert Token in bill invoice
                TransactionMode.SelectedIndex = 0;
                SampleDate.Text = EntryDate.Value.ToShortDateString();
                ListAutoLoadData();
                LoadSettingsData();
            }
        }
        private void InitNewInvoice()
        {
            String TOKEN = UtilityClass.GetNewToken();
            String CurrDate = EntryDate.Value.ToShortDateString() + " " + EntryDate.Value.ToShortTimeString();
            try
            {
                DBConnection.Open();
                //Insert token in sales
                {
                    String query = "insert into Sales (`Token`,`Date`,`Status`) values (?,?,2)";
                    OleDbParameter[] pars = new OleDbParameter[] { 
                        new OleDbParameter() { Value = TOKEN },
                        new OleDbParameter() { Value =  CurrDate} 
                    };
                    DBConnection._Write(query, pars);
                }
                //Select SalesID using token
                {
                    String query = "select ID from Sales where Token=?";
                    OleDbParameter[] pars = new OleDbParameter[] { new OleDbParameter() { Value = TOKEN }};
                    OleDbDataReader reader = DBConnection._Read(query, pars);
                    if (reader.HasRows)
                    {
                        reader.Read();
                        SaleID = reader["ID"].ToString();
                        reader.Close();
                    }
                }
                BillNo.Text = SaleID;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DBConnection.Close();
            }
            _InputCode.Select();
            _InputCode.Focus();
        }
        private void SelectInvoiceUsingID()
        {
            try
            {
                BGrid.Rows.Clear();
                DBConnection.Open();
                {
                    //Select data from sales
                    String query = "select * from Sales where ID=?";
                    OleDbParameter[] pars = new OleDbParameter[] { 
                        new OleDbParameter() { Value = SaleID }
                    };
                    OleDbDataReader reader = DBConnection._Read(query, pars);
                    if (reader.HasRows)
                    {
                        reader.Read();
                        BillNo.Text = reader["ID"].ToString();
                        //EntryDate.Value = 
                        GrossTotal.Text = reader["Gross_amount"].ToString();
                        DisPercentageVal.Value = Convert.ToDecimal(reader["Discount_percentage"]);
                        DisAmountVal.Value = Convert.ToDecimal(reader["Discount_amount"]);
                        GrandTotal.Text = reader["Grand_total"].ToString();
                        TenderAmount.Text = reader["Tender_amount"].ToString();
                        ReturnAmount.Text = reader["Return_amount"].ToString();
                        TransactionMode.Text = reader["Transaction_mode"].ToString();
                        Remarks.Text = reader["Remarks"].ToString();
                        try{EntryDate.Value = DateTime.Parse(reader["Date"].ToString());}catch { }
                        reader.Close();
                    }
                }
                {
                    //Select data from Inventory 
                    String query = "select Inventory.Quantity,Inventory.Rate,Inventory.Gross_amount,Items.Unit,Items.Name as IName from Inventory LEFT OUTER JOIN Items on Inventory.IID=Items.ID where Inventory.SPID=? and Inventory.Status=?";
                    OleDbParameter[] pars = new OleDbParameter[] { 
                        new OleDbParameter() { Value = SaleID },
                        new OleDbParameter() { Value = UtilityClass.getInventoryStatusCode("Sales") }
                    };
                    OleDbDataReader reader = DBConnection._Read(query, pars);
                    int row = 0;
                    while (reader.Read())
                    {
                        row++;
                        BGrid.Rows.Add(MartSolution.Properties.Resources.delete_2, row.ToString(), " ",reader["IName"].ToString(), reader["Unit"].ToString(), reader["Quantity"].ToString(), reader["Rate"].ToString(), reader["Gross_amount"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DBConnection.Close();
            }
        }
        private void SelectItemFromCode(String CODE)
        {
            bool exceedFiveThousand = false;
            try
            {
                bool isItemExists = false;
                String IName = "", Unit = "", IID = "", Des = "";
                Decimal Rate = 0;
                DBConnection.Open();
                {
                    {
                        String query = String.Empty;
                        if (iCode == InputCodeMode.BARCODE)
                        {
                            if (iCode.ToString().Length >= ResourceClass.TotalBarCodeMin)
                            {
                                query = "select Items.Default_quantity, Items.ID as ItemID,Items.Unit,Items.Name as IName,Items.Description from Items where Items.BarCode=? and Items.Status=1";
                            }
                            else
                            {
                                throw new Exception("Barcode less then Min Barcode");
                            }
                        }
                        else if (iCode == InputCodeMode.ITEMCODE)
                        {
                            query = "select Items.Default_quantity, Items.ID as ItemID,Items.Unit,Items.Name as IName,Items.Description from Items where Items.Code=? and Items.Status=1";
                        }
                        else if (iCode == InputCodeMode.ITEMNAME)
                        {
                            query = "select Items.Default_quantity, Items.ID as ItemID,Items.Unit,Items.Name as IName,Items.Description from Items where Items.Name=? and Items.Status=1";
                        }
                        OleDbParameter[] pars = new OleDbParameter[] { new OleDbParameter() { Value = CODE } };
                        OleDbDataReader reader = DBConnection._Read(query, pars);
                        if (reader.HasRows)
                        {
                            reader.Read();
                            IName = reader["IName"].ToString();
                            Unit = reader["Unit"].ToString();
                            IID = reader["ItemID"].ToString();
                            Des = reader["Description"].ToString();
                            Decimal Q = 1;
                            try { Q = Convert.ToDecimal(reader["Default_quantity"].ToString()); } catch (Exception EXC) { Console.WriteLine(EXC.ToString()); }

                            if (Q != QuantityData.Value)
                            {
                                Q = QuantityData.Value;
                            }
                            reader.Close();
                            isItemExists = true;
                        }
                    }
                    //Select New Rates
                    {
                        String query = "select Unit_price from ItemsDetail where IID=? and ID=(select MAX(ID) from ItemsDetail where IID=?)";
                        OleDbParameter[] pars = new OleDbParameter[] { new OleDbParameter() { Value = IID }, new OleDbParameter() { Value = IID } };
                        OleDbDataReader reader = DBConnection._Read(query, pars);
                        if (reader.HasRows)
                        {
                            reader.Read();
                            Rate = Convert.ToDecimal(reader["Unit_price"].ToString());
                            reader.Close();
                        }
                    }
                }
                if (isItemExists)
                {
                    decimal GTotalWithNewAmount = 0;
                    GTotalWithNewAmount = Convert.ToDecimal(GrossTotal.Text);
                    GTotalWithNewAmount += Rate;
                    if (GTotalWithNewAmount <= ResourceClass.AVIAmountMAX)
                    {
                        LoadItems(IID, IName, Unit, Rate);
                        _InputCode.Clear();
                        QuantityData.Value = 1;
                        _InputCode.Focus();
                    }
                    else
                    {
                        exceedFiveThousand = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DBConnection.Close();
            }

            if (exceedFiveThousand)
            {
                MessageBox.Show("Total Item cost is more than 5000/- please make new invoice.", "Wait", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                _InputCode.Clear();
            }
        }
        private void LoadItems(String IID, String IName, String Unit, Decimal Rate)
        {
            Decimal currentBasketQty = 0;
            Decimal GrossAmount = 0;
            Decimal Q = QuantityData.Value;
            bool isItemExists = false;
            
            for (int i = 0; i < BGrid.Rows.Count; i++)
            {
                String ItemID = BGrid[2,i].Value.ToString();
                if (ItemID == IID) //ID match
                {
                    Decimal basketQty = Convert.ToDecimal(BGrid[4, i].Value.ToString());
                    currentBasketQty = Q + basketQty;
                    GrossAmount = currentBasketQty * Rate;
                    BGrid[4, i].Value = currentBasketQty.ToString(); //set quantity
                    BGrid[6, i].Value = Rate.ToString(); //set Rate
                    BGrid[7, i].Value = GrossAmount.ToString(); //set Gross Amount
                    isItemExists = true;
                }
            }
            if (!isItemExists)
            {
                currentBasketQty = Q;
                GrossAmount = Q * Rate;
                BGrid.Rows.Add(MartSolution.Properties.Resources.delete_2, (BGrid.Rows.Count + 1 ).ToString(), IID, IName, currentBasketQty, Unit,Rate.ToString(), GrossAmount.ToString());
            }

            ReCalcDataAll();
        }
        private void ReCalcDataAll()
        {
            ReCalculateItemsLists();
            RecalculateDiscount();
            ReCalculateTenderAmount();
        }
        private void Bar_ItemCode_TextChanged(object sender, EventArgs e)
        {
            if (_InputCode.Text.Trim() == "") { return; }
            if (_AutoAdd.Checked){
                SelectItemFromCode(_InputCode.Text.Trim());
            }
        }
        private void Bar_ItemCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (_InputCode.Text.Trim() == "") { return; }

                String CODE = _InputCode.Text.Trim();
                SelectItemFromCode(CODE);
            }
        }
        private void QuantityData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (_InputCode.Text.Trim() == "") { _InputCode.Focus(); return; }

                String CODE = _InputCode.Text.Trim();
                SelectItemFromCode(CODE);
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Alt | Keys.I) || keyData == (Keys.F4))
            {
                _InputCode.Focus();
                return true;
            }
            else if (keyData == (Keys.Alt | Keys.T))
            {
                TenderAmount.Focus();
                return true;
            }
            else if (keyData == (Keys.Alt | Keys.D1))
            {
                S_ItemBarCode.Checked = true;
                _InputCode.Focus();

                return true;
            }
            else if (keyData == (Keys.Alt | Keys.D2))
            {
                S_ItemCode.Checked = true;
                _InputCode.Focus();
                return true;
            }
            else if (keyData == (Keys.Alt | Keys.D3))
            {
                S_ItemName.Checked = true;
                _InputCode.Focus();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void ReCalculateItemsLists()
        {
            Decimal GTotal = 0;
            for (int i = 0; i < BGrid.Rows.Count; i++)
            {
                GTotal += Convert.ToDecimal(BGrid[7, i].Value.ToString());
            }
            GrossTotal.Text = GTotal.ToString();
        }
        private void RecalculateDiscount()
        {
            try
            {
                //Recalculate discount
                decimal GA = 0;
                decimal DA = 0;
                decimal DP = 0;
                decimal GT = 0;
                GA = Convert.ToDecimal(GrossTotal.Text);

                DisAmountVal.Maximum = GA;

                if (DisPercentage.Checked)
                {
                    DP = DisPercentageVal.Value;
                    if (DP > 0)
                    {
                        DA = (GA * (DP / 100));
                    }

                    DisAmountVal.Value = DA;
                }
                else
                {
                    DA = DisAmountVal.Value;
                    if (DA > 0 && GA > 0)
                    {
                        DP = ((DA / GA) * 100);
                    }
                    DisPercentageVal.Value = DP;
                }

                GT = Math.Round((GA - DA), 4);

                GrandTotal.Text = GT.ToString();

            }
            catch (Exception ex)
            {
                //-------->
                Console.WriteLine(ex.Message);
            }
        }
        private void ReCalculateTenderAmount()
        {
            if (!TenderAmount.Text.Trim().Equals(String.Empty) && !GrandTotal.Text.Trim().Equals(String.Empty))
            {
                decimal TAmount = Convert.ToDecimal(TenderAmount.Text.Trim());
                decimal NAmount = Convert.ToDecimal(GrandTotal.Text);
                decimal RAmount = Math.Round(TAmount - NAmount, 4);

                if (RAmount >= 0)
                {
                    ReturnAmount.Text = RAmount.ToString();
                    ReturnAmount.BackColor = Color.WhiteSmoke;
                    Save.Enabled = true;
                }
                else
                {
                    ReturnAmount.BackColor = Color.Tomato;
                    Save.Enabled = false;
                }
            }
        }
        private void BGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!ISEDIT)
            {
                if (e.RowIndex >= 0)
                {
                    if (e.ColumnIndex == 0)
                    {
                        int QTY = Convert.ToInt16(BGrid[4, e.RowIndex].Value.ToString());

                        if (RemoveAll.Checked)
                        {
                            BGrid.Rows.RemoveAt(e.RowIndex);
                        }
                        else
                        {
                            if (QTY > 1)
                            {
                                QTY--;
                                BGrid[4, e.RowIndex].Value = QTY.ToString();
                                Decimal Rate = Convert.ToDecimal(BGrid[6, e.RowIndex].Value);

                                BGrid[7, e.RowIndex].Value = Rate * QTY;
                            }
                            else
                            {
                                BGrid.Rows.RemoveAt(e.RowIndex);
                            }
                        }
                        ReCalcDataAll();
                    }
                }
            }
        }
        private void DisPercentageVal_ValueChanged(object sender, EventArgs e)
        {
            RecalculateDiscount();
        }
        private void DisAmountVal_ValueChanged(object sender, EventArgs e)
        {
            RecalculateDiscount();
        }
        private void TenderAmount_TextChanged(object sender, EventArgs e)
        {
            ReCalculateTenderAmount();
        }
        private void ClearField()
        {
            _InputCode.Clear();
            BGrid.Rows.Clear();
            TenderAmount.Text = "0.00";
            GrossTotal.Text = "0.00";
            DisAmountVal.Value = 0;
            DisPercentageVal.Value = 0;
            ReturnAmount.BackColor = Color.WhiteSmoke;
            ReturnAmount.Text = "0.00";
            GrandTotal.Text = "0.00";
            Save.Enabled = false;
            TransactionMode.SelectedIndex = 0;
            Remarks.Clear();
            BGrid.Rows.Clear();
        }
        private void SaveData()
        {
            Decimal GTotalValue;
            if (Decimal.TryParse(GrandTotal.Text.Trim(), out GTotalValue))
            {
                if (GTotalValue >= ResourceClass.AVIAmountMAX)
                {
                    MessageBox.Show("Grand Total is more than " + ResourceClass.AVIAmountMAX + " Please Make Another Bill.\nNote* Re-add items to another bill", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                return;
            }
            bool ISFinish = false;
            try
            {
                String EDate = EntryDate.Value.ToShortDateString() + " " + EntryDate.Value.ToShortTimeString();
                DBConnection.Open();
                { //Update Bill info
                    String query = "update Sales set `EID`=?, `Gross_amount`=?,Discount_percentage=?,Discount_amount=?, Grand_total=?,Tender_amount=?,Return_amount=?,Transaction_mode=?,Remarks=?,`Date`=?,Status=1 where ID=?";
                    OleDbParameter[] pars = new OleDbParameter[] { 
                        new OleDbParameter() { Value = MainForm.USERID },
                        new OleDbParameter() { Value = GrossTotal.Text.Trim() }, 
                        new OleDbParameter() { Value = DisPercentageVal.Value }, 
                        new OleDbParameter() { Value = DisAmountVal.Value },
                        new OleDbParameter() { Value = GrandTotal.Text.Trim()},
                        new OleDbParameter() { Value = TenderAmount.Text.Trim()},
                        new OleDbParameter() { Value = ReturnAmount.Text.Trim()},
                        new OleDbParameter() { Value = TransactionMode.Text.Trim()},
                        new OleDbParameter() { Value = Remarks.Text.Trim()},
                        new OleDbParameter() { Value = EDate},
                        new OleDbParameter() { Value = SaleID}
                    };
                    DBConnection._Write(query, pars);
                }
                { //update inventory details
                    for (int i = 0; i < BGrid.Rows.Count; i++)
                    {
                        String IID, R, GA;

                        IID = BGrid[2,i].Value.ToString();
                        R = BGrid[6,i].Value.ToString();
                        GA = BGrid[7,i].Value.ToString();

                        String query = "insert into inventory (IID,SPID,EID,Quantity,Status,`Date`,Rate,Gross_amount) values (?,?,?,?,?,?,?,?)";
                        OleDbParameter[] pars = new OleDbParameter[] { 
                            new OleDbParameter() { Value =  IID},
                            new OleDbParameter() { Value = SaleID }, 
                            new OleDbParameter() { Value = MainForm.USERID}, 
                            new OleDbParameter() { Value = BGrid[4,i].Value.ToString() },
                            new OleDbParameter() { Value = UtilityClass.getInventoryStatusCode("Sales")},
                            new OleDbParameter() { Value = EDate},
                            new OleDbParameter() { Value = R},
                            new OleDbParameter() { Value = GA}
                        };
                        DBConnection._Write(query, pars);
                    }
                }

                ISFinish = true;
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            finally
            {
                DBConnection.Close();
            }
            if (ISFinish)
            {
                BillMessageTimer.Start();
                BillSavedMessage.Visible = true;
                if (AutoPrintInvoice.Checked) 
                {
                    PrintDoc(true);
                }
                //Clear field
                BillFinish = true;
                ClearField();
                if (!AutoTransaction.Checked)
                {
                    WarnMessage();
                }
                else
                {
                    BillFinish = false;
                    InitNewInvoice();
                }
            }
        }
        private void WarnMessage()
        {
            if (MessageBox.Show("Data is saved! Want To Continue with another Bill Invoice? Click Yes to Continue OR No For Close Bill Transaction", "Wait", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                BillFinish = false;
                InitNewInvoice();
            }
            else
            {
                formTerminate = true;
                this.Close();
            }
        }
        private void BillInvoice_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ISEDIT)
            {
                if (!formTerminate)
                {
                    if (MessageBox.Show("Want to close this invoice? \n [note* this will automatically canceled]", "Wait", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        formTerminate = true;
                        this.Close();
                    }
                    else
                    {
                        formTerminate = false;
                        e.Cancel = true;
                    }
                }
            }
        }
        private void TenderAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (Save.Enabled)
                {
                    SaveData();
                }
            }
        }
        private void PrintDoc(bool isPrint)
        {
            try
            {
                String ORGNAME ="", ADDRESS="", PAN="", PHONE="", GTotal ="";
                #region "ORG INFO"
                {
                    try
                    {
                        DBConnection.Open();
                        string query = "select * from Organization where ID=1";
                        OleDbDataReader reader = DBConnection._Read(query);
                        if (reader.HasRows)
                        {
                            reader.Read();
                            ORGNAME = reader["Name"].ToString();
                            ADDRESS = reader["Address"].ToString();
                            PAN = reader["PhoneNo"].ToString();
                            PHONE = reader["Pan_no"].ToString();
                            reader.Close();
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
                try
                {
                    GTotal = new E2NEngine().InWords(GrandTotal.Text);
                }
                catch (Exception Ex)
                {
                    Console.WriteLine(Ex.Message);
                }

                ReportDisplayForm reportForm = new ReportDisplayForm();
                ReportViewer reportViewer = reportForm.reportViewerPanel;
                reportViewer.LocalReport.ReportPath = "ReportPages/BillInvoice.rdlc";
                DataSetCollection dataSetCollection = new DataSetCollection();
                DataTable dataTable = dataSetCollection.Tables["BillInvoice"];

                for (int i = 0; i < BGrid.Rows.Count; i++)
                {
                    dataTable.Rows.Add(
                        (i+1).ToString(), 
                        BGrid[3,i].Value.ToString(),
                        BGrid[4,i].Value.ToString(),
                        BGrid[5,i].Value.ToString(),
                        BGrid[6,i].Value.ToString(),
                        BGrid[7,i].Value.ToString()
                        );
                }

                ReportDataSource reportDataSource = new ReportDataSource("BillInvoice", dataTable);
                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.LocalReport.DataSources.Add(reportDataSource);

                List<ReportParameter> reportParameters = new List<ReportParameter>();
                reportParameters.Add(new ReportParameter("InvoiceNo", BillNo.Text.Trim()));
                reportParameters.Add(new ReportParameter("OrganizationName", ORGNAME));
                reportParameters.Add(new ReportParameter("Address",ADDRESS));
                reportParameters.Add(new ReportParameter("PAN",PAN));
                reportParameters.Add(new ReportParameter("Phone",PHONE));
                reportParameters.Add(new ReportParameter("Date", EntryDate.Value.ToShortDateString() + " " + EntryDate.Value.ToShortTimeString()));
                reportParameters.Add(new ReportParameter("Mode", TransactionMode.Text));
                reportParameters.Add(new ReportParameter("User", MainForm.mainForm.EmployeeName));
                reportParameters.Add(new ReportParameter("LongMoneyString", GTotal));
                reportParameters.Add(new ReportParameter("GrossTotal", GrossTotal.Text));

                if (DisPercentage.Checked)
                {
                    reportParameters.Add(new ReportParameter("Discount","Discount  (%) :" + DisPercentageVal.Value.ToString()));
                }
                else
                {
                    reportParameters.Add(new ReportParameter("Discount","Discount  (Rs.) : " + DisAmountVal.Value.ToString()));
                }
                reportParameters.Add(new ReportParameter("GrandTotal", GrandTotal.Text));
                reportParameters.Add(new ReportParameter("Tender", TenderAmount.Text));
                reportParameters.Add(new ReportParameter("Return", ReturnAmount.Text));

                reportViewer.LocalReport.SetParameters(reportParameters);
                reportViewer.RefreshReport();

                System.Drawing.Printing.PageSettings pSetting = new System.Drawing.Printing.PageSettings();
                pSetting.Margins.Top = 0;
                pSetting.Margins.Bottom = 0;
                pSetting.Margins.Left = 0;
                pSetting.Margins.Right = 0;
                reportViewer.SetPageSettings(pSetting);
                reportViewer.RefreshReport();

                DocAutoPrint DAP = null;

                if (AutoPrintInvoice.Checked && isPrint)
                {
                    DAP = new DocAutoPrint();
                    DAP.ADJUSTRECTWIDTH = ResourceClass.ReceiptWidth;
                    DAP.Run(reportViewer.LocalReport);
                }
               
                if (ShowPrintPreview.Checked)
                {
                    if (R_Wlayout.Checked)
                    {
                        reportViewer.ZoomMode = ZoomMode.PageWidth;
                    }
                    else if (R_NLayout.Checked)
                    {
                        reportViewer.SetDisplayMode(DisplayMode.Normal);
                    }
                    else if (R_PrintLayout.Checked)
                    {
                        reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
                    }

                    reportForm.Text = "Bill Invoice [ " + BillNo.Text + " ]";
                    reportForm.StartPosition = FormStartPosition.CenterScreen;
                    reportForm.MdiParent = MainForm.mainForm;
                    reportForm.Show();
                }
                if (DAP != null)
                {
                    DAP.Dispose();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        private void GrandTotal_TextChanged(object sender, EventArgs e)
        {
            ReCalculateTenderAmount();
        }
        #region "CELL EDIT"
        int CellEditRow = -1;
        private void BGrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            CellEditRow = e.RowIndex;
        }
        private void BGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CellEditRow = -1;
        }
        private void BGrid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                var txtBox = e.Control as TextBox;
                if (txtBox != null && txtBox is TextBox)
                {
                    txtBox.TextChanged -= txtBox_TextChanged;
                    txtBox.TextChanged += txtBox_TextChanged;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void txtBox_TextChanged(object sender, EventArgs e)
        {
            if (CellEditRow > -1)
            {
                if (BGrid.CurrentCell.ColumnIndex == 4)
                {
                    TextBox t = (TextBox)sender;
                    //Convert this data and recalculate whole thing
                    Decimal QTY;
                    Decimal RATE = Convert.ToDecimal(BGrid[6,CellEditRow].Value); //RATE
                    if (Decimal.TryParse(t.Text.ToString().Trim(), out QTY))
                    {
                        BGrid[7, CellEditRow].Value = QTY * RATE;

                        ReCalcDataAll();
                    }
                }
            }
        }
        #endregion
        private void ShowPrintPreview_CheckedChanged(object sender, EventArgs e)
        {
            PrintPreviewPanel.Enabled = ShowPrintPreview.Checked;
        }
        private void BillInvoice_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ResourceClass.FORMMODE == 0)
            {
                ResourceClass.billInvoice = null;
            }
        }
        private void S_BarCode_CheckedChanged(object sender, EventArgs e)
        {
            _AutoAdd.Visible = true;
            _AutoAdd.Checked = true;
            _AutoAdd.BackColor = Color.Bisque;
            _InputCode.BackColor = Color.Bisque;
            S_ItemBarCode.BackColor = Color.Bisque;
            S_ItemCode.BackColor = Color.White;
            S_ItemName.BackColor = Color.White;
            InputCodeDisplaySelected.Text = "Item Barcode";
            ReloadItemNameAutoComplete.Enabled = false;
            ReloadItemNameAutoComplete.Visible = false;
            iCode = InputCodeMode.BARCODE;
            ClearAutoLoaddata();
        }
        private void S_ItemCode_CheckedChanged(object sender, EventArgs e)
        {
            _AutoAdd.Visible = true;
            _AutoAdd.Checked = false;
            _AutoAdd.BackColor = Color.Aquamarine;
            _InputCode.BackColor = Color.Aquamarine;
            S_ItemBarCode.BackColor = Color.White;
            S_ItemCode.BackColor = Color.Aquamarine;
            S_ItemName.BackColor = Color.White;
            InputCodeDisplaySelected.Text = "Item Code";
            ReloadItemNameAutoComplete.Enabled = false;
            ReloadItemNameAutoComplete.Visible = false;
            iCode = InputCodeMode.ITEMCODE;
            ClearAutoLoaddata();
        }
        private void S_ItemName_CheckedChanged(object sender, EventArgs e)
        {
            _AutoAdd.Visible = false;
            _AutoAdd.Checked = false;
            _AutoAdd.BackColor = Color.LightPink;
            _InputCode.BackColor = Color.LightPink;
            S_ItemBarCode.BackColor = Color.White;
            S_ItemCode.BackColor = Color.White;
            S_ItemName.BackColor = Color.LightPink;
            InputCodeDisplaySelected.Text = "Item Name";
            ReloadItemNameAutoComplete.Enabled = true;
            ReloadItemNameAutoComplete.Visible = true;
            iCode = InputCodeMode.ITEMNAME;
            SetAutoLoadData();
        }
        private void ListAutoLoadData()
        {
            ItemNameCollection = new AutoCompleteStringCollection();
            try
            {
                DBConnection.Open();
                String query = "select Name from Items where Status=1 order by Name asc";
                OleDbDataReader reader = DBConnection._Read(query);
                while (reader.Read())
                {
                    ItemNameCollection.Add(reader[0].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DBConnection.Close();
            }
        }
        private void SetAutoLoadData()
        {
            _InputCode.AutoCompleteMode = AutoCompleteMode.Suggest;
            _InputCode.AutoCompleteSource = AutoCompleteSource.CustomSource;
            _InputCode.AutoCompleteCustomSource = ItemNameCollection;
        }
        private void ClearAutoLoaddata()
        {
            _InputCode.AutoCompleteMode = AutoCompleteMode.None;
            _InputCode.AutoCompleteSource = AutoCompleteSource.None;
        }
        private void ReloadItemNameAutoComplete_Click(object sender, EventArgs e)
        {
            ListAutoLoadData();
            SetAutoLoadData();
        }
        private void LoadSettingsData()
        {
            ShowPrintPreview.Checked = ResourceClass.ShowReceiptPreviewAfterSave;
            AutoPrintInvoice.Checked = ResourceClass.AutoPrintInvoice;
            AutoTransaction.Checked = ResourceClass.AutoNewTransaction;

            S_ItemBarCode.Text += "[ > " + ResourceClass.TotalBarCodeMin + " ]";

        }
        private void BillMessageTimer_Tick(object sender, EventArgs e)
        {
             BillSavedMessage.Visible = false;
             BillMessageTimer.Stop();
        }
    }
}
