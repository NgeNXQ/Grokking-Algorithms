using NUnit.Framework;

namespace GrokkingAlgorithms
{
    namespace CSharp
    {
        namespace DataStructures
        {
            namespace UnitTests
            {
                [TestFixture]
                internal sealed class QueueTests
                {
                    private Queue<int> queue;

                    [SetUp]
                    public void SetUp() => this.queue = new Queue<int>();

                    #region Enqueue

                    [Test]
                    public void Enqueue_Integer_UpdatesCount()
                    {
                        int expected = 5;

                        queue.Enqueue(1);
                        queue.Enqueue(2);
                        queue.Enqueue(3);
                        queue.Enqueue(4);
                        queue.Enqueue(5);

                        int actual = queue.Count;

                        Assert.That(expected, Is.EqualTo(actual));
                    }

                    #endregion

                    #region Dequeue

                    [Test]
                    public void Dequeue_Integer_ReturnsItem()
                    {
                        queue.Enqueue(1);
                        queue.Enqueue(2);
                        queue.Enqueue(3);
                        queue.Enqueue(4);
                        queue.Enqueue(5);

                        int expected = 1;

                        int actual = queue.Dequeue();

                        Assert.That(expected, Is.EqualTo(actual));
                    }

                    [Test]
                    public void Dequeue_Integer_CountIsCorrect()
                    {
                        queue.Enqueue(1);
                        queue.Enqueue(2);
                        queue.Enqueue(3);
                        queue.Enqueue(4);
                        queue.Enqueue(5);

                        int expected = 4;

                        queue.Dequeue();
                        int actual = queue.Count;

                        Assert.That(expected, Is.EqualTo(actual));
                    }

                    [Test]
                    public void Dequeue_Integer_CountEqualsZero()
                    {
                        queue.Enqueue(1);

                        int expected = 0;

                        queue.Dequeue();
                        int actual = queue.Count;

                        Assert.That(expected, Is.EqualTo(actual));
                    }

                    [Test]
                    public void Dequeue_EmptyQueue_ThrowsInvalidOperationException()
                    {
                        Assert.Throws<InvalidOperationException>(() => queue.Dequeue());
                    }

                    #endregion

                    #region Peek

                    [Test]
                    public void Peek_Integer_ReturnsItem()
                    {
                        queue.Enqueue(1);
                        queue.Enqueue(2);
                        queue.Enqueue(3);
                        queue.Enqueue(4);
                        queue.Enqueue(5);

                        int expected = 1;

                        int actual = queue.Peek();

                        Assert.That(expected, Is.EqualTo(actual));
                    }

                    [Test]
                    public void Peek_Integer_CountIsCorrect()
                    {
                        queue.Enqueue(1);

                        int expected = 1;

                        queue.Peek();
                        int actual = queue.Count;

                        Assert.That(expected, Is.EqualTo(actual));
                    }

                    [Test]
                    public void Peek_EmptyQueue_ThrowsInvalidOperationException()
                    {
                        Assert.Throws<InvalidOperationException>(() => queue.Peek());
                    }

                    #endregion

                    #region TryDequeue

                    [Test]
                    public void TryDequeue_Integer_ReturnsItem()
                    {
                        queue.Enqueue(1);
                        queue.Enqueue(2);
                        queue.Enqueue(3);
                        queue.Enqueue(4);
                        queue.Enqueue(5);

                        int expected = 1;

                        queue.TryDequeue(out int actual);

                        Assert.That(expected, Is.EqualTo(actual));
                    }

                    [Test]
                    public void TryDequeue_Integer_CountIsCorrect()
                    {
                        queue.Enqueue(1);
                        queue.Enqueue(2);
                        queue.Enqueue(3);
                        queue.Enqueue(4);
                        queue.Enqueue(5);

                        int expected = 4;

                        queue.TryDequeue(out int _);
                        int actual = queue.Count;

                        Assert.That(expected, Is.EqualTo(actual));
                    }

                    [Test]
                    public void TryDequeue_Integer_CountEqualsZero()
                    {
                        queue.Enqueue(1);

                        int expected = 0;

                        queue.TryDequeue(out int _);
                        int actual = queue.Count;

                        Assert.That(expected, Is.EqualTo(actual));
                    }

