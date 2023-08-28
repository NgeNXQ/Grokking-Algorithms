[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("GrokkingAlgorithms_CSharp.UnitTests")]

namespace GrokkingAlgorithms
{
    namespace CSharp
    {
        internal static partial class SearchingAlgorithms
        {
            internal static int BinarySearch<T>(T[] array, T item) where T : IComparable<T>
            {
                int mid;
                int low = 0;
                int high = array.Length - 1;

                while (low <= high)
                {
                    mid = (low + high) / 2;

                    if (array[mid].CompareTo(item) < 0)
                        low = mid + 1;
                    else if (array[mid].CompareTo(item) > 0)
                        high = mid - 1;
                    else
                        return mid;
                }

                return -1;
            }

            internal static int BinarySearchRecursive<T>(T[] array, T item) where T : IComparable<T>
            {
                return RecursiveBinarySearch(0, array.Length - 1);

                int RecursiveBinarySearch(int low, int high)
                {
                    if (low <= high)
                    {
                        int mid = (low + high) / 2;

                        if (array[mid].CompareTo(item) < 0)
                            return RecursiveBinarySearch(mid + 1, high);
                        else if (array[mid].CompareTo(item) > 0)
                            return RecursiveBinarySearch(low, mid - 1);
                        else
                            return mid;
                    }
                    else
                        return -1;
                }  
            }
        }
    }
}
