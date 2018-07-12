using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
     class BinaryTree
    {

        private Node root;


        public bool IsEmpty
        {
           get
           {
               return root == null;
           }

        }

        public BinaryTree()
        {
           root = null;
        }


        public void AddData(int data)
        {
            bool check = false;
            Node current = root;


            if (IsEmpty)
            {
                root = new Node(data);
                check = true;
            }

            while (check == false)
            {
                if (current.rightChild == null && current.number < data)
                {
                    current.rightChild = new Node(data);
                    check = true;
                }

                else if (current.leftChild == null && current.number > data)
                {
                    current.leftChild = new Node(data);
                    check = true;
                }
                else if (current.rightChild != null && current.number < data)
                {
                    current = current.rightChild;
                }
                else if (current.leftChild != null && current.number > data)
                {
                    current = current.leftChild;
                }
           }
        }
  
        public void Search(int value)
        {
            Node current = root;
            bool found = false;
            string foundPath = "Your current number, " + value + ", in the tree. To get to number we had to make the following moves:";
            while (found == false)
            {
                if (current.number == value)
                {
                    found = true;
                }
                else if (current.rightChild != null && current.number < value)
                {
                    current = current.rightChild;
                    foundPath += " Moved down Right,";
                }
                else if (current.leftChild != null && current.number > value)
                {
                    current = current.leftChild;
                    Console.WriteLine(" Moved down left,");
                }
                else
                {
                    return;
                }
            }

             if (found == true)
             {
                foundPath += ".";
                Console.WriteLine(foundPath);
                Console.ReadLine();
             }
        }
     }
}
