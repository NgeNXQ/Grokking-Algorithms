namespace GrokkingAlgorithms
{
    internal sealed class Program
    {
        private static void Main() 
        {
            GrokkingAlgorithms.CSharp.DataStructures.LinkedList<int> list = new GrokkingAlgorithms.CSharp.DataStructures.LinkedList<int>();

            CSharp.DataStructures.LinkedListNode<int> node1 = list.AddLast(1);
            CSharp.DataStructures.LinkedListNode<int> node2 = list.AddLast(2);
            CSharp.DataStructures.LinkedListNode<int> node3 = list.AddLast(3);
            CSharp.DataStructures.LinkedListNode<int> node4 = list.AddLast(4);
            CSharp.DataStructures.LinkedListNode<int> node5 = list.AddLast(5);

            list.AddBefore(node1, new CSharp.DataStructures.LinkedListNode<int>(1));
            list.AddBefore(node2, new CSharp.DataStructures.LinkedListNode<int>(2));
            list.AddBefore(node3, new CSharp.DataStructures.LinkedListNode<int>(3));
            list.AddBefore(node4, new CSharp.DataStructures.LinkedListNode<int>(4));
            list.AddBefore(node5, new CSharp.DataStructures.LinkedListNode<int>(5));

            foreach (int i in list) { Console.WriteLine(i); }
        }
    }
}