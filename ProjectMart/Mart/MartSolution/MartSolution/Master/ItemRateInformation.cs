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
    public partial class ItemRateInformation : Form
    {
        public ItemRateInformation()
        {
            InitializeComponent();
        }
        private void LoadIRI(String needle)
        {
            try
            {
                IRIGrid.Rows.Clear();
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
                    String UPRICE="", LDATE="";
                    String query2 = "select  `Unit_price`,`Date` from ItemsDetail where IID=? and ID=(select MAX(ID) from ItemsDetail where IID=?)";
                    OleDbParameter[] pars2 = new OleDbParameter[] { 
                        new OleDbParameter() { Value = reader["IID"].ToString() }, 
                        new OleDbParameter() { Value = reader["IID"].ToString() } 
                    };
                    OleDbDataReader reader2 = DBConnection._Read(query2, pars2);
                    reader2.Read();
                    if (reader2.HasRows)
                    {
                        UPRICE = reader2["Unit_price"].ToString();
                        LDATE = reader2["Date"].ToString();
                    }
                    reader2.Close();
                    //---------------------------------------->
                    IRIGrid.Rows.Add(
                        (row + 1).ToString(), reader["IID"].ToString(), 
                        reader["CID"].ToString(),reader["CName"].ToString(),
                        reader["Code"].ToString(),reader["IName"].ToString(),
                         UPRICE,LDATE
                        );

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
        private void ItemRateInformation_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.Clone() as Icon;
            FilterBy.SelectedIndex = 0;
            LoadIRI(String.Empty);
        }
        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            LoadIRI(SearchText.Text.Trim());
        }
        private void Save_Click(object sender, EventArgs e)
        {
            SaveIRI();
        }
        private void FilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadIRI(SearchText.Text.Trim());
        }
        private void SaveIRI()
        {
            int rFlag = 0;
            try
            {
                DBConnection.Open();
                for (int i = 0; i < IRIGrid.Rows.Count; i++)
                {
                    String UP = IRIGrid[6, i].Value.ToString().Trim();
                    if (!UP.Equals(String.Empty))
                    {
                        //Check OldRate
                        Boolean isRateExists = false;
                        String IID = IRIGrid[1, i].Value.ToString(), UPrice = IRIGrid[6, i].Value.ToString().Trim();
                        String query = "SELECT Unit_price FROM ItemsDetail WHERE (IID = ?) AND (ID = (SELECT MAX(ID) AS Expr1 FROM ItemsDetail WHERE (IID = ?))) AND (Unit_price = ?)";
                        OleDbParameter[] pars = new OleDbParameter[] { 
                            new OleDbParameter() { Value = IID }, 
                            new OleDbParameter() { Value = IID },
                            new OleDbParameter() { Value = UPrice }
                        };
                        OleDbDataReader reader = DBConnection._Read(query, pars);
                        if (reader.HasRows)
                        {
                            isRateExists = true;
                        }
                        if (!isRateExists)
                        {
                            //Insert
                            String EDATE = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
                            IRIGrid[6, i].Style.BackColor = Color.GreenYellow;
                            String query2 = "insert into ItemsDetail (`IID`,`Unit_price`,`Date`) values (?,?,?)";
                            OleDbParameter[] pars2 = new OleDbParameter[] { 
                                new OleDbParameter() { Value = IID }, 
                                new OleDbParameter() { Value = UPrice },
                                new OleDbParameter() { Value = EDATE }
                            };
                            DBConnection._Write(query2, pars2);
                            rFlag += 1;
                        }
                        else
                        {
                            IRIGrid[6, i].Style.BackColor = Color.LimeGreen;
                        }
                    }
                    else
                    {
                        IRIGrid[6, i].Style.BackColor = Color.Tomato;
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
        private void ItemRateInformation_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ResourceClass.FORMMODE == 0)
            {
                ResourceClass.itemRateInformation = null;
            }
        }
    }
}
