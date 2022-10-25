using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeweyDecimalSystem
{
   //THIS CLASS WILL BE USED TO ADD POINTS TO OUR LIST OF POINTS
    public  class Points
    {
         int point;

        public Points(int point)
        {
            this.Point1 = point;
        }

       
        public int Point1 { get => point; set => point = value; }
       
    }

   
}
