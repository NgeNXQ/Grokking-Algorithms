using System.Collections;

namespace GrokkingAlgorithms
{
    namespace CSharp
    {
        namespace DataStructures
        {
            internal sealed class Queue<T> : IEnumerable<T>
            {
                private const int INITIAL_CAPACITY = 10;
                private const float CAPACITY_THRESHOLD = 0.7f;

                private T[] queue;
                private int headIndex;
                private int tailIndex;

                public int Count { get => this.tailIndex - this.headIndex; }

                public Queue() => this.queue = new T[INITIAL_CAPACITY];

                public Queue(int capacity) => this.queue = new T[capacity];

                public Queue(IEnumerable<T> collection)
                {
                    foreach (T item in collection)
                        this.Enqueue(item);
                }

                public void Enqueue(T item)
                {
                    if (this.headIndex == this.tailIndex)
                    {
                        this.headIndex = 0;
                        this.tailIndex = 0;
                    }

                    if ((float)this.tailIndex / this.queue.Length > CAPACITY_THRESHOLD)
                    {
                        if (this.headIndex != 0)
                        {
                            for (int i = this.headIndex, j = 0; i < this.tailIndex; ++i, ++j)
                            {
                                this.queue[j] = this.queue[i];
                            }

                            this.tailIndex -= this.headIndex;
                            this.headIndex = 0;   
                        }
                        else
                        {
                            Array.Resize(ref this.queue, this.queue.Length * 2);
                        }

                    }

                    this.queue[this.tailIndex++] = item;
                }

                public T Dequeue()
                {
                    if (this.Count < 1)
                        throw new InvalidOperationException($"{nameof(Queue<T>)} is empty");

                    T result = this.queue[this.headIndex++];
                    return result;
                }

                public bool TryDequeue(out T result)
                {
                    if (this.Count < 1)
                    {
                        result = default;
                        return false;
                    }
                    else
                    {
                        result = this.queue[this.headIndex++];
                        return true;
                    }
                        
                }

                public T Peek()
                {
                    if (this.Count < 1)
                        throw new InvalidOperationException($"{nameof(Queue<T>)} is empty.");

                    return this.queue[this.headIndex];
                }

                public bool TryPeek(out T result)
                {
                    if (this.Count < 1)
                    {
                        result = default;
                        return false;
                    }
                    else
                    {
                        result = this.queue[this.headIndex];
                        return true;
                    }
                }

                public void Clear()
                {
                    this.headIndex = 0;
                    this.tailIndex = 0;
                    this.queue = new T[INITIAL_CAPACITY];
                }

                public T[] ToArray()
                {
                    T[] array = new T[this.Count];

                    for (int i = 0; i < this.Count; ++i)
                        array[i] = this.queue[i];

                    return array;
                }

                public void TrimExcess()
                {
                    if ((float)this.Count / this.queue.Length > CAPACITY_THRESHOLD)
                        Array.Resize(ref queue, this.Count);
                }

                public IEnumerator<T> GetEnumerator()
                {
                    for (int i = 0; i < this.Count; ++i)
                        yield return this.queue[i];
                }

                IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
            }
        }
    }
}
