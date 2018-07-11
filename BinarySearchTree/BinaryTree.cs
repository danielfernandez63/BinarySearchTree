using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
     class BinaryTree
    {
        Node node;
        private Node root;
        private int count; 

        public int Count
        {
            get
            {
                return count;
            }
        }   

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
            count = 0;
        }


        public void AddData(int data)
        {
            if (IsEmpty)
            {
                root = new Node(data);
            }

            else
            {

                if (node.number < data)
                {
                    if (node.rightChild == null)
                    {
                        node.rightChild = new Node(data);
                    }
                    else
                    {
                        node.rightChild.AddData(data);
                    }
                }

                else if (node.number > data)
                {
                    if (node.leftChild == null)
                    {
                        node.leftChild = new Node(data);
                    }
                    else
                    {
                        node.leftChild.AddData(data);
                    }
                }
      
           }

            count++;
        }






        public bool Search(int s)
        {
            //return root.Search(toSearch);

            if (node.number == s)
            {
                return true;
            }

            else if (node.number < s)
            {
                if (node.rightChild == null)
                {
                    return false;
                }
                return node.rightChild.Search(s);
            }

            else if (node.number > s)
            {
                if (node.leftChild == null)
                {
                    return false;
                }
                return node.leftChild.Search(s);
            }

            return false;

        }

























            //public void Display() //override to string to string function return representation
            //{
            //    if (!IsEmpty)
            //    {
            //        root.Display(root);
            //    }
            //}










            //public override string ToString()
            //{
            //    string result = string.Empty;

            //    if (!IsEmpty)
            //    {
            //        result = root.ToString();
            //    }

            //    return result;
            //}






            //belongs in the node class

            //public bool isChild()
            //{
            //    if (!isEmpty())
            //    {
            //        return root.isChild(ref root);
            //    }

            //  return true;
            //}




        }





}
