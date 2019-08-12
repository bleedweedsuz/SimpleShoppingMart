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
    public partial class ItemInformation : Form
    {
        public AllReportForm ARF= null;
        List<CItems> CItemsList;
        public ItemInformation()
        {
            InitializeComponent();
        }
        private void ItemInformation_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.Clone() as Icon;
            if (ARF == null)
            {
                CategoryList();
                ItemLists("");
            }
            else
            {
                Column4.DefaultCellStyle.BackColor = Color.LightGreen;
                buttonPanel.Visible = false;
                inputPanel.Visible = false;
                ItemLists("");

            }
        }
        public void CategoryList()
        {
            CItemsList = new List<CItems>();
            ItemCategory.Items.Clear();
            try
            {
                DBConnection.Open();
                String query = "select * from ItemCategory where `Status`=1 order by Name asc;";
                OleDbDataReader reader = DBConnection._Read(query);
                while (reader.Read())
                {
                    CItemsList.Add(new CItems(Convert.ToInt32(reader[0]), reader[1].ToString()));
                    ItemCategory.Items.Add(reader[1].ToString());
                }
                if (ItemCategory.Items.Count >= 1)
                {
                    ItemCategory.SelectedIndex = 0;
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
        private void Save_Click(object sender, EventArgs e)
        {
            if (ItemCategory.Items.Count > 0)
            {
                SaveData();
            }
            else
            {
                CategoryPanel.BackColor = Color.Tomato;
                MessageBox.Show("No Category Selected.", "Error");
            }

        }
        private bool IsOkToWrite()
        {
            if (NameText.Text.Trim() != "" && Unit.Text.Trim() != "" && (BarCode.Text.Trim() != "" || Code.Text.Trim() != ""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void SaveData()
        {
            int flag = 0;
            try
            {
                if (IID.Text.Trim().Equals(String.Empty))
                {
                    #region "Insert Portion"
                    bool isCheckExists = false;
                    //Check Item Code & Name
                    String queryTemp = "";
                    OleDbParameter[] pars = null;

                    String _BCode = "";
                    String _Code = "";

                    if (!IsOkToWrite())
                    {
                        MessageBox.Show("Fill the form correctly!\n* must be fill up. \n** optional between fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    


                    DBConnection.Open();
                    if (Code.Text.Trim() == "")
                    {
                        queryTemp = "select * from Items where (Name=? or BarCode=?) and status =1";
                        pars = new OleDbParameter[] { 
                            new OleDbParameter() { Value = NameText.Text.Trim() },
                            new OleDbParameter() { Value = BarCode.Text.Trim() } 
                        };
                        _BCode = BarCode.Text.Trim();
                        _Code = "";
                    }
                    else if (BarCode.Text.Trim() == "")
                    {
                        queryTemp = "select * from Items where (Code =? or Name=?) and status =1";
                        pars = new OleDbParameter[] { 
                            new OleDbParameter() { Value = Code.Text.Trim() },
                            new OleDbParameter() { Value = NameText.Text.Trim() }
                        };
                        _BCode = "";
                        _Code = Code.Text.Trim();
                    }
                    else
                    {
                        queryTemp = "select * from Items where (Code =? or Name=? or BarCode=?) and status =1";
                        pars = new OleDbParameter[] { 
                            new OleDbParameter() { Value = Code.Text.Trim() },
                            new OleDbParameter() { Value = NameText.Text.Trim() },
                            new OleDbParameter() { Value = BarCode.Text.Trim() }
                        };
                        _BCode = BarCode.Text.Trim();
                        _Code = Code.Text.Trim(); ;
                    }
                    //-----------------------Execute All Parameter--------------------------------
                    OleDbDataReader reader = DBConnection._Read(queryTemp, pars);
                    if (reader.HasRows) {
                        reader.Read();
                        if (NameText.Text.Trim().Equals(reader[4].ToString())) { flag = 2; }
                        else if (Code.Text.Trim().Equals(reader[2].ToString())) { flag = 3; }
                        else if (BarCode.Text.Trim().Equals(reader[3].ToString())) { flag = 4; }
                        isCheckExists = true; 
                    }
                    reader.Close();
                    //Insert
                    if (!isCheckExists)
                    {
                        String query = "insert into `Items` (`CID`,`Code`,`BarCode`,`Name`,`Unit`,`Default_quantity`,`Description`,`Status`) values (?,?,?,?,?,?,?,1)";
                        OleDbParameter[] parsLists = new OleDbParameter[]{
                            new OleDbParameter { Value = CItemsList[ItemCategory.SelectedIndex].ID.ToString() },
                            new OleDbParameter { Value = _Code},
                            new OleDbParameter { Value = _BCode},
                            new OleDbParameter { Value = NameText.Text.Trim()},
                            new OleDbParameter { Value = Unit.Text.Trim()},
                            new OleDbParameter { Value = DQuantity.Value.ToString()},
                            new OleDbParameter { Value = Description.Text.Trim()}
                        };
                        DBConnection._Write(query, parsLists);
                        flag = 1;
                    }
                    #endregion

                }
                else
                {
                    #region "Update Portion"
                    bool isCheckExists = false;
                    //Check Item Code & Name
                    String queryTemp = "";
                    OleDbParameter[] pars = null;

                    String _BCode = "";
                    String _Code = "";

                    if (!IsOkToWrite())
                    {
                        MessageBox.Show("Fill the form correctly!\n* must be fill up. \n** optional between fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }



                    DBConnection.Open();
                    if (Code.Text.Trim() == "")
                    {
                        queryTemp = "select * from Items where (Name=? or BarCode=?) and status =1 and ID<>?";
                        pars = new OleDbParameter[] { 
                            new OleDbParameter() { Value = NameText.Text.Trim() },
                            new OleDbParameter() { Value = BarCode.Text.Trim() },
                            new OleDbParameter() { Value = IID.Text.Trim() } 
                        };
                        _BCode = BarCode.Text.Trim();
                        _Code = "";
                    }
                    else if (BarCode.Text.Trim() == "")
                    {
                        queryTemp = "select * from Items where (Code =? or Name=?) and status =1 and ID<>?";
                        pars = new OleDbParameter[] { 
                            new OleDbParameter() { Value = Code.Text.Trim() },
                            new OleDbParameter() { Value = NameText.Text.Trim() },
                             new OleDbParameter() { Value = IID.Text.Trim() } 
                        };
                        _BCode = "";
                        _Code = Code.Text.Trim();
                    }
                    else
                    {
                        queryTemp = "select * from Items where (Code =? or Name=? or BarCode=?) and status =1 and ID<>?";
                        pars = new OleDbParameter[] { 
                            new OleDbParameter() { Value = Code.Text.Trim() },
                            new OleDbParameter() { Value = NameText.Text.Trim() },
                            new OleDbParameter() { Value = BarCode.Text.Trim() },
                            new OleDbParameter() { Value = IID.Text.Trim() } 
                        };
                        _BCode = BarCode.Text.Trim();
                        _Code = Code.Text.Trim(); ;
                    }
                    //-----------------------Execute All Parameter--------------------------------
                    OleDbDataReader reader = DBConnection._Read(queryTemp, pars);
                    if (reader.HasRows)
                    {
                        reader.Read();
                        if (NameText.Text.Trim().Equals(reader[4].ToString())) { flag = 2; }
                        else if (Code.Text.Trim().Equals(reader[2].ToString())) { flag = 3; }
                        else if (BarCode.Text.Trim().Equals(reader[3].ToString())) { flag = 4; }
                        isCheckExists = true;
                    }
                    reader.Close();

                    //Update
                    if (!isCheckExists)
                    {
                        String query = "update `Items` set `CID`=?,`Code`=?,`BarCode`=?,`Name`=?,`Unit`=?,`Default_quantity`=?,`Description`=? where ID=?";
                        OleDbParameter[] parsLists = new OleDbParameter[]{
                            new OleDbParameter { Value = CItemsList[ItemCategory.SelectedIndex].ID.ToString() },
                            new OleDbParameter { Value = _Code},
                            new OleDbParameter { Value = _BCode},
                            new OleDbParameter { Value = NameText.Text.Trim()},
                            new OleDbParameter { Value = Unit.Text.Trim()},
                            new OleDbParameter { Value = DQuantity.Value.ToString()},
                            new OleDbParameter { Value = Description.Text.Trim()},
                            new OleDbParameter { Value = IID.Text.Trim()}
                        };
                        DBConnection._Write(query, parsLists);
                        flag = 1;
                    }
                    #endregion
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
            //---FLAG UPDATE
            if (flag == 1)
            {
                ClearField();
                ItemLists("");
            }
            else if (flag == 2)
            {
                MessageBox.Show("Item Name Already Exists.", "Error");
            }
            else if (flag == 3)
            {
                MessageBox.Show("Item CODE Already Exists.", "Error");
            }
            else if (flag == 4)
            {
                MessageBox.Show("BarCode Already Exists.", "Error");
            }
        }
        private void AddItemCategory_Click(object sender, EventArgs e)
        {
            ItemCategory IC = new ItemCategory();
            IC.II = this;
            IC.ShowDialog();
        }
        private void RefreshCategoryList_Click(object sender, EventArgs e)
        {
            CategoryList();
        }
        private void ClearField()
        {
            CategoryPanel.BackColor = Color.White;
            NameText.Clear();
            if (ItemCategory.Items.Count > 0) { Code.Text = CItemsList[ItemCategory.SelectedIndex].ID + "."; }
            CategoryPanel.BackColor = Color.White;
            IID.Clear();
            Unit.Clear();
            Description.Clear();
            BarCode.Clear();
            //ItemCategory.SelectedIndex = 0;
            DQuantity.Value = 1;
            NameText.Focus();
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            ClearField();
        }
        private void ItemLists(String needle)
        {
            try
            {
                IGrid.Rows.Clear();
                DBConnection.Open();
                String query = "";
                if (CheckGarbage.Checked)
                {
                    query = "select Items.Default_quantity,Items.BarCode, Items.ID,Items.CID,Items.Code,Items.Name as IName,Items.Unit,Items.Description,Items.Status as IStatus,ItemCategory.Name as CName,ItemCategory.Status as ICStatus from Items LEFT JOIN ItemCategory on Items.CID=ItemCategory.ID where Items.Name LIKE @needle + '%' order by Items.ID desc;";
                }
                else
                {
                    query = "select Items.Default_quantity,Items.BarCode, Items.ID,Items.CID,Items.Code,Items.Name as IName,Items.Unit,Items.Description,Items.Status as IStatus,ItemCategory.Name as CName,ItemCategory.Status as ICStatus from Items LEFT JOIN ItemCategory on Items.CID=ItemCategory.ID where Items.Name LIKE @needle + '%' and Items.Status=1 order by Items.ID desc;";
                }
                OleDbParameter[] pars = new OleDbParameter[] { new OleDbParameter() { Value = needle } };
                OleDbDataReader reader = DBConnection._Read(query, pars);

                int row = 0;
                while (reader.Read())
                {
                    IGrid.Rows.Add(reader["CID"], reader["CName"], reader["ID"], reader["Code"], reader["BarCode"], reader["IName"], reader["Unit"], reader["Default_quantity"], reader["Description"], reader["IStatus"]);
                    if (reader["IStatus"].ToString() == "0")
                    {
                        IGrid[2, row].Style.BackColor = Color.IndianRed;
                    }
                    if (reader["ICStatus"].ToString() == "0")
                    {
                        IGrid[1, row].Style.BackColor = Color.Tomato;
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
        private void CheckGarbage_CheckedChanged(object sender, EventArgs e)
        {
            ItemLists("");
        }
        private void IGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (ARF == null)
                {
                    CategoryPanel.BackColor = IGrid[1, e.RowIndex].Style.BackColor;
                    if (IGrid[8, e.RowIndex].Value.ToString() == "1") { Delete.Visible = true; } else { Delete.Visible = false; }
                    IID.Text = IGrid[2, e.RowIndex].Value.ToString();
                    NameText.Text = IGrid[5, e.RowIndex].Value.ToString();
                    BarCode.Text = IGrid[4, e.RowIndex].Value.ToString();
                    ItemCategory.Text = IGrid[1, e.RowIndex].Value.ToString();
                    Unit.Text = IGrid[6, e.RowIndex].Value.ToString();
                    DQuantity.Value = Convert.ToDecimal(IGrid[7, e.RowIndex].Value.ToString());
                    Description.Text = IGrid[8, e.RowIndex].Value.ToString();
                    Code.Text = IGrid[3, e.RowIndex].Value.ToString();
                }
                else
                {
                    ARF.ItemID.Text = IGrid[2, e.RowIndex].Value.ToString();
                    ARF.ItemName.Text = IGrid[5, e.RowIndex].Value.ToString();
                    this.Close();
                }
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.R))
            {
                CategoryList();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.N))
            {
                AddItemCategory_Click(null, null);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            ItemLists(SearchText.Text.Trim());
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            int flag = 0;
            try
            {
                DBConnection.Open();
                String queryTemp = "update `Items` set `Status`=0 where `ID`=?";
                OleDbParameter[] parsLists = new OleDbParameter[]{
                            new OleDbParameter { Value = IID.Text.Trim()}
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
                ItemLists("");
            }
        }
        private void ItemCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Code.Text = CItemsList[ItemCategory.SelectedIndex].ID + ".";
        }

        private void ItemInformation_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ResourceClass.FORMMODE == 0)
            {
                ResourceClass.itemInformation = null;
            }
        }

        private void ItemCodeClear_Click(object sender, EventArgs e)
        {
            Code.Clear();
        }

        private void BarcodeClear_Click(object sender, EventArgs e)
        {
            BarCode.Clear();
        }
    }
    public class CItems
    {
        public Int32 ID { set; get; }
        public String Name { set; get; }
        public CItems(Int32 ID, String Name)
        {
            this.ID = ID;
            this.Name = Name;
        }
    }
}