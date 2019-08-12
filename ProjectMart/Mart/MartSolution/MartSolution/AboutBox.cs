/*Copyright (C) Sujan Thapa - All Rights Reserved
Unauthorized copying of this file, via any medium is strictly prohibited
Proprietary and confidential
Written by Sujan Thapa <suz_47@outlook.com>, 2016
*/

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
    public partial class AboutBox : Form
    {
        Boolean isScroll = false;
        int flux = 1;
        int speed = 35;
        public AboutBox()
        {
            InitializeComponent();
        }
        private void tScrollerTimer_Tick(object sender, EventArgs e)
        {
            if (!isScroll)
            {
                int currentY = descriptionBox.Location.Y;
                if (currentY <= -descriptionBox.Height)
                {
                    descriptionBox.Location = new Point(descriptionBox.Location.X, 202);//81
                }
                descriptionBox.Location = new Point(descriptionBox.Location.X, (descriptionBox.Location.Y - flux));
            }
        }
        private void AboutBox_Load(object sender, EventArgs e)
        {
            this.ppBtn.Parent = this.HeaderImage;
            this.SpeedTxt.Parent = this.HeaderImage;

            this.Text = ResourceClass.APPDESCRIPTION;
            tScrollerTimer.Start();
        }
        private void ppBtn_Click(object sender, EventArgs e)
        {
            if (isScroll)
            {
                isScroll = false;
                ppBtn.Image = MartSolution.Properties.Resources.play_1;
            }
            else
            {
                isScroll = true;
                ppBtn.Image = MartSolution.Properties.Resources.pause_2;
            }
        }
        private void SpeedTxt_Click(object sender, EventArgs e)
        {
            if (speed == 35)
            {
                speed = 10;
                SpeedTxt.Text = "speed x 2";
            }
            else if (speed == 10)
            {
                speed = 35;
                SpeedTxt.Text = "speed x 1";
            }
            tScrollerTimer.Interval = speed;
        }
    }
}
