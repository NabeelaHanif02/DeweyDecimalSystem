using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeweyDecimalSystem
{
    class IdentifyingDesc
    {
        //I USED THIS CLASS TO GENERATE QUESTIONS ANSWERS AND CHECK FOR DESCRIPTIONS AS QUESTIONS AND CALL NUMBERS AS ANSWERS
        public string[] fill(string[] description)
        {
       
            //THIS METHOD WILL JUST SHUFFLE OUR ARRAY OF DESCRIPTIONS AND STORE IT IN AN ARRAY OF QUESTIONS TO GET THEM RANDOMLY PICKED
            string[] array = new string[4];
            Random shuf = new Random();
            description = description.OrderBy(x => shuf.Next()).ToArray();
            array[0] = description[0];
            array[1] = description[1];
            array[2] = description[2];
            array[3] = description[3];


            return array;

        }
        public string[] match(string txt1, string txt2, string txt3, string txt4, string[] desc)
        {
            //THIS METHOD SERVES TO GET 4 CORRECT CALL NUMBERS AND 3 GENERATED AND THEN RETURNS AN ARRAY OF 7 SHUFFLED ANSWERS
            string[] array2 = ListClass.dictionaries.Select(kvp => kvp.Key).ToArray();
       
            string[] array = new string[7];
            Random pick = new Random();
            string callNum = "";
            //THE 3 INTS THAT WE WILL USE TO STORE GENERATED 3 CALL NUMBERS
            int fifth = -1;
            int sixth = -1; 
            int seventh=-1;

            //IN HERE WE ARE GETTING THE SUBSTRING OF QUESTION LABELS AND SW IS A SWITCH CASE STATEMENT METHOD TO COMPARE THE SUBSTRING AND RETURN POSITIONS BY CHECKING THE TWO FIRST CHARS
            //SINCE SEARCHING IN THE LIST AND GETTING THE INDEX DIRECTLY WAS CONFUSING SCIENCE WITH SOCIAL SCIENCE
            var first = sw(txt1.Substring(0, 2));
            var second = sw(txt2.Substring(0, 2));
            var third = sw(txt3.Substring(0, 2));
            var fourth = sw(txt4.Substring(0, 2));
          
            //THIS LOOP WILL CREATE 3 GENERATED numbers position THAT IS VALIDATED TO NOT BE THE SAME AS THE FIRST 4 CORRECT ANSWERS
            //THIS LOOP WILL ALSO STORE THE CALL NUMBERS IN THE ARRAY OF ANSWERS
            //IN THIS CASE THE POSITION ALREADY REPRESENTS THE FIRS NUMBER WE JUST ADD 00

            for (var a=0; a < 3; a++)
            {
                if (a == 0)
                {
                    do
                    {
                        fifth = pick.Next(0, 9);
                    } while (fifth == first || fifth == second || fifth == third || fifth == fourth);
                   
                }
                if (a == 1)
                {
                    do
                    {
                        sixth = pick.Next(0, 9);
                    } while (sixth == first || sixth == second || sixth == third || sixth == fourth || sixth == fifth);
                    
                }
                if (a == 2)
                {
                    do
                    {
                        seventh = pick.Next(0, 9);
                    } while (seventh == first || seventh == second || seventh == third || seventh == fourth || seventh == fifth || seventh == sixth);
                   
                }
            }

            array[0] = array2[first];
            array[1] = array2[second];
            array[2] = array2[third];
            array[3] = array2[fourth];
            array[4] = array2[fifth];
            array[5] = array2[sixth];
            array[6] = array2[seventh];
               

            //THIS WILL SHUFFLE THE ARRAY SO IT CAN BE RANDOMLY DISPLAYED
            Random shuf = new Random();
            array = array.OrderBy(x => shuf.Next()).ToArray();


            return array;

        }

        public int sw(string a)
        {
            //this switch statement serves to get the number or the position for each category since getting
            //index of each description is going to get confused with science and social science
            switch (a) {
                case "GE": return 0;
                    break;
                case "PH":
                    return 1;
                    break;
                case "RE":
                    return 2;
                    break;
                case "SO":
                    return 3;
                    break;
                case "LA":
                    return 4;
                    break;
                case "SC":
                    return 5;
                    break;
                case "TE":
                    return 6;
                    break;
                case "AR":
                    return 7;
                    break;
                case "LI":
                    return 8;
                    break;
                case "HI":
                    return 9;
                    break;
                default: return -1;
            }




        }


        public bool check(int i1, int i2, int i3, int i4, string[] answer, string[] question)
        {
            //THIS BOOL WILL TAKE INDEXES OF CHOOSEN ANSWER IN THE CMBVAL SO WE CAN USE IT AGAIN AS OUR POSITIONS TO ANSWERS ARRAY
            //FOR EXAMPLE IF THE USER CHOOSES "A" THE INDEX OF "A" IS "0", WE WILL USE IT TO GET THE ANSWER THAT WILL BE IN OUR "0" POSITION IN OUR ARRAY THAT WAS USED TO DISPLAY THE ANSWERS

            bool isChecked;//BOOL IS CHECKED WILL RETURN TRUE IF CONDITION IS MET
            string val1 = question[0];//VALUES WE REPRESENT AS QUESTIONS HERE (DESCRIPTIONS)
            string key1 = answer[i1];//KEYS WE REPRESENT AS ANSWERS HERE (CALL NUMBERS)AND WE AUTOMATICALY KNOW THE POSITIONS OF THE QUESTION IS 0,1,2 AND 3
            string val2 = question[1];
            string key2 = answer[i2];
            string val3 = question[2];
            string key3 = answer[i3];
            string val4 = question[3];
            string key4 = answer[i4];

            //THIS IF AND ELSE WILL VALIDATE IF THE KEYS AND THEIR PAIRS VALUES EXITS AND CORRESPOND TO TGE ANSWEERS AND QUESTION
            if (ListClass.dictionaries[key1].Equals(val1) &&
                ListClass.dictionaries[key2].Equals(val2) &&
                ListClass.dictionaries[key3].Equals(val3) &&
                ListClass.dictionaries[key4].Equals(val4)) /*ListClass.dictionaries.ContainsKey(key1) && */

            {
                isChecked = true;
            }

            else
            {
                isChecked = false;
            }

            return isChecked;
        }
    }

  
}
