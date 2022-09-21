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
            MessageBox.Show("COMING SOON!");
        }

        private void btnFindCallNum_Click(object sender, EventArgs e)
        {
            MessageBox.Show("COMING SOON!");
        }

        private void btnRwards_Click(object sender, EventArgs e)
        {
            Rewards r = new Rewards();
            this.Hide();
            r.Show();
        }
    }
}
