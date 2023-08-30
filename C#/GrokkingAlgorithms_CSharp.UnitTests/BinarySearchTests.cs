using NUnit.Framework;

namespace GrokkingAlgorithms
{
    namespace CSharp
    {
        namespace Algorithms
        {
            namespace UnitTests
            {
                [TestFixture]
                public sealed class BinarySearchTests
                {
                    #region Default Binary Search

                    [Test]
                    [TestCase(1, 0)]
                    [TestCase(2, 1)]
                    [TestCase(3, 2)]
                    [TestCase(4, 3)]
                    [TestCase(5, 4)]
                    [TestCase(6, 5)]
                    [TestCase(7, 6)]
                    [TestCase(8, 7)]
                    [TestCase(9, 8)]
                    [TestCase(10, 9)]
                    public void BinarySearch_ElementInArray_ReturnsIndex(int input, int expected)
                    {
                        int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                        int actual = SearchingAlgorithms.BinarySearch(array, input);

                        Assert.That(actual, Is.EqualTo(expected));
                    }

                    [Test]
                    public void BinarySearch_ElementNotInArray_ReturnsMinusOne()
                    {
                        int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                        const int NUMBER_NOT_IN_ARRAY = 0;

                        int actual = SearchingAlgorithms.BinarySearch(array, NUMBER_NOT_IN_ARRAY);

                        Assert.That(actual == -1);
                    }

                    [Test]
                    public void BinarySearch_EmptyArray_ReturnsMinusOne()
                    {
                        int[] array = new int[0];
                        int target = 10;

                        int actual = SearchingAlgorithms.BinarySearch(array, target);

                        Assert.That(actual == -1);
                    }

                    #endregion

                    #region Recursive Binary Search

                    [Test]
                    [TestCase(1, 0)]
                    [TestCase(2, 1)]
                    [TestCase(3, 2)]
                    [TestCase(4, 3)]
                    [TestCase(5, 4)]
                    [TestCase(6, 5)]
                    [TestCase(7, 6)]
                    [TestCase(8, 7)]
                    [TestCase(9, 8)]
                    [TestCase(10, 9)]
                    public void BinarySearchRecursive_ElementInArray_ReturnsIndex(int input, int expected)
                    {
                        int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                        int actual = SearchingAlgorithms.BinarySearchRecursive(array, input);

                        Assert.That(actual, Is.EqualTo(expected));
                    }

                    [Test]
                    public void BinarySearchRecursive_ElementNotInArray_ReturnsMinusOne()
                    {
                        int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                        const int NUMBER_NOT_IN_ARRAY = 0;

                        int result = SearchingAlgorithms.BinarySearchRecursive(array, NUMBER_NOT_IN_ARRAY);

                        Assert.That(result == -1);
                    }

                    [Test]
                    public void BinarySearchRecursive_EmptyArray_ReturnsMinusOne()
                    {
                        int[] array = new int[0];
                        int target = 10;

                        int actual = SearchingAlgorithms.BinarySearchRecursive(array, target);

                        Assert.That(actual == -1);
                    }

                    #endregion
                }
            }
        }
        
    }  
}
