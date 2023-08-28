using NUnit.Framework;

namespace GrokkingAlgorithms
{
    namespace CSharp
    {
        namespace UnitTests
        {
            public sealed class BinarySearchTests
            {
                #region Default Binary Search

                [Test]
                public void BinarySearch_FoundElement_ReturnsIndex()
                {
                    int[] array = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

                    for (int i = 0; i < array.Length; ++i)
                    {
                        if (SearchingAlgorithms.BinarySearch(array, i) != i)
                            Assert.Fail();
                    }
                }

                [Test]
                public void BinarySearch_ElementNotFound_ReturnsMinusOne()
                {
                    int[] array = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                    int target = 10;

                    int result = SearchingAlgorithms.BinarySearch(array, target);

                    Assert.That(result == -1);
                }

                [Test]
                public void BinarySearch_EmptyArray_ReturnsMinusOne()
                {
                    int[] array = new int[0];
                    int target = 10;

                    int result = SearchingAlgorithms.BinarySearch(array, target);

                    Assert.That(result == -1);
                }

                #endregion

                #region Recursive Binary Search

                [Test]
                public void BinarySearchRecursive_FoundElement_ReturnsIndex()
                {
                    int[] array = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

                    for (int i = 0; i < array.Length; ++i)
                    {
                        if (SearchingAlgorithms.BinarySearchRecursive(array, i) != i)
                            Assert.Fail();
                    }
                }

                [Test]
                public void BinarySearchRecursive_ElementNotFound_ReturnsMinusOne()
                {
                    int[] array = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                    int target = 10;

                    int result = SearchingAlgorithms.BinarySearchRecursive(array, target);

                    Assert.That(result == -1);
                }

                [Test]
                public void BinarySearchRecursive_EmptyArray_ReturnsMinusOne()
                {
                    int[] array = new int[0];
                    int target = 10;

                    int result = SearchingAlgorithms.BinarySearchRecursive(array, target);

                    Assert.That(result == -1);
                }

                #endregion
            }
        }
    }  
}
