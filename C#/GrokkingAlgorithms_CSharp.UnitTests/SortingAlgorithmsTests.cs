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
                internal sealed class SortingAlgorithmsTests
                {
                    #region Selection Sort Tests

                    [Test]
                    public void SelectionSort_DefaultArray_ReturnsSortedArrayByAscending()
                    {
                        int[] array = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
                        int[] expected = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                        SortingAlgorithms.SelectionSort(array, SortingAlgorithms.Order.Ascending);

                        Assert.That(expected, Is.EqualTo(array));
                    }

                    [Test]
                    public void SelectionSort_DefaultArray_ReturnsSortedArrayByDescending()
                    {
                        int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                        int[] expected = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

                        SortingAlgorithms.SelectionSort(array, SortingAlgorithms.Order.Descending);

                        Assert.That(expected, Is.EqualTo(array));
                    }

                    [Test]
                    public void SelectionSort_EmptyArray_ReturnsEmptyArray()
                    {
                        int[] array = new int[] { };
                        int[] expected = new int[] { };

                        SortingAlgorithms.SelectionSort(array, SortingAlgorithms.Order.Ascending);

                        Assert.That(expected, Is.EqualTo(array));
                    }

                    [Test]
                    public void SelectionSort_NullAsArray_ThrowsNullArgumentException()
                    {
                        int[] array = null;

                        Assert.Throws<ArgumentNullException>(() => SortingAlgorithms.SelectionSort(array, SortingAlgorithms.Order.Ascending));
                    }

                    #endregion

                    #region Insertion Sort Tests

                    [Test]
                    public void InsertionSort_DefaultArray_ReturnsSortedArrayByAscending()
                    {
                        int[] array = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
                        int[] expected = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                        SortingAlgorithms.InsertionSort(array, SortingAlgorithms.Order.Ascending);

                        Assert.That(expected, Is.EqualTo(array));
                    }

                    [Test]
                    public void InsertionSort_DefaultArray_ReturnsSortedArrayByDescending()
                    {
                        int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                        int[] expected = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

                        SortingAlgorithms.InsertionSort(array, SortingAlgorithms.Order.Descending);

                        Assert.That(expected, Is.EqualTo(array));
                    }

                    [Test]
                    public void InsertionSort_EmptyArray_ReturnsEmptyArray()
                    {
                        int[] array = new int[] { };
                        int[] expected = new int[] { };

                        SortingAlgorithms.InsertionSort(array, SortingAlgorithms.Order.Ascending);

                        Assert.That(expected, Is.EqualTo(array));
                    }

                    [Test]
                    public void InsertionSort_NullAsArray_ThrowsNullArgumentException()
                    {
                        int[] array = null;

                        Assert.Throws<ArgumentNullException>(() => SortingAlgorithms.InsertionSort(array, SortingAlgorithms.Order.Ascending));
                    }

                    #endregion

                    #region Bubble Sort Tests

                    [Test]
                    public void BubbleSort_DefaultArray_ReturnsSortedArrayByAscending()
                    {
                        int[] array = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
                        int[] expected = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                        SortingAlgorithms.BubbleSort(array, SortingAlgorithms.Order.Ascending);

                        Assert.That(expected, Is.EqualTo(array));
                    }

                    [Test]
                    public void BubbleSort_DefaultArray_ReturnsSortedArrayByDescending()
                    {
                        int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                        int[] expected = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

                        SortingAlgorithms.BubbleSort(array, SortingAlgorithms.Order.Descending);

                        Assert.That(expected, Is.EqualTo(array));
                    }

                    [Test]
                    public void BubbleSort_EmptyArray_ReturnsEmptyArray()
                    {
                        int[] array = new int[] { };
                        int[] expected = new int[] { };

                        SortingAlgorithms.BubbleSort(array, SortingAlgorithms.Order.Ascending);

                        Assert.That(expected, Is.EqualTo(array));
                    }

                    [Test]
                    public void BubbleSort_NullAsArray_ThrowsNullArgumentException()
                    {
                        int[] array = null;

                        Assert.Throws<ArgumentNullException>(() => SortingAlgorithms.BubbleSort(array, SortingAlgorithms.Order.Ascending));
                    }

                    #endregion

                    #region Quick Sort Tests

                    [Test]
                    public void QuickSortPivotLeftWithoutMedian_DefaultArray_ReturnsSortedArrayByAscending()
                    {
                        int[] array = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
                        int[] expected = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                        SortingAlgorithms.QuickSortPivotLeftWithoutMedian(array, SortingAlgorithms.Order.Ascending);

                        Assert.That(expected, Is.EqualTo(array));
                    }

                    [Test]
                    public void QuickSortPivotLeftWithoutMedian_DefaultArray_ReturnsSortedArrayByDescending()
                    {
                        int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                        int[] expected = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

                        SortingAlgorithms.QuickSortPivotLeftWithoutMedian(array, SortingAlgorithms.Order.Descending);

                        Assert.That(expected, Is.EqualTo(array));
                    }

                    [Test]
                    public void QuickSort_EmptyArray_ReturnsEmptyArray()
                    {
                        int[] array = new int[] { };
                        int[] expected = new int[] { };

                        SortingAlgorithms.QuickSortPivotLeftWithoutMedian(array, SortingAlgorithms.Order.Ascending);

                        Assert.That(expected, Is.EqualTo(array));
                    }

                    [Test]
                    public void QuickSort_NullAsArray_ThrowsNullArgumentException()
                    {
                        int[] array = null;

                        Assert.Throws<ArgumentNullException>(() => SortingAlgorithms.QuickSortPivotLeftWithoutMedian(array, SortingAlgorithms.Order.Ascending));
                    }

                    #endregion
                }
            }
        }
    }
}
