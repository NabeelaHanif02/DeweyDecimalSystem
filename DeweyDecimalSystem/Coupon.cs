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
    public partial class Coupon : Form
    {
        public Coupon()
        {
            //THIS IS THE FORM I USED TO CREATE A COUPON WITH GENERATED COUPON CODE AND A LINK TO THE WEB FOR WHEN THE USER PRESSES REDEEM `TROPHEE WHEN HE GETS 100 POINTS
            InitializeComponent();
            Random r = new Random();
            string coupon = "";
            string code = "ABCDEFGHIJLMNOPQRSTUVXWYZ1234567890abcdefghijklmnopqrstuvxwyz";
            for (var i = 0; i < 9; i++)
            {
                coupon += "" + code[r.Next(0, code.Length)];

            }

            lblCoupon.Text = coupon;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Rewards r = new Rewards();
            this.Hide();
            r.Show();
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            //THIS BUTTON WILL TAKE THE USER TO THIS BOOK WEBSITE
            System.Diagnostics.Process.Start("explorer.exe","https://www.bookebooks.org/");

        }
    }
}
