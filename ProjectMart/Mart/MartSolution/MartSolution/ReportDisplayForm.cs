using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MartSolution
{
    public partial class ReportDisplayForm : Form
    {
        public ReportDisplayForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {

            this.reportViewerPanel.RefreshReport();
        }
    }
}
