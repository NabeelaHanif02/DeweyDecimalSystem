using System;
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
    public partial class Rewards : Form
    {
        public Rewards()
        {
            InitializeComponent();
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();

            if(Points.point == 15)
            {
                //pictureBoxBronze.Show();
                panel1.Show();
            }
            else
            {
                MessageBox.Show("There are no rewards yet");
            }
              
        }

        private void btnRback_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void btnRedeem_Click(object sender, EventArgs e)
        {

        }
    }
}
