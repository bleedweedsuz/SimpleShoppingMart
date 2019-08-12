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
    public partial class ItemCategory : Form
    {
        public ItemInformation II = null;
        public ItemCategory()
        {
            InitializeComponent();
        }
        private void Save_Click(object sender, EventArgs e)
        {
            SaveData();
            ReLoadIICategory();
        }
        private void SaveData()
        {
            int flag = 0;
            try
            {
                //Checking Important Fields
                if (NameText.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Fill Form Correctly!", "Error");
                    return;
                }
                DBConnection.Open();
                //Insert Data
                if (CID.Text.Trim().Equals(String.Empty))
                {
                    Boolean isCategoryNameExists = false;
                    //Check UserName
                    String queryTemp = "select * from `ItemCategory` where Name=@needle and Status=1";
                    OleDbParameter[] pars = new OleDbParameter[] { new OleDbParameter() { Value = NameText.Text.Trim() } };
                    OleDbDataReader reader = DBConnection._Read(queryTemp, pars);
                    if (reader.HasRows) { isCategoryNameExists = true; }
                    reader.Close();

                    if (!isCategoryNameExists)
                    {
                        //Insert EmployeeInformation
                        queryTemp = "Insert into `ItemCategory` (`Name`,`Status`) values (?,1)";
                        OleDbParameter[] parsLists = new OleDbParameter[]{
                            new OleDbParameter { Value = NameText.Text.Trim()}
                            };
                        DBConnection._Write(queryTemp, parsLists);
                        flag = 1;
                    }
                    else
                    {
                        flag = 2;
                    }
                }
                //Update Data
                else
                {
                    Boolean isCategoryNameExists = false;
                    //Check UserName
                    String queryTemp = "select * from `ItemCategory` where Name = ? and ID <> ? and Status=1";
                    OleDbParameter[] pars = new OleDbParameter[] { new OleDbParameter() { Value = NameText.Text.Trim() }, new OleDbParameter() { Value = CID.Text.Trim() } };
                    OleDbDataReader reader = DBConnection._Read(queryTemp, pars);
                    if (reader.HasRows) { isCategoryNameExists = true; }
                    reader.Close();

                    if (!isCategoryNameExists)
                    {
                        queryTemp = "update `ItemCategory` set `Name`=? where `ID`=?";
                        OleDbParameter[] parsLists = new OleDbParameter[]{
                            new OleDbParameter { Value = NameText.Text.Trim()},
                            new OleDbParameter { Value = CID.Text.ToString()}
                        };
                        DBConnection._Write(queryTemp, parsLists);
                        flag = 1;
                    }
                    else
                    {
                        flag = 2;
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
                CategoryList("");
            }
            else if (flag == 2)
            {
                MessageBox.Show("Category Name Already Exists!", "Error");
            }
        }
        private void CategoryList(String needle)
        {
            try
            {
                ICGrid.Rows.Clear();
                DBConnection.Open();
                String query = "";
                if (CheckGarbage.Checked)
                {
                    query = "select * from ItemCategory where Name LIKE @needle + '%' order by ID desc;";
                }
                else
                {
                    query = "select * from ItemCategory where Name LIKE @needle + '%' and `Status`=1 order by ID desc;";
                }
                OleDbParameter[] pars = new OleDbParameter[] { new OleDbParameter() { Value = needle } };
                OleDbDataReader reader = DBConnection._Read(query, pars);

                int row = 0;
                while (reader.Read())
                {
                    ICGrid.Rows.Add(reader[0], reader[1],reader[2]);
                    if (reader[2].ToString() == "0")
                    {
                        ICGrid[0, row].Style.BackColor = Color.IndianRed;
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
        private void ClearField()
        {
            Delete.Visible = false;
            NameText.Clear();
            CID.Clear();
        }
        private void ItemCategory_Load(object sender, EventArgs e)
        {
            CategoryList("");
        }
        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            CategoryList(SearchText.Text.Trim());
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            ClearField();
        }
        private void ICGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (ICGrid[2, e.RowIndex].Value.ToString() == "1") { Delete.Visible = true; } else { Delete.Visible = false; }
                CID.Text = ICGrid[0, e.RowIndex].Value.ToString();
                NameText.Text = ICGrid[1, e.RowIndex].Value.ToString();
            }
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            int flag = 0;
            try
            {
                DBConnection.Open();
                String queryTemp = "update `ItemCategory` set `Status`=0 where `ID`=?";
                OleDbParameter[] parsLists = new OleDbParameter[]{
                            new OleDbParameter { Value = CID.Text.Trim()}
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
                CategoryList("");
            }
        }
        private void CheckGarbage_CheckedChanged(object sender, EventArgs e)
        {
            CategoryList("");
        }
        private void ItemCategory_FormClosed(object sender, FormClosedEventArgs e)
        {
            ReLoadIICategory();
        }
        private void ReLoadIICategory()
        {
            try
            {
                if (II != null)
                {
                    II.CategoryList();
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
