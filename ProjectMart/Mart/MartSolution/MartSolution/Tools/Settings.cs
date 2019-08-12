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
    public partial class Settings : Form
    {
        String imagePath = "";
        public Settings()
        {
            InitializeComponent();
        }
        private void BackgroundImageSetting_Load(object sender, EventArgs e)
        {
            //Preferences
            PreferenceInit();
            //Background Setting
            BackgroundSettingInit();
        }
        private void TControlTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TControlTabs.SelectedIndex == 0)
            {
                //Preferences
                this.Height = 360;
            }
            else if (TControlTabs.SelectedIndex == 1)
            {
                //Background Image Settings
                this.Height = 165;
            }
        }
        #region "Options"
        private void PreferenceInit()
        {
            B_BRWidthVal.Value = ResourceClass.ReceiptWidth; //Receipt scale width
            bLimitVal.Value = ResourceClass.TotalBarCodeMin; //Barcode MIN Limit
            U_FormMode.SelectedIndex = ResourceClass.FORMMODE;
            U_FormState.SelectedIndex = ResourceClass.FORMSTATE;
            B_ShowPrintPreViewAfterSave.Checked = ResourceClass.ShowReceiptPreviewAfterSave;
            B_AutoNewTransaction.Checked = ResourceClass.AutoNewTransaction;
            B_AutoPrintINvoice.Checked = ResourceClass.AutoPrintInvoice;
        }
        private void Barcode_Update_Click(object sender, EventArgs e)
        {
            bool isSaved = false;
            try
            {
                DBConnection.Open();
                String query = "UPDATE Setting set value_1='', value_2=? where ID=2";//Barcode Min Limit
                OleDbParameter[] pars = new OleDbParameter[] { 
                        new OleDbParameter() { Value = bLimitVal.Value.ToString() } 
                };
                DBConnection._Write(query, pars);
                isSaved = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                DBConnection.Close();
            }
            if (isSaved)
            {
                ResourceClass.TotalBarCodeMin = Convert.ToInt16(bLimitVal.Value);
                MessageBox.Show("Barcode Limit Updated", "Info");
            }
        }
        private void BillPrinting_Update_Click(object sender, EventArgs e)
        {
            bool isSaved = false;
            try
            {
                DBConnection.Open();
                {
                    String query = "UPDATE Setting set value_1='', value_2='" + B_BRWidthVal.Value.ToString() + "' where ID=3";//Bill Print Scale Width (in px)
                    DBConnection._Write(query);
                }
                {
                    String query = "UPDATE Setting set value_1='', value_2='" + B_ShowPrintPreViewAfterSave.Checked + "' where ID=5";//Bill Print Preview Save
                    DBConnection._Write(query);
                }
                {
                    String query = "UPDATE Setting set value_1='', value_2='" + B_AutoNewTransaction.Checked + "' where ID=6";//Auto New Transaction
                    DBConnection._Write(query);
                }
                {
                    String query = "UPDATE Setting set value_1='', value_2='" + B_AutoPrintINvoice.Checked + "' where ID=7";//Auto Print Invoice
                    DBConnection._Write(query);
                }
                isSaved = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                DBConnection.Close();
            }
            if (isSaved)
            {
                ResourceClass.ReceiptWidth = Convert.ToInt16(B_BRWidthVal.Value);
                ResourceClass.ShowReceiptPreviewAfterSave = B_ShowPrintPreViewAfterSave.Checked;
                ResourceClass.AutoNewTransaction = B_AutoNewTransaction.Checked;
                ResourceClass.AutoPrintInvoice = B_AutoPrintINvoice.Checked;

                MessageBox.Show("Bill Printing (Preview) New Value Update", "Info");
            }
        }
        private void U_Update_Click(object sender, EventArgs e)
        {
            bool isSaved = false;
            try
            {
                DBConnection.Open();
                String query = "UPDATE Setting set value_1=?, value_2=? where ID=4";//Bill Print Scale Width (in px)
                OleDbParameter[] pars = new OleDbParameter[] { 
                        new OleDbParameter() { Value = U_FormMode.SelectedIndex.ToString() } ,
                         new OleDbParameter() { Value = U_FormState.SelectedIndex.ToString() } 
                };
                DBConnection._Write(query, pars);
                isSaved = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                DBConnection.Close();
            }
            if (isSaved)
            {
                ResourceClass.FORMMODE = U_FormMode.SelectedIndex;
                ResourceClass.FORMSTATE = U_FormState.SelectedIndex;
                MessageBox.Show("User Interface New Value Update", "Info");
            }
        }
        #endregion
        #region "Background Settings"
        private void BSave_Click(object sender, EventArgs e)
        {
            bool isSaved = false;
            try
            {
                DBConnection.Open();
                String query = "UPDATE Setting set value_1=?, value_2=? where ID=1";
                OleDbParameter[] pars = new OleDbParameter[] { 
                        new OleDbParameter() { Value = mode_.SelectedIndex.ToString() },
                        new OleDbParameter() { Value = imgtextbox.Text.ToString() } 
                };
                DBConnection._Write(query,pars);
                isSaved = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                DBConnection.Close();
            }
            if (isSaved)
            {
                MainForm.mainForm.LoadPBImage();
            }
        }
        private void BackgroundSettingInit()
        {
            try
            {
                DBConnection.Open();
                OleDbDataReader reader = DBConnection._Read("select * from `Setting` where ID=1");
                reader.Read();
                if (reader.HasRows)
                {
                    imagePath = reader["value_2"].ToString();
                    mode_.SelectedIndex = Convert.ToInt16(reader["value_1"].ToString());
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                DBConnection.Close();
            }
            imgtextbox.Text = imagePath;
        }
        private void BBrowseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFileDialog = new OpenFileDialog();
            oFileDialog.Filter = "Image File|*.png;*.jpg;*.jpeg";
            oFileDialog.Title = "browse image file";
            if (oFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                imgtextbox.Text = oFileDialog.FileName;
            }
        }
        private void BClearBtn_Click(object sender, EventArgs e)
        {
            imgtextbox.Clear();
        }
        #endregion       
    }
}
