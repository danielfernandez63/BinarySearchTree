using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
     public class Node 
    {
        public int number;
        public Node rightChild;
        public Node leftChild;

        public Node(int value)
        {
            number = value;
            rightChild = null;
            leftChild = null;
        }

        public bool IsChild()
        {
            return (rightChild == null && leftChild == null);
        }

        //public void AddData(int data)
        //{
        //    if (number < data)
        //    {
        //       if (rightChild == null)
        //       {
        //            rightChild = new Node(data);
        //       }
        //       else
        //        {
        //            rightChild.AddData(data);
        //        }
        //    }

        //    else if (number > data)
        //    {
        //        if (leftChild == null)
        //        {
        //            leftChild = new Node(data);
        //        }
        //        else
        //        {
        //            leftChild.AddData(data);
        //        }
        //    }



            //else if (node.number < data)
            //{
            //    return AddData(node.rightChild, data);
            //}

            //else //(node.number > data)
            //{
            //    return AddData(node.leftChild, data);
            //}


     }

        //public bool Search(int s)
        //{
        //    if(number == s)
        //    {
        //        return true;
        //    }

        //    else if (number < s)
        //    {
        //       if (rightChild == null)
        //        {
        //            return false;
        //        }
        //        return rightChild.Search(s);
        //    }

        //    else if (number > s)
        //    {
        //        if (leftChild == null)
        //        {
        //            return false;
        //        }
        //        return leftChild.Search(s);
        //    }

        //    return false;

            //else if (node.number < s)
            //{
            //    return Search(node.rightChild, s);
            //}

            //else if (node.number > s)
            //{
            //    return Search(node.leftChild, s);
            //}
            //return false;
 }

        //public void Display(Node node)
        //{
        //    if (leftChild != null)
        //    {
        //        Display(node.leftChild);
        //    }
                      
        //    if (rightChild != null)
        //    {
        //        Display(node.rightChild);
        //    }

        //    Console.WriteLine(" " + node.number);

        // }








        //Display(node.leftChild);
        //Console.WriteLine(" " + node.number);
        //        Display(node.rightChild);

        //        return;













    }
}
