using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeweyDecimalSystem
{
    class IdentifyingCallNum
    {
      

        public IdentifyingCallNum()
        {
           
        }
        //I USED THIS CLASS TO GENERATE QUESTIONS ANSWERS AND CHECK FOR CALL NUMBERS AS QUESTIONS AND DESCRIPTIONS AS ANSWERS

        //this class returns array methods questions and answers as it is easier to work with arrays positions and values when managing small data such as this
        public string []fill() 
        {
            //this method will take all tke call numbers from dictionary list store it on an array and then shuffle it and return as an array of 4 questions
            string[] array = new string[4];//this array will be used to store the 4 questions and will be returned
            string[] array2 = ListClass.dictionaries.Select(kvp => kvp.Key).ToArray(); //this is the cinversion from dictionary list to array
            Random shuf = new Random();//this random will be used to shuffle array2
            array2 = array2.OrderBy(x => shuf.Next()).ToArray();
            //after shuffling we store 4 in the array of questions starting vfrom position 0
            array[0] = array2[0];
            array[1] = array2[1];
            array[2] = array2[2];
            array[3] = array2[3];
          
            return array;

        }

        public string [] match(string txt1, string txt2, string txt3, string txt4,  string []description)
        {
            //THIS METHOD WILL TAKE THE SUBSTRING OF EACH QUESTION LABEL AND USE IT AS POSITION FOR MY DESCRIPTION ARRAY TO GET THE 4 CORRECT ANSWERS 

            string [] array= new string[7];//THIS IS THE ARRAY WE WILL USE TO STORE THE ANSWERS INCLUDING 4 CORRECT AND 3 GENERATED
            Random pick = new Random();//THIS RANDOM WILL BE USED TO PICK 3 INTEGERS AND USE IT AS POSITION TO GET RANDOM DESCRIPTION FOR THE 3 GENERATED
            int fifth,sixth, seventh;//THIS IS WHERE WE WILL STORE THE 3 RANDOM INTEGERES 
            int p1 = Int32.Parse(txt1.Substring(0, 1));
            int p2 = Int32.Parse(txt2.Substring(0, 1));
            int p3 = Int32.Parse(txt3.Substring(0, 1));
            int p4 = Int32.Parse(txt4.Substring(0, 1));
        

            //THIS DO WHILES WILL ENSURE THAT THE INTEGERS DONT REPEAT POSITIONS WITH THE CORRECT ANSWERS
            do
            {
                fifth = pick.Next(0, 9);
            } while (fifth == p1 || fifth == p2 || fifth == p3 || fifth==p4);
            do
            {
                sixth = pick.Next(0, 9);
            } while (sixth == p1 || sixth ==p2 || sixth ==p3 || sixth == p4 || sixth == fifth);//|| sixth == Int32.Parse(t5)
            do
            {
                seventh = pick.Next(0, 9);
            } while (seventh == p1 || seventh == p2 || seventh == p3 || seventh == p4 ||seventh==fifth ||seventh == sixth);//|| seventh == Int32.Parse(t5) 


            //I AM GETTING THE THE DESCRIPTION IN THE POSITIONS THAT I GOT AND STORING IT IN OUR ARRAY FOR ANSWERS
            array[0] = description[p1];
            array[1] = description[p2];
            array[2] = description[p3];
            array[3] = description[p4];
            array[4] = description[fifth];
            array[5] = description[sixth];
            array[6] = description[seventh];
            
            //LASTLY SHUFFLING THE ARRAY SO ITS DISPLAYED RANDOMLY
            Random shuf = new Random();
            array = array.OrderBy(x => shuf.Next()).ToArray();

           
            return array;

        }

        public bool check(int i1,int i2, int i3, int i4, string[] answer, string[] question)
        {
            //THIS BOOL WILL TAKE INDEXES OF CHOOSEN ANSWER IN THE CMBVAL SO WE CAN USE IT AGAIN AS OUR POSITIONS TO ANSWERS ARRAY
            //FOR EXAMPLE IF THE USER CHOOSES "A" THE INDEX OF "A" IS "0", WE WILL USE TO GET THE ANSWER THAT WILL BE IN OUR "0" POSITION IN OUR ARRAY THAT WAS USED TO DISPLAY THE ANSWERS
            bool isChecked;//BOOL IS CHECKED WILL RETURN TRUE IF CONDITION IS MET

            string key1 = question[0];//KEYS WE REPRESENT AS QUESTION (CALL NUMBERS)AND WE AUTOMATICALY KNOW THE POSITIONS OF THE QUESTION IS 0,1,2 AND 3
            string val1 = answer[i1];//VALUES WE REPRESENT AS ANSWERS (DESCRIPTIONS)
            string key2 = question[1];
            string val2 = answer[i2];
            string key3 = question[2];
            string val3 = answer[i3];
            string key4 = question[3];
            string val4 = answer[i4];

            //THIS IF AND ELSE STATEMENT WILL VALIDATE OUR QUESTIONS AND ANSWERS AND WILL RETURN TRUE IF THE PAIRS CONTAINS IN THE DICTIONARY
            if (ListClass.dictionaries[key1].Equals(val1) &&
                ListClass.dictionaries[key2].Equals(val2) &&
                ListClass.dictionaries[key3].Equals(val3) &&
                ListClass.dictionaries[key4].Equals(val4)) /*ListClass.dictionaries.ContainsKey(key1) && */

            {
              isChecked=true;
            }

            else
            {
                isChecked=false;
            }

            return isChecked;
        }

    }

    
}
