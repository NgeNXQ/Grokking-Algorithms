using System.Collections;

[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("GrokkingAlgorithms_CSharp.UnitTests")]

namespace GrokkingAlgorithms
{
    namespace CSharp
    {
        namespace DataStructures
        {
            internal sealed class Stack<T> : IEnumerable<T>
            {
                private const int INITIAL_CAPACITY = 10;
                private const float CAPACITY_THRESHOLD = 0.7f;

                private T[] stack;
                private int count;

                public int Count { get => this.count; }

                public Stack() => this.stack = new T[INITIAL_CAPACITY];

                public Stack(int capacity) => this.stack = new T[capacity];

                public void Push(T item)
                {
                    if ((float)this.count / this.stack.Length > CAPACITY_THRESHOLD)
                        Array.Resize(ref this.stack, this.stack.Length * 2);

                    this.stack[this.count++] = item;   
                }

                public T Pop()
                {
                    if (this.count < 1)
                        throw new InvalidOperationException($"{nameof(Stack<T>)} is empty.");

                    return this.stack[--this.count];
                }

                public bool TryPop(out T result)
                {
                    if (this.count < 1)
                    {
                        result = default;
                        return false;
                    }
                    else
                    {
                        result = this.stack[--this.count];
                        return true;
                    }
                }

                public T Peek()
                {
                    if (this.count < 1)
                        throw new InvalidOperationException($"{nameof(Stack<T>)} is empty.");

                    return this.stack[this.count - 1];
                }

                public bool TryPeek(out T result)
                {
                    if (this.count < 1)
                    {
                        result = default;
                        return false;
                    }
                    else
                    {
                        result = this.stack[this.count - 1];
                        return true;
                    }
                }

                public void TrimExcess()
                {
                    if ((float)this.count / this.stack.Length > CAPACITY_THRESHOLD)
                        Array.Resize(ref this.stack, this.stack.Length);
                } 

                public T[] ToArray()
                {
                    int index = 0;
                    T[] array = new T[this.count];

                    for (int i = this.count - 1; i >= 0; --i)
                        array[index++] = this.stack[i];

                    return array;
                }

                public void Clear()
                {
                    this.count = 0;
                    this.stack = new T[Stack<T>.INITIAL_CAPACITY];
                }

                public IEnumerator<T> GetEnumerator()
                {
                    for (int i = this.count - 1; i >= 0; --i)
                        yield return this.stack[i];
                }

                IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
            }
        }
    }
}
