using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeweyDecimalSystem
{
    class ListClass
    {
  
        public static List<CallNumbers> callnum= new List<CallNumbers>();//THIS LIST STORES ALL THE CALL NUMBERS
        public static List<Points> points = new List<Points>();//THIS LIST STORES ALL THE POINTS
        public static Dictionary<string, string> dictionaries = new Dictionary<string, string>()//THIS IS OUR DICTIONARY LIST WITH THE DATA
        {
             {"000", "GENERAL KNOWLEDGE"},
             {"100", "PHILOSOPHY & PSYCHOLOGY"},
             {"200", "RELIGION"},
             {"300", "SOCIAL SCIENCE"},
             {"400", "LANGUAGES"},
             {"500", "SCIENCE"},
             {"600", "TECHNOLOGY"},
             {"700", "ARTS & RECREATION"},
             {"800", "LITERATURE"},
             {"900", "HISTORY & GEOGRAPHY"}

        };



       
    }
}