                    [Test]
                    public void TryDequeue_EmptyQueue_ReturnsFalse()
                    {
                        bool expected = false;

                        bool actual = queue.TryDequeue(out int _);

                        Assert.That(expected, Is.EqualTo(actual));
                    }

                    [Test]
                    public void TryDequeue_EmptyQueue_ReturnsDefault()
                    {
                        int expected = 0;

                        queue.TryDequeue(out int actual);

                        Assert.That(expected, Is.EqualTo(actual));
                    }

                    [Test]
                    public void TryDequeue_FilledQueue_ReturnsTrue()
                    {
                        queue.Enqueue(1);
                        queue.Enqueue(2);
                        queue.Enqueue(3);
                        queue.Enqueue(4);
                        queue.Enqueue(5);

                        bool expected = true;

                        bool actual = queue.TryDequeue(out int _);

                        Assert.That(expected, Is.EqualTo(actual));
                    }

                    [Test]
                    public void TryDequeue_FilledQueue_ReturnsItem()
                    {
                        queue.Enqueue(1);
                        queue.Enqueue(2);
                        queue.Enqueue(3);
                        queue.Enqueue(4);
                        queue.Enqueue(5);

                        int expected = 1;

                        queue.TryDequeue(out int actual);

                        Assert.That(expected, Is.EqualTo(actual));
                    }

                    #endregion

                    #region TryPeek

                    [Test]
                    public void TryPeek_Integer_ReturnsItem()
                    {
                        queue.Enqueue(1);
                        queue.Enqueue(2);
                        queue.Enqueue(3);
                        queue.Enqueue(4);
                        queue.Enqueue(5);

                        int expected = 1;

                        queue.TryPeek(out int actual);

                        Assert.That(expected, Is.EqualTo(actual));
                    }

                    [Test]
                    public void TryPeek_Integer_CountIsCorrect()
                    {
                        queue.Enqueue(1);

                        int expected = 1;

                        queue.TryPeek(out int _);
                        int actual = queue.Count;

                        Assert.That(expected, Is.EqualTo(actual));
                    }

                    [Test]
                    public void TryPeek_EmptyQueue_ReturnsFalse()
                    {
                        bool expected = false;

                        bool actual = queue.TryPeek(out int _);

                        Assert.That(expected, Is.EqualTo(actual));
                    }

                    [Test]
                    public void TryPeek_EmptyQueue_ReturnsDefault()
                    {
                        int expected = 0;

                        queue.TryPeek(out int actual);

                        Assert.That(expected, Is.EqualTo(actual));
                    }

                    [Test]
                    public void TryPeek_FilledQueue_ReturnsTrue()
                    {
                        queue.Enqueue(1);
                        queue.Enqueue(2);
                        queue.Enqueue(3);
                        queue.Enqueue(4);
                        queue.Enqueue(5);

                        bool expected = true;

                        bool actual = queue.TryPeek(out int _);

                        Assert.That(expected, Is.EqualTo(actual));
                    }

                    [Test]
                    public void TryPeek_FilledQueue_ReturnsItem()
                    {
                        queue.Enqueue(1);
                        queue.Enqueue(2);
                        queue.Enqueue(3);
                        queue.Enqueue(4);
                        queue.Enqueue(5);

                        int expected = 1;

                        queue.TryPeek(out int actual);

                        Assert.That(expected, Is.EqualTo(actual));
                    }

                    #endregion

                    #region ToArray

                    [Test]
                    public void ToArray_FilledQueue_ReturnsFilledArray()
                    {
                        queue.Enqueue(1);
                        queue.Enqueue(2);
                        queue.Enqueue(3);
                        queue.Enqueue(4);
                        queue.Enqueue(5);

                        int[] expected = new int[5] { 1, 2, 3, 4, 5 };

                        int[] actual = queue.ToArray();

                        CollectionAssert.AreEqual(expected, actual);
                    }

                    [Test]
                    public void ToArray_EmptyQueue_ReturnsFilledArray()
                    {
                        int[] expected = new int[0] { };

                        int[] actual = queue.ToArray();

                        CollectionAssert.AreEqual(expected, actual);
                    }

                    #endregion
                }
            }
        }
    }
}