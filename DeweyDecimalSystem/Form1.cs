using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeweyDecimalSystem
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnHome.Enabled = false;//this will disable home button when its on the form home
            lblPoints.Text = ListClass.points.Sum(item => item.Point1).ToString(); //this will display the sum of al the users poiny in the home form
            //lblPoints.Text = Points.Point.ToString();


        }

        private void btnReplaceBooks_Click(object sender, EventArgs e)
        {
            //this will take us to another form
            Replacing r = new Replacing();
            this.Hide();
            r.Show();
        }

        private void btnIdenAreas_Click(object sender, EventArgs e)
        {
            //this will enable identifying area button
            IdentifyingAreas a = new IdentifyingAreas();
            this.Hide();
            a.Show();
        }

        private void btnFindCallNum_Click(object sender, EventArgs e)
        {
            FindingCallNums fc = new FindingCallNums();
            fc.Show();
            this.Hide();
        }

        private void btnRwards_Click(object sender, EventArgs e)
        {
           //this will open rewards page
            Rewards r = new Rewards();
            this.Hide();
            r.Show();
        }

        
    }
}
