using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        //member variables
        public Node root;

        //constructor
        public BinarySearchTree()
        {
            root = null;
        }

        //member methods
        public void AddNode(int num)
        {
            Node newNode = new Node();
            newNode.data = num;
            if(root == null)
            {
                root = newNode;
            }
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if(num < current.data)
                    {
                        current = current.left;
                        if(current == null)
                        {
                            parent.left = newNode;
                            break;
                        }
                        else
                        {
                            current = current.right;
                            if(current == null)
                            {
                                parent.right = newNode;
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
