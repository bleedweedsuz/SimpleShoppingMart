using Microsoft.Win32;
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

namespace MartSolution
{
    public partial class LoginForm : Form
    {
        private Point OrgLocation = new Point(12, 12);
        private Point OtherLocation = new Point(1000, 1000);
        public int countLogin = 4;
        public static LoginForm loginForm;
        public LoginForm()
        {
            InitializeComponent();
            loginForm = this;
        }
        private void Login_Click(object sender, EventArgs e)
        {
            LoginData();
        }
        private void LoginData()
        {
            if (UserName.Text.Trim() == "" || Password.Text.Trim() == "")
            {
                return;
            }
            int flag = 0;
            int userID=0;
            String EName = "";
            try
            {
                DBConnection.Open();
                String query = "select ID,Name from EmployeeInformation where User_name=? and User_pass=?";
                OleDbParameter[] pars = new OleDbParameter[] { 
                    new OleDbParameter() { Value = UserName.Text.Trim() },
                    new OleDbParameter() { Value = Password.Text.Trim() } 
                };
                OleDbDataReader reader = DBConnection._Read(query, pars);
                if (reader.HasRows)
                {
                    reader.Read();
                    userID = Convert.ToInt16(reader["ID"].ToString());
                    EName = reader["name"].ToString();
                    reader.Close();
                    flag = 1;
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
                this.Hide();
                MainForm.USERID = userID;
                MainForm MF = new MainForm();
                MF.EmployeeName = EName;
                MF.Show();
            }
            else
            {
                countLogin--;
                Login.Text = "Login [" + countLogin + "]";
                MessageBox.Show("User Name & Password Doesnot Match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (countLogin <= 0)
                {
                    this.Close();
                }
            }
        }
        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                LoginData();
            }
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            AppDescription.Text = ResourceClass.APPDESCRIPTION;
            CheckRegistryExists();
        }
        //REGISTRY WORKS
        private void CheckRegistryExists()
        {
            try
            {
                //check data in register
                RegistryKey Rkey = Registry.CurrentUser.OpenSubKey(ResourceClass.REGKEYPATH);
                if (Rkey != null)
                {
                    //found
                    Object KVal = Rkey.GetValue(ResourceClass.REGKEY_KEY);

                    if (KVal != null)
                    {
                        String KeyValue = KVal.ToString();
                        //Check if the key is proper or not check in database
                        if (!KeyValue.Equals(String.Empty))
                        {
                            String EKeyValue = KeyValue;
                            if (CheckIfKeyExists(EKeyValue))
                            {
                                CallLoginForm();
                            }
                            else
                            {
                                MessageBox.Show("Product Key Error. Please Contact to System Admin and ask for Product key", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                CallLicenseForm();
                            }
                        }
                        else
                        {
                            //not found
                            MessageBox.Show("Product Key Error. Please Contact to System Admin and ask for Product key", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            CallLicenseForm();
                        }
                    }
                    else
                    {
                        //not found
                        CallLicenseForm();
                    }
                }
                else
                {
                    //not found
                    CallLicenseForm();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void CallLicenseForm()
        {
            this.Text = "Enter Product Key";
            LoginPanel.Location = OtherLocation;
            LoginPanel.Enabled = false;
            LicenseRegisterPanel.Location = OrgLocation;
            LicenseRegisterPanel.Focus();
        }
        private void CallLoginForm()
        {
            this.Text = "Mart Solution Login Form";
            LicenseRegisterPanel.Location = OtherLocation;
            LicenseRegisterPanel.Enabled = false;

            LoginPanel.Location = OrgLocation;
            LoginPanel.Focus();
        }
        private bool CheckIfKeyExists(String KEY)
        {
            bool isKeyExists = false;
            try
            {
                //ONLY 40 KEYS MADE
                DBConnection.Open();
                String query = "select KEY from KeyBox where KEY=?";
                OleDbDataReader reader = DBConnection._Read(query, new OleDbParameter[] { new OleDbParameter() { Value = KEY} });
                if (reader.HasRows)
                {
                    isKeyExists = true;
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
            return isKeyExists;
        }
        private void RegisterProductKey_Click(object sender, EventArgs e)
        {
            String KeyValue = Pkey.Text.Trim();
            if (KeyValue.Equals(String.Empty)) { return; }

            String EKeyValue = UtilityClass.EncryptText(KeyValue, ResourceClass.ENCRYPTKEY);
            if (CheckIfKeyExists(EKeyValue))
            {
                //Cereate New Registry sub and insert pure key
                RegistryKey key = Registry.CurrentUser.CreateSubKey(ResourceClass.REGKEYPATH);
                key.SetValue(ResourceClass.REGKEY_KEY, EKeyValue);
                key.Close();

                MessageBox.Show("Thank you for using our product.\n\nApplication will restart......", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
                Application.Restart();
            }
            else
            {
                countLogin--;
                RegisterProductKey.Text = "Register [ " + countLogin + " ]";
                Pkey.BackColor = Color.Tomato;
                PTimerLicense.Start();
                Pkey.Focus();
            }

            if (countLogin <= 0)
            {
                MessageBox.Show("You Enter too many times Applicating is closing.... :(", "!@#$%^&*(!@#$%^&...... ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Close();
            }
        }
        private void PTimerLicense_Tick(object sender, EventArgs e)
        {
            PTimerLicense.Stop();
            Pkey.BackColor = Color.White;
        }
        private void Pkey_TextChanged(object sender, EventArgs e)
        {
            if (Pkey.Text.Length >= 19)
            {
                RegisterProductKey.Enabled = true;
            }
            else
            {
                RegisterProductKey.Enabled = false;
            }
        }
    }
}
