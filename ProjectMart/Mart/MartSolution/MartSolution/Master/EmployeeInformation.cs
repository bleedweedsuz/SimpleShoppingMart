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
    public partial class EmployeeInformation : Form
    {
        List<PItems> pItems;
        public EmployeeInformation()
        {
            InitializeComponent();
        }
        private void EmployeeInformation_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.Clone() as Icon;
            MaritalStatus.SelectedIndex = 0;
            PrivilegeList();
            Gender.SelectedIndex = 0;
            BloodGroup.SelectedIndex = 0;
            ShowEmployeeList("");
        }
        private void PCheck()
        {
            String suffix = "MEIVUP";
            if (ResourceClass.CurrentPSuffixString.Contains(suffix))
            {
                ViewPass.Visible = true;
            }
        }
        private void PrivilegeList()
        {
            try
            {
                pItems = new List<PItems>();
                Role.Items.Clear();

                DBConnection.Open();
                String query = "select * from Privilege";
                OleDbDataReader reader = DBConnection._Read(query);
                int row = 0;
                while (reader.Read())
                {
                    pItems.Add(new PItems(Convert.ToInt16(reader[0]),reader[1].ToString(),reader[2].ToString()));
                    Role.Items.Add(reader[1].ToString());
                    row += 1;
                    Role.SelectedIndex = 0;
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
            int flag = 0;
            try
            {
                //Checking Important Fields
                if (NameText.Text.Trim() == String.Empty || UserName.Text.Trim() == String.Empty || NewPassword.Text.Trim() == String.Empty || RePassword.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Fill Form Correctly!", "Error");
                    return;
                }
                else if (NewPassword.Text != RePassword.Text)
                {
                    MessageBox.Show("Password Doesnot Match!", "Error");
                    return;
                }
                //----------->
                DBConnection.Open();
                //Insert Data
                if (EID.Text.Trim().Equals(String.Empty))
                {
                    Boolean isUserExists = false;
                    //Check UserName
                    String queryTemp = "select * from `EmployeeInformation` where User_name=@needle";
                    OleDbParameter[] pars = new OleDbParameter[] { new OleDbParameter() { Value = UserName.Text.Trim() } };
                    OleDbDataReader reader = DBConnection._Read(queryTemp, pars);
                    if (reader.HasRows) { isUserExists = true; }
                    reader.Close();

                    if (!isUserExists)
                    {
                        //Insert EmployeeInformation
                        queryTemp = "Insert into `EmployeeInformation` (`Name`,`Date_of_birth`,`Marital_status`,`Role`,`Gender`,`Blood_group`,`Phone`,`Email`,`Address`,`Join_date`,`User_name`,`User_pass`,`Last_login`,`Status`) values (?,?,?,?,?,?,?,?,?,?,?,?,?,1)";
                        OleDbParameter[] parsLists = new OleDbParameter[]{
                            new OleDbParameter { Value = NameText.Text.Trim()},
                            new OleDbParameter { Value = DateOfBirth.Value.ToString()},
                            new OleDbParameter { Value = MaritalStatus.Text.Trim()},
                            new OleDbParameter { Value = pItems[Role.SelectedIndex].ID},
                            new OleDbParameter { Value = Gender.Text.Trim()},
                            new OleDbParameter { Value = BloodGroup.Text.Trim()},
                            new OleDbParameter { Value = Phone.Text.Trim()},
                            new OleDbParameter { Value = Email.Text.Trim()},
                            new OleDbParameter { Value = Address.Text.Trim()},
                            new OleDbParameter { Value = JoinDate.Value.ToString()},
                            new OleDbParameter { Value = UserName.Text.Trim()},
                            new OleDbParameter { Value = NewPassword.Text.Trim()},
                            new OleDbParameter { Value = "1/1/2000"},
                            new OleDbParameter { Value = "0"}
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
                    Boolean isUserExists = false;
                    //Check UserName
                    String queryTemp = "select * from `EmployeeInformation` where User_name = ? and ID <> ?";
                    OleDbParameter[] pars = new OleDbParameter[] { new OleDbParameter() { Value = UserName.Text.Trim() }, new OleDbParameter() { Value = EID.Text.Trim() } };
                    OleDbDataReader reader = DBConnection._Read(queryTemp, pars);
                    if (reader.HasRows) { isUserExists = true; }
                    reader.Close();

                    if (!isUserExists)
                    {
                        queryTemp = "update `EmployeeInformation` set `Name`=?,`Date_of_birth`=?,`Marital_status`=?,`Role`=?,`Gender`=?,`Blood_group`=?,`Phone`=?,`Email`=?,`Address`=?,`Join_date`=?,`User_name`=?,`User_pass`=? where `ID`=?";
                        OleDbParameter[] parsLists = new OleDbParameter[]{
                            new OleDbParameter { Value = NameText.Text.Trim()},
                            new OleDbParameter { Value = DateOfBirth.Value.ToString()},
                            new OleDbParameter { Value = MaritalStatus.Text.Trim()},
                            new OleDbParameter { Value = pItems[Role.SelectedIndex].ID},
                            new OleDbParameter { Value = Gender.Text.Trim()},
                            new OleDbParameter { Value = BloodGroup.Text.Trim()},
                            new OleDbParameter { Value = Phone.Text.Trim()},
                            new OleDbParameter { Value = Email.Text.Trim()},
                            new OleDbParameter { Value = Address.Text.Trim()},
                            new OleDbParameter { Value = JoinDate.Value.ToString()},
                            new OleDbParameter { Value = UserName.Text.Trim()},
                            new OleDbParameter { Value = NewPassword.Text.Trim()},
                            new OleDbParameter { Value = EID.Text.Trim()}
                        };
                        DBConnection._Write(queryTemp, parsLists);
                        flag = 1;
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
            if (flag==1)
            {
                ClearField();
                ShowEmployeeList("");
            }
            else if (flag == 2)
            {
                MessageBox.Show("User Name Already Exists.", "Error");
            }
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            ClearField();
        }
        private void ClearField()
        {
            RolePanel.BackColor = Color.White;
            Delete.Visible = false;
            EID.Clear();
            NameText.Clear();
            MaritalStatus.SelectedIndex = 0;
            if (Role.Items.Count > 0)
            {
                Role.SelectedIndex = 0;
            }
            Gender.SelectedIndex = 0;
            BloodGroup.SelectedIndex = 0;
            Phone.Clear();
            Email.Clear();
            Address.Clear();
            UserName.Clear();
            NewPassword.Clear();
            RePassword.Clear();
            ViewPass.Visible = false;
            InvisiblePassStore.Clear();
        }
        private void ShowEmployeeList(String needle)
        {
            try
            {
                EGrid.Rows.Clear();
                DBConnection.Open();
                String query = "";
                if (CheckGarbage.Checked)
                {
                   query = "select * from EmployeeInformation where Name LIKE @needle + '%' order by ID desc;";
                }
                else
                {
                    query = "select * from EmployeeInformation where Name LIKE @needle + '%' and `Status`=1 order by ID desc;";
                }
                OleDbParameter[] pars = new OleDbParameter[] { new OleDbParameter() { Value = needle } };
                OleDbDataReader reader = DBConnection._Read(query, pars);
                int row = 0;
                while (reader.Read())
                {
                    int rID = Convert.ToInt16(reader[4]);
                    String RoleTemplate = "Not Set";
                    String query2 = "select Template_name from Privilege where ID=?";
                    OleDbParameter[] pars2 = new OleDbParameter[] { 
                        new OleDbParameter() { Value = rID }
                    };
                    OleDbDataReader reader2 = DBConnection._Read(query2, pars2);
                    if (reader2.HasRows)
                    {
                        reader2.Read();
                        RoleTemplate = reader2[0].ToString();
                    }
                    else
                    {
                        rID = 0;
                    }
                    reader2.Close();
                    //------------------>
                    EGrid.Rows.Add(reader[0], reader[1], reader[2], reader[3], rID.ToString(), RoleTemplate, reader[5], reader[6], reader[7], reader[8], reader[9], reader[10], reader[11], "********", reader[12], reader[14]);
                    if (reader[14].ToString() == "0")
                    {
                        EGrid[1, row].Style.BackColor = Color.Tomato;
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
        private void EGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (EGrid[15, e.RowIndex].Value.ToString() == "1") { Delete.Visible = true; } else { Delete.Visible = false; }
                PCheck();
                EID.Text = EGrid[0, e.RowIndex].Value.ToString();
                NameText.Text = EGrid[1,e.RowIndex].Value.ToString();
                DateOfBirth.Value = DateTime.Parse(EGrid[2, e.RowIndex].Value.ToString());
                MaritalStatus.Text  = EGrid[3,e.RowIndex].Value.ToString();
                if (EGrid[4, e.RowIndex].Value.ToString().Equals("0")) { RolePanel.BackColor = Color.Tomato; } else { RolePanel.BackColor = Color.White; }
                Role.Text  = EGrid[5,e.RowIndex].Value.ToString();
                Gender.Text  = EGrid[6,e.RowIndex].Value.ToString();
                BloodGroup.Text  = EGrid[7,e.RowIndex].Value.ToString();
                Phone.Text  = EGrid[8,e.RowIndex].Value.ToString();
                Email.Text  = EGrid[9,e.RowIndex].Value.ToString();
                Address.Text  = EGrid[10,e.RowIndex].Value.ToString();
                JoinDate.Value = DateTime.Parse(EGrid[11, e.RowIndex].Value.ToString());
                UserName.Text  = EGrid[12,e.RowIndex].Value.ToString();
                NewPassword.Text = EGrid[14, e.RowIndex].Value.ToString();
                RePassword.Text = EGrid[14, e.RowIndex].Value.ToString();
                InvisiblePassStore.Text = EGrid[14, e.RowIndex].Value.ToString();
            }
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            int flag = 0;
            try
            {
                DBConnection.Open();
                String queryTemp = "update `EmployeeInformation` set `Status`=0 where `ID`=?";
                OleDbParameter[] parsLists = new OleDbParameter[]{
                            new OleDbParameter { Value = EID.Text.Trim()}
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
                ShowEmployeeList("");
            }
        }
        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            ShowEmployeeList(SearchText.Text.Trim());
        }
        private void CheckGarbage_CheckedChanged(object sender, EventArgs e)
        {
            ShowEmployeeList(SearchText.Text.Trim());
        }
        private void ViewPass_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selected Password Is [ " + InvisiblePassStore.Text.Trim() + " ]", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void EmployeeInformation_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ResourceClass.FORMMODE == 0)
            {
                ResourceClass.employeeInformation = null;
            }
        }
    }
    public class PItems
    {
        public int ID;
        public String TName;
        public String PList;
        public PItems(int ID, String TName,String PList)
        {
            this.ID = ID;
            this.TName = TName;
            this.PList = PList;
        }
    }
}
