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
    public partial class OrganizationInformation : Form
    {
        public OrganizationInformation()
        {
            InitializeComponent();
        }

        private void OrganizationInformation_Load(object sender, EventArgs e)
        {
            LoadORGInfo();
        }
        private void LoadORGInfo()
        {
            try
            {
                DBConnection.Open();

                String query = "select * from Organization where ID=1";
                OleDbDataReader reader = DBConnection._Read(query);
                if (reader.HasRows) {
                    reader.Read();
                    OrganizationName.Text = reader[1].ToString();
                    Address.Text = reader[2].ToString();
                    PhoneNo.Text = reader[3].ToString();
                    PanNo.Text = reader[4].ToString();
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

        private void Save_Click(object sender, EventArgs e)
        {
            int flag = 0;
            try
            {
                DBConnection.Open();

                String query = "update Organization set Name=?,Address=?,PhoneNo=?,Pan_no=? where ID=1";
                OleDbParameter[] parsLists = new OleDbParameter[]{
                            new OleDbParameter { Value = OrganizationName.Text.Trim()},
                            new OleDbParameter { Value = Address.Text.Trim()},
                            new OleDbParameter { Value = PhoneNo.Text.Trim()},
                            new OleDbParameter { Value = PanNo.Text.Trim()}
                };
                DBConnection._Write(query, parsLists);
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
                MessageBox.Show("Organization Information Set", "Info");
            }
        }
    }
}
