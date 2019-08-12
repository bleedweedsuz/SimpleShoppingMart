using MartSolution.Tools;
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

namespace MartSolution.Transaction
{
    public partial class DayEndCloseOut : Form
    {
        enum ExecuteMode { ListOutClosing, ClosedData }
        private bool isProgressFinished = false, isEngineStart =false;
        ExecuteMode EMode;
        List<ClosingTableItems> CTIList = new List<ClosingTableItems>();
        public DayEndCloseOut()
        {
            InitializeComponent();
        }
        private void DayEndCloseOut_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseOutProgress.IsBusy)
            {
                CloseOutProgress.CancelAsync();
            }
        }
        private void DayEndCloseOut_Load(object sender, EventArgs e)
        {
            this.Text = "Day End Close Out [ " + CloseDate.Value.ToShortDateString() + " ]";
            if (ResourceClass.ISClosedAccount)
            {
                ExecuteBtn.Enabled = false;
                CloseOutBtn.Enabled = false;
                StatusLabel.Visible = true;
                StatusLabel.Location = new Point(80, 200);
                StatusLabel.ForeColor = Color.Red;
                StatusLabel.Text = "\"TODAY ACCOUNT ALREADY CLOSED\"";
                CBackup.Enabled = true;
                CBackup.Visible = true;
            }
        }
        private void CloseDate_ValueChanged(object sender, EventArgs e)
        {
            this.Text = "Day End Close Out [ " + CloseDate.Value.ToShortDateString() + " ]";
        }
        private void ColorBack(DataGridViewRow datagridViewRow)
        {
            datagridViewRow.DefaultCellStyle.BackColor = Color.LimeGreen;
        }
        private void ExecuteBtn_Click(object sender, EventArgs e)
        {
            if (!isEngineStart)
            {
                //Start Engine
                isProgressFinished = false;
                CloseOutBtn.Enabled = false;
                StatusLabel.Visible = true;
                EMode = ExecuteMode.ListOutClosing;
                ExecuteBtn.Text = "Cancel";
                isEngineStart = true;
                CloseOutProgress.RunWorkerAsync();

            }
            else
            {
                StatusLabel.Visible = false;
                isEngineStart = false;
                //Cancel Things
                CloseOutProgress.CancelAsync();
            }
        }
        private void CloseOutBtn_Click(object sender, EventArgs e)
        {
            if (!isEngineStart)
            {
                if (MessageBox.Show("Are you sure want to close transaction of this day?", "WAIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    //Start Engine
                    ExecuteBtn.Enabled = false;
                    isProgressFinished = false;
                    CloseOutBtn.Enabled = false;
                    StatusLabel.Visible = true;
                    EMode = ExecuteMode.ClosedData;
                    CloseOutBtn.Text = "Processing..";
                    isEngineStart = true;
                    CloseOutProgress.RunWorkerAsync();
                }
            }
        }
        private void CloseOutProgress_DoWork(object sender, DoWorkEventArgs e)
        {
            if (EMode == ExecuteMode.ListOutClosing)
            {
                ExecuteList(e);
            }
            else if (EMode == ExecuteMode.ClosedData)
            {
                ExecuteClose(e);
            }
        }
        private void CloseOutProgress_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (EMode == ExecuteMode.ListOutClosing)
            {
                StatusLabel.Text = "Total Data Transaction: " + e.ProgressPercentage + " %";
            }
            else if (EMode == ExecuteMode.ClosedData)
            {
                StatusLabel.Text = "Data Transaction: " + e.ProgressPercentage + " / " + CTIList.Count;
            }
        }
        private void CloseOutProgress_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            #region "LIST OUT CLOSING END"
            if (EMode == ExecuteMode.ListOutClosing)
            {
                if (isProgressFinished)
                {
                    ExecuteBtn.Enabled = true;
                    CloseOutBtn.Enabled = true;

                    IGrid.Rows.Clear();
                    Decimal P=0, S=0;

                    bool isDataLoad = false;

                    for (int i = 0; i < CTIList.Count; i++)
                    {
                        P += CTIList[i].PAmount;
                        S += CTIList[i].SAmount;
                        IGrid.Rows.Add((i + 1), CTIList[i].IID, CTIList[i].IName, CTIList[i].InventoryArrayString, "Rs. " + CTIList[i].PAmount + " /-", "Rs. " + CTIList[i].SAmount + " /-", CTIList[i].CDate);
                        isDataLoad = true;
                    }

                    if (isDataLoad)
                    {
                        IGrid.Rows.Add("", "", "", "", "", "", "");
                        IGrid.Rows.Add("", "", "", "Total:", "Rs. " + P + " /-", "Rs. " + S + " /-", "");
                        ColorBack(IGrid.Rows[IGrid.Rows.Count - 1]);
                    }
                }
                else
                {
                    ExecuteBtn.Enabled = true;
                    CloseOutBtn.Enabled = false;
                }
                ExecuteBtn.Text = "&Execute";
                StatusLabel.Text = "";
            }
            #endregion
            #region "Close Data"
            else if (EMode == ExecuteMode.ClosedData)
            {
                if (isProgressFinished)
                {
                    ExecuteBtn.Enabled = false;
                    CloseOutBtn.Enabled = false;
                    ResourceClass.ISClosedAccount = true;
                    CBackup.Enabled = true;
                    CBackup.Visible = true;
                }
                else
                {
                    CloseOutBtn.Enabled = true;
                } 
                CloseOutBtn.Text = "&Close Out";
                StatusLabel.Text = "";
            }
            #endregion
            isEngineStart = false;
            StatusLabel.Visible = false;
        }
        #region "List Out Closing Data"
        private void ExecuteList(DoWorkEventArgs e)
        {
            int ProgressVal = 0;
            try
            {
                CTIList.Clear();
                DBConnection.Open();
                String TodayDate = CloseDate.Value.ToShortDateString();

                #region "Close Out List"
                //selecting items from item lists
                String Query = "select ID,Name from Items where Status =1";
                OleDbDataReader reader = DBConnection._Read(Query);
                while (reader.Read())
                {
                    ProgressVal++;
                    //Quantity
                    Decimal OpeningStock = 0, Damage = 0, Expired = 0, InitialStock = 0, Lost = 0, Purchase = 0, Sales = 0, SalesReturn = 0, TotalQTY = 0;
                    //Amount
                    Decimal PurchaseAmount = 0, SalesAmount = 0;
                    //String Inventory Template Array
                    String InventoryTemplateArray = "";


                    String CDate = CloseDate.Value.ToShortDateString();
                    //Dates
                    String DateStr1 = TodayDate + ResourceClass.FIRST_TIME;
                    String DateStr2 = TodayDate + ResourceClass.LAST_TIME;

                    String ID = reader["ID"].ToString(), IName = reader["Name"].ToString();
                    
                    {//Opening Stocks
                        String Query2 = "select Quantity from ClosingTable where IID=@ID and SN=(select MAX(SN) from ClosingTable where IID=@ID)";
                        OleDbParameter[] pars2 = new OleDbParameter[] { new OleDbParameter() { Value = ID, ParameterName= "ID" }};
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
                            //Progress Report
                            CloseOutProgress.ReportProgress(ProgressVal);

                            //CANCEL IF TRIGGER
                            if (CloseOutProgress.CancellationPending) { e.Cancel = true; CloseOutProgress.ReportProgress(100); break; }
                        }
                    }


                    TotalQTY = (OpeningStock + Damage + Expired + InitialStock + Purchase + SalesReturn) - (Lost + Sales);
                    InventoryTemplateArray = "( " + OpeningStock + " + " + Damage + " + " + Expired + " + " + InitialStock + " + " + Purchase + " + " + SalesReturn + " ) - ( " + Lost + " + " + Sales + " ) = " + TotalQTY;

                    if (CDate != String.Empty) { CDate = DateTime.Parse(CDate).ToShortDateString(); } else { CDate = "----"; }

                    CTIList.Add(new ClosingTableItems(ID.ToString(), IName, TotalQTY, PurchaseAmount, SalesAmount, CDate, InventoryTemplateArray));
                    //CANCEL IF TRIGGER
                    if (CloseOutProgress.CancellationPending) { e.Cancel = true; CloseOutProgress.ReportProgress(100); break; }
                    isProgressFinished = true;
                }
                #endregion
            }
            catch (Exception Ex)
            {
                isProgressFinished = false;
                Console.WriteLine(Ex.ToString());
            }
            finally
            {
                DBConnection.Close();
            }
        }
        #endregion
        #region "Insert Closing Data into System"
        private void ExecuteClose(DoWorkEventArgs e)
        {
            int ProgressVal = 0;
            try
            {
                String CDate = CloseDate.Value.ToShortDateString();
                for (int i = 0; i < CTIList.Count; i++)
                {
                    ProgressVal++;
                    //--------->>
                    try
                    {
                        DBConnection.Open();
                        String Query = "insert into ClosingTable (`IID`,`Quantity`,`Purchase`,`Sales`,`Date`) values (?,?,?,?,?)";
                        OleDbParameter[] pars = new OleDbParameter[] {
                            new OleDbParameter() { Value = CTIList[i].IID },
                            new OleDbParameter() { Value = CTIList[i].QTY },
                            new OleDbParameter() { Value = CTIList[i].PAmount },
                            new OleDbParameter() { Value = CTIList[i].SAmount },
                            new OleDbParameter() { Value = CDate}
                        };
                        DBConnection._Write(Query, pars);
                    }
                    catch (Exception E)
                    {
                        Console.WriteLine(E.Message);
                    }
                    finally
                    {
                        DBConnection.Close();
                    }
                    CloseOutProgress.ReportProgress(ProgressVal);
                    if (CloseOutProgress.CancellationPending) { e.Cancel = true; CloseOutProgress.ReportProgress(100); break; }
                    isProgressFinished = true;
                }
            }
            catch (Exception Ex)
            {
                isProgressFinished = false;
                Console.WriteLine(Ex.ToString());
            }
        }
        #endregion

        private void CBackup_Click(object sender, EventArgs e)
        {
            DatabaseManipulation dbm = new DatabaseManipulation();
            dbm.DBMState = 1;
            dbm.ShowDialog();
        }
    }
    class ClosingTableItems
    {
        public String IID;
        public String IName;
        public decimal QTY;
        public decimal PAmount;
        public decimal SAmount;
        public String CDate;
        public String InventoryArrayString;
        public ClosingTableItems(String IID, String IName, decimal QTY, decimal PAmount, decimal SAmount, String CDate, String InventoryArrayString)
        {
            this.IID = IID;
            this.IName = IName;
            this.PAmount = PAmount;
            this.SAmount = SAmount;
            this.QTY = QTY;
            this.CDate = CDate;
            this.InventoryArrayString = InventoryArrayString;
        }

    }
}
