using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MartSolution.Tools
{
    public partial class DatabaseManipulation : Form
    {
        public int DBMState = 0;

        public enum MANIPULATIONPROCESS { CREATE_BACKUP, RESET_DATABASE }
        MANIPULATIONPROCESS MPP;
        String PString = "";

        String DatabaseLocationString;
        public DatabaseManipulation()
        {
            InitializeComponent();
            DatabaseLocationString = Application.StartupPath + "\\Database\\martsolution.mdb";
        }
        private void CreateBackup_Click(object sender, EventArgs e)
        {
            if (CreateBackupFolderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                String CURRENTFILE = CreateBackupFolderBrowserDialog.SelectedPath + "\\" + DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second + "_.mdb";
                bool isSaveData = false;
                try
                {
                    String DATAFILE = DatabaseLocationString;
                    FileInfo FI = new FileInfo(DATAFILE);
                    FI.CopyTo(CURRENTFILE, false);
                    isSaveData = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
                if (isSaveData)
                {
                    String PATH = Path.GetDirectoryName(CURRENTFILE);
                    if (File.Exists(CURRENTFILE))
                    {
                        string argument = "/select, \"" + CURRENTFILE + "\"";
                        Process.Start(PATH, argument);
                        Fname.Text = "File Created: " + Path.GetFileName(CURRENTFILE);
                    }
                }
            }
        }
        private void ResetDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                bool isDtabaseSave = false;
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Title = "Making System Database Backup";
                //saveFile.CheckFileExists = true;
                //saveFile.CheckPathExists = true;
                saveFile.DefaultExt = "mdb";
                saveFile.Filter = "MS Access File (*.mdb)|*.mdb";
                saveFile.FilterIndex = 1;
                saveFile.RestoreDirectory = true;
                saveFile.FileName = "martsolution_" + DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second;

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    //Saving system database to local path
                    String DATAFILE = DatabaseLocationString;
                    String CURRENTFILE = saveFile.FileName;
                    FileInfo FI = new FileInfo(DATAFILE);
                    FI.CopyTo(CURRENTFILE, false);
                    isDtabaseSave = true;
                }
                if (isDtabaseSave)
                {
                    if (MessageBox.Show("Are you sure want to reset database?", "WARNING!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        //RESET DATABASE
                        CreateNewSession();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void CreateNewSession()
        {
            String[] NewSessionString = {
                                            "update Setting set value_1='1', value_2='' where ID=1;",  //reset Settings
                                            "update Setting set value_1='', value_2='5' where ID=2;",  //reset Settings
                                            "update Setting set value_1='', value_2='105' where ID=3;",  //reset Settings
                                            "update Setting set value_1='0', value_2='1' where ID=4;",  //reset Settings
                                            "update Setting set value_1='', value_2='True' where ID=5;",  //reset Settings
                                            "update Setting set value_1='', value_2='True' where ID=6;",  //reset Settings
                                            "update Setting set value_1='', value_2='True' where ID=7;",  //reset Settings
                                            
                                            "delete from Inventory;",         //delete Inventory
                                            "ALTER TABLE Inventory ALTER COLUMN ID COUNTER (1, 1);",//reset autoincrement

                                            "delete from ItemCategory;",         //delete ItemCategory
                                            "ALTER TABLE ItemCategory ALTER COLUMN ID COUNTER (1, 1);",//reset autoincrement

                                            "delete from Items;",         //delete Items
                                            "ALTER TABLE Items ALTER COLUMN ID COUNTER (1, 1);",//reset autoincrement

                                            "delete from ItemsDetail;",         //delete ItemsDetail
                                            "ALTER TABLE ItemsDetail ALTER COLUMN ID COUNTER (1, 1);",//reset autoincrement

                                            "update Organization set Name='',Address='',PhoneNo='',Pan_no='' where ID=1;",  //reset ORG

                                            "delete from Privilege;",         //delete Privilege
                                            "ALTER TABLE Privilege ALTER COLUMN ID COUNTER (1, 1);",//reset autoincrement
                                            "insert into Privilege values (1,'Admin','MEI,MEIVUP,MII,MIRI,MSI,MIVI,MPI,MBI,MSIN,TDECO,RSR,RPR,RIR,TOI,TS,TUPR,TUA,TD,TL,')",//Add new ADMIN

                                            "delete from EmployeeInformation;",         //delete EmployeeInformation
                                            "ALTER TABLE EmployeeInformation ALTER COLUMN ID COUNTER (1, 1);",//reset autoincrement
                                            "insert into EmployeeInformation (Name,User_name,User_pass,Role,Date_of_birth,Join_date,Last_login,Status) values ('Admin','Admin','Admin',1,'01/01/2000','01/01/2000','01/01/2000',1)",//Add new Employee

                                            "delete from Purchase;",         //delete Purchase
                                            "ALTER TABLE Purchase ALTER COLUMN ID COUNTER (1, 1);",//reset autoincrement

                                            "delete from Sales;",         //delete Sales
                                            "ALTER TABLE Sales ALTER COLUMN ID COUNTER (1, 1);",//reset autoincrement

                                            "delete from Suppliers;",         //delete Suppliers
                                            "ALTER TABLE Suppliers ALTER COLUMN ID COUNTER (1, 1);",//reset autoincrement

                                            "delete from ClosingTable;",         //delete Closing Table
                                            "ALTER TABLE ClosingTable ALTER COLUMN SN COUNTER (1, 1);",//reset autoincrement
                                        };
            bool isFinish = false;
            for (int i = 0; i < NewSessionString.Length; i++)
            {
                try
                {
                    DBConnection.Open();
                    String query = NewSessionString[i];
                    DBConnection._Write(query);

                    Console.WriteLine("OK--> " + (i + 1).ToString() + " Q: " + query);
                    isFinish = true;
                }
                catch (Exception Ex)
                {
                    Console.WriteLine(Ex.Message);
                }
                finally
                {
                    DBConnection.Close();
                }
            }

            if (isFinish)
            {
                MessageBox.Show("System Datatabse reset!! \n[Shutting down the application]", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                MainForm.mainForm.Close();
            }
        }
        private void DatabaseManipulation_Load(object sender, EventArgs e)
        {
            if (DBMState == 1)
            {
                tabControl1.TabPages.RemoveAt(1);
            }
        }
    }
}
