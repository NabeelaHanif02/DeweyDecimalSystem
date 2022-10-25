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
    public partial class Replacing : Form
    {
       
        public ArrayList callNumbers = new ArrayList(); //this array list will store all the call numbers
        //arr1 and arr2 will be used to store the items in listbox2 
        public string[] arr1 = new string[10];
        public string[] arr2 = new string[10];
        public List<string> list, list2;
        int point = 0;
        
      
     

        
      

        public Replacing()
        {
            InitializeComponent();
            listBox1.AllowDrop = true;
            listBox2.AllowDrop = true;
            pictureBox1.Visible = false;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            callNumbers.Clear();
            lblPnts.Text = point.ToString();



            //We are just generating a string of numbers and letters and joining it together as a string line of call numbers
            const string src = "ABCDEFGHIJKLMNUPQRSTUVXWYZ";
            String callNum = "";
            Random RNG = new Random();
            Random RNG1 = new Random();

            for (var a = 0; a < 10; a++)
            {
                callNum += "" + RNG1.Next(0, 9);
                callNum += "" + RNG1.Next(0, 9);
                callNum += "" + RNG1.Next(0, 9);
                callNum += ".";//wait
                for (var k = 0; k < 2; k++)
                {
                    callNum += "" + RNG1.Next(0, 9);
                }
                callNum += " ";
                for (var i = 0; i < 3; i++)
                {
                    callNum += "" + src[RNG.Next(0, src.Length)];

                }

                CallNumbers c = new CallNumbers(callNum);
                ListClass.callnum.Add(c);

                callNumbers.Add(callNum); //this will store each call number in an array list
                callNum = "";
            }
           

            foreach (var item in callNumbers)
            {
                listBox1.Items.Add(item);

            }

         



        }

        private void Replacing_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            listBox2.DoDragDrop(listBox1.SelectedItem.ToString(), DragDropEffects.Copy); //applying drag and drop effect
        }

        private void listBox2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) //verifying if the data thats being dragged is in text format
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {
            listBox2.Items.Add(e.Data.GetData(DataFormats.Text)); //getting ddata that was added and removing from the list that was taken out of
            listBox1.Items.Remove(e.Data.GetData(DataFormats.Text));
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();//this will clear out the items in the listbox before adding new ones
            //this button allows the user to try again by replacing all of the data back to the previous listbox from the arraylist and clearing it from the other list box from the other listbox 
            listBox2.Items.Clear();
            foreach (var item in callNumbers)
            {
                listBox1.Items.Add(item);

            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string temp;
            bool found=false;
            int k = 0;
            if (listBox2.Items.Count > 9)
            {
                //this loop will store the listbox 2 values in 2 diff arrays
                //one will be used to sorth the other will be used to compare
                foreach (var item in listBox2.Items)
                {
                    arr1[k] = item + "";
                    arr2[k] = item + "";
                    k++;
                }
                 

             //this will sorth the order in array list 1  
                int l = arr1.Length;

                for (int i = 0; i < l; i++)
                {
                    for (int j = 0; j < l - 1; j++)
                    {
                        if (arr1[j].CompareTo(arr1[j + 1]) > 0)
                        {
                            temp = arr1[j];
                            arr1[j] = arr1[j + 1];
                            arr1[j + 1] = temp;
                        }
                    }
                }

                //this will compare both arrays to check if they are in order
                for (int b = 0; b < arr1.Length; b++)
                {
                    if (String.Equals(arr1[b], arr2[b]) == false)
                    {
                        found = true;
                        break;
                    }

                }
                list = arr1.ToList();


               

                var br = new StringBuilder(); //this will build a string line for our arraylist to be displayed
                foreach (var item in list)
                {
                    br.Append(item + "\n");
                }
                if (found == true)
                {
                    MessageBox.Show("The order is incorrect");
                }

                else
                {
                MessageBox.Show("" + br.ToString() + "\n The order is correct");
                pictureBox1.Visible = true;
                    point = 15;
                    Points p = new Points(point);
                    ListClass.points.Add(p);
                    MessageBox.Show("CONGRATULATIONS YOU WON " + point+ " POINTS!" + " \n" + "Check rewards for achievements!");
                    btnRestart.Hide();
                    lblPnts.Text = point.ToString();




                }
                   
            }
            else
            {
                MessageBox.Show("Box 2 Incomplete, missing call numbers", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Close();
            f.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


}
}



    



