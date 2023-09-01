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
                public sealed class LinkedListTests
                {
                    private LinkedList<int> list;

                    [SetUp]
                    public void SetUp() => list = new LinkedList<int>();

                    #region AddFirst

                    [Test]
                    public void AddFirst_DefaultValue_FirstValueIsCorrect()
                    {
                        int expected = 5;

                        list.AddFirst(1);
                        list.AddFirst(2);
                        list.AddFirst(3);
                        list.AddFirst(4);
                        list.AddFirst(5);

                        Assert.That(list.First.Value == expected);
                    }

                    [Test]
                    public void AddFirst_LinkedListNode_FirstValueIsCorrect()
                    {
                        int expected = 5;

                        list.AddFirst(new LinkedListNode<int>(1));
                        list.AddFirst(new LinkedListNode<int>(2));
                        list.AddFirst(new LinkedListNode<int>(3));
                        list.AddFirst(new LinkedListNode<int>(4));
                        list.AddFirst(new LinkedListNode<int>(5));

                        Assert.That(list.First.Value == expected);
                    }

                    [Test]
                    public void AddFirst_Null_ThrowsArgumentNullException() 
                        => Assert.Throws<ArgumentNullException>(() => list.AddFirst(null));

                    [Test]
                    public void AddFirst_ValuesAndLinkedListNodes_ReturnsCount()
                    {
                        int expected = 10;

                        list.AddLast(1);
                        list.AddLast(new LinkedListNode<int>(1));
                        list.AddLast(2);
                        list.AddLast(new LinkedListNode<int>(2));
                        list.AddLast(3);
                        list.AddLast(new LinkedListNode<int>(3));
                        list.AddLast(4);
                        list.AddLast(new LinkedListNode<int>(4));
                        list.AddLast(5);
                        list.AddLast(new LinkedListNode<int>(5));

                        Assert.That(expected, Is.EqualTo(list.Count));
                    }

                    #endregion

                    #region AddLast

                    [Test]
                    public void AddLast_DefaultValue_LastValueIsCorrect()
                    {
                        int expected = 5;

                        list.AddLast(1);
                        list.AddLast(2);
                        list.AddLast(3);
                        list.AddLast(4);
                        list.AddLast(5);

                        Assert.That(list.Last.Value == expected);
                    }

                    [Test]
                    public void AddLast_LinkedListNode_LastValueIsCorrect()
                    {
                        int expected = 5;

                        list.AddLast(new LinkedListNode<int>(1));
                        list.AddLast(new LinkedListNode<int>(2));
                        list.AddLast(new LinkedListNode<int>(3));
                        list.AddLast(new LinkedListNode<int>(4));
                        list.AddLast(new LinkedListNode<int>(5));

                        Assert.That(list.Last.Value == expected);
                    }

                    [Test]
                    public void AddLast_Null_ThrowsArgumentNullException()
                        => Assert.Throws<ArgumentNullException>(() => list.AddLast(null));

                    [Test]
                    public void AddLast_ValuesAndLinkedListNodes_ReturnsCount()
                    {
                        int expected = 10;

                        list.AddLast(1);
                        list.AddLast(new LinkedListNode<int>(1));
                        list.AddLast(2);
                        list.AddLast(new LinkedListNode<int>(2));
                        list.AddLast(3);
                        list.AddLast(new LinkedListNode<int>(3));
                        list.AddLast(4);
                        list.AddLast(new LinkedListNode<int>(4));
                        list.AddLast(5);
                        list.AddLast(new LinkedListNode<int>(5));

                        Assert.That(expected, Is.EqualTo(list.Count));
                    }

                    #endregion

                    #region AddBefore

                    [Test]
                    public void AddBefore_LinkedListNodesAndValues_ReturnsCount()
                    {
                        int expected = 10;

                        LinkedListNode<int> node1 = list.AddLast(1);
                        LinkedListNode<int> node2 = list.AddLast(2);
                        LinkedListNode<int> node3 = list.AddLast(3);
                        LinkedListNode<int> node4 = list.AddLast(4);
                        LinkedListNode<int> node5 = list.AddLast(5);

                        list.AddBefore(node1, 1);
                        list.AddBefore(node2, 2);
                        list.AddBefore(node3, 3);
                        list.AddBefore(node4, 4);
                        list.AddBefore(node5, 5);

                        Assert.That(list.Count, Is.EqualTo(expected));
                    }

                    [Test]
                    public void AddBefore_NullAsLinkedListNodeWithValue_ThrowsArgumentNullException()
                    {
                        list.AddLast(1);

                        Assert.Throws<ArgumentNullException>(() => list.AddBefore(null, 1));
                    }

                    [Test]
                    public void AddBefore_WrongLinkedListNodeWithValue_ThrowsInvalidOperationException()
                    {
                        LinkedListNode<int> node = new LinkedListNode<int>(1);

                        list.AddLast(1);
                        list.AddLast(2);
                        list.AddLast(3);
                        list.AddLast(4);
                        list.AddLast(5);

                        Assert.Throws<InvalidOperationException>(() => list.AddBefore(node, 1));
                    }

                    [Test]
                    public void AddBefore_LinkedListNodesAndLinkedListNodes_ReturnsCount()
                    {
                        int expected = 10;

                        LinkedListNode<int> node1 = list.AddLast(1);
                        LinkedListNode<int> node2 = list.AddLast(2);
                        LinkedListNode<int> node3 = list.AddLast(3);
                        LinkedListNode<int> node4 = list.AddLast(4);
                        LinkedListNode<int> node5 = list.AddLast(5);

                        list.AddBefore(node1, new LinkedListNode<int>(1));
                        list.AddBefore(node2, new LinkedListNode<int>(2));
                        list.AddBefore(node3, new LinkedListNode<int>(3));
                        list.AddBefore(node4, new LinkedListNode<int>(4));
                        list.AddBefore(node5, new LinkedListNode<int>(5));

                        Assert.That(list.Count, Is.EqualTo(expected));
                    }

                    [Test]
                    public void AddBefore_NullAsLinkedListNodeWithLinkedListNode_ThrowsArgumentNullException()
                    {
                        list.AddLast(1);

                        Assert.Throws<ArgumentNullException>(() => list.AddBefore(null, new LinkedListNode<int>(1)));
                    }

                    [Test]
                    public void AddBefore_WrongLinkedListNodeWithLinkedListNode_ThrowsInvalidOperationException()
                    {
                        LinkedListNode<int> node = new LinkedListNode<int>(1);

                        list.AddLast(1);
                        list.AddLast(2);
                        list.AddLast(3);
                        list.AddLast(4);
                        list.AddLast(5);

                        Assert.Throws<InvalidOperationException>(() => list.AddBefore(node, new LinkedListNode<int>(1)));
                    }

                    #endregion


                }
            }
        }
    }
}