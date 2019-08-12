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
    public partial class InventoryInformation : Form
    {
        public InventoryInformation()
        {
            InitializeComponent();
        }
        private void InventoryInformation_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.Clone() as Icon;
            FilterBy.SelectedIndex = 0;
            LoadII(String.Empty);
        }
        private void LoadII(String needle)
        {
            try
            {
                IIGrid.Rows.Clear();
                DBConnection.Open();
                String query = "";// 
                if (FilterBy.SelectedIndex == 0)//Normal Item Selection
                {
                    query = "SELECT Items.ID AS IID, Items.CID, Items.Code, Items.Name AS IName,ItemCategory.Name as CName FROM (Items LEFT OUTER JOIN ItemCategory ON Items.CID = ItemCategory.ID) WHERE ( Items.Name LIKE ? + '%' and Items.Status = 1)";
                }
                else if (FilterBy.SelectedIndex == 1)//Order with category
                {
                    query = "SELECT Items.ID AS IID, Items.CID, Items.Code, Items.Name AS IName,ItemCategory.Name as CName FROM (Items LEFT OUTER JOIN ItemCategory ON Items.CID = ItemCategory.ID) WHERE ( ItemCategory.Name LIKE ? + '%' and Items.Status = 1) order by ItemCategory.Name asc";
                }
                else if (FilterBy.SelectedIndex == 2)//Item Code
                {
                    query = "SELECT Items.ID AS IID, Items.CID, Items.Code, Items.Name AS IName,ItemCategory.Name as CName FROM (Items LEFT OUTER JOIN ItemCategory ON Items.CID = ItemCategory.ID) WHERE ( Items.Code LIKE ? + '%' and Items.Status = 1) order by Items.Code asc";
                }

                OleDbParameter[] pars = new OleDbParameter[] { new OleDbParameter() { Value = needle } };
                OleDbDataReader reader = DBConnection._Read(query, pars);
                int row = 0;
                while (reader.Read())
                {
                    IIGrid.Rows.Add(
                        (row + 1).ToString(), reader["IID"].ToString(),
                        reader["CID"].ToString(), reader["CName"].ToString(),
                        reader["Code"].ToString(), reader["IName"].ToString() ,"",""
                        );
                    IIGrid.Rows[row].Cells[6].Value = (IIGrid.Rows[row].Cells[6] as DataGridViewComboBoxCell).Items[0];
                    row += 1;
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
        private void FilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadII(SearchText.Text.Trim());
        }
        private void Save_Click(object sender, EventArgs e)
        {
            SaveII();
        }
        private void SaveII()
        {
            int rFlag = 0;
            try
            {
                DBConnection.Open();
                for (int i = 0; i < IIGrid.Rows.Count; i++)
                {
                    String QUANTITY = IIGrid[7,i].Value.ToString().Trim();
                    if (!QUANTITY.Equals(String.Empty))
                    {
                        String EDATE = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
                        String query = "Insert into `Inventory` (`IID`,`SPID`,`EID`,`Quantity`,`Status`,`Date`) values (?,?,?,?,?,?)";
                        OleDbParameter[] parsLists = new OleDbParameter[]{
                            new OleDbParameter { Value = IIGrid[1,i].Value.ToString() },
                            new OleDbParameter { Value = "0"},
                            new OleDbParameter { Value = MainForm.USERID.ToString()},
                            new OleDbParameter { Value = QUANTITY},
                            new OleDbParameter { Value = UtilityClass.getInventoryStatusCode(IIGrid[6,i].Value.ToString())},
                            new OleDbParameter { Value = EDATE},
                        };
                        DBConnection._Write(query, parsLists);
                        rFlag += 1;
                    }
                    else
                    {
                        IIGrid[7, i].Style.BackColor = Color.Tomato;
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
            if (rFlag > 0)
            {
                StatusPanel.Visible = true;
                statusRep.Text = rFlag + " Data Saved.";
                Timer_.Start();
            }
            else
            {
                StatusPanel.Visible = true;
                statusRep.Text = "No Data Saved.";
                Timer_.Start();
            }
        }
        private void Timer__Tick(object sender, EventArgs e)
        {
            StatusPanel.Visible = false;
            Timer_.Stop();
        }
        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            LoadII(SearchText.Text.Trim());
        }

        private void InventoryInformation_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ResourceClass.FORMMODE == 0)
            {
                ResourceClass.inventoryInformation = null;
            }
        }
    }
}
