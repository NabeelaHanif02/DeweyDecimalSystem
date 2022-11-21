using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeweyDecimalSystem
{
    //CODE ATTRIBUTION : BINARY TREE
    //https://stackoverflow.com/questions/36311991/c-sharp-display-a-binary-search-tree-in-console 
    //THIS IS OUR BINARY SEARCH TREE CLASS, WHERE ALL THE METHODS FOR COMPARATION, INSERTION AND SEARCHING OF ITEMS AND NODES HAPPEN, AND WHERE ALL THE OTHER METHODS OCCUR
    public class BTree
    {
        private BNode _root;
        private int _count;
        private IComparer<int> _comparer = Comparer<int>.Default;


       
        public BTree()
        {
            //THIS IS OUR ROOT
            _root = null;
            _count = 0;
        }


        //THIS METHOD ADDS A NODE TO THE ROOT 
        //IT IS A RECURSIVE METHODN THAT CHECKS IF THE ROOT IS NULL IF NOT NULL CALLS ON THE METHOD TO ADD A SUB NODE TO IT
        public bool Add(int level, int Item, string callNum,string description)
        {
            if (_root == null)
            {
                _root = new BNode(level, Item, callNum, description);
                _count++;
                return true;
            }
            else
            {
                return Add_Sub(_root, level, Item, callNum, description);
            }
        }

        //THIS METHOD ADD_SUB ADDS A LEFT AND A RIGHT NODE TO A NOODE A SUB NODE
        //IT USES ICOMPARER TO COMPARE THE NODE.ITEM TO THE NODE ROOT THAT ITS ADDING TO TO CHECK IF SMALLER THAN THE NODE IT ADDS TO THE LEFT
        //NODE AND IF BIGGER ADDS TO THE RIGHT NODE.
        //IT IS A RECURSIVE METHOD BECAUSE IT CHECKS IF A RIGHT NODE IS NULL IT ADDS  RIGHT NODE BUT IF NOT NULL IT CALLS ITS OWN METHOD AGAIN TO CHECK FOR COMPARATION
        //AND IF NULL IN ORDER FOR INSERTION TO HAPPEN IT CHECKS ALL THE NODES LEFT AND RIGHT IN ORDWR TO ADD A NEW NODE OR SUBNODE
        private bool Add_Sub(BNode Node, int level, int Item, string callNum, string Description)
        {
            if (_comparer.Compare(Node.item, Item) < 0)//this is comparing the current node if smaller than the node thats being added
            {
                if (Node.right == null)//checking if right is null
                {
                    Node.right = new BNode(level, Item,callNum, Description);//adding a right node if not null
                    _count++; //counting the nodes
                    return true;
                }
                else
                {
                    return Add_Sub(Node.right, level, Item,callNum, Description);//else adding a subnode to the right node and calling on the sub node method again to compare and check if the next node  is null or bigger and smaller
                }
            }//this else serves if the node is smaller than the current node it adds a left and checks for left
            else if (_comparer.Compare(Node.item, Item) > 0)//comparing if the current node is bigger than node.item
            {
                if (Node.left == null) //checking if left node is null
                {
                    Node.left = new BNode(level, Item,callNum, Description); //if null inserts a new node
                    _count++;
                    return true;
                }
                else
                {
                    return Add_Sub(Node.left, level, Item,callNum, Description);//else recursing and adding a subnode to the right node and calling on the sub node method again to compare and check if the next node  is null or bigger and smaller
                }
            }
            else
            {
                return false;
            }
        }

     

        //THIS SEARCH METHOD IS A RECURSIVE THAT WILL CALL IT SELF TO SEARCH ALL THE NODES FROM LEFT TO RIGHT OF THE TREE TO RETURN ME NODES THAT ARE LEVEL 3
        public string PrintLevelThrees()
        {
            return PrintLevelThrees(_root);//always starting with the root

        }
        public string PrintLevelThrees(BNode p)
        {



            string message = "";

            if (p != null)//checks if the node is null
            {
                if (p.right != null) //moves then to the right node and checks if the node is not null
                {
                    message += PrintLevelThrees(p.right);// adds the right node and checks for the other node and calls the method again
                }


                if (p.level == 3)//checks if node level = 3
                    message += p.callNum.ToString() + "#";//if the nodes that are being added either left or right meets this if statement keep it in a line of string separated by a hash


                if (p.left != null)//checks if the left node is null
                {

                    message += PrintLevelThrees(p.left); //if not null adds the node to be checked again to this method
                }
            }
            return message;
        }

        //THIS SEARCH METHOD IS A RECURSIVE THAT WILL CALL IT SELF TO SEARCH ALL THE NODES FROM LEFT TO RIGHT OF THE TREE TO RETURN ME NODES THAT ARE LEVEL 2
        public string PrintLevelTwos()
        {
            return PrintLevelTwos(_root);//always starting with the root

        }
        public string PrintLevelTwos(BNode p)
        {



            string message = "";

            if (p != null)//checks if the node is null
            {
                if (p.right != null)//moves then to the right node and checks if the node is not null
                {
                    message += PrintLevelTwos(p.right);// adds the right node and checks for the other node and calls the method again
                }


                if (p.level == 2)//checks if node level = 2
                    message += p.callNum +" "+p.description.ToString() + "#";//if the nodes that are being added either left or right meets this if statement keep it in a line of string separated by a hash


                if (p.left != null)//checks if the left node is null
                {

                    message += PrintLevelTwos(p.left);//if not null adds the node to be checked again to this method
                }
            }
            return message;
        }
        //THIS SEARCH METHOD IS A RECURSIVE THAT WILL CALL IT SELF TO SEARCH ALL THE NODES FROM LEFT TO RIGHT OF THE TREE TO RETURN ME NODES THAT ARE LEVEL 1
        public string PrintLevelones()
        {
            return PrintLevelones(_root);//always starting with the root

        }
        public string PrintLevelones(BNode p)
        {

            string message = "";

            if (p != null)//checks if the node is null
            {
                if (p.right != null)//Checks if node right is null
                {
                    message += PrintLevelones(p.right);//if not adds a new nod
                }


                if (p.level == 1)//checks if node level = 1
                    message += p.callNum +" "+p.description.ToString() + "#";//if the nodes that are being added either left or right meets this if statement keep it in a line of string separated by a hash


                if (p.left != null)
                {

                    message += PrintLevelones(p.left);//if not null adds the node to be checked again to this method
                }
            }
            return message;
        }

        //THIS METHOD CALLS ON THE PRINT LEVELS THREES METHOD TO RETURN A RANDOM LEVEL 3 ITEM
        public string getRandomThirdLvl()
        {
            var myList = new List<string>();//this will temporary store the 3rd levels to get a random 
            string thirdLevelQuestion = " ";
            string message = PrintLevelThrees().Substring(0, PrintLevelThrees().Length - 1);//this will store message from printlevel 3, the substring lenght -1 allows me to remove the last extra hash 
            myList = new List<string>(message.Split("#"));//this will split the message and keep it in the list
            //this random will be used to get a random call number from third level
            Random random = new Random();
            int index = random.Next(myList.Count);
            thirdLevelQuestion = myList[index];
            return thirdLevelQuestion;
        }


       // THIS SEARCH METHOD FIND DESCRIPTION, IS A RECURSIVE THAT WILL CALL IT SELF TO SEARCH ALL THE NODES FROM LEFT TO RIGHT OF THE TREE TO RETURN ME 
       //A DESCRIPTION BASED ON THE CALL NUMBER IT RECIEVES, SO IT WILL SEARCH TROUGH THE LIST FOR THE CALL NUMBER AND WILL RETURN ME THE DESCRIPTION FOR IT ONLY
         public string FindDescription(int item)
        {
            return FindDescription(_root, item);//always starting with the root
        }


        public string FindDescription(BNode p, int item)
        {
            string description = "";
            if (p != null)//checks if the node is null
            {
                if (p.right != null)//Checks if node right is null
                {
                    description=FindDescription(p.right, item);//if not null adds the node to be checked again to this method
                }


                if (p.item == item)//checks if node item == item
                     description=p.description.ToString();//if the nodes that are being added either left or right meets this if statement it stores the node in the string variable description
                                                          //and it returns the description at the end

                if (p.left != null)//Checks if node left is null
                {

                    description=FindDescription(p.left, item);//if not null adds the node to be checked again to this method
                }
            }
            return description;
        }

        // THIS SEARCH METHOD FIND DESCRIPTION, IS A RECURSIVE THAT WILL CALL IT SELF TO SEARCH ALL THE NODES FROM LEFT TO RIGHT OF THE TREE TO RETURN ME 
        //A CALL NUMBER BASED ON THE DESCRIPTION IT RECIEVES, SO IT WILL SEARCH TROUGH THE LIST FOR THE CALL NUMBER AND WILL RETURN ME THE DESCRIPTION FOR IT ONLY
        public string FindCallNum(string description)
        {
            return FindCallNum(_root, description);//always starting with the root
        }


        public string FindCallNum(BNode p, string description)
        {
            string callnum = "";
            if (p != null)//checks if the node is null
            {
                if (p.right != null)//Checks if node right is null
                {
                    callnum = FindCallNum(p.right, description);
                }


                if (p.description == description)//checks if node.description matches the description
                    callnum = p.callNum.ToString();//if the nodes that are being added either left or right meets this if statement it stores the node in the string variable 
                                                   //called call number and it returns the variable at the end


                if (p.left != null)
                {

                    callnum = FindCallNum(p.left, description);//if not null adds the node to be checked again to this method
                }
            }
            return callnum;
        }

        //THIS METHOD RETURNS A CORRECT OPTION FOR TOP LEVEL ACCORDING TO THE CALL NUMBER OF THIRD LEVEL QUESTION DISPLAYED ON THE UI
        public string getCorrectAnswerFirstLvl(string callNum)
        {
            //takes the substring to compare to first level substring as the similarity on the top level and third level is the first char
            string item1 = callNum.Substring(0, 1);
            var myList = new List<string>();
            string leveloneanswer = "";
            string message = PrintLevelones().Substring(0, PrintLevelones().Length - 1);//gets all the level ones -1 the hashtag in string message
            myList = new List<string>(message.Split("#"));//adds it temporarily to the list
            //searches the list for the correct answwer for level 1 by comparing their substrings on the first caracter
            foreach(var value in myList)
            {
                if (value.Substring(0, 1).Equals(item1))
                {
                    leveloneanswer = value;
                }
             
               
            }
          
            return leveloneanswer;//returns the correct answer
        }

        //THIS METHOD RETURNS AN ARRAY OF 4 OPTIONS , 1 CORRECT AND 3 RANDOMLY CHOOSEN FOR TOP LEVEL 
        public string[] options1stlevel(string callNum)
        {
            string[] options= new string[4];
            string option1="";
            string option2="";
            string option3="";
            string option4="";
            var myList = new List<string>();
            //gets all the level ones -1 the hashtag in string message
            string message = PrintLevelones().Substring(0, PrintLevelones().Length - 1); //gets all the level ones -1 the hashtag in string message
            myList = new List<string>(message.Split("#"));//adds it temporarily to the list
            option1 = getCorrectAnswerFirstLvl(callNum);//this calls the correct answer method and adds it to option 1 variable
            Random shuf = new Random();//this random will be used to shuffle Tthe list
            myList = myList.OrderBy(x => shuf.Next()).ToList();//this will shuffle the list to get a random question everytime

            //this for each is going to search and return option 2 making sure its not equal to option 1
            foreach(var item in myList)
            {
                if(item != option1)
                {
                   option2 = item;
                }
            }
            //this for each is going to search and return option 3 making sure its not equal to option 1 and 2
            foreach (var item in myList)
            {
                if (item != option1 && item != option2)
                {
                    option3 = item;
                }
            }
            //this for each is going to search and return option 4 making sure its not equal to option 1,2 and 3
            foreach (var item in myList)
            {
                if (item != option1 && item != option2 && item != option3)
                {
                    option4 = item;
                }
            }

            //options being stored in the array
            options[0] = option1;
            options[1] = option2;
            options[2] = option3;
            options[3] = option4;

            return options;
        }

        //THIS METHOD GET CORRECT 2 RETURNS A CORRECT OPTION FOR SECOND LEVEL ACCORDING TO THE CALL NUMBER OF THIRD LEVEL QUESTION DISPLAYED ON THE UI
        public string getCorrectAnswer2Lvl(string callNum)
        {
            //takes the substring from 0 to 2 to compare to first level substring as the similarity on the second level and third level is the first and second char
            string item1 = callNum.Substring(0, 2);
            var myList = new List<string>();
            string leveltwoanswer = "";
            string message = PrintLevelTwos().Substring(0, PrintLevelTwos().Length - 1);//gets all the level twos length -1 which is the hashtag in string message
            myList = new List<string>(message.Split("#")); //adds it temporarily to the list
            //searches the list for the correct answwer for level 1 by comparing their substrings 0 to 2 on the first and second caracter
            foreach (var value in myList)
            {
                if (value.Substring(0, 2).Equals(item1))
                {
                    leveltwoanswer = value;
                }
            }

            return leveltwoanswer;
        }

        //THIS METHOD RETURNS AN ARRAY OF 4 OPTIONS , 1 CORRECT AND 3 RANDOMLY CHOOSEN FOR SECOND LEVEL OPTIONS
        public string[] options2stlevel(string callNum)
        {
            string[] options = new string[4];
            string option1 = "";
            string option2 = "";
            string option3 = "";
            string option4 = "";
            var myList = new List<string>();
            string message = PrintLevelTwos().Substring(0, PrintLevelTwos().Length - 1);//gets the message returned on printlevel twos and the lentgh and subtracts -1 which removes the hash and stores it on the string message
            myList = new List<string>(message.Split("#"));//splits each item by the hash and adds it to the list temporarily 
            option1 = getCorrectAnswer2Lvl(callNum);//this calls the correct answer method and adds it to option 2 variable
            Random shuf = new Random();//this random will be used to shuffle the list
            myList = myList.OrderBy(x => shuf.Next()).ToList();//shuffles the list for random outputs
            var result = from m in myList where m.Substring(0, 1) == option1.Substring(0, 1)//gets 2nd level options that are inside a top level categoryb by taking the substring 
                         select m;
            //this for each is going to search the new var result and return option 2 making sure its not equal to option 1
            foreach (var item in result)
            {
                if (item != option1)
                {
                    option2 = item;
                }
            }
            //this for each is going to search the new var result and return option 2 making sure its not equal to option 1 and 2
            foreach (var item in result)
            {
                if (item != option1 && item != option2)
                {
                    option3 = item;
                }
            }

            //this for each is going to search the new var result and return option 2 making sure its not equal to option 1,2 and 3
            foreach (var item in result)
            {
                if (item != option1 && item != option2 && item != option3)
                {
                    option4 = item;
                }
            }

           
            //options being stored in the array
            options[0] = option1;
            options[1] = option2;
            options[2] = option3;
            options[3] = option4;

            return options;
        }
        public string[] options3rdlevel(string callNum)
        {
            string[] options = new string[4];
            string option1 = "";
            string option2 = "";
            string option3 = "";
            string option4 = "";
            var myList = new List<string>();
            string message = PrintLevelThrees().Substring(0, PrintLevelThrees().Length - 1);//gets the message returned on printlevel threes and the lentgh and subtracts -1 which removes the hash and stores it on the string message
            myList = new List<string>(message.Split("#"));//splits each item by the hash and adds it to the list temporarily 
            option1 = callNum;//we dont need to search a correct level 3 call number as the one that is being used to compare for level 1 and 2 is the correct level 3 answer in this case
            Random shuf = new Random();//this random will be used to shuffle the list 
            myList = myList.OrderBy(x => shuf.Next()).ToList();//this will shuffle the list for random options
           //var reult gets 3rdd level options that are inside a correct 2nd level categoryb by taking similar substring to 2 numbers
            var result = from m in myList
                         where m.Substring(0, 2) == option1.Substring(0, 2)
                         select m;
            //this for each is going to search the new var result and return option 2 making sure its not equal to option 1
            foreach (var item in result)
            {
                if (item != option1)
                {
                    option2 = item;
                }
            }
            //this for each is going to search the new var result and return option 3 making sure its not equal to option 1 and 2
            foreach (var item in result)
            {
                if (item != option1 && item != option2)
                {
                    option3 = item;
                }
            }
            //this for each is going to search the new var result and return option 4 making sure its not equal to option 1,2 and 3
            foreach (var item in result)
            {
                if (item != option1 && item != option2 && item != option3)
                {
                    option4 = item;
                }
            }
            //adds the options to the array
            options[0] = option1;
            options[1] = option2;
            options[2] = option3;
            options[3] = option4;

            return options;
        }

    }
}
