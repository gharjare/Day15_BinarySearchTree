using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerachTreePrblm
{
    public class SearchTree<T> where T : IComparable
    {
        public T data;
        public SearchTree<T> left;
        public SearchTree<T> right;
        public SearchTree(T data)
        {
            this.data = data;
            this.left = null; this.right = null;
        }
        int leftIdx = 0, rightIdx = 0;
        public void AddNode(T Value)
        {
            T NodeValue = this.data;
            if (NodeValue.CompareTo(Value) > 0)
            {
                if (this.left == null)
                    this.left = new SearchTree<T>(Value);
                else
                    this.left.AddNode(Value);
            }
            else
            {
                if (this.right == null)
                    this.right = new SearchTree<T>(Value);
                else
                    this.right.AddNode(Value);
            }

        }
        public void Display()
        {
            if (this.left != null)
            {
                this.leftIdx++;
                this.left.Display();
            }
            Console.WriteLine(this.data);
            if (this.right != null)
            {
                this.rightIdx++;
                this.right.Display();
            }
        }
        public void getSize()
        {
            Console.WriteLine("Size" + " " + (1 + this.leftIdx + this.rightIdx));
        }

        public bool ifExist(T element, SearchTree<T> node )
        {
            if(node == null)
            {
                return false;
            }
            if(node.data.Equals(element))
            {
                Console.WriteLine("Found the element in BST" + " " + node.data);
                return true;
            }
            else
            {
                Console.WriteLine("Current element in {0} in BST", node.data);
            }
            if(element.CompareTo(node.data) < 0)
            {
                ifExist(element, node.left);
            }
            if(element.CompareTo(node.data) > 0)
            {
                ifExist(element, node.right);
            }
            return true;
        }
    }
}
