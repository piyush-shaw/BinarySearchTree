using BinarySearchTree;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Binary Search Tree Problem !!! ");
        BinarySearchTree<int> binaryTree = new BinarySearchTree<int>(56);
        Console.WriteLine("\n1.Create Binary Search Tree");
        Console.WriteLine("Select the option from above");
        int option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            case 1:
                Console.WriteLine("Creating BST to insert and display node value");
                binaryTree.Insert(30);
                binaryTree.Insert(70);
                binaryTree.Display();
                break;
            default:
                Console.WriteLine("Please enter the correct option");
                break;
        }
    }
}