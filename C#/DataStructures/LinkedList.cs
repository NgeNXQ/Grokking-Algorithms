using System.Collections;

[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("GrokkingAlgorithms_CSharp.UnitTests")]

namespace GrokkingAlgorithms
{
    namespace CSharp
    {
        namespace DataStructures
        {
            internal sealed class LinkedList<T> : IEnumerable<T>
            {
                private int count;
                private LinkedListNode<T> head;
                private LinkedListNode<T> tail;

                public LinkedListNode<T> First { get => this.head; }

                public LinkedListNode<T> Last { get => this.tail; }

                public int Count { get => this.count; }

                public bool IsEmpty { get => this.count < 1; }

                public LinkedList()
                {
                    this.count = 0;
                    this.head = null;
                    this.tail = null;
                }

                public LinkedList(T value) : this() => this.AddLast(value);

                public LinkedList(IEnumerable<T> collection) : this()
                {
                    foreach(T value in collection)
                        this.AddLast(value);
                }

                public LinkedListNode<T> AddFirst(T value)
                {
                    LinkedListNode<T> newNode = new LinkedListNode<T>(value);

                    if (this.count < 1)
                        this.tail = newNode;

                    newNode.Next = this.head;
                    this.head = newNode;
                    ++this.count;
                    return newNode;
                }

                public void AddFirst(LinkedListNode<T> node)
                {
                    if (node == null)
                        throw new ArgumentNullException($"{nameof(node)} is null.");

                    if (this.count < 1)
                        this.tail = node;

                    node.Next = this.head;
                    this.head = node;
                    ++this.count;
                }

                public LinkedListNode<T> AddLast(T value)
                {
                    LinkedListNode<T> newNode = new LinkedListNode<T>(value);
                    
                    if (this.count < 1)
                    {
                        this.head = this.tail = newNode;
                    }
                    else
                    {
                        this.tail.Next = newNode;
                        this.tail = newNode;
                    }
                    
                    ++this.count;
                    return newNode;
                }

                public void AddLast(LinkedListNode<T> node)
                {
                    if (node == null)
                        throw new ArgumentNullException($"{nameof(node)} is null.");

                    if (this.count < 1)
                    {
                        this.head = this.tail = node;
                    }
                    else
                    {
                        this.tail.Next = node;
                        this.tail = node;
                    }

                    ++this.count;
                }

                public LinkedListNode<T> AddBefore(LinkedListNode<T> node, T value)
                {
                    if (node == null)
                        throw new ArgumentNullException($"{nameof(node)} is null.");

                    if (head == node)
                        return this.AddFirst(value);

                    LinkedListNode<T> previous = head;
                    LinkedListNode<T> current = head.Next;
                    LinkedListNode<T> newNode = new LinkedListNode<T>(value);

                    while (current != null)
                    {
                        if (current == node)
                        {
                            newNode.Next = previous.Next;
                            previous.Next = newNode;
                            ++count;
                            return newNode;
                        }

                        previous = current;
                        current = current.Next;
                    }

                    throw new System.InvalidOperationException($"{nameof(LinkedList<T>)} does not contain specific {nameof(node)}.");
                }

                public void AddBefore(LinkedListNode<T> node, LinkedListNode<T> newNode)
                {
                    if (node == null)
                        throw new ArgumentNullException($"{nameof(node)} is null.");

                    if (head == node)
                    {
                        this.AddFirst(newNode);
                        return;
                    }

                    LinkedListNode<T> previous = head;
                    LinkedListNode<T> current = head.Next;

                    while (current != null)
                    {
                        if (current == node)
                        {
                            newNode.Next = previous.Next;
                            previous.Next = newNode;
                            ++count;
                            return;
                        }

                        previous = current;
                        current = current.Next;
                    }

                    throw new System.InvalidOperationException($"{nameof(LinkedList<T>)} does not contain specific {nameof(node)}.");
                }

                //AddAfter(LinkedListNode<T> node, T value): Adds a new node with the specified value after the specified existing node.

                //Remove(LinkedListNode<T> node): Removes the specified node from the LinkedList.

                //Find(T value): Finds the first occurrence of a node with the specified value in the LinkedList.

                //Contains(T value): Determines whether the LinkedList contains a node with the specified value.

                //ToArray(): Copies the elements of the LinkedList to a new array.

                //public LinkedListNode<T> RemoveFirst()
                //{

                //}

                //public LinkedListNode<T> RemoveLast()
                //{

                //}

                //public void Clear()
                //{
                //    this.head = null;
                //    this.tail = null;
                //    this.count = 0;
                //}

                public IEnumerator<T> GetEnumerator()
                {
                    LinkedListNode<T> node = this.head;

                    while (node != null)
                    {
                        yield return node.Value;
                        node = node.Next;
                    }
                }

                IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
            }

            internal sealed class LinkedListNode<T>
            {
                public T Value { get; set; }

                public LinkedListNode<T> Next { get; set; }

                public LinkedListNode()
                {
                    this.Value = default;
                    this.Next = null;
                }

                public LinkedListNode(T value) : this() => this.Value = value;
            }
        }   
    }
}
