using MartSolution.DataSetCollectionArchive;
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

namespace MartSolution.Master
{
    public partial class PurchaseInvoice : Form
    {
        public enum InputCodeMode { BARCODE, ITEMCODE, ITEMNAME }
        private InputCodeMode iCode = InputCodeMode.BARCODE;
        public bool ISEDIT =false;
        public bool ISENDTRANSACTION = false;
        public String PurchaseID = "";
        AutoCompleteStringCollection ItemNameCollection;
        public PurchaseInvoice()
        {
            InitializeComponent();
        }
        private void AddItem_Click(object sender, EventArgs e)
        {
            AddItemIntoPGrid();
        }
        private void Bar_ItemCode_TextChanged(object sender, EventArgs e)
        {
            if (_InputCode.Text.Trim() == "") { return; }
            if (_AutoFind.Checked)
            {
                SelectItemFromCode(_InputCode.Text.Trim());
            }
        }
        private void PGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 0)
                {
                    PGrid.Rows.RemoveAt(e.RowIndex);
                    ResetSN();
                }
                else
                {
                    AddItem.Text = "Update";
                    AddItem.Image = MartSolution.Properties.Resources.update;
                    B_IID.Text = PGrid[3, e.RowIndex].Value.ToString();
                    _InputCode.Text = PGrid[2, e.RowIndex].Value.ToString();
                    Quantity.Value = Convert.ToDecimal(PGrid[6, e.RowIndex].Value);
                    PurchaseRate.Value = Convert.ToDecimal(PGrid[7, e.RowIndex].Value);
                    if (DisPercentage.Checked)
                    {
                        DisPercentageVal.Value = Convert.ToDecimal(PGrid[9, e.RowIndex].Value);
                    }
                    else
                    {
                        DisAmountVal.Value = Convert.ToDecimal(PGrid[10, e.RowIndex].Value);
                    }
                    Quantity.Focus();
                }
            }
        }
        private void Save_Click(object sender, EventArgs e)
        {
            SaveInvoice();
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            ResetAllField();
        }
        private void Delete_Click(object sender, EventArgs e)
        {

        }
        private void DisPercentage_CheckedChanged(object sender, EventArgs e)
        {
            DDChange();
        }
        private void DisAmount_CheckedChanged(object sender, EventArgs e)
        {
            DDChange();
        }
        private void DisAfterPercentage_CheckedChanged(object sender, EventArgs e)
        {
            DDAChange();
        }
        private void DisAfterAmount_CheckedChanged(object sender, EventArgs e)
        {
            DDAChange();
        }
        private void DDChange()
        {
            if (DisPercentage.Checked)
            {
                DisPercentageVal.Enabled = true;
                DisAmountVal.Enabled = false;
            }
            else if (DisAmount.Checked)
            {
                DisPercentageVal.Enabled = false;
                DisAmountVal.Enabled = true;
            }
        }
        private void DDAChange()
        {
            if (DisAfterPercentage.Checked)
            {
                DisAfterPercentageVal.Enabled = true;
                DisAfterAmountVal.Enabled = false;
            }
            else if (DisAfterAmount.Checked)
            {
                DisAfterPercentageVal.Enabled = false;
                DisAfterAmountVal.Enabled = true;
            }
        }
        private void CalculateItemData()
        {
            //Init
            decimal Q = Quantity.Value;
            decimal PR = PurchaseRate.Value;
            decimal GA = 0;
            decimal DA = 0;
            decimal NA = 0;
            decimal DP = 0;

            //GA Calculate
            GA = Q * PR;

            if (DisPercentage.Checked) 
            {
                DP = DisPercentageVal.Value;
                if (DP > 0)
                {
                    DA = (GA * (DP / 100));
                }
            }
            else
            {
                DA = DisAmountVal.Value;
                if (DA > 0 && GA >0)
                {
                   DP = ((DA / GA) * 100);
                }
            }
            
            //Calculate
            NA = GA - DA;
            //Display
            GrossAmount.Text = GA.ToString();
            NetAmount.Text = NA.ToString();
            if (DisPercentage.Checked)
            {
                DisAmountVal.Text = DA.ToString();
            }
            else
            {
                DisPercentageVal.Text = DP.ToString();
            }

        } 
        private void PurchaseInvoice_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.Clone() as Icon;
            if (!ISEDIT)
            {
                PurchaseType.SelectedIndex = 0;
                TransactionMode.SelectedIndex = 0;
                PCheck();
                SetSupplierInfoToAutoComplete();
                TokenGenerator.Start();
                ListAutoLoadData();
            }
            else
            {
                EmployeeName.Visible = true;
                EntryDate.Enabled = false;
                SupplierRefresh.Enabled = false;
                SupplierName.ReadOnly = true;
                PurchaseInvoiceNo.ReadOnly = true;
                PurchaseInvoiceDate.Enabled = false;
                InvoiceStatusPanel.Visible = true;
                PGrid.ReadOnly = true;
                ItemInPanel.Enabled = false;
                Save.Enabled = false;
                Clear.Enabled = false;
                PrintPreview.Visible = true;
                LoadPurchaseDataFromID();
                S_ItemBarCode.Text += "[ > " + ResourceClass.TotalBarCodeMin + " ]";
            }
        }
        private void Quantity_ValueChanged(object sender, EventArgs e)
        {
            CalculateItemData();
        }
        private void PurchaseRate_ValueChanged(object sender, EventArgs e)
        {
            CalculateItemData();
        }
        private void DisPercentageVal_ValueChanged(object sender, EventArgs e)
        {
             CalculateItemData();
        }
        private void DisAmountVal_ValueChanged(object sender, EventArgs e)
        {
            CalculateItemData();
        }
        private void PurchaseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            VatInc.Text = "( "+ PurchaseType.Text + " )";
            if (PurchaseType.SelectedIndex == 0)
            {
                VatIncVal.Enabled = true;
            }
            else if (PurchaseType.SelectedIndex == 1)
            {
                VatIncVal.Enabled = false;
                VatIncVal.Text = "";
            }
            DisAfterCalculate();
        }
        private void Reset_Click(object sender, EventArgs e)
        {
            _InputCode.Clear();
            ResetItemField();
        }
        private void SupplierName_TextChanged(object sender, EventArgs e)
        {
            if (SupplierName.Text.Trim().Equals(String.Empty)) { SupplierID.Clear(); SupplierID.BackColor = Color.FromArgb(255, 224, 224, 224); }
        }
        private void Supplier_Click(object sender, EventArgs e)
        {
            SupplierInformation SI = new SupplierInformation();
            SI.StartPosition = FormStartPosition.CenterScreen;
            SI.ShowDialog();
        }
        private void SupplierRefresh_Click(object sender, EventArgs e)
        {
            SetSupplierInfoToAutoComplete();
        }
        private void SupplierName_KeyUp(object sender, KeyEventArgs e)
        {
            GetSupplierAndSetID(SupplierName.Text.Trim());
        }
        private void PGrid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (!ISEDIT)
            {
                ReCalculatePGridData();
            }
        }
        private void PGrid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (!ISEDIT)
            {
                ReCalculatePGridData();
            }
        }
        private void DisAfterPercentageVal_ValueChanged(object sender, EventArgs e)
        {
            DisAfterCalculate();
        }
        private void DisAfterAmountVal_ValueChanged(object sender, EventArgs e)
        {
            DisAfterCalculate();
        }
        private void TokenGenerator_Tick(object sender, EventArgs e)
        {
            TokenGenerator.Stop();
            SetTokenGenerator();
        }
        private void PurchaseInvoice_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ISENDTRANSACTION)
            {
                if (!ISEDIT)
                {

                    if (MessageBox.Show("Are you sure want to cancel this invoice?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        //do nothing
                        try
                        {
                            DBConnection.Open();
                            //Get Set bill no
                            String query = "update `Purchase` set Status=0 where ID=?";
                            OleDbParameter[] pars = new OleDbParameter[] { new OleDbParameter() { Value = PurchaseID } };
                            DBConnection._Write(query, pars);
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
                    else
                    {
                        e.Cancel = true;
                    }
                }
            }
        }
        private void TotalExeVal_TextChanged(object sender, EventArgs e)
        {
            DisAfterCalculate();
        }
        private void Timer__Tick(object sender, EventArgs e)
        {
            if (S_ItemBarCode.Checked)
            {
                _InputCode.BackColor = S_ItemBarCode.BackColor;
            }
            else if (S_ItemCode.Checked)
            {
                _InputCode.BackColor = S_ItemCode.BackColor;
            }
            else if (S_ItemName.Checked)
            {
                _InputCode.BackColor = S_ItemName.BackColor;
            }
            StatusPanel.Visible = false;
            Timer_.Stop();
        }
        private void SelectItemFromCode(String CODE)
        {
            try
            {
                DBConnection.Open();
                String query = String.Empty;
                if (iCode == InputCodeMode.BARCODE)
                {
                    if (iCode.ToString().Length >= ResourceClass.TotalBarCodeMin)
                    {
                        query = "select ID,Name,Unit,Description from Items where BarCode=? and Items.Status=1";
                    }
                    else
                    {
                        throw new Exception("Barcode less then Min Barcode");
                    }
                }
                else if (iCode == InputCodeMode.ITEMCODE)
                {
                    query = "select ID,Name,Unit,Description from Items where Code=? and Items.Status=1";
                }
                else if (iCode == InputCodeMode.ITEMNAME)
                {
                    query = "select ID,Name,Unit,Description from Items where Name=? and Items.Status=1";
                }
                OleDbParameter[] pars = new OleDbParameter[] { new OleDbParameter() { Value = CODE } };
                OleDbDataReader reader = DBConnection._Read(query, pars);
                if (reader.HasRows)
                {
                    reader.Read();
                    ItemID.Text = reader["ID"].ToString();
                    ItemName.Text = reader["Name"].ToString();
                    Unit.Text = reader["Unit"].ToString();
                    Description.Text = reader["Description"].ToString();
                    ItemCalculatePanel.Enabled = true;
                    reader.Close();
                }
                else
                {
                    ResetItemField();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                DBConnection.Close();
            }
        }
        private void AddItemIntoPGrid()
        {
            if (!B_IID.Text.Trim().Equals(""))
            {
                //Edit Part
                bool isExists = false;
                int cIndex = -1;
                for (int i = 0; i < PGrid.Rows.Count; i++)
                {
                    if (ItemID.Text == PGrid[3, i].Value.ToString())
                    {
                        isExists = true;
                        cIndex = i;
                        break;
                    }
                }
                if (isExists)
                {
                    //Update Columns selected data
                    PGrid[6, cIndex].Value = Quantity.Value.ToString();
                    PGrid[7, cIndex].Value = PurchaseRate.Value.ToString();
                    PGrid[8, cIndex].Value = GrossAmount.Text.ToString();
                    PGrid[9, cIndex].Value = DisPercentageVal.Value.ToString();
                    PGrid[10, cIndex].Value = DisAmountVal.Value.ToString();
                    PGrid[11, cIndex].Value = NetAmount.Text.ToString();
                }
            }
            else
            {
                //Insert Part
                bool isExists = false;
                int cIndex = -1;
                for (int i = 0; i < PGrid.Rows.Count; i++)
                {
                    if (ItemID.Text == PGrid[3, i].Value.ToString())
                    {
                        isExists = true;
                        cIndex = i;
                        break;
                    }
                }
                if (isExists)
                {
                    _InputCode.BackColor = Color.Tomato;
                    StatusPanel.Visible = true;
                    Timer_.Start();
                    statusRep.Text = "Item already in list.\nYou can either edit or delete It";
                    PGrid.Rows[cIndex].Selected = true;
                    _InputCode.Focus();
                    return;
                }
                else
                {

                    //Add Items
                    PGrid.Rows.Add(MartSolution.Properties.Resources.delete_2, "", _InputCode.Text.Trim(), ItemID.Text, ItemName.Text, Unit.Text, Quantity.Value.ToString(), PurchaseRate.Value.ToString(), GrossAmount.Text, DisPercentageVal.Value.ToString(), DisAmountVal.Value.ToString(), NetAmount.Text);
                }
            }
            Reset_Click(null, null);
            _InputCode.Focus();
            ResetSN();
            ReCalculatePGridData();
        }
        private void ResetSN()
        {
            for (int i = 0; i < PGrid.Rows.Count; i++)
            {
                PGrid[1, i].Value = (i + 1).ToString();
            }
        }
        private void ResetItemField()
        {
            ItemID.Clear();
            ItemName.Clear();
            Unit.Clear();
            Description.Clear();
            Quantity.Value = 0;
            PurchaseRate.Value = 0;
            ItemCalculatePanel.Enabled = false;
            DisPercentageVal.Value = 0;
            DisAmountVal.Value = 0;
            B_IID.Clear();
            AddItem.Text = "Add";
            AddItem.Image = MartSolution.Properties.Resources.add_2;

            if (S_ItemBarCode.Checked)
            {
                _InputCode.BackColor = S_ItemBarCode.BackColor;
            }
            else if (S_ItemCode.Checked)
            {
                _InputCode.BackColor = S_ItemCode.BackColor;
            }
            else if (S_ItemName.Checked)
            {
                _InputCode.BackColor = S_ItemName.BackColor;
            }
        }
        private void ResetAllField()
        {
            SupplierID.Clear();
            SupplierName.Clear();
            PurchaseInvoiceNo.Clear();
            PurchaseType.SelectedIndex = 0;
            TransactionMode.SelectedIndex = 0;
            Remarks.Clear();
            PGrid.Rows.Clear();
            _InputCode.Clear();
            ResetItemField();
            TotalExcVal.Text = "0.00";
            DisAfterAmountVal.Value = 0;
            DisAfterPercentageVal.Value = 0;
            VatIncVal.Text = "0.00";
            GrandTotal.Text = "0.00";
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Alt | Keys.I) || keyData == (Keys.F4))
            {
                _InputCode.Focus();
                return true;
            }
            else if (keyData == (Keys.Alt | Keys.S))
            {
                SupplierName.Focus();
                return true;
            }
            else if (keyData == (Keys.Alt | Keys.P))
            {
                PurchaseInvoiceNo.Focus();
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
        private void PCheck()
        {
            String suffix = "MSI";
            if (ResourceClass.CurrentPSuffixString.Contains(suffix))
            {
                Supplier.Enabled = true;
            }
        }
        private void SetSupplierInfoToAutoComplete()
        {
            SupplierName.AutoCompleteMode = AutoCompleteMode.Suggest;
            SupplierName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection dataCollection = new AutoCompleteStringCollection();
            try
            {
                DBConnection.Open();
                String query = "select Name from Suppliers order by ID asc;";
                OleDbDataReader reader = DBConnection._Read(query);
                while (reader.Read())
                {
                    dataCollection.Add(reader["Name"].ToString());
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
            SupplierName.AutoCompleteCustomSource = dataCollection;
        }
        private void GetSupplierAndSetID(String needle)
        {
            String SID = "";
            try
            {
                if (needle.Equals(String.Empty))
                {
                    return;
                }

                DBConnection.Open();
                String query = "select ID from Suppliers where Name=?";
                OleDbParameter[] pars = new OleDbParameter[] { 
                        new OleDbParameter() { Value = needle },
                    };
                OleDbDataReader reader = DBConnection._Read(query,pars);
                if (reader.HasRows)
                {
                    reader.Read();
                    SID = reader["ID"].ToString();
                    reader.Close();
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
            SupplierID.Text = SID;
            if (!SID.Equals(String.Empty))
            {
                SupplierID.BackColor = Color.FromArgb(255, 192, 255, 192);
            }
            else
            {
                SupplierID.BackColor = Color.FromArgb(255, 224, 224, 224);
            }
        }
        private void ReCalculatePGridData()
        {
            decimal Total = 0;
            for (int i = 0; i < PGrid.Rows.Count; i++)
            {
                Total += Convert.ToDecimal(PGrid[11, i].Value);
            }
            TotalExcVal.Text = Total.ToString();
        }
        private void DisAfterCalculate()
        {
            try
            {
                decimal TEV = Convert.ToDecimal(TotalExcVal.Text);
                decimal DA = 0;
                decimal DP = 0;
                decimal GT = 0;
                decimal VAT = 0;
                if (DisAfterPercentage.Checked)
                {
                    DP = DisAfterPercentageVal.Value;
                    if (DP > 0)
                    {
                        DA = (TEV * (DP / 100));
                    }
                }
                else
                {
                    DA = DisAfterAmountVal.Value;
                    if (DA > 0)
                    {
                        DP = ((DA / TEV) * 100);
                    }
                }
                GT = TEV - DA;
                //with / without vat
                if (PurchaseType.SelectedIndex == 0) //with vat
                {
                    VAT = GT / 1.13M;
                    VAT = GT - VAT;
                }
                else if (PurchaseType.SelectedIndex == 1)//without vat
                {
                    VAT = 0;
                }
                //
                VatIncVal.Text = Math.Round(VAT, 2).ToString();
                GrandTotal.Text = Math.Round(GT, 2).ToString();

                if (DisAfterPercentage.Checked)
                {
                    DisAfterAmountVal.Value = DA;
                }
                else
                {
                    DisAfterPercentageVal.Value = DP;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void SetTokenGenerator()
        {
            String BILLNO = "P-1";
            try
            {
                String TOKEN = UtilityClass.GetNewToken();
                DBConnection.Open();
                {
                    string EDate = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
                    //Generate Token insert to purchase
                    String query = "insert into `Purchase` (`Token`,`Status`,`EntryDate`) values (?,2,?)";
                    OleDbParameter[] pars2 = new OleDbParameter[] { 
                                new OleDbParameter() { Value = TOKEN },
                                new OleDbParameter() { Value = EDate }
                            };
                    DBConnection._Write(query, pars2);
                }
                {
                    //Get Set bill no
                    String query = "select ID from `Purchase` where Token=?";
                    OleDbParameter[] pars = new OleDbParameter[] { new OleDbParameter() { Value = TOKEN } };
                    OleDbDataReader reader = DBConnection._Read(query, pars);
                    if (reader.HasRows)
                    {
                        reader.Read();
                        PurchaseID = reader["ID"].ToString();
                        BILLNO = "P-" + PurchaseID;
                        reader.Close();
                    }
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
            BillNo.Text = BILLNO;
        }
        private void SaveInvoice()
        {
            int flag = 0;

            //Check for empty field
            if (SupplierID.Text.Trim().Equals(String.Empty) || PurchaseInvoiceNo.Text.Trim().Equals(String.Empty) || PGrid.Rows.Count <= 0)
            {
                MessageBox.Show("Fill Form Correctly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Set Alert Warning for saving invoice
            try
            {
                String EDATE = EntryDate.Value.ToShortDateString() + " " + EntryDate.Value.ToShortTimeString();
                DBConnection.Open();
                //Update Purchase Database
                String query = "update `Purchase` set Bill_no=?,EntryDate=?,SID=?,Purchase_invoice_no=?,Purchase_invoice_date=?,Purchase_type=?,Transaction_mode=?,Remarks=?,Total_exc_vat=?,Discount_percentage=?,Discount_amount=?,With_vat_13=?,Grand_total=?,Status=1 where ID=?";
                OleDbParameter[] pars = new OleDbParameter[] { 
                    new OleDbParameter() { Value = BillNo.Text.Trim() } ,
                    new OleDbParameter() { Value = EDATE} ,
                    new OleDbParameter() { Value = SupplierID.Text } ,
                    new OleDbParameter() { Value = PurchaseInvoiceNo.Text.Trim() } ,
                    new OleDbParameter() { Value = PurchaseInvoiceDate.Value.ToShortDateString()} ,
                    new OleDbParameter() { Value = PurchaseType.Text } ,
                    new OleDbParameter() { Value = TransactionMode.Text } ,
                    new OleDbParameter() { Value = Remarks.Text.Trim() } ,
                    new OleDbParameter() { Value = TotalExcVal.Text } ,
                    new OleDbParameter() { Value = DisAfterPercentageVal.Value } ,
                    new OleDbParameter() { Value = DisAfterAmountVal.Value } ,
                    new OleDbParameter() { Value = VatIncVal.Text } ,
                    new OleDbParameter() { Value = GrandTotal.Text } ,
                    new OleDbParameter() { Value = PurchaseID } 
                };
                DBConnection._Write(query, pars);

                //Update Inventory
                for (int i = 0; i < PGrid.Rows.Count; i++)
                {
                    string query2 = "insert into Inventory (`IID`,`SPID`,`EID`,`Quantity`,`Status`,`Rate`,`Discount_percentage`,`Discount_amount`,`Gross_amount`,`Net_amount`,`Date`) values (?,?,?,?,?,?,?,?,?,?,?)";
                    OleDbParameter[] pars2 = new OleDbParameter[] { 
                        new OleDbParameter() { Value = PGrid[3,i].Value.ToString() },
                        new OleDbParameter() { Value = PurchaseID },
                        new OleDbParameter() { Value = MainForm.USERID },
                        new OleDbParameter() { Value = PGrid[6,i].Value.ToString() },
                        new OleDbParameter() { Value = UtilityClass.getInventoryStatusCode("Purchase")},
                        new OleDbParameter() { Value = PGrid[7,i].Value.ToString() },
                        new OleDbParameter() { Value = PGrid[9,i].Value.ToString() },
                        new OleDbParameter() { Value = PGrid[10,i].Value.ToString() },
                        new OleDbParameter() { Value = PGrid[8,i].Value.ToString() },
                        new OleDbParameter() { Value = PGrid[11,i].Value.ToString() },
                        new OleDbParameter() { Value = EDATE},
                    };
                    DBConnection._Write(query2, pars2);

                }
                flag = 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                DBConnection.Close();
            }
            if (flag == 1)
            {

                if (MessageBox.Show("Data is saved! Want To Continue with another purchase? Click Yes to Continue OR No For Close Purchase Transaction", "Wait", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    ResetAllField();
                    PurchaseType.SelectedIndex = 0;
                    TransactionMode.SelectedIndex = 0;
                    TokenGenerator.Start();
                    StatusPanel.Visible = true;
                    statusRep.Text = " Data Saved.";
                    Timer_.Start();
                    //Bill Print Preview
                    //Reset The Form
                }
                else
                {
                    ISENDTRANSACTION = true;
                    this.Close();
                }
            }
        }
        private void LoadPurchaseDataFromID()
        {
            String STAT = "";
            try
            {
                String SID = "";
                DBConnection.Open();
                {//Select Purchase data
                    String query = "select * from Purchase where ID =?";
                    OleDbParameter[] pars = new OleDbParameter[] { new OleDbParameter() { Value = PurchaseID } };
                    OleDbDataReader reader = DBConnection._Read(query, pars);
                    if (reader.HasRows)
                    {
                        reader.Read();
                        BillNo.Text = reader["Bill_no"].ToString();
                        EntryDate.Value = DateTime.Parse(reader["EntryDate"].ToString());
                        SupplierID.Text = reader["SID"].ToString();
                        SID = reader["SID"].ToString();
                        PurchaseInvoiceNo.Text = reader["Purchase_invoice_no"].ToString();
                        try
                        {
                            String TDate = reader["Purchase_invoice_date"].ToString();
                            PurchaseInvoiceDate.Value = DateTime.Parse(TDate);
                        }
                        catch (FormatException fex)
                        {
                            Console.WriteLine(fex.Message);
                        }
                        PurchaseType.Text = reader["Purchase_type"].ToString();
                        TransactionMode.Text = reader["Transaction_mode"].ToString();
                        Remarks.Text = reader["Remarks"].ToString();
                        TotalExcVal.Text = reader["Total_exc_vat"].ToString();
                        try { DisAfterPercentageVal.Value = Convert.ToDecimal(reader["Discount_percentage"].ToString()); } catch { }
                        try { DisAfterAmountVal.Value = Convert.ToDecimal(reader["Discount_amount"].ToString()); } catch { }
                        VatIncVal.Text = reader["With_vat_13"].ToString();
                        GrandTotal.Text = reader["Grand_total"].ToString();
                        STAT = reader["Status"].ToString();
                        reader.Close();
                    }
                }
                {//Select Supplier
                    String query = "select Name from Suppliers where ID =?";
                    OleDbParameter[] pars = new OleDbParameter[] { new OleDbParameter() { Value = SID } };
                    OleDbDataReader reader = DBConnection._Read(query, pars);
                    if (reader.HasRows)
                    {
                        reader.Read();
                        SupplierName.Text = reader["Name"].ToString();
                        reader.Close();
                    }
                }
                {//Select Data from Inventory
                    String query = "select Items.ID as IID, Items.Name as IName,Items.Code,Inventory.Quantity,Items.Unit,Inventory.Rate,Inventory.Gross_amount,Inventory.Discount_amount,Inventory.Discount_percentage,Inventory.Net_amount from Inventory INNER JOIN Items on Inventory.IID=Items.ID where Inventory.SPID =? and Inventory.Status=?";
                    OleDbParameter[] pars = new OleDbParameter[] { new OleDbParameter() { Value = PurchaseID }, new OleDbParameter() { Value = UtilityClass.getInventoryStatusCode("Purchase") } };
                    OleDbDataReader reader = DBConnection._Read(query, pars);
                    int row = 0;
                    while (reader.Read())
                    {
                        row += 1;
                        PGrid.Rows.Add(MartSolution.Properties.Resources.delete_2, row.ToString(), reader["Code"].ToString(), reader["IID"].ToString(), reader["IName"].ToString(), reader["Unit"].ToString(), reader["Quantity"].ToString(), reader["Rate"].ToString(), reader["Gross_amount"].ToString(), Math.Round(Convert.ToDecimal(reader["Discount_percentage"].ToString()), 2), Math.Round(Convert.ToDecimal(reader["Discount_amount"].ToString()), 2), reader["Net_amount"].ToString());
                    }
                }
                {//Select Employee
                    String query = "select EmployeeInformation.Name from Inventory LEFT OUTER JOIN EmployeeInformation on Inventory.EID=EmployeeInformation.ID where Inventory.SPID =?";
                    OleDbParameter[] pars = new OleDbParameter[] { new OleDbParameter() { Value = PurchaseID } };
                    OleDbDataReader reader = DBConnection._Read(query, pars);
                    if (reader.HasRows)
                    {
                        reader.Read();
                        EmployeeName.Text = reader["Name"].ToString();
                        reader.Close();
                    }
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

            try
            {
                PurchaseStatus.Text = UtilityClass.getPurchaseStatusString(Convert.ToInt16(STAT));
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }
        private void PrintPreview_Click(object sender, EventArgs e)
        {
            PrintDoc();
        }
        private void PrintDoc()
        {
            try
            {

                ReportDisplayForm reportForm = new ReportDisplayForm();
                ReportViewer reportViewer = reportForm.reportViewerPanel;
                reportViewer.LocalReport.ReportPath = "ReportPages/PurchaseInvoicePage.rdlc";
                DataSetCollection dataSetCollection = new DataSetCollection();
                DataTable dataTable = dataSetCollection.Tables["PurchaseInvoice"];

                for (int i = 0; i < PGrid.Rows.Count; i++)
                {
                    dataTable.Rows.Add(
                        PGrid[1,i].Value.ToString(),
                        PGrid[3, i].Value.ToString(),
                        PGrid[4, i].Value.ToString(),
                        PGrid[5, i].Value.ToString(),
                        PGrid[6, i].Value.ToString(),
                        PGrid[7, i].Value.ToString(),
                        PGrid[8, i].Value.ToString(),
                        PGrid[9, i].Value.ToString(),
                        PGrid[10, i].Value.ToString(),
                        PGrid[11, i].Value.ToString()
                        );
                }

                ReportDataSource reportDataSource = new ReportDataSource("PurchaseInvoice", dataTable);
                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.LocalReport.DataSources.Add(reportDataSource);

                List<ReportParameter> reportParameters = new List<ReportParameter>();
                reportParameters.Add(new ReportParameter("BillNo", BillNo.Text.Trim()));
                reportParameters.Add(new ReportParameter("Date", EntryDate.Value.ToShortDateString() + " " + EntryDate.Value.ToShortTimeString()));
                reportParameters.Add(new ReportParameter("SID", SupplierID.Text.Trim()));
                reportParameters.Add(new ReportParameter("Supplier", SupplierName.Text.Trim()));
                reportParameters.Add(new ReportParameter("PurchaseInvoiceNo", PurchaseInvoiceNo.Text.Trim()));
                reportParameters.Add(new ReportParameter("PurchaseInvoiceDate", PurchaseInvoiceDate.Value.ToShortDateString()));
                reportParameters.Add(new ReportParameter("PurchaseType", PurchaseType.Text.Trim()));
                reportParameters.Add(new ReportParameter("TransactionMode", TransactionMode.Text.Trim()));
                reportParameters.Add(new ReportParameter("Remarks", Remarks.Text.Trim()));
                reportParameters.Add(new ReportParameter("TotalExcVat", TotalExcVal.Text.Trim()));
                reportParameters.Add(new ReportParameter("Discount", DisAfterPercentageVal.Value.ToString() + " % " + DisAfterAmountVal.Value.ToString() + " Rs."));
                reportParameters.Add(new ReportParameter("Vat_13", VatIncVal.Text.ToString()));
                reportParameters.Add(new ReportParameter("GrandTotal", GrandTotal.Text.Trim()));
                reportParameters.Add(new ReportParameter("Status", PurchaseStatus.Text.Trim()));
                reportParameters.Add(new ReportParameter("EmployeeName", EmployeeName.Text.Trim()));

                reportViewer.LocalReport.SetParameters(reportParameters);
                reportViewer.RefreshReport();

                reportForm.MdiParent = MainForm.mainForm;
                reportForm.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        private void PurchaseInvoice_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ResourceClass.FORMMODE == 0)
            {
                ResourceClass.purchaseInvoice = null;
            }
        }
        private void S_ItemCode_CheckedChanged(object sender, EventArgs e)
        {
            _AutoFind.Visible = true;
            _AutoFind.Checked = true;
            _AutoFind.BackColor = Color.Aquamarine;
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
            _AutoFind.Visible = false;
            _AutoFind.Checked = false;
            _AutoFind.BackColor = Color.LightPink;
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
        private void S_ItemBarCode_CheckedChanged(object sender, EventArgs e)
        {
            _AutoFind.Visible = true;
            _AutoFind.Checked = true;
            _AutoFind.BackColor = Color.Bisque;
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
    }
}
