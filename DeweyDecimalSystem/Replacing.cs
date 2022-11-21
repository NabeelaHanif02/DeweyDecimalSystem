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
        replacingClass replacecallnums = new replacingClass();
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
            callNumbers = replacecallnums.createCallnums();
          
            //we getting the call numbrs from the list to the listbox
            foreach (var item in callNumbers)
            {
                listBox1.Items.Add(item);

            }

         

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

                ////this will sorth the order in array list 1 
                replacecallnums.sorthOrder(arr1);

                ////this will compare both arrays to check if they are in order
                found = replacecallnums.compareArrays(arr1, arr2);
                 
                list = arr1.ToList();//this is storing the sorthed arrray to a list
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
                    lblPnts.Text = point.ToString();
                }       
            }
            else
            {
                MessageBox.Show("Box 2 Incomplete, missing call numbers", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

       

        private void upPictureBox_Click(object sender, EventArgs e)
        {
            //this click even for the picture box to move up
            
            if(listBox2.SelectedIndex == -1)//this is checking if an item is selected
            {
                MessageBox.Show("No item is selected, please select an item to move", "Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int newIndex = listBox2.SelectedIndex - 1;//this allows the item to move up by subtracting the index
                if (newIndex < 0)//this will prevent exception from ocurring if newindex is less than 0 it will ignorw
                    return;
                object selecteditem = listBox2.SelectedItem;//this gets the selected item
                listBox2.Items.Remove(selecteditem);//removes it
                listBox2.Items.Insert(newIndex, selecteditem); //inserts again on the list with the new index
                listBox2.SetSelected(newIndex, true); //keeps the item selected until he sselects another so the user doesnt have to select it all the time
            }
        }

        private void downPictureBox_Click(object sender, EventArgs e)
        {
            //this click even for the picture box to move down
            if (listBox2.SelectedIndex == -1)//this is checking if an item is selected
            {
                MessageBox.Show("No item is selected, please select an item to move", "Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int newIndex = listBox2.SelectedIndex + 1;//this allows the item to move down by adding the index
                if (newIndex >=listBox2.Items.Count)//this will prevent exception from ocurring if newindex is mpre than the items it will ignorw
                    return;
                object selecteditem = listBox2.SelectedItem;//this gets the selected item
                listBox2.Items.Remove(selecteditem);//removes it
                listBox2.Items.Insert(newIndex, selecteditem); //inserts again on the list with the new index
                listBox2.SetSelected(newIndex, true); //keeps the item selected until he sselects another so the user doesnt have to select it all the time
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Close();
            f.Show();

        }

     

      


}
}



    



