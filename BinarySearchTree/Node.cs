using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node
    {
        //member variables

        public int data;
        public Node left;
        public Node right;

        //constructor
        public Node()
        {

        }

        //member methods
        public void DisplayNode()
        {
            Console.Write(data + " ");
        }
    }
}
