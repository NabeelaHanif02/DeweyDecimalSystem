using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeweyDecimalSystem
{
    public class BNode
    {
      //THIS NODE CLASS WILL BE OUR NODE FOR THE BINARY TREE
      //REPEATING CALL NUMBERS AS INT ITEM AND STRING CALL NUMBER TO ALLOW THE LIST TO USE THE ITEM FOR SORTHIBG PURPOSES AND THE CALL NUMBERS FOR DISPLAYING PURPOSES
        public int level;
        public int item;
        public string callNum;
        public string description;
        public BNode right;
        public BNode left;

        public BNode(int level, int item, string callNum, string description)
        {
            this.level = level;
            this.item = item;
            this.callNum = callNum;
            this.description = description;
        }
    }
}
