using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net.Mime;

namespace DeweyDecimalSystem
{
    public partial class FindingCallNums : Form
    {
        BTree btr = new BTree();
        string[] options;


        public FindingCallNums()
        {
            InitializeComponent();
            btnCheck2.Visible = false;
            btnCheck3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox3.Visible = false; 
            var myList = new List<string>();

            //ITS READING THE TEXT FILE AND PASSING THE DATA TO A BINARY TREE
            //CODE ATTRIBUTION : READING FROM TEXTFILE
            //https://learn.microsoft.com/en-us/troubleshoot/developer/visualstudio/csharp/language-compilers/read-write-text-file
            string[] words;
            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("C:\\Users\\User\\OneDrive\\Documents\\library.txt");
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //split the line into diff items to add it to the list
                    words= line.Split('#');
                     //add to the list each time it reads a line                
                    btr.Add(Int32.Parse(words[0]), Int32.Parse(words[1]),words[1], words[2]);
            
                    //Read the next line
                    line = sr.ReadLine();
                }              
                sr.Close();
               
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e.Message);
            }

            //CALLING THE METHOD TO LOAD THE FIRST LEVEL OPTIONS WITH A THIRD LEVEL DESCRIPTION AS SOON AS THE UI LOADS
            firstLevelLoad();


        }

       
        private void btnCheck1_Click(object sender, EventArgs e)
        {
            //THIS BUTTON CHECKS FOR TOP LEVEL ANSWERS TO CHECK IF ITS WRONG
            
            //gets the checked radiobutton
            var checkedButton = Controls.OfType<RadioButton>()
                                   .FirstOrDefault(r => r.Checked);
            //gets the callnumber for comparation by calling the search description method that searches the description on the binary tree and returns the call number 
            string callNum = btr.FindCallNum(lblDescription.Text);//the description from the ui
            //compares if the checked radio button text substring first char equals to call num first char for top level check
             if(checkedButton.Text.Substring(0,1).Equals(callNum.Substring(0,1)))
            {
                //if correct shows the user and moves on to the next level
                int points = 2;
                Points p = new Points(points);//we are adding points
                ListClass.points.Add(p);//and storing it in a list
                double total = ListClass.points.Sum(item => item.Point1);//we getting the sum of the points inside the list
                MessageBox.Show("Level 1 answer is correct! you get: " + points + " Points." + "\nYou have a sum of " + total + " Points." + "\nGet all 3 levels correct to earn 30 points!", "Correct", MessageBoxButtons.OK, MessageBoxIcon.None);
                lblPoints.Text = total.ToString();
             
                    //CALLING FIRST LEVEL OPTIONS         
                    options = btr.options2stlevel(callNum);
                    Array.Sort(options, (x, y) => x.Substring(0, 3).CompareTo(y.Substring(0, 3)));//SORTHING THE OPTIONS IN NUMERICAL ORDER BY CALL NUMBER
                    rbt1.Text = options[0];
                    rbt2.Text = options[1];
                    rbt3.Text = options[2];
                    rbt4.Text = options[3];
                    btnCheck2.Visible = true;
                    btnCheck2.Enabled = true;
                    btnCheck3.Visible = false;
                    btnCheck3.Enabled = false;
                    btnCheck1.Visible = false;
                    btnCheck1.Enabled = false;


            }
            else
            {
                //if wrong tells the user and starts again from first level
                MessageBox.Show("wrong");
                firstLevelLoad();
            } 
        }
        private void btnCheck2_Click(object sender, EventArgs e)
        {
            //THIS BUTTON CHECKS FOR SECOND LEVEL ANSWERS TO CHECK IF ITS WRONG
            //gets the checked radiobutton
            var checkedButton = Controls.OfType<RadioButton>()
                                               .FirstOrDefault(r => r.Checked);
            //gets the callnumber for comparation by calling the search description method that searches the description on the binary tree and returns the call number 
            string callNum = btr.FindCallNum(lblDescription.Text);//Searches with the description from ui label
             
            //compares if the checked radio button text substring 0 to second char equals to call num 0 to second char for top level check
            if (checkedButton.Text.Substring(0, 2).Equals(callNum.Substring(0, 2)))
            {
                int points = 2;
                Points p = new Points(points);//we are adding points
                ListClass.points.Add(p);//and storing it in a list
                double total = ListClass.points.Sum(item => item.Point1);//we getting the sum of the points inside the list
                MessageBox.Show("Level 2 answer is correct! you get: " +points+" Points."+"\nYou have a sum of " +total+" Points."+"\nGet all 3 levels correct to earn 30 points, ALMOST THERE!", "Correct", MessageBoxButtons.OK, MessageBoxIcon.None);
                lblPoints.Text = total.ToString();

                //CALLING SECOND LEVEL OPTIONS 
                options = btr.options3rdlevel(callNum);
                Array.Sort(options, (x, y) => x.Substring(0, 3).CompareTo(y.Substring(0, 3)));//SORTHING THE ARRAY IN NUMERICAL ORDER BY CALL NUMBER

                //fillinf the buttons
                rbt1.Text = options[0];
                rbt2.Text = options[1];
                rbt3.Text = options[2];
                rbt4.Text = options[3];
                //hidding the other buttons
                btnCheck3.Visible = true;
                btnCheck3.Enabled = true;
                btnCheck2.Visible = false;
                btnCheck2.Enabled = false;
                btnCheck1.Visible = false;
                btnCheck1.Enabled = false;

            }
            else
            {
                MessageBox.Show("wrong");
                firstLevelLoad();

            }
        }
        private void btnCheck3_Click(object sender, EventArgs e)
        {
            //THIS BUTTON CHECKS FOR SECOND LEVEL ANSWERS TO CHECK IF ITS WRONG  OR CORRECT
            //IF CORRECT IT CONGRATULATES THE USER WIITH MEMOJIS AND 30 POINTS THENN PROCEEDS TO THE NEXT QUESTION
            //IF WRONG TELLS THE USER AND STARTS AGAIN ANOTHER QUESTION

            //gets the checked radiobutton
            var checkedButton = Controls.OfType<RadioButton>()
                                  .FirstOrDefault(r => r.Checked);
            string callNum = btr.FindCallNum(lblDescription.Text);//this is getting the 3rd level call number on the binary tree with the description that is displayed on the ui
            if (checkedButton.Text.Equals(callNum))//checks to see if the chosen option matches the found call number
            {
                //IF CORRECT
                Points p = new Points(30);//we are adding points
                ListClass.points.Add(p);//and storing it in a list

                double total = ListClass.points.Sum(item => item.Point1);//we getting the sum of the points inside the list

                //MESSAGE BOX CONGRATULATING AND SHOWING THE TOTAL OF POINTS GAINED
                MessageBox.Show("you have matched all the 3 level questions", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.None);
                MessageBox.Show("YOU HAVE EARNED " + total + " POINTS!,\nKeep practising to earn a gift at 100 points, Check rewards page for gains", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.None);
                lblPoints.Text = total.ToString();

                //DISPLAYING MEMOJIS
                var basePath = @"C:\Users\User\Downloads\memoji"; //Gets the memoji folder path stored in my computer
                var pics = System.IO.Directory.EnumerateFiles(basePath, "*.gif").ToArray();//ads the gif to an array of pics
                var randomPic = pics.OrderBy(p => Guid.NewGuid()).First();//randomizes it
                pictureBox3.Image = System.Drawing.Image.FromFile(randomPic);//assigns it to picture box 3
                pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;//makes it fit on the picture box
               
                //DISPLAYING THE MEMOJIS AND CLEARING EVERYTHING FOR 5 SECONDS BEFORE CONTINUING
                this.pictureBox3.Visible = true;
                this.pictureBox4.Visible = true;
                this.lblDescription.Visible = false;
                this.rbt1.Visible = false;
                this.rbt2.Visible = false;
                this.rbt3.Visible = false;
                this.rbt4.Visible = false;
                //THIS TASK. RUN ALLOWS IT TO RUN FOR 5 SECONDS BEFORE PUTTING EVERYTHING BACK AND CONTINUING
                Task.Run(() =>
                {
                    Thread.Sleep(5000);
                    this.Invoke(new Action(() =>
                    {
                        this.pictureBox3.Visible = false;
                        this.pictureBox4.Visible = false;
                        this.lblDescription.Visible = true;
                        this.rbt1.Visible = true;
                        this.rbt2.Visible = true;
                        this.rbt3.Visible = true;
                        this.rbt4.Visible = true;

                    }));
                });
                //CONTINUE TO NEXT QUESTION AS NORMAL STARTING FROM TOP LEVEL
                firstLevelLoad();

            }
            else
            {
                MessageBox.Show("wrong");
                firstLevelLoad();
            }
        }

        //THIS METHOD FIRSTLEVELLOAD I CREATED TO AVOID REPEATING THE WHOLE CODE MANY TIMES AND ALSO TO AVOID ADDING A LOT OF CODE TO MY UI AND BUTTONS
        private void firstLevelLoad()
        {
            //GETS A RANDOM THIRD ITEM CALL NUMBER FROM THE BINARY SEARCH TREE METHOD
            string QItem = btr.getRandomThirdLvl();
            //GETS THE DESCRIPTION ON THE BINARY SEARCH TREE METHOD USING THE CALL NUMBER FOR THE THIRD LEVEL QITEM THAT WAS PICKED
            string QDescription = btr.FindDescription(Int32.Parse(QItem)).ToString();

            //SETS THE LABEL FOR DESCRIPTION AS QDESCRIPTION THE FOUND DESCRIPTION 
            lblDescription.Text = QDescription;

            //GETS THE OPTIONS FOR FIRST LEVEL IN THE FIRST LEVEL OPTIONS  MTHOD
            options = btr.options1stlevel(QItem);

            //SORTHS THE ARRAY OPTIONS IN NUMERICAL ORDER BEFORE DISPLAYING
            Array.Sort(options, (x, y) => x.Substring(0, 3).CompareTo(y.Substring(0, 3)));

            //FILL THE BUTTONS WITH THE ARRAY OF OPTIONS
            rbt1.Text = options[0];
            rbt2.Text = options[1];
            rbt3.Text = options[2];
            rbt4.Text = options[3];
            //HIDE THE UNNECESSARY BUTTONS AND ENABLE THE NECESSARY
            btnCheck1.Visible = true;
            btnCheck1.Enabled = true;
            btnCheck2.Visible = false;
            btnCheck2.Enabled = false;
            btnCheck3.Visible = false;
            btnCheck3.Enabled = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

            //THIS WILL TAKE BACK TO THE ORIGINAL FORM
            Form1 f = new Form1();
            f.Show();
            f.Hide();


        }
    }
}
