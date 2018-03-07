using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Tree
    {
        public Node root;

        public Tree()
        {
            
        }

        public void Add(int value)
        {
            if (root == null)
            {
                Node nodeToAdd = new Node(value);
                root = nodeToAdd;
                return;
            }
            Node currentNode = root;
            bool added = false;
            do
            {
                if (value < currentNode.value)
                {
                    if (currentNode.left == null)
                    {
                        Node newNode = new Node(value);
                        currentNode.left = newNode;
                        added = true;
                    }
                    else
                    {
                        currentNode = currentNode.left;
                    }
                }
                if (value > currentNode.value)
                {
                    if (currentNode.right == null)
                    {
                        Node newNode = new Node(value);
                        currentNode.right = newNode;
                        added = true;
                    }
                    else
                    {
                        currentNode = currentNode.right;
                    }
                }
            } while (!added);
        }

        public void SearchTree()
        {
            int numberToSearch = 0;

            if(numberToSearch > root.value)
            {
                //while()
            }
        }
    }
}

