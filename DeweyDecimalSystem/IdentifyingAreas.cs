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
    public partial class IdentifyingAreas : Form
    {
        //THIS ARRAY WILL BE USED TO COMPARE, AND GRAB POSITIONS FOR COMBOBOXES, AND FILL METHODS AND CHECK METHODS
        public string[] desc = ListClass.dictionaries.Select(kvp => kvp.Value).ToArray();
      
        //BOTH OF THIS ARRAYS REPRESENT QUESTIONS AND ASNWERS THAT WE WILL USE TO STORE OUR QUESTIONS AND NSWERS COMING FROM BOTH CLASSES THAT WILL BE INSTANTIATED
        public string[] ans= new string[7];
        public string[] ques = new string[4];

        //THIS ARRAY WILL JUST FILL THE COMBOBOXES
        public string[] cmbVal= new string[7] {"A","B","C","D", "E","F","G"};

        //THIS BOTH CLASSES THAT WE INSTANTIATED EACH HAS SIMILAR METHODS TO FILL, MATCH AND CHECK, EXCEPT ONE IS FOR IDENTIFYING CALL NUMBERS, WHEN CALL NUMBERS ARE THE QUESTIONS
        //AND OTHER IS FOR IDENTIFYING DESCRIPTIONS WHEN THE DESCRIPTIONS ARE THE QUESTIONS
        IdentifyingCallNum icall = new IdentifyingCallNum();
        IdentifyingDesc iDesc = new IdentifyingDesc();
        



        public IdentifyingAreas()
        {
       
            InitializeComponent();
          
            //ONCE THE PAGE IS OPENED THE USER WILL BE PRESENTED WITH CALL NUMBERS AS QUESTION AND ANSWERS AS DESCRIPTIONS
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            //BUTTON USED TO ALTERNATE BETWEEN QUESTIONS
            btnNxtC.Hide();//represents for when call numbers are questions
            btnNxtD.Show();//when descriptions are questions


            ques = icall.fill();//we call the method fill to fill the questions
            //WE FILL THE LABEL WITH FILLED ARRAY QUES[]
             lbl1.Text= ques[0];
          lbl2.Text = ques[1];
             lbl3.Text= ques[2];
           lbl4.Text= ques[3];

            //WE CALL THE METHOD MATCH FROM IDENTIFYNG CALL NUMBERS AND WE FILL IT ON THE ANS ARRAY FOR ANSWERS
            ans = icall.match(lbl1.Text,lbl2.Text,lbl3.Text,lbl4.Text,desc);
            //AND WE FILL THE LABELS ABC USRD FOR ANSWERS WITH ANS ARRAY
            lblA.Text = ans[0];
            lblB.Text = ans[1];
            lblC.Text = ans[2];
            lblD.Text = ans[3];
            lblE.Text = ans[4];
            lblF.Text = ans[5];
            lblG.Text = ans[6];

            //WE ARE FILLING COMBOBOXES WITH CMB VAL
            cmb1.Items.AddRange(cmbVal);
            cmb2.Items.AddRange(cmbVal);
            cmb3.Items.AddRange(cmbVal);
            cmb4.Items.AddRange(cmbVal);
           


            

        }
      

        private void btnCheck_Click(object sender, EventArgs e)

        {
           
            //THIS BUTTON IS USED TO CHECK WETHER THE ANSWERS ARE CORRECT OR NOT

            //ISANYEMPTY IS A METHOD BELOW CALLED SCAN FOR CONTROLS THAT I USED TO CHECK IF ANY COMBOBOXES ARE MISSING ANSWERS
            var isAnyEmpty = ScanForControls<ComboBox>(this)
            .Where(x => x.SelectedIndex < 0)
            .Any();

            if (isAnyEmpty)
            {
                MessageBox.Show("Missing answers, Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                //I AM CHECKING IF ANY COMBBOX HAS A DUPLICATE ANSWER TO THE OTHERS
                String cm1 = cmb1.SelectedItem.ToString();
                String cm2 = cmb2.SelectedItem.ToString();
                String cm3 = cmb3.SelectedItem.ToString();
                String cm4 = cmb4.SelectedItem.ToString();

                if ((cm1 == cm2 || cm1 == cm3 || cm1 == cm4) ||
                    (cm2 == cm3 || cm2 == cm4) ||
                    (cm3 == cm4))

                {
                    MessageBox.Show("Duplicate not allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    //I AM RETRIEVING USER CHOSEN ANSWER AND FINDING ITS INDEX THAT WILL BE THEN USED TO COMPARE ON MY BOTH CLASSES
                    var index1 = Array.FindIndex(cmbVal, row => row.Contains(cmb1.SelectedItem.ToString()));
                    var index2 = Array.FindIndex(cmbVal, row => row.Contains(cmb2.SelectedItem.ToString()));
                    var index3 = Array.FindIndex(cmbVal, row => row.Contains(cmb3.SelectedItem.ToString()));
                    var index4 = Array.FindIndex(cmbVal, row => row.Contains(cmb4.SelectedItem.ToString()));

                    //THIS IF AND ELSE WILL CHECK IF BTN NEXTDESCRIPTION IS VISIBLE IT WILL CHECK THE ANSWERS ACCORDING TO ICALLNUMBERS CLASS, IT WILL CHECK FOR WHEN CALL NUMBERS ARE QUESTIONS
                    //ELSE IT WILL CHECK FOR WHEN DESCRIPTIONS ARE VISIBLE
                    if (btnNxtD.Visible)
                    {
                        //WE INSTANTIATED ICALL CHECK METHOD THAT RETURNS TRUE IF CORRECT
                        bool isChecked = icall.check(index1, index2, index3, index4, ans, ques);

                        if (isChecked == true)
                        {

                            btnCheck.Enabled = false;//this will disable check button so the user does not repeat the same question and get points again for the same question
                            Points p = new Points(100);//we are adding points
                            ListClass.points.Add(p);//and storing it in a list
                           
                            double total = ListClass.points.Sum(item => item.Point1);//we getting the sum of the points inside the list

                            MessageBox.Show("you have matched all the questions", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.None);
                            MessageBox.Show("YOU HAVE EARNED " +total + " POINTS!,\nKeep practising to earn a gift at 100 points, Check rewards page for gains", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.None);
                           
                            //this will present the memos 
                            pictureBox1.Visible = true;
                            pictureBox2.Visible = true;

                        }
                        else
                        {
                            MessageBox.Show("MATCH IS INCORRECT, YOU CAN TRY AGAIN OR MOVE TO THE NEXT MATCH COLUMN QUESTION", "MATCH INCORRECT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                        //var lines = ListClass.dictionaries.Select(kvp => kvp.Key + ": " + kvp.Value.ToString());
                        //MessageBox.Show(string.Join(Environment.NewLine, lines));
                    }
                    else
                    {
                       //this else is checking the qnswers for the identifying description , for when description is questions
                       //bool is checked is calling the  method for check in idesc to check for correct
                        bool isChecked = iDesc.check(index1, index2, index3, index4, ans, ques);

                        if (isChecked == true)
                        {
                            //the same is happenig here as above if the asnwer is correct btncheck will be disabled the user will gain points the sum will be presented and memos will be visible
                            btnCheck.Enabled = false;
                            Points p = new Points(15);
                            ListClass.points.Add(p);
                            double total = ListClass.points.Sum(item => item.Point1);
                           
                            MessageBox.Show("you have matched all the questions", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.None);
                            MessageBox.Show("YOU HAVE EARNED " + total + " POINTS!,\nKeep practising to earn a gift at 100 points, Check rewards page for gains", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.None);
                            pictureBox1.Visible = true;
                            pictureBox2.Visible = true;
                            
                        }
                        else
                        {
                            MessageBox.Show("MATCH IS INCORRECT YOU CAN TRY AGAIN OR MOVE TO THE NEXT MATCH COLUMN QUESTION", "MATCH INCORRECT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                        //var lines = ListClass.dictionaries.Select(kvp => kvp.Key + ": " + kvp.Value.ToString());
                        //MessageBox.Show(string.Join(Environment.NewLine, lines));
                    }
                   






                }


            }

            double total2 = ListClass.points.Sum(item => item.Point1);
            lblP.Text = total2.ToString();//we store the total points in label points so the user can see on the screen his score everytime

        }

        //THIS METHOD SCAN CONTROL WILL BE USED TO CHECK IF CMBS ARE EMPTY OR NOT
        public IEnumerable<T> ScanForControls<T>(Control parent) where T : Control
        {
            if (parent is T)
                yield return (T)parent;

            foreach (Control child in parent.Controls)
            {
                foreach (var child2 in ScanForControls<T>(child))
                    yield return (T)child2;
            }
        }

        private void btnNxtD_Click(object sender, EventArgs e)
        {
            //WHWN USER CLICKS BTNNEXTD THE QUESTIONS WILL ALTERNATE FRON CALL  NUMBERS TO DESCRIPTIONS AND ANSWERS FROM DESCRIPTIONS TO CALL NUMBERS

            btnCheck.Enabled = true;//this will enable check button again if disabled
            //this will hide the memos again
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            
            //this will show btnnextc so the usser can then alternate to call numbers as questions again and will hide btnnextd 
            btnNxtC.Show();
            btnNxtD.Hide();
           
            //so array ques will now inherit values from from idesc fill method  and will fill the labels used for questions with array ques
            ques = iDesc.fill(desc);
            lbl1.Text = ques[0];
            lbl2.Text = ques[1];
            lbl3.Text = ques[2];
            lbl4.Text = ques[3];

            //and ans will inherit values from iden description match method and will fill the labels for answers with array ans
            ans = iDesc.match(lbl1.Text, lbl2.Text, lbl3.Text, lbl4.Text, desc);
            lblA.Text = ans[0];
            lblB.Text = ans[1];
            lblC.Text = ans[2];
            lblD.Text = ans[3];
            lblE.Text = ans[4];
            lblF.Text = ans[5];
            lblG.Text = ans[6];

        }

        private void btnNxtC_Click(object sender, EventArgs e)
        {
            //this button will do the same as btnnextd except for now it will fill the questions with call numbers and answers with descriptions
            //and values now are going to be inherited from class identify call numbers
            btnCheck.Enabled = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            btnNxtC.Hide();
            btnNxtD.Show();
            ques = icall.fill();
            lbl1.Text = ques[0];
            lbl2.Text = ques[1];
            lbl3.Text = ques[2];
            lbl4.Text = ques[3];
           
            ans = icall.match(lbl1.Text, lbl2.Text, lbl3.Text, lbl4.Text, desc);
            lblA.Text = ans[0];
            lblB.Text = ans[1];
            lblC.Text = ans[2];
            lblD.Text = ans[3];
            lblE.Text = ans[4];
            lblF.Text = ans[5];
            lblG.Text = ans[6];
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //this button represents home button  that goes back to home page
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //this button will display message box help  with the message below that will help the user hoe to match the questions and what to do
            MessageBox.Show("->Match the definitions in the right-hand column with the terms in the left hand column;" +
                "\n->Answer in the white boxes where it says answer here;" +
                "\n->Each column represents each question and they are numbered according to the question's number;" +
                "\n->In each box choose the correct answer's alphabet for each question and press check." +
                "\n->You don't need to complete a match the question to move to another, alternate match-column questions as much as you wish;" +
                "\n->keep practising to earn points and unlock rewards, at 100 points you unlock a coupon, check rewards for more info." +
                "\nGOOD LUCK! ", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       
    }

  
}
