using BinarySerachTreePrblm;

namespace BinarySearchTreePrblm
{
    class program
    {
        public static void Main(string[] args)
        {
            //BinaryTree<int> tree = new BinaryTree<int>(56);
            //tree.AddNode(30);
            //tree.AddNode(70);
            //tree.Display();

            //BinarySearchTree<int> binary = new BinarySearchTree<int>(56);
            //binary.AddNode(30);
            //binary.AddNode(70);
            //binary.AddNode(22);
            //binary.AddNode(40);
            //binary.AddNode(60);
            //binary.AddNode(95);
            //binary.AddNode(11);
            //binary.AddNode(65);
            //binary.AddNode(31);
            //binary.AddNode(16);
            //binary.AddNode(63);
            //binary.AddNode(67);
            //binary.Display();
            //binary.getSize();

            SearchTree<int> search = new SearchTree<int>(56);
            search.AddNode(30);
            search.AddNode(70);
            search.AddNode(22);
            search.AddNode(40);
            search.AddNode(60);
            search.AddNode(95);
            search.AddNode(11);
            search.AddNode(65);
            search.AddNode(31);
            search.AddNode(16);
            search.AddNode(63);
            search.AddNode(67);
            search.Display();
            search.getSize();

            bool result = search.ifExist(63, search);
            Console.WriteLine(result);
        }
    }
}
