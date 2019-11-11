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
            Node newNode = new Node(num);
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
                    return;
                }
            }
        }
        public bool SearchForNode(int num)
        {
            Node current = root;
            while(true)
            {
                if (num == current.data)
                {
                    Console.WriteLine("Woooo Andrew's Awesome Binary Search Tree has that number!");
                    return true;
                }
                else if (num < current.data && current.left != null)
                {
                    current = current.left;                  
                }
                else if(num > current.data && current.right != null)
                {
                    current = current.right;
                }
                else
                {
                    Console.WriteLine("It's not here.... oops.");
                    return false;
                }
            }
                      
        }
    }
}