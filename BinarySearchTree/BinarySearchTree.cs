﻿using System;
namespace BinarySearchTree
{
    //Creating BST using generics and IComparable to use CompareTo method in program
    class BinarySearchTree<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }
        public BinarySearchTree<T> leftTree { get; set; }
        public BinarySearchTree<T> rightTree { get; set; }

        public BinarySearchTree(T nodeData)
        {
            this.NodeData = nodeData;
            this.rightTree = null;
            this.leftTree = null;

        }

        int leftCount = 0, rightCount = 0;
        bool result = false;

        //Method to check node and add node value to either left or right by comparing
        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.leftTree == null)
                    this.leftTree = new BinarySearchTree<T>(item);
                else
                    this.leftTree.Insert(item);
            }
            else
            {
                if (this.rightTree == null)
                    this.rightTree = new BinarySearchTree<T>(item);
                else
                    this.rightTree.Insert(item);
            }
        }

        //Displaying the data in the binary tree
        public void Display()
        {
            if (this.leftTree != null)
            {
                this.leftCount++;
                this.leftTree.Display();

            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.rightTree != null)
            {
                this.rightCount++;
                this.rightTree.Display();
            }
        }

    }
}