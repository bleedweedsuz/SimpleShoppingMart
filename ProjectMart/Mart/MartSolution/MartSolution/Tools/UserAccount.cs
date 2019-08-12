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
    public partial class UserAccount : Form
    {
        public UserAccount()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            int flag = 0;
            try
            {
                if (!NewPass.Text.Trim().Equals(RePass.Text.Trim()))
                {
                    MessageBox.Show("Re-Password doesnot match!", "Error");
                    return;
                }
                Boolean IsOldPassExists = false;
                DBConnection.Open();
                String query = "select `User_name` from `EmployeeInformation` where `User_pass`=? and `ID`=?";
                OleDbParameter[] pars = new OleDbParameter[] { 
                        new OleDbParameter() { Value = OldPass.Text.ToString() },
                        new OleDbParameter() { Value = MainForm.USERID.ToString() } 
                };
                OleDbDataReader reader = DBConnection._Read(query, pars);
                if (reader.HasRows)
                {
                    IsOldPassExists = true;
                }
                reader.Close();

                if (IsOldPassExists)
                {
                    String query2 = "update EmployeeInformation set User_pass=? where ID=?";
                    OleDbParameter[] parsLists = new OleDbParameter[]{
                        new OleDbParameter { Value = NewPass.Text.Trim()},
                        new OleDbParameter { Value = MainForm.USERID.ToString()}
                    };
                    DBConnection._Write(query2, parsLists);
                    flag = 1;
                }
                else
                {
                    flag = 0;
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

            if (flag == 0)
            {
                MessageBox.Show("Old Password Doesnot Match!", "Error");
            }
            else if (flag == 1)
            {
                MessageBox.Show("New Password Updated!", "Info");
            }
        }
        private void UserAccount_Load(object sender, EventArgs e)
        {
            LoadUser();
        }
        private void LoadUser()
        {
            try
            {
                DBConnection.Open();
                String query = "select `User_name` from `EmployeeInformation` where `ID`=?";
                OleDbParameter[] pars = new OleDbParameter[] { new OleDbParameter() { Value = MainForm.USERID.ToString() } };
                OleDbDataReader reader = DBConnection._Read(query, pars);
                if (reader.HasRows)
                {
                    reader.Read();
                    UserName.Text = reader[0].ToString();
                }
                reader.Close();
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
    }
}
