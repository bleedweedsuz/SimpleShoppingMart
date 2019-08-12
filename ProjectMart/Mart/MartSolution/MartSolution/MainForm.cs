/*Copyright (C) Sujan Thapa - All Rights Reserved
Unauthorized copying of this file, via any medium is strictly prohibited
Proprietary and confidential
Written by Sujan Thapa <suz_47@outlook.com>, 2017
*/

using MartSolution.Master;
using MartSolution.Report;
using MartSolution.Tools;
using MartSolution.Transaction;
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
    public partial class MainForm : Form
    {
        public static MainForm mainForm;
        public static int USERID;
        public String EmployeeName;
        public MainForm()
        {
            InitializeComponent();
            mainForm = this;
        }
        private void aboutMartSolutionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }
        private void databaseManipulationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DatabaseManipulation().ShowDialog();
        }
        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseInvoice P = new PurchaseInvoice();
            P.MdiParent = this;
            P.Show();
        }
        private void cascadeViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = ResourceClass.APPNAME;
            SetBackColorMDI();
            AppDescription.Text = ResourceClass.APPDESCRIPTION;
            Timer_.Start();
            LoginUserName.Text = "Login User:[ " + EmployeeName + " ]";
            LoadPrivilegeTemplate();
            CheckIfCloseAccountExistsOrNot(DateTime.Now.ToShortDateString());
            LoadSettingDataToResourcesValue();
            LoadPBImage();
        }
        private void organizationInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new OrganizationInformation().ShowDialog();
        }
        private void userAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
           new UserAccount().ShowDialog();
        }
        public void LoadPBImage()
        {
            String imgPath = "";
            ImageLayout iLayout = ImageLayout.None;
            int layoutVal = 0;
            try
            {
                DBConnection.Open();
                OleDbDataReader reader = DBConnection._Read("select * from Setting where ID=1");
                reader.Read();
                if (reader.HasRows)
                {
                    layoutVal = Convert.ToInt16(reader["value_1"]);
                    imgPath = reader["value_2"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DBConnection.Close();
            }
            //----------->
            if (layoutVal == 0)
            {
                iLayout = ImageLayout.None;
            }
            else if (layoutVal == 1)
            {
                iLayout = ImageLayout.Center;
            }
            else if (layoutVal == 2)
            {
                iLayout = ImageLayout.Stretch;
            }
            else if (layoutVal == 3)
            {
                iLayout = ImageLayout.Tile;
            }
            else if (layoutVal == 4)
            {
                iLayout = ImageLayout.Zoom;
            }
            //-------------->
            this.Refresh();
            if (!imgPath.Equals(""))
            {
                if (System.IO.File.Exists(imgPath))
                {
                    this.BackgroundImage = Image.FromFile(imgPath);
                    this.BackgroundImageLayout = iLayout;
                }
                else
                {
                    this.BackgroundImage = MartSolution.Properties.Resources.unknown;
                    this.BackgroundImageLayout = ImageLayout.Center;
                }
            }
            else
            {
                this.BackgroundImage = MartSolution.Properties.Resources.martsolutionback;
                this.BackgroundImageLayout = ImageLayout.Center;
            }
        }
        private void EI_Click(object sender, EventArgs e)
        {
            employeeInformationToolStripMenuItem_Click(sender, e);
        }
        private void II_Click(object sender, EventArgs e)
        {
            itemInformationToolStripMenuItem_Click(sender, e);
        }
        private void IRI_Click(object sender, EventArgs e)
        {
            itemRateInformationToolStripMenuItem_Click(sender, e);
        }
        private void INI_Click(object sender, EventArgs e)
        {
            inventoryInformationToolStripMenuItem_Click(sender, e);
        }
        private void PI_Click(object sender, EventArgs e)
        {
            purchaseInvoiceToolStripMenuItem_Click(sender, e);
        }
        private void BI_Click(object sender, EventArgs e)
        {
            billInvoiceToolStripMenuItem_Click(sender, e);
        }
        private void toolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolBarToolStripMenuItem.Checked)
            {
                toolBarToolStripMenuItem.Checked = false;
                toolBarToolStripMenuItem1.Checked = false;
                mainToolStrip.Visible = false;
            }
            else
            {
                toolBarToolStripMenuItem.Checked = true;
                toolBarToolStripMenuItem1.Checked = true;
                mainToolStrip.Visible = true;
            }
        }
        private void employeeInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ResourceClass.FORMMODE == 0) 
            {
                if (ResourceClass.employeeInformation == null)
                {
                    ResourceClass.employeeInformation = new EmployeeInformation();
                    ResourceClass.employeeInformation.MdiParent = this;
                    ReSizeFormState(ResourceClass.employeeInformation);
                    ResourceClass.employeeInformation.Show();
                }
                else
                {
                    ResourceClass.employeeInformation.Focus();
                }
            }
            else
            {
                EmployeeInformation EI = new EmployeeInformation();
                ReSizeFormState(EI);
                EI.MdiParent = this;
                EI.Show();
            }
        }
        private void itemInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ResourceClass.FORMMODE == 0)
            {
                if (ResourceClass.itemInformation == null)
                {
                    ResourceClass.itemInformation = new ItemInformation();
                    ResourceClass.itemInformation.MdiParent = this;
                    ReSizeFormState(ResourceClass.itemInformation);
                    ResourceClass.itemInformation.Show();
                }
                else
                {
                    ResourceClass.itemInformation.Focus();
                }
            }
            else
            {
                ItemInformation II = new ItemInformation();
                ReSizeFormState(II);
                II.MdiParent = this;
                II.Show();
            }
        }
        private void itemRateInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ResourceClass.FORMMODE == 0)
            {
                if (ResourceClass.itemRateInformation == null)
                {
                    ResourceClass.itemRateInformation = new ItemRateInformation();
                    ResourceClass.itemRateInformation.MdiParent = this;
                    ReSizeFormState(ResourceClass.itemRateInformation);
                    ResourceClass.itemRateInformation.Show();
                }
                else
                {
                    ResourceClass.itemRateInformation.Focus();
                }
            }
            else
            {
                ItemRateInformation IRI = new ItemRateInformation();
                ReSizeFormState(IRI);
                IRI.MdiParent = this;
                IRI.Show();
            }
        }
        private void purchaseInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ResourceClass.ISClosedAccount)
            {
                if (ResourceClass.FORMMODE == 0)
                {
                    if (ResourceClass.purchaseInvoice == null)
                    {
                        ResourceClass.purchaseInvoice = new PurchaseInvoice();
                        ResourceClass.purchaseInvoice.MdiParent = this;
                        ReSizeFormState(ResourceClass.purchaseInvoice);
                        ResourceClass.purchaseInvoice.Show();
                    }
                    else
                    {
                        ResourceClass.purchaseInvoice.Focus();
                    }
                }
                else
                {
                    PurchaseInvoice PI = new PurchaseInvoice();
                    ReSizeFormState(PI);
                    PI.MdiParent = this;
                    PI.Show();
                }
            }
            else
            {
                MessageBox.Show("Today Account Is Closed. System won't accepet purchase invoice", "Error");
            }
        }
        private void billInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ResourceClass.ISClosedAccount)
            {
                if (ResourceClass.FORMMODE == 0)
                {
                    if (ResourceClass.billInvoice == null)
                    {
                        ResourceClass.billInvoice = new BillInvoice();
                        ResourceClass.billInvoice.MdiParent = this;
                        ReSizeFormState(ResourceClass.billInvoice);
                        ResourceClass.billInvoice.Show();
                    }
                    else
                    {
                        ResourceClass.billInvoice.Focus();
                    }
                }
                else
                {
                    BillInvoice BI = new BillInvoice();
                    ReSizeFormState(BI);
                    BI.MdiParent = this;
                    BI.Show();
                }
            }
            else
            {
                MessageBox.Show("Today Account Is Closed. System won't accepet bill invoice", "Error");
            }
        }
        private void inventoryInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ResourceClass.FORMMODE == 0)
            {
                if (ResourceClass.inventoryInformation == null)
                {
                    ResourceClass.inventoryInformation = new InventoryInformation();
                    ResourceClass.inventoryInformation.MdiParent = this;
                    ReSizeFormState(ResourceClass.inventoryInformation);
                    ResourceClass.inventoryInformation.Show();
                }
                else
                {
                    ResourceClass.inventoryInformation.Focus();
                }
            }
            else
            {
                InventoryInformation INI = new InventoryInformation();
                ReSizeFormState(INI);
                INI.MdiParent = this;
                INI.Show();
            }
        }
        private void supplierInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ResourceClass.FORMMODE == 0)
            {
                if (ResourceClass.supplierInformation == null)
                {
                    ResourceClass.supplierInformation = new SupplierInformation();
                    ResourceClass.supplierInformation.MdiParent = this;
                    ReSizeFormState(ResourceClass.supplierInformation);
                    ResourceClass.supplierInformation.Show();
                }
                else
                {
                    ResourceClass.supplierInformation.Focus();
                }
            }
            else
            {
                SupplierInformation SI = new SupplierInformation();
                ReSizeFormState(SI);
                SI.MdiParent = this;
                SI.Show();
            }
        }
        private void SI_Click(object sender, EventArgs e)
        {
            supplierInformationToolStripMenuItem_Click(sender, e);
        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm.loginForm.Close();
        }
        private void LoadPrivilegeTemplate()
        {
            int flag = 0;
            try
            {
                ResourceClass.CurrentPSuffixString = String.Empty;
                DBConnection.Open();
                String query = "select Privilege.PList from Privilege INNER JOIN EmployeeInformation on Privilege.ID=EmployeeInformation.Role where EmployeeInformation.ID=?";
                OleDbParameter[] pars = new OleDbParameter[] { new OleDbParameter() { Value = MainForm.USERID } };
                OleDbDataReader reader = DBConnection._Read(query, pars);
                if (reader.HasRows)
                {
                    reader.Read();
                    ResourceClass.CurrentPSuffixString = reader["PList"].ToString();
                    flag = 1;
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

            DisableHideToolStripMenu();

            if (flag == 1)
            {
                //------------>
                Array PSuffixList = ResourceClass.PSuffixString.Split(',');
                for (int i = 0; i < PSuffixList.Length; i++)
                {
                    String currentSuffix = PSuffixList.GetValue(i).ToString();
                    if (ResourceClass.CurrentPSuffixString.Contains(currentSuffix))
                    {
                        switch (currentSuffix)
                        {
                            case "MEI":
                                    employeeInformationToolStripMenuItem.Enabled = true;
                                    employeeInformationToolStripMenuItem.Visible = true;
                                    EI.Visible = true;
                                break;
                            case "MEIVUP":
                                    //do nothing
                                break;
                            case "MII":
                                    itemInformationToolStripMenuItem.Enabled = true;
                                    itemInformationToolStripMenuItem.Visible = true;
                                    II.Visible = true;
                                break;
                            case "MIRI":
                                    itemRateInformationToolStripMenuItem.Enabled = true;
                                    itemRateInformationToolStripMenuItem.Visible = true;
                                    IRI.Visible = true;
                                break;
                            case "MSI":
                                    supplierInformationToolStripMenuItem.Visible = true;
                                    supplierInformationToolStripMenuItem.Enabled = true;
                                    SI.Visible = true;
                                break;
                            case "MIVI":
                                    inventoryInformationToolStripMenuItem.Visible = true;
                                    inventoryInformationToolStripMenuItem.Enabled = true;
                                    INI.Visible = true;
                                break;
                            case "MPI":
                                    purchaseInvoiceToolStripMenuItem.Visible = true;
                                    purchaseInvoiceToolStripMenuItem.Enabled = true;
                                    PI.Visible = true;
                                break;
                            case "MBI":
                                     billInvoiceToolStripMenuItem.Visible = true;
                                     billInvoiceToolStripMenuItem.Enabled = true;
                                     BI.Visible = true;
                                break;
                            case "MSIN":
                                    searchInvoiceToolStripMenuItem.Visible = true;
                                    searchInvoiceToolStripMenuItem.Enabled = true;
                                    SIN.Visible = true;
                                break;
                            case "TDECO":
                                dayEndCloseOutToolStripMenuItem.Enabled = true;
                                dayEndCloseOutToolStripMenuItem.Visible = true;
                                break;
                            case "RSR":
                                    salesReportToolStripMenuItem.Visible = true;
                                break;
                            case "RPR":
                                    purchaseReportToolStripMenuItem.Visible = true;
                                break;
                            case "RIR":
                                    inventoryReportToolStripMenuItem.Visible = true;
                                break;
                            case "TOI":
                                    organizationInformationToolStripMenuItem.Visible = true;
                                break;
                            case "TS":
                                    settingsToolStripMenuItem.Visible = true;
                                    settingsToolStripMenuItem1.Enabled = true;
                                break;
                            case "TUPR":
                                     userPrivilegeRoleToolStripMenuItem.Visible = true;
                                break;
                            case "TUA":
                                     userAccountToolStripMenuItem.Visible = true;
                                break;
                            case "TD":
                                     databaseToolStripMenuItem.Visible = true;
                                break;
                            case "TL":
                                    logoutToolStripMenuItem.Visible = true;
                                    logoutToolStripMenuItem1.Enabled = true;
                                break;
                            default: break;
                        }
                    }
                }
            }
        }
        private void DisableHideToolStripMenu()
        {

            //made invisible to all control
            employeeInformationToolStripMenuItem.Visible = false;
            employeeInformationToolStripMenuItem.Enabled = false;
            EI.Visible = false;

            itemInformationToolStripMenuItem.Visible = false;
            itemInformationToolStripMenuItem.Enabled = false;
            II.Visible = false;

            itemRateInformationToolStripMenuItem.Visible = false;
            itemRateInformationToolStripMenuItem.Enabled = false;
            IRI.Visible = false;

            supplierInformationToolStripMenuItem.Visible = false;
            supplierInformationToolStripMenuItem.Enabled = false;
            SI.Visible = false;

            inventoryInformationToolStripMenuItem.Visible = false;
            inventoryInformationToolStripMenuItem.Enabled = false;
            INI.Visible = false;

            purchaseInvoiceToolStripMenuItem.Visible = false;
            purchaseInvoiceToolStripMenuItem.Enabled = false;
            PI.Visible = false;

            billInvoiceToolStripMenuItem.Visible = false;
            billInvoiceToolStripMenuItem.Enabled = false;
            BI.Visible = false;

            searchInvoiceToolStripMenuItem.Visible = false;
            searchInvoiceToolStripMenuItem.Enabled = false;
            SIN.Visible = false;

            salesReportToolStripMenuItem.Visible = false;
            purchaseReportToolStripMenuItem.Visible = false;
            inventoryReportToolStripMenuItem.Visible = false;

            dayEndCloseOutToolStripMenuItem.Visible = false;
            dayEndCloseOutToolStripMenuItem.Enabled = false;


            organizationInformationToolStripMenuItem.Visible = false;
            userPrivilegeRoleToolStripMenuItem.Visible = false;
            settingsToolStripMenuItem.Visible = false;
            settingsToolStripMenuItem1.Enabled = false;
            userPrivilegeRoleToolStripMenuItem.Visible = false;
            userAccountToolStripMenuItem.Visible = false;
            databaseToolStripMenuItem.Visible = false;
            logoutToolStripMenuItem.Visible = false;
            logoutToolStripMenuItem1.Enabled = false;
        }
        private void userPrivilegeRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UserPrivilegeRole().ShowDialog();
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm.loginForm.Close();
        }
        private void Timer__Tick(object sender, EventArgs e)
        {
            DateTimeToolStripStatusLabel.Text = "Date Time: " + DateTime.Now.ToShortDateString() + " " +DateTime.Now.ToLongTimeString();
        }
        private void SetBackColorMDI()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                {
                    ctrl.BackColor = Color.FromArgb(255, 255,255,255);
                }
            }
        }
        private void toolBarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            toolBarToolStripMenuItem_Click(sender, e);
        }
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetBackColorMDI();
            LoadPBImage();
            LoadPrivilegeTemplate();
        }
        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            logoutToolStripMenuItem_Click(sender, e);
        }
        private void searchInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ResourceClass.FORMMODE == 0)
            {
                if (ResourceClass.searchInvoice == null)
                {
                    ResourceClass.searchInvoice = new SearchInvoice();
                    ResourceClass.searchInvoice.MdiParent = this;
                    ReSizeFormState(ResourceClass.searchInvoice);
                    ResourceClass.searchInvoice.Show();
                }
                else
                {
                    ResourceClass.searchInvoice.Focus();
                }
            }
            else
            {
                SearchInvoice SI = new SearchInvoice();
                ReSizeFormState(SI);
                SI.MdiParent = this;
                SI.Show();
            }
        }
        private void purchaseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllReportForm purchaseReportForm = new AllReportForm();
            purchaseReportForm.StartPosition = FormStartPosition.CenterScreen;
            purchaseReportForm.reportType = AllReportForm.ReportType.PURCHASE_REPORT;
            purchaseReportForm.ShowDialog();
        }
        private void salesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllReportForm saleReportForm = new AllReportForm();
            saleReportForm.StartPosition = FormStartPosition.CenterScreen;
            saleReportForm.reportType = AllReportForm.ReportType.SALES_REPORT;
            saleReportForm.ShowDialog();
        }
        private void inventoryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllReportForm inventoryReportForm = new AllReportForm();
            inventoryReportForm.StartPosition = FormStartPosition.CenterScreen;
            inventoryReportForm.reportType = AllReportForm.ReportType.INVENTORY_REPORT;
            inventoryReportForm.ShowDialog();
        }
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Settings().ShowDialog();
        }
        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Settings().ShowDialog();
        }
        private void dayEndCloseOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DayEndCloseOut().ShowDialog();
        }
        public void CheckIfCloseAccountExistsOrNot(String CDate)
        {
            try
            {
                DBConnection.Open();
                String Query = "select SN from ClosingTable where Date=?";
                OleDbParameter[] pars = new OleDbParameter[] { new OleDbParameter() { Value = CDate } };
                OleDbDataReader reader = DBConnection._Read(Query, pars);
                if (reader.HasRows)
                {
                    reader.Read();
                    ResourceClass.ISClosedAccount = true;
                    reader.Close();   
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
        }
        private void LoadSettingDataToResourcesValue()
        {
            try
            {
                DBConnection.Open();
                OleDbDataReader reader = DBConnection._Read("select * from Setting");
                while (reader.Read())
                {
                    String ID = reader["ID"].ToString();
                    if (ID == "2")
                    {
                        ResourceClass.TotalBarCodeMin = Convert.ToInt16(reader["value_2"].ToString());
                    }
                    else if (ID == "3")
                    {
                        ResourceClass.ReceiptWidth = Convert.ToInt16(reader["value_2"].ToString());
                    }
                    else if (ID == "4")
                    {
                        ResourceClass.FORMMODE = Convert.ToInt16(reader["value_1"].ToString());
                        ResourceClass.FORMSTATE = Convert.ToInt16(reader["value_2"].ToString());
                    }
                    else if (ID == "5")
                    {
                        ResourceClass.ShowReceiptPreviewAfterSave = Convert.ToBoolean(reader["value_2"].ToString());
                    }
                    else if (ID == "6")
                    {
                        ResourceClass.AutoNewTransaction = Convert.ToBoolean(reader["value_2"].ToString());
                    }
                    else if (ID == "7")
                    {
                        ResourceClass.AutoPrintInvoice = Convert.ToBoolean(reader["value_2"].ToString());
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
        }
        private void SIN_Click(object sender, EventArgs e)
        {
            searchInvoiceToolStripMenuItem_Click(sender, e);
        }
        private void ReSizeFormState(Form form)
        {
            if (ResourceClass.FORMSTATE == 1)
            {
                form.WindowState = FormWindowState.Maximized;
            }
            else if(ResourceClass.FORMSTATE == 0)
            {
                form.WindowState =  FormWindowState.Normal;
            }
        }

    }
}
