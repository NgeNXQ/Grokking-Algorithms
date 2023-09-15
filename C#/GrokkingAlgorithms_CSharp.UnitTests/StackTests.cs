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
                internal sealed class StackTests
                {
                    private Stack<int> stack;

                    [SetUp]
                    public void SetUp() => this.stack = new Stack<int>();

                    #region Push

                    [Test]
                    public void Push_Integer_UpdatesCount()
                    {
                        int expected = 5;

                        stack.Push(1);
                        stack.Push(2);
                        stack.Push(3);
                        stack.Push(4);
                        stack.Push(5);

                        int actual = stack.Count;

                        Assert.That(expected, Is.EqualTo(actual));
                    }

                    #endregion

                    #region Pop

                    [Test]
                    public void Pop_Integer_ReturnsItem()
                    {
                        stack.Push(1);
                        stack.Push(2);
                        stack.Push(3);
                        stack.Push(4);
                        stack.Push(5);

                        int expected = 5;

                        int actual = stack.Pop();

                        Assert.That(expected, Is.EqualTo(actual));
                    }

                    [Test]
                    public void Pop_Integer_CountIsCorrect()
                    {
                        stack.Push(1);
                        stack.Push(2);
                        stack.Push(3);
                        stack.Push(4);
                        stack.Push(5);

                        int expected = 4;

                        stack.Pop();
                        int actual = stack.Count;

                        Assert.That(expected, Is.EqualTo(actual));
                    }

                    [Test]
                    public void Pop_Integer_CountEqualsZero()
                    {
                        stack.Push(1);

                        int expected = 0;

                        stack.Pop();
                        int actual = stack.Count;

                        Assert.That(expected, Is.EqualTo(actual));
                    }

                    [Test]
                    public void Pop_EmptyStack_ThrowsInvalidOperationException()
                    {
                        Assert.Throws<InvalidOperationException>(() => stack.Pop());
                    }

                    #endregion

                    #region Peek

                    [Test]
                    public void Peek_Integer_ReturnsItem()
                    {
                        stack.Push(1);
                        stack.Push(2);
                        stack.Push(3);
                        stack.Push(4);
                        stack.Push(5);

                        int expected = 5;

                        int actual = stack.Peek();

                        Assert.That(expected, Is.EqualTo(actual));
                    }

                    [Test]
                    public void Peek_Integer_CountIsCorrect()
                    {
                        stack.Push(1);

                        int expected = 1;

                        stack.Peek();
                        int actual = stack.Count;

                        Assert.That(expected, Is.EqualTo(actual));
                    }

                    [Test]
                    public void Peek_EmptyStack_ThrowsInvalidOperationException()
                    {
                        Assert.Throws<InvalidOperationException>(() => stack.Peek());
                    }

                    #endregion

                    #region TryPop

                    [Test]
                    public void TryPop_Integer_ReturnsItem()
                    {
                        stack.Push(1);
                        stack.Push(2);
                        stack.Push(3);
                        stack.Push(4);
                        stack.Push(5);

                        int expected = 5;

                        stack.TryPop(out int actual);

                        Assert.That(expected, Is.EqualTo(actual));
                    }

                    [Test]
                    public void TryPop_Integer_CountIsCorrect()
                    {
                        stack.Push(1);
                        stack.Push(2);
                        stack.Push(3);
                        stack.Push(4);
                        stack.Push(5);

                        int expected = 4;

                        stack.TryPop(out int _);
                        int actual = stack.Count;

                        Assert.That(expected, Is.EqualTo(actual));
                    }

                    [Test]
                    public void TryPop_Integer_CountEqualsZero()
                    {
                        stack.Push(1);

                        int expected = 0;

                        stack.TryPop(out int _);
                        int actual = stack.Count;

                        Assert.That(expected, Is.EqualTo(actual));
                    }

                    [Test]
                    public void TryPop_EmptyStack_ReturnsFalse()
                    {
                        bool expected = false;

                        bool actual = stack.TryPop(out int _);

                        Assert.That(expected, Is.EqualTo(actual));
                    }

                    [Test]
                    public void TryPop_EmptyStack_ReturnsDefault()
                    {
                        int expected = 0;

                        stack.TryPop(out int actual);

                        Assert.That(expected, Is.EqualTo(actual));
                    }

                    [Test]
                    public void TryPop_FilledStack_ReturnsTrue()
                    {
                        stack.Push(1);
                        stack.Push(2);
                        stack.Push(3);
                        stack.Push(4);
                        stack.Push(5);

                        bool expected = true;

                        bool actual = stack.TryPop(out int _);

                        Assert.That(expected, Is.EqualTo(actual));
                    }

                    [Test]
                    public void TryPop_EmptyStack_ReturnsItem()
                    {
                        stack.Push(1);
                        stack.Push(2);
                        stack.Push(3);
                        stack.Push(4);
                        stack.Push(5);

                        int expected = 5;

                        stack.TryPop(out int actual);

                        Assert.That(expected, Is.EqualTo(actual));
                    }

                    #endregion

                    #region TryPeek

                    [Test]
                    public void TryPeek_Integer_ReturnsItem()
                    {
                        stack.Push(1);
                        stack.Push(2);
                        stack.Push(3);
                        stack.Push(4);
                        stack.Push(5);

                        int expected = 5;

                        stack.TryPeek(out int actual);

                        Assert.That(expected, Is.EqualTo(actual));
                    }

                    [Test]
                    public void TryPeek_Integer_CountIsCorrect()
                    {
                        stack.Push(1);

                        int expected = 1;

                        stack.TryPeek(out int _);
                        int actual = stack.Count;

                        Assert.That(expected, Is.EqualTo(actual));
                    }

                    [Test]
                    public void TryPeek_EmptyStack_ReturnsFalse()
                    {
                        bool expected = false;

                        bool actual = stack.TryPeek(out int _);

                        Assert.That(expected, Is.EqualTo(actual));
                    }

                    [Test]
                    public void TryPeek_EmptyStack_ReturnsDefault()
                    {
                        int expected = 0;

                        stack.TryPeek(out int actual);

                        Assert.That(expected, Is.EqualTo(actual));
                    }

                    [Test]
                    public void TryPeek_FilledStack_ReturnsTrue()
                    {
                        stack.Push(1);
                        stack.Push(2);
                        stack.Push(3);
                        stack.Push(4);
                        stack.Push(5);

                        bool expected = true;

                        bool actual = stack.TryPeek(out int _);

                        Assert.That(expected, Is.EqualTo(actual));
                    }

                    [Test]
                    public void TryPeek_EmptyStack_ReturnsItem()
                    {
                        stack.Push(1);
                        stack.Push(2);
                        stack.Push(3);
                        stack.Push(4);
                        stack.Push(5);

                        int expected = 5;

                        stack.TryPeek(out int actual);

                        Assert.That(expected, Is.EqualTo(actual));
                    }

                    #endregion

                    #region ToArray

                    [Test]
                    public void ToArray_FilledStack_ReturnsFilledArray()
                    {
                        stack.Push(1);
                        stack.Push(2);
                        stack.Push(3);
                        stack.Push(4);
                        stack.Push(5);

                        int[] expected = new int[5] { 5, 4, 3, 2, 1 };

                        int[] actual = stack.ToArray();

                        CollectionAssert.AreEqual(expected, actual);
                    }

                    [Test]
                    public void ToArray_EmptyStack_ReturnsFilledArray()
                    {
                        int[] expected = new int[0] { };

                        int[] actual = stack.ToArray();

                        CollectionAssert.AreEqual(expected, actual);
                    }

                    #endregion
                }
            }
        }
    }
}
