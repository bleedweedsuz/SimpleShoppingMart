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

namespace MartSolution.Tools
{
    public partial class UserPrivilegeRole : Form
    {
        Array PList,PSuffixList;
        public UserPrivilegeRole()
        {
            InitializeComponent();
        }
        private void UserPrivilegeRole_Load(object sender, EventArgs e)
        {
            InitPGrid();
            CleanPDataToPGrid();
            LoadPrivilege(String.Empty);
        }
        private void LoadPrivilege(String needle)
        {
            try
            {
                PRTNGrid.Rows.Clear();
                DBConnection.Open();
                String query = "select * from Privilege";
                OleDbParameter[] pars = new OleDbParameter[] { new OleDbParameter() { Value = needle } };
                OleDbDataReader reader = DBConnection._Read(query, pars);
                while (reader.Read())
                {
                    PRTNGrid.Rows.Add(reader[0], reader[1]);
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
            SavePRTName();
        }
        private void PRName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SavePRTName();
            }
        }
        private void SavePRTName()
        {
            int flag = 0;
            if (PRName.Text.Equals(String.Empty))
            {
                return;
            }
            try
            {
                DBConnection.Open();
                if (TID.Text.Equals(String.Empty))
                {
                    Boolean isTemplateExists = false;
                    //Check UserName
                    String queryTemp = "select ID from Privilege where Template_name=?";
                    OleDbParameter[] pars = new OleDbParameter[] { new OleDbParameter() { Value = PRName.Text.Trim() } };
                    OleDbDataReader reader = DBConnection._Read(queryTemp, pars);
                    if (reader.HasRows) { isTemplateExists = true; }
                    reader.Close();

                    if (!isTemplateExists)
                    {
                        string PList = getPDataList();
                        string query = "insert into Privilege (`Template_name`,`PList`) values (?,?)";
                        OleDbParameter[] pars2 = new OleDbParameter[] { 
                                new OleDbParameter() { Value = PRName.Text.Trim() } ,
                                new OleDbParameter() { Value = PList } 
                            };
                        DBConnection._Write(query, pars2);
                        flag = 1;
                    }
                    else
                    {
                        flag =2;
                    }
                }
                else
                {
                    Boolean isTemplateExists = false;
                    //Check UserName
                    String queryTemp = "select ID from Privilege where Template_name=? and ID<>?";
                    OleDbParameter[] pars = new OleDbParameter[] { new OleDbParameter() { Value = PRName.Text.Trim() }, new OleDbParameter() { Value = TID.Text.Trim() } };
                    OleDbDataReader reader = DBConnection._Read(queryTemp, pars);
                    if (reader.HasRows) { isTemplateExists = true; }
                    reader.Close();

                    if (!isTemplateExists)
                    {
                        string PList = getPDataList();
                        string query = "update Privilege set `Template_name`=?, PList=? where ID=?";
                        OleDbParameter[] pars2 = new OleDbParameter[] { 
                                new OleDbParameter() { Value = PRName.Text.Trim() } ,
                                new OleDbParameter() { Value = PList } ,
                                new OleDbParameter() { Value = TID.Text.Trim()} 
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
                LoadPrivilege(String.Empty);
            }
            else if (flag == 2)
            {
                MessageBox.Show("Template Name Already Exists!","Error");
            }
        }
        private string getPDataList()
        {
            String PList ="";
            for (int i = 0; i < PGrid.Rows.Count; i++)
            {
               if(((bool)PGrid[2, i].Value)){
                   PList += PGrid[1,i].Value.ToString() +",";
               }
            }
            return PList;
        }
        private void ClearField()
        {
            PRName.Clear();
            TID.Clear();
            Delete.Visible = false;
            SelectAll.Checked = false;
            CleanPDataToPGrid();

        }
        private void PRTNGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Delete.Visible = true;
                TID.Text = PRTNGrid[0, e.RowIndex].Value.ToString();
                PRName.Text = PRTNGrid[1, e.RowIndex].Value.ToString();

                String PListTempData = "";
                try
                {
                    DBConnection.Open();
                    String query = "select PList from Privilege where ID=?";
                    OleDbParameter[] pars = new OleDbParameter[] { new OleDbParameter() { Value = TID.Text.ToString() } };
                    OleDbDataReader reader = DBConnection._Read(query, pars);
                    if (reader.HasRows)
                    {
                        reader.Read();
                        PListTempData = reader["PList"].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    DBConnection.Close();
                }
                for (int i = 0; i < PGrid.Rows.Count; i++)
                {
                    String suffix = PGrid[1, i].Value.ToString();
                    if (PListTempData.Contains(suffix))
                    {
                        PGrid[2, i].Value = true;
                    }
                    else
                    {
                        PGrid[2, i].Value = false;
                    }
                }
            }
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            int flag = 0;
            try
            {
                DBConnection.Open();
                string query = "delete from Privilege where ID=?";
                OleDbParameter[] pars2 = new OleDbParameter[] { 
                                new OleDbParameter() { Value = TID.Text.Trim()} 
                            };
                DBConnection._Write(query, pars2);
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
                ClearField();
                LoadPrivilege(String.Empty);
            }
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            ClearField();
        }
        private void InitPGrid()
        {
            String PLString = ResourceClass.PLString;
            String PSuffixString = ResourceClass.PSuffixString;
            
            PList = PLString.Split(',');
            PSuffixList = PSuffixString.Split(',');
        }
        private void CleanPDataToPGrid()
        {
            PGrid.Rows.Clear();
            for (int i = 0; i < PList.Length; i++)
            {
                PGrid.Rows.Add((i + 1).ToString(), PSuffixList.GetValue(i).ToString(), false, PList.GetValue(i).ToString());
            }
        }

        private void SelectAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < PGrid.Rows.Count; i++)
            {
                PGrid[2, i].Value = SelectAll.Checked;
            }
        }
    }
}
