using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree classmatesAge = new BinaryTree();

            classmatesAge.AddData(28);
            classmatesAge.AddData(25);
            classmatesAge.AddData(22);
            classmatesAge.AddData(21);
            classmatesAge.AddData(27);
            classmatesAge.AddData(24);
            classmatesAge.AddData(99);
            classmatesAge.AddData(19);

            classmatesAge.Search(19);

         
        }
    }
}
