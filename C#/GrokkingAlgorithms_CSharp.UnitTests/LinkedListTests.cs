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
                    public void AddFirst_ValueType_ValueOfFirstIsCorrect()
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
                    public void AddFirst_NullAsValue_ThrowsArgumentNullException()
                    {
                        Assert.Throws<ArgumentNullException>(() => list.AddFirst(null));
                    }

                    [Test]
                    public void AddFirst_ValueTypesAndLinkedListNodes_ReturnsCount()
                    {
                        int expected = 10;

                        list.AddFirst(1);
                        list.AddFirst(new LinkedListNode<int>(1));
                        list.AddFirst(2);
                        list.AddFirst(new LinkedListNode<int>(2));
                        list.AddFirst(3);
                        list.AddFirst(new LinkedListNode<int>(3));
                        list.AddFirst(4);
                        list.AddFirst(new LinkedListNode<int>(4));
                        list.AddFirst(5);
                        list.AddFirst(new LinkedListNode<int>(5));

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
                    {
                        Assert.Throws<ArgumentNullException>(() => list.AddLast(null));
                    }

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
                    public void AddBefore_LinkedListNodesAndValues_FirstNodeIsCorrect()
                    {
                        LinkedListNode<int> node1 = list.AddLast(1);
                        LinkedListNode<int> node2 = list.AddLast(2);
                        LinkedListNode<int> node3 = list.AddLast(3);
                        LinkedListNode<int> node4 = list.AddLast(4);
                        LinkedListNode<int> node5 = list.AddLast(5);

                        LinkedListNode<int> newHead = list.AddBefore(node1, 1);
                        list.AddBefore(node2, 2);
                        list.AddBefore(node3, 3);
                        list.AddBefore(node4, 4);
                        list.AddBefore(node5, 5);

                        Assert.That(list.First == newHead);
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
                    public void AddBefore_LinkedListNodesAndLinkedListNodes_FirstNodeIsCorrect()
                    {
                        LinkedListNode<int> node1 = list.AddLast(1);
                        LinkedListNode<int> node2 = list.AddLast(2);
                        LinkedListNode<int> node3 = list.AddLast(3);
                        LinkedListNode<int> node4 = list.AddLast(4);
                        LinkedListNode<int> node5 = list.AddLast(5);

                        LinkedListNode<int> newHead = new LinkedListNode<int>(1);
                        list.AddBefore(node1, newHead);
                        list.AddBefore(node2, new LinkedListNode<int>(2));
                        list.AddBefore(node3, new LinkedListNode<int>(3));
                        list.AddBefore(node4, new LinkedListNode<int>(4));
                        list.AddBefore(node5, new LinkedListNode<int>(5));

                        Assert.That(list.First == newHead);
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

                    #region AddAfter

                    [Test]
                    public void AddAfter_LinkedListNodesAndValues_ReturnsCount()
                    {
                        int expected = 10;

                        LinkedListNode<int> node1 = list.AddLast(1);
                        LinkedListNode<int> node2 = list.AddLast(2);
                        LinkedListNode<int> node3 = list.AddLast(3);
                        LinkedListNode<int> node4 = list.AddLast(4);
                        LinkedListNode<int> node5 = list.AddLast(5);

                        list.AddAfter(node1, 1);
                        list.AddAfter(node2, 2);
                        list.AddAfter(node3, 3);
                        list.AddAfter(node4, 4);
                        list.AddAfter(node5, 5);

                        Assert.That(list.Count, Is.EqualTo(expected));
                    }

                    [Test]
                    public void AddAfter_LinkedListNodesAndValues_LastNodeIsCorrect()
                    {
                        LinkedListNode<int> node1 = list.AddLast(1);
                        LinkedListNode<int> node2 = list.AddLast(2);
                        LinkedListNode<int> node3 = list.AddLast(3);
                        LinkedListNode<int> node4 = list.AddLast(4);
                        LinkedListNode<int> node5 = list.AddLast(5);

                        list.AddAfter(node1, 1);
                        list.AddAfter(node2, 2);
                        list.AddAfter(node3, 3);
                        list.AddAfter(node4, 4);
                        LinkedListNode<int> newTail = list.AddAfter(node5, 5);

                        Assert.That(list.Last == newTail);
                    }

                    [Test]
                    public void AddAfter_NullAsLinkedListNodeWithValue_ThrowsArgumentNullException()
                    {
                        list.AddLast(1);

                        Assert.Throws<ArgumentNullException>(() => list.AddAfter(null, 1));
                    }

                    [Test]
                    public void AddAfter_WrongLinkedListNodeWithValue_ThrowsInvalidOperationException()
                    {
                        LinkedListNode<int> node = new LinkedListNode<int>(1);

                        list.AddLast(1);
                        list.AddLast(2);
                        list.AddLast(3);
                        list.AddLast(4);
                        list.AddLast(5);

                        Assert.Throws<InvalidOperationException>(() => list.AddAfter(node, 1));
                    }

                    [Test]
                    public void AddAfter_LinkedListNodesAndLinkedListNodes_ReturnsCount()
                    {
                        int expected = 10;

                        LinkedListNode<int> node1 = list.AddLast(1);
                        LinkedListNode<int> node2 = list.AddLast(2);
                        LinkedListNode<int> node3 = list.AddLast(3);
                        LinkedListNode<int> node4 = list.AddLast(4);
                        LinkedListNode<int> node5 = list.AddLast(5);

                        list.AddAfter(node1, new LinkedListNode<int>(1));
                        list.AddAfter(node2, new LinkedListNode<int>(2));
                        list.AddAfter(node3, new LinkedListNode<int>(3));
                        list.AddAfter(node4, new LinkedListNode<int>(4));
                        list.AddAfter(node5, new LinkedListNode<int>(5));

                        Assert.That(list.Count, Is.EqualTo(expected));
                    }

                    [Test]
                    public void AddAfter_NullAsLinkedListNodeWithLinkedListNode_ThrowsArgumentNullException()
                    {
                        list.AddLast(1);

                        Assert.Throws<ArgumentNullException>(() => list.AddAfter(null, new LinkedListNode<int>(1)));
                    }

                    [Test]
                    public void AddAfter_WrongLinkedListNodeWithLinkedListNode_ThrowsInvalidOperationException()
                    {
                        LinkedListNode<int> node = new LinkedListNode<int>(1);

                        list.AddLast(1);
                        list.AddLast(2);
                        list.AddLast(3);
                        list.AddLast(4);
                        list.AddLast(5);

                        Assert.Throws<InvalidOperationException>(() => list.AddAfter(node, new LinkedListNode<int>(1)));
                    }

                    #endregion

                    #region Remove

                    [Test]
                    public void Remove_LinkedListIsEmpty_ThrowsInvalidOperationException()
                    {
                        Assert.Throws<InvalidOperationException>(() => list.Remove(new LinkedListNode<int>(1)));
                    }

                    [Test]
                    public void Remove_LinkedListContainsOneNode_LinkedListCountIsZero()
                    {
                        int expectedCount = 0;
                        LinkedListNode<int> node = list.AddLast(1);

                        list.Remove(node);

                        Assert.That(list.Count, Is.EqualTo(expectedCount));

                    }

                    [Test]
                    public void Remove_LinkedListContainsOneNode_LinkedListFirstIsNull()
                    {
                        LinkedListNode<int> node = list.AddLast(1);

                        list.Remove(node);

                        Assert.That(list.First == null);
                    }

                    [Test]
                    public void Remove_LinkedListContainsOneNode_LinkedListLastIsNull()
                    {
                        LinkedListNode<int> node = list.AddLast(1);

                        list.Remove(node);

                        Assert.That(list.Last == null);
                    }

                    [Test]
                    public void Remove_LinkedListContainsMultipleNodes_LinkedListLastIsNull()
                    {
                        LinkedListNode<int> node = list.AddLast(1);

                        list.Remove(node);

                        Assert.That(list.Last == null);
                    }

                    #endregion

                    #region RemoveFirst

                    [Test]
                    public void RemoveFirst_LinkedListIsEmpty_ThrowsInvalidOperationException()
                    {
                        Assert.Throws<InvalidOperationException>(() => list.RemoveFirst());
                    }

                    [Test]
                    public void RemoveFirst_LinkedListContainsOneNode_LinkedListCountIsZero()
                    {
                        int expectedCount = 0;
                        list.AddLast(1);

                        list.RemoveFirst();

                        Assert.That(list.Count, Is.EqualTo(expectedCount));

                    }

                    [Test]
                    public void RemoveFirst_LinkedListContainsOneNode_LinkedListFirstIsNull()
                    {
                        list.AddLast(1);

                        list.RemoveFirst();

                        Assert.That(list.First == null);
                    }

                    [Test]
                    public void RemoveFirst_LinkedListContainsOneNode_LinkedListLastIsNull()
                    {
                        list.AddLast(1);

                        list.RemoveFirst();

                        Assert.That(list.Last == null);
                    }

                    #endregion

                    #region RemoveLast

                    [Test]
                    public void RemoveLast_LinkedListIsEmpty_ThrowsInvalidOperationException()
                    {
                        Assert.Throws<InvalidOperationException>(() => list.RemoveLast());
                    }

                    [Test]
                    public void RemoveLast_LinkedListContainsOneNode_LinkedListCountIsZero()
                    {
                        int expectedCount = 0;
                        list.AddLast(1);

                        list.RemoveLast();

                        Assert.That(list.Count, Is.EqualTo(expectedCount));

                    }

                    [Test]
                    public void RemoveLast_LinkedListContainsOneNode_LinkedListFirstIsNull()
                    {
                        list.AddLast(1);

                        list.RemoveLast();

                        Assert.That(list.First == null);
                    }

                    [Test]
                    public void RemoveLast_LinkedListContainsOneNode_LinkedListLastIsNull()
                    {
                        list.AddLast(1);

                        list.RemoveLast();

                        Assert.That(list.Last == null);
                    }

                    #endregion

                    #region Find

                    [Test]
                    public void Find_LinkedListIsEmpty_ThrowsInvalidOperationException()
                    {
                        Assert.Throws<InvalidOperationException>(() => list.Find(1));
                    }

                    [Test]
                    [TestCase(1, 1)]
                    [TestCase(2, 2)]
                    [TestCase(3, 3)]
                    [TestCase(4, 4)]
                    [TestCase(5, 5)]
                    public void Find_LinkedListWithAFewNodes_ReturnsCorrectNode(int input, int expected)
                    {
                        list.AddLast(1);
                        list.AddLast(2);
                        list.AddLast(3);
                        list.AddLast(4);
                        list.AddLast(5);

                        Assert.That(list.Find(input).Value, Is.EqualTo(expected));
                    }

                    [Test]
                    public void Find_ValueIsNotInLinkedList_ThrowsInvalidOperationException()
                    {
                        list.AddLast(1);
                        list.AddLast(2);
                        list.AddLast(3);
                        list.AddLast(4);
                        list.AddLast(5);

                        Assert.Throws<InvalidOperationException>(() => list.Find(6));
                    }

                    #endregion

                    #region Contains

                    [Test]
                    public void Contains_EmptyLinkedList_ReturnsFalse()
                    {
                        bool expected = false;

                        bool actual = list.Contains(5);

                        Assert.That(actual, Is.EqualTo(expected));
                    }

                    [Test]
                    public void Contains_LinkedListNodeIsNotInLinkedList_ReturnsFalse()
                    {
                        list.AddLast(1);
                        list.AddLast(2);
                        list.AddLast(3);
                        list.AddLast(4);
                        list.AddLast(5);
                        bool expected = false;

                        bool actual = list.Contains(6);

                        Assert.That(actual, Is.EqualTo(expected));
                    }

                    [Test]
                    public void Contains_LinkedListNodeIsInLinkedList_ReturnsTrue()
                    {
                        list.AddLast(1);
                        list.AddLast(2);
                        list.AddLast(3);
                        list.AddLast(4);
                        list.AddLast(5);
                        bool expected = true;

                        bool actual = list.Contains(5);

                        Assert.That(actual, Is.EqualTo(expected));
                    }

                    #endregion

                    #region ToArray

                    [Test]
                    public void ToArray_EmptyLinkedList_ReturnsEmptyArray()
                    {
                        int[] array = list.ToArray();

                        Assert.That(array, Is.Empty);
                    }

                    [Test]
                    public void ToArray_FilledLinkedList_ReturnsFilledArray()
                    {
                        list.AddLast(1);
                        list.AddLast(2);
                        list.AddLast(3);
                        list.AddLast(4);
                        list.AddLast(5);
                        int[] expected = new int[5] { 1, 2, 3, 4, 5 };

                        int[] array = list.ToArray();

                        Assert.That(array, Is.EqualTo(expected));
                    }

                    #endregion

                    #region Clear

                    [Test]
                    public void Clear_LinkedListWithNodes_LinkedListCountEqualsZero()
                    {
                        int expected = 0;

                        list.AddLast(1);
                        list.AddLast(2);
                        list.AddLast(3);
                        list.AddLast(4);
                        list.AddLast(5);

                        list.Clear();

                        Assert.That(list.Count, Is.EqualTo(expected));
                    }

                    [Test]
                    public void Clear_LinkedListWithNodes_LinkedListFirstIsNull()
                    {
                        list.AddLast(1);
                        list.AddLast(2);
                        list.AddLast(3);
                        list.AddLast(4);
                        list.AddLast(5);

                        list.Clear();

                        Assert.That(list.First, Is.EqualTo(null));
                    }

                    [Test]
                    public void Clear_LinkedListWithNodes_LinkedListLastIsNull()
                    {
                        list.AddLast(1);
                        list.AddLast(2);
                        list.AddLast(3);
                        list.AddLast(4);
                        list.AddLast(5);

                        list.Clear();

                        Assert.That(list.Last, Is.EqualTo(null));
                    }

                    #endregion
                }
            }
        }
    }
}