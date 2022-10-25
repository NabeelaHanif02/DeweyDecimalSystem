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
        
        double total = 0;
        public Rewards()
        {

            InitializeComponent();
            //THIS WILL HIDE THE REWARDS UNTIL WON
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();

            //THIS WILL GET THE TOTAL POINTS FOR OUR REWARDS
             total = ListClass.points.Sum(item => item.Point1);

            //THIS WILL CHECK THE POINTS AND SHOW REWARDS ACCORDINGLY
            if (total >= 15)
            {
                //pictureBoxBronze.Show();
                panel1.Show();
             
            }
            if (total >= 45)
            {
              
                panel2.Show();
            }
            if (total >= 75)
            {
               
                panel3.Show();
            }
            if (total >= 85)
            {
              
                panel4.Show();
            }
            //else
            //{
            //    MessageBox.Show("There are no rewards yet");
            //}

        }

        private void btnRback_Click(object sender, EventArgs e)
        {



           Form1 f = new Form1();
            f.Show();
            this.Hide();
   



        }

        private void btnRedeem_Click(object sender, EventArgs e)
        {
            Coupon c = new Coupon();
            c.Show();
            this.Hide();
        }

       
    }
}
