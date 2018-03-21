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
        public int count = 0;

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
        public bool Search(int numberToSearch)
        {         

            if(numberToSearch == root.value)
            {
                return true;
            }
            if(numberToSearch > root.value)
            {
                for(int i = 0; i < count; i++)
                {
                    if(numberToSearch == root.right.value)
                    {
                        return true;
                    }
                }
            }
            if(numberToSearch < root.value)
            {
                for(int i = 0; i < count; i++)
                {
                    if(numberToSearch == root.left.value)
                    {
                        return true;
                    }
                }       
            }
             return false;
        }
    }
}

