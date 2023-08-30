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
                }
            }
        }
    }   
}
