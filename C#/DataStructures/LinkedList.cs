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
                    foreach (T value in collection)
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
                    if (this.count < 1)
                        throw new InvalidOperationException($"{nameof(LinkedList<T>)} is empty.");

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
                    if (this.count < 1)
                        throw new InvalidOperationException($"{nameof(LinkedList<T>)} is empty.");

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

                    throw new InvalidOperationException($"{nameof(LinkedList<T>)} does not contain specific {nameof(node)}.");
                }

                public LinkedListNode<T> AddAfter(LinkedListNode<T> node, T value)
                {
                    if (this.count < 1)
                        throw new InvalidOperationException($"{nameof(LinkedList<T>)} is empty.");

                    if (node == null)
                        throw new ArgumentNullException($"{nameof(node)} is null.");

                    LinkedListNode<T> current = this.head;
                    LinkedListNode<T> newNode = new LinkedListNode<T>(value);

                    while (current != null)
                    {
                        if (current == node)
                        {
                            if (current == this.tail)
                            {
                                this.tail.Next = newNode;
                                this.tail = newNode;
                            }
                            else
                            {
                                newNode.Next = current.Next;
                                current.Next = newNode;
                            }

                            ++this.count;
                            return newNode;
                        }

                        current = current.Next;
                    }

                    throw new InvalidOperationException($"{nameof(LinkedList<T>)} does not contain specific {nameof(node)}.");
                }

                public void AddAfter(LinkedListNode<T> node, LinkedListNode<T> newNode)
                {
                    if (this.count < 1)
                        throw new InvalidOperationException($"{nameof(LinkedList<T>)} is empty.");

                    if (node == null)
                        throw new ArgumentNullException($"{nameof(node)} is null.");

                    LinkedListNode<T> current = this.head;

                    while (current != null)
                    {
                        if (current == node)
                        {
                            if (current == this.tail)
                            {
                                this.tail.Next = newNode;
                                this.tail = newNode;
                            }
                            else
                            {
                                newNode.Next = current.Next;
                                current.Next = newNode;
                            }

                            ++this.count;
                            return;
                        }

                        current = current.Next;
                    }

                    throw new InvalidOperationException($"{nameof(LinkedList<T>)} does not contain specific {nameof(node)}.");
                }

                public void Remove(LinkedListNode<T> node)
                {
                    if (node == null)
                        throw new InvalidOperationException($"{nameof(node)} is null.");

                    if (this.count < 1)
                        throw new InvalidOperationException($"{nameof(LinkedList<T>)} is empty.");

                    if (node == this.head)
                    {
                        this.head = this.head.Next;
                        this.tail = null;
                    }
                    else if (node == this.tail)
                    {
                        LinkedListNode<T> current = this.head;

                        while (current.Next.Next != null)
                            current = current.Next;

                        current.Next = null;
                    }
                    else
                    {
                        LinkedListNode<T> previous = this.head;
                        LinkedListNode<T> current = this.head.Next;

                        while (current != null)
                        {
                            if (current == node)
                            {
                                previous.Next = current.Next;
                                --this.count;
                                return;
                            }

                            previous = current;
                            current = current.Next;
                        }
                    }

                    --this.count;
                }

                public LinkedListNode<T> RemoveFirst()
                {
                    switch (this.count)
                    {
                        case 0:
                            {
                                throw new InvalidOperationException($"{nameof(LinkedList<T>)} is empty.");
                            }
                        case 1:
                            {
                                LinkedListNode<T> node = this.head;
                                this.head = null;
                                this.tail = null;
                                --this.count;
                                return node;
                            }
                        default:
                            {
                                LinkedListNode<T> node = this.head;
                                this.head = this.head.Next;
                                --this.count;
                                return node;
                            }
                    }
                }

                public LinkedListNode<T> RemoveLast()
                {
                    switch (this.count)
                    {
                        case 0:
                            {
                                throw new InvalidOperationException($"{nameof(LinkedList<T>)} is empty.");
                            }
                        case 1:
                            {
                                LinkedListNode<T> node = this.tail;
                                this.head = null;
                                this.tail = null;
                                --this.count;
                                return node;
                            }
                        default:
                            {
                                LinkedListNode<T> current = this.head;

                                while (current.Next.Next != null)
                                    current = current.Next;

                                LinkedListNode<T> node = current.Next;
                                current.Next = null;
                                --this.count;
                                return node;
                            }
                    }
                }

                public LinkedListNode<T> Find(T value)
                {
                    if (this.count < 1)
                        throw new InvalidOperationException($"{nameof(LinkedList<T>)} is empty.");

                    LinkedListNode<T> current = this.head;

                    while (current != null)
                    {
                        if (this.AreEqual(current.Value, value))
                            return current;

                        current = current.Next;
                    }

                    throw new InvalidOperationException($"There is no {nameof(value)} in {nameof(LinkedList<T>)}.");
                }

                public bool Contains(T value)
                {
                    LinkedListNode<T> current = this.head;

                    while (current != null)
                    {
                        if (this.AreEqual(current.Value, value))
                            return true;

                        current = current.Next;
                    }

                    return false;
                }

                public T[] ToArray()
                {
                    T[] array = new T[this.count];
                    LinkedListNode<T> current = this.head;

                    for (int i = 0; i < this.count; ++i)
                    {
                        array[i] = current.Value;
                        current = current.Next;
                    }

                    return array;
                }

                public void Clear()
                {
                    this.head = null;
                    this.tail = null;
                    this.count = 0;
                }

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

                private bool AreEqual(T obj1, T obj2)
                {
                    if (obj1 == null && obj2 == null)
                        return true;

                    if (obj1 == null || obj2 == null)
                        return false;

                    return obj1.Equals(obj2);
                }
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
