// See https://aka.ms/new-console-template for more information
using static Kata.Kata;

Console.WriteLine("Hello, World!");

IntBinarySearchTree bst = new IntBinarySearchTree(null);
bst.Insert(30);
bst.Insert(50);
bst.Insert(15);
bst.Insert(20);
bst.Insert(10);
bst.Insert(40);
bst.Insert(60);

foreach (int i in bst.InOrderTraverse())
{
  Console.WriteLine(i);
}
