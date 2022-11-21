using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeweyDecimalSystem
{
    class replacingClass
    {
        //THIS CLASS WILL BE USED TO STORE OUR METHODS IN REPLACING CALLNUMBERS

        public ArrayList createCallnums()
        {

            ArrayList callNumbers = new ArrayList();
            //We are just generating a string of numbers and letters and joining it together as a string line of call numbers
            const string title = "ABCDEFGHIJKLMNUPQRSTUVXWYZ";
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
                        callNum += "" + title[RNG.Next(0, title.Length)];

                    }

                    CallNumbers c = new CallNumbers(callNum);
                    ListClass.callnum.Add(c);

                    callNumbers.Add(callNum); //this will store each call number in an array list
                    callNum = "";
                }

            return callNumbers;
        }

        public void sorthOrder(string[] arr1)
        {
            //this will sorth the order in array list 1
            string temp;
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
        }

        public bool compareArrays(string[] arr1, string[]arr2)
        {
            bool found = false;
            //this will compare both arrays to check if they are in order
            for (int b = 0; b < arr1.Length; b++)
            {
                if (String.Equals(arr1[b], arr2[b]) == false)
                {
                    found = true;
                    break;
                }

            }
            return found;
        }

        }
}
