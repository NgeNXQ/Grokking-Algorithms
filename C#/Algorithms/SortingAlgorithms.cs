﻿namespace GrokkingAlgorithms
{
    namespace CSharp
    {
        namespace Algorithms
        {
            internal static class SortingAlgorithms
            {
                #region Supporting members

                internal enum Order : byte
                {
                    Ascending,
                    Descending
                }

                private static void Swap<T>(T[] array, int index1, int index2)
                {
                    T temp = array[index1];
                    array[index1] = array[index2];
                    array[index2] = temp;
                }

                #endregion

                #region Selection Sort

                public static void SelectionSort<T>(T[] array, Order order) where T : IComparable<T>
                {
                    int index;

                    switch (order)
                    {
                        case Order.Ascending:
                            {
                                for (int i = 0; i < array.Length; ++i)
                                {
                                    index = i;

                                    for (int j = i + 1; j < array.Length; ++j)
                                    {
                                        if (array[i].CompareTo(array[j]) > 0)
                                            index = j;
                                    }

                                    if (i != index)
                                        Swap(array, index, i);
                                }
                            }
                            break;
                        case Order.Descending:
                            {
                                for (int i = 0; i < array.Length; ++i)
                                {
                                    index = i;

                                    for (int j = i + 1; j < array.Length; ++j)
                                    {
                                        if (array[i].CompareTo(array[j]) < 0)
                                            index = j;
                                    }

                                    if (i != index)
                                        Swap(array, index, i);
                                }
                            }
                            break;
                    }
                }

                #endregion

                #region Quick Sort

                public static void QuickSortPivotLeftWithoutMedian<T>(T[] array, Order order) where T : IComparable<T>
                {
                    switch(order)
                    {
                        case Order.Ascending:
                            PartitionAscending(0, array.Length, 0);
                            break;
                        case Order.Descending:
                            PartitionDescending(0, array.Length, 0);
                            break;
                    }

                    void PartitionAscending(int low, int high, int depth)
                    {
                        if (low < high)
                        {
                            int pivot = low;

                            for (int i = low + 1; i < high; ++i)
                            {
                                if (array[i].CompareTo(array[low]) < 0)
                                    Swap(array, ++pivot, i);
                            }

                            Swap(array, low, pivot);

                            if (pivot - low > 1)
                                PartitionAscending(low, pivot, ++depth);

                            if (depth-- > 2)
                                return;

                            PartitionAscending(pivot + 1, high, depth);
                        }
                    }

                    void PartitionDescending(int low, int high, int depth)
                    {
                        if (low < high)
                        {
                            int pivot = low;

                            for (int i = low + 1; i < high; ++i)
                            {
                                if (array[i].CompareTo(array[low]) > 0)
                                    Swap(array, ++pivot, i);
                            }

                            Swap(array, low, pivot);

                            if (pivot - low > 1)
                                PartitionDescending(low, pivot, ++depth);

                            if (depth-- > 2)
                                return;

                            PartitionDescending(pivot + 1, high, depth);
                        }
                    }
                }

                #endregion
            }
        }
    }
}
