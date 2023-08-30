namespace GrokkingAlgorithms
{
    namespace CSharp
    {
        namespace Algorithms
        {
            internal static class SortingAlgorithms
            {
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
            }
        }
    }
}
