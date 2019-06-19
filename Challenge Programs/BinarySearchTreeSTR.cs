using System;

namespace BinarySearchTreeSTR
{
    class Program
    {
        static void Main(string[] args)
        {
            BST myTree = new BST();                       

            myTree.insert1("Bob", "CSE", "TX");            //                  Bob      Height: 4 (Bob, Zebra, Jack, Sandy)
            myTree.insert1("Alice", "Undecided", "OR");    //                 /   \     Leaf Nodes: 2 (Arnold, Sandy)
            myTree.insert1("Zebra", "Math", "WA");         //             Alice   Zebra
            myTree.insert1("Jack", "Art", "WY");           //                \      /
            myTree.insert1("Sandy", "Chemistry", "UT");    //             Arnold  Jack
            myTree.insert1("Arnold", "Physics", "OR");     //                       \
                                                           //                      Sandy
                                                                      

            //myTree.insert2(new BST.Student("Dan", "Music", "TN"));        //            Dan
            //myTree.insert2(new BST.Student("Betty", "History", "WY"));    //            / \    Height: 3 (Dan, Betty, Alfred)
            //myTree.insert2(new BST.Student("Alfred", "Biology", "WA"));   //        Betty Joe  Leaf Nodes: 2 (Alfred, Joe)
            //myTree.insert2(new BST.Student("Joe", "CSE", "MD"));          //          /
            //                                                              //       Alfred
            Console.WriteLine("The tree height is {0}", myTree.height());
            Console.WriteLine("The number of leaf nodes: {0}", myTree.numLeafNodes());
            Console.WriteLine();

            myTree.printInOrder();
            Console.WriteLine();
            myTree.printPreOrder();
            Console.WriteLine();
            myTree.printPostOrder();
            Console.WriteLine();
            Console.WriteLine("Bob is in the list: {0}", myTree.Search("Bob")); // Searches for Bob.
        }
    }

    class BST
    {
        // Student class will act as a 'node' and take 3 different string values
        public class Student
        {
            public string studName;
            public string studMajor;
            public string originState;

            // Because the Student class is a node, Binary Search Tree will require
            // left and right.
            public Student left, right;

            public Student(string name, string major, string state)
            {
                studName = name;
                studMajor = major;
                originState = state;
            }
        }

        // Establish base node or the 'root'
        Student basenode;

        public bool isEmpty()
        {
            return basenode == null;
        }

        public void insert1(string studName, string major, string originState)
        {
            // Declare and instantiate stud variable.
            Student stud = new Student(studName, major, originState);

            if (isEmpty())
            {
                // When the tree is empty, the basenode will return the value of stud variable
                basenode = stud;
            }

            else
            {
                Student current = basenode;

                while(true)
                {
                    // The conditional statement will check to see if the compared string values return
                    // less than 0 to sort them alphabetically.
                    if (studName.CompareTo(current.studName) < 0)
                    {
                        // If current.left node does not return null, assign current
                        // to current.left node.
                        if (current.left != null)
                        {
                            current = current.left;
                        }

                        else
                        {
                            // Else, current.left will be the stud node and the loop
                            // will break.
                            current.left = stud;
                            break;
                        }
                    }

                    // If the studName is greater (i.e., input is "Jack" and current
                    // node or basenode is "Dan"), execute the following code.
                    else
                    {
                        // If current.right node does not return null, assign
                        // current node to current.right node.
                        if(current.right != null)
                        {
                            current = current.right;
                        }

                        else
                        {
                            // Else, current.right will equal stud node and break
                            // the loop.
                            current.right = stud;
                            break;
                        }
                    }
                }
            }
        }

        // Unlike insert1 method, the parameters for insert2 accepts
        // Student class variable. As a result, a new class does not
        // need to be declared or assigned and the input newStudent 
        // can be used directly as it retains the Student class
        // properties (which accept all 3 types of string values)

        // However to call the method, it's required to instantiate with
        // new keyword inside the parameters while calling the BST class,
        // e.g. myTree.insert2(new BST.Student("Jake", "Art", "MI")).
        public void insert2(Student newStudent)
        {
            
            if (isEmpty())
            {
                basenode = newStudent;
            }

            else
            {
                Student current = basenode;

                while (true)
                {
                    // The conditional statement will check to see if the compared string values return
                    // less than 0 to sort them alphabetically.
                    if (newStudent.studName.CompareTo(current.studName) < 0)
                    {
                        // If current.left node does not return null, move left.
                        if (current.left != null)
                        {
                            current = current.left;
                        }

                        else
                        {
                            // If current.left is null, assign it to
                            // newStudent variable.
                            current.left = newStudent;
                            break;
                        }
                    }

                    // If the studName value of the newStudent input is greater than
                    // the string value of current.studName node, execute the following
                    // statements.
                    else
                    {
                        // If current.right node does not return null, assign
                        // current node to current.right node.
                        if (current.right != null)
                        {
                            current = current.right;
                        }

                        else
                        {
                            // Else, current.right will equal newStudent node and break
                            // the loop.
                            current.right = newStudent;
                            break;
                        }
                    }
                }
            }
        }

        // The Search method will only need to return a boolean value as long as
        // the input string value matches a value inside the tree, in this case,
        // student name.
        public bool Search(string studName)
        {
            if (isEmpty())
            {
                return false;
            }
            else
            {
                Student current = basenode;

                // Continue to loop as long as current does not return null
                while (current != null)
                {
                    // If the studName matches current.studName (i.e. if Bob
                    // matches Bob during traversal), the string values will
                    // return 0 as both are equal when using CompareTo method,
                    // and the program will return true for boolean value.
                    if (studName.CompareTo(current.studName) == 0)
                    {
                        return true;
                    }

                    // If studName doesn't match and appears earlier (i.e., if
                    // input is Bob but current node has Joe), move left.
                    else if (studName.CompareTo(current.studName) < 0)
                    {
                        current = current.left;
                    }

                    // Move right if studName is alphabetically greater (i.e., if
                    // input is Dan but current node is Bob).
                    else
                    {
                        current = current.right;
                    }
                }
                // If input studName does not match any of the values in the tree,
                // return false.
                return false;
            }
        }

        public void printInOrder()
        {
            printInOrderHelper(basenode);
        }

        public void printInOrderHelper(Student current) //Left - Node - Right
        {
            if (current != null)
            {
                printInOrderHelper(current.left); // Left
                Console.Write(current.studName + " " + current.studMajor + " " + current.originState + " "); // Node
                Console.WriteLine();
                printInOrderHelper(current.right); // Right
            }
        }

        public void printPreOrder()
        {
            preOrderHelper(basenode);
        }

        public void preOrderHelper(Student current) // Node - Left - Right
        {
            if (current != null)
            {
                Console.Write(current.studName + " " + current.studMajor + " " + current.originState + " "); // Node
                Console.WriteLine();
                preOrderHelper(current.left);    // Left
                preOrderHelper(current.right);   // Right
            }
        }

        public void printPostOrder()
        {
            printPostOrderHelper(basenode);
        }

        public void printPostOrderHelper(Student current) //Left - Right - Node
        {
            if (current != null)
            {
                printPostOrderHelper(current.left); // Left
                printPostOrderHelper(current.right); // Right
                Console.Write(current.studName + " " + current.studMajor + " " + current.originState + " "); // Node
                Console.WriteLine();
            }
        }

        public int height()
        {
            return heightHelper(basenode);
        }

        public int heightHelper(Student current)
        {
            // Return 0 for height if the tree is empty.
            if (current == null)
            {
                return 0;
            }
            else
            {
                // Declare leftHeight/rightHeight as int type and assign
                // them to recursively call heightHelper method.
                int leftHeight = heightHelper(current.left);
                int rightHeight = heightHelper(current.right);

                // Through recursion, left/rightHeight will continue to add
                // 1 for each node the heightHelper method will use. E.g.,
                // in the Bob tree, rightHeight > leftHeight so the method
                // will add 1 four times to rightHeight and return 4 for
                // the height.
                if (leftHeight > rightHeight)
                {
                    return leftHeight + 1;
                }

                else
                {
                    return rightHeight + 1;
                }
            }
        }

        public int numLeafNodes()
        {
            return numLeafNodesHelper(basenode);
        }
        
        public int numLeafNodesHelper(Student current)
        {

            if (current == null)
            {
                return 0;
            }
            
            // If the node is a leaf (both left and right point to null),
            // the program will return 1.
            else if (current.left == null && current.right == null)
            {
               return 1;
            }

            // Using recursion, nodes will be checked if they are leaf nodes and will
            // continuously return int 1 until there are no more nodes to check. Once
            // all nodes have been checked, the values will add up every leaf nodes
            // found through current.left and current.right.
            else
            {
                return numLeafNodesHelper(current.left) + numLeafNodesHelper(current.right);
            }

        }

        public BST()
        {
            basenode = null;
        }
    }
}
