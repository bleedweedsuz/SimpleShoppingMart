using MartSolution.Report;
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
    public partial class SupplierInformation : Form
    {
        public AllReportForm ARF = null;
        public SupplierInformation()
        {
            InitializeComponent();
        }
        private void SupplierInformation_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.Clone() as Icon;
            if (ARF == null) 
            { 
                ShowSuppliersList(String.Empty);
            }
            else
            {
                inputPanel.Visible = false;
                buttonPanel.Visible = false;
                ShowSuppliersList(String.Empty);
            }
        }
        private void ShowSuppliersList(String needle)
        {
            try
            {
                SGrid.Rows.Clear();
                DBConnection.Open();
                String query = "";
                if (CheckGarbage.Checked)
                {
                    query = "select * from Suppliers where Name LIKE @needle + '%' order by ID desc;";
                }
                else
                {
                    query = "select * from Suppliers where Name LIKE @needle + '%' and `Status`=1 order by ID desc;";
                }
                OleDbParameter[] pars = new OleDbParameter[] { new OleDbParameter() { Value = needle } };
                OleDbDataReader reader = DBConnection._Read(query, pars);
                int row = 0;
                while (reader.Read())
                {
                    SGrid.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6], reader[7]);
                    if (reader[7].ToString() == "0")
                    {
                        SGrid[0, row].Style.BackColor = Color.Tomato;
                    }
                    row += 1;
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
        private void SGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (ARF == null)
                {
                    if (SGrid[7, e.RowIndex].Value.ToString() == "1") { Delete.Visible = true; } else { Delete.Visible = false; }
                    SID.Text = SGrid[0, e.RowIndex].Value.ToString();
                    NameText.Text = SGrid[1, e.RowIndex].Value.ToString();
                    Phone.Text = SGrid[2, e.RowIndex].Value.ToString();
                    Address.Text = SGrid[3, e.RowIndex].Value.ToString();
                    PanNo.Text = SGrid[4, e.RowIndex].Value.ToString();
                    Email.Text = SGrid[5, e.RowIndex].Value.ToString();
                    Remarks.Text = SGrid[6, e.RowIndex].Value.ToString();
                }
                else
                {
                    ARF.SupplierID.Text = SGrid[0, e.RowIndex].Value.ToString();
                    ARF.SupplierName.Text = SGrid[1, e.RowIndex].Value.ToString();
                    this.Close();
                }
            }
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            ClearField();
        }
        private void ClearField()
        {
            SID.Clear();
            NameText.Clear();
            Phone.Clear();
            Address.Clear();
            PanNo.Clear();
            Email.Clear();
            Remarks.Clear();
        }
        private void Save_Click(object sender, EventArgs e)
        {
            SaveData();
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            int flag = 0;
            try
            {
                DBConnection.Open();
                String queryTemp = "update `Suppliers` set `Status`=0 where `ID`=?";
                OleDbParameter[] parsLists = new OleDbParameter[]{
                            new OleDbParameter { Value = SID.Text.Trim()}
                        };
                DBConnection._Write(queryTemp, parsLists);
                flag = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                DBConnection.Close();
            }

            if (flag == 1)
            {
                ClearField();
                ShowSuppliersList(String.Empty);
            }
        }
        private void CheckGarbage_CheckedChanged(object sender, EventArgs e)
        {
            ShowSuppliersList(SearchText.Text.Trim());
        }
        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            ShowSuppliersList(SearchText.Text.Trim());
        }
        private void SaveData()
        {
            int flag = 0;
            try
            {
                if(NameText.Text.Trim().Equals(String.Empty))
                {
                    MessageBox.Show("Fill The Form Correctly!", "Error");
                    return;
                }
                else
                {
                    if (SID.Text.Trim().Equals(String.Empty))
                    {
                        DBConnection.Open();
                        //Check For Supplier Name
                        Boolean isSupplierExists = false;
                        //Check UserName
                        String queryTemp = "select Name from `Suppliers` where `Name`=? and Status=1";
                        OleDbParameter[] pars = new OleDbParameter[] { new OleDbParameter() { Value = NameText.Text.Trim() } };
                        OleDbDataReader reader = DBConnection._Read(queryTemp, pars);
                        if (reader.HasRows) { isSupplierExists = true; }
                        reader.Close();
                       
                        if (!isSupplierExists)
                        {
                            String query = "insert into Suppliers (`Name`,`Phone_no`,`Address`,`Pan_no`,`Email`,`Remarks`,`Status`) values (?,?,?,?,?,?,1)";
                            OleDbParameter[] pars2 = new OleDbParameter[] { 
                                new OleDbParameter() { Value = NameText.Text.Trim() } ,
                                new OleDbParameter() { Value = Phone.Text.Trim() } ,
                                new OleDbParameter() { Value = Address.Text.Trim() } ,
                                new OleDbParameter() { Value = PanNo.Text.Trim() } ,
                                new OleDbParameter() { Value = Email.Text.Trim() } ,
                                new OleDbParameter() { Value = Remarks.Text.Trim() } 
                            };
                            DBConnection._Write(query, pars2);
                            flag = 1;
                        }
                        else
                        {
                            flag = 2;
                        }
                    }
                    else
                    {
                        DBConnection.Open();
                        //Check For Supplier Name
                        Boolean isSupplierExists = false;
                        //Check UserName
                        String queryTemp = "select Name from `Suppliers` where `Name`=? and Status=1 and ID <> ?";
                        OleDbParameter[] pars = new OleDbParameter[] { 
                            new OleDbParameter() { Value = NameText.Text.Trim() },
                            new OleDbParameter() { Value = SID.Text.Trim() } 
                        };
                        OleDbDataReader reader = DBConnection._Read(queryTemp, pars);
                        if (reader.HasRows) { isSupplierExists = true; }
                        reader.Close();

                        if (!isSupplierExists)
                        {
                            String query = "Update Suppliers set `Name`=?,`Phone_no`=?,`Address`=?,`Pan_no`=?,`Email`=?,`Remarks`=? where ID=?";
                            OleDbParameter[] pars2 = new OleDbParameter[] { 
                                new OleDbParameter() { Value = NameText.Text.Trim() } ,
                                new OleDbParameter() { Value = Phone.Text.Trim() } ,
                                new OleDbParameter() { Value = Address.Text.Trim() } ,
                                new OleDbParameter() { Value = PanNo.Text.Trim() } ,
                                new OleDbParameter() { Value = Email.Text.Trim() } ,
                                new OleDbParameter() { Value = Remarks.Text.Trim() },
                                new OleDbParameter() { Value = SID.Text.Trim() }
                            };
                            DBConnection._Write(query, pars2);
                            flag = 1;
                        }
                        else
                        {
                            flag = 2;
                        }
                    }
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
            //Message Status
            if (flag == 1)
            {
                ClearField();
                ShowSuppliersList(String.Empty);
            }
            else if (flag == 2)
            {
                MessageBox.Show("Suppliers Name Already Exists.", "Error");
            }
        }

        private void SupplierInformation_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ResourceClass.FORMMODE == 0)
            {
                ResourceClass.supplierInformation = null;
            }
        }
    }
}
