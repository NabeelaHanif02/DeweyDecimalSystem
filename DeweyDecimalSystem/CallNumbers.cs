using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeweyDecimalSystem
{
    class CallNumbers
    {

        String callNum;

        public CallNumbers(string callNum)
        {
            this.CallNum = callNum;
        }

        public string CallNum { get => callNum; set => callNum = value; }
    }

    //public ArrayList CallNumbers(string callNum)
    //{

    //    try
    //    {
    //        ArrayList call = new ArrayList();
    //        const string src = "ABCDEFGHIJKLMNUPQRSTUVXWYZ";
    //        Random RNG = new Random();
    //        Random RNG1 = new Random();
    //        callNum += "00";
    //        callNum += "" + RNG1.Next(0, 9);
    //        callNum += ".";//wait
    //        for (var k = 0; k < 2; k++)
    //        {
    //            callNum += "" + RNG1.Next(0, 9);
    //        }
    //        callNum += " ";
    //        for (var i = 0; i < 3; i++)
    //        {
    //            callNum += "" + src[RNG.Next(0, src.Length)];

    //        }


    //        call.Add(callNum); //this will store each call number in an array list
    //        callNum = "";
    //        return null;
    //    }
    //    catch(Exception ex) { throw; }
      
    //}
           

    }

