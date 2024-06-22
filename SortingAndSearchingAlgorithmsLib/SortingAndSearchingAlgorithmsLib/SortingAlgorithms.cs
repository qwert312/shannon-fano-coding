using System;
using System.Collections.Generic;
using System.Linq;

namespace SortSearchAlgs
{
    public static class SortingAlgorithms
    {
        public static T[] BubbleSort<T>(T[] array) where T : IComparable<T>
        {
            if (array.Length == 0)
            {
                throw new Exception("В массиве нет элементов");
            }

            T[] arrayCopy = new T[array.Length];
            Array.Copy(array, arrayCopy, array.Length);

            int l = arrayCopy.Length - 1;
            T temp;
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < l - i; j++)
                {
                    if (arrayCopy[j].CompareTo(arrayCopy[j + 1]) > 0)
                    {
                        temp = arrayCopy[j + 1];
                        arrayCopy[j + 1] = arrayCopy[j];
                        arrayCopy[j] = temp;
                    }
                }
            }
            return arrayCopy;
        }

        public static T[] SelectionSort<T>(T[] array) where T : IComparable<T>
        {
            if (array.Length == 0)
            {
                throw new Exception("В массиве нет элементов");
            }

            T[] arrayCopy = new T[array.Length];
            Array.Copy(array, arrayCopy, array.Length);

            int l = arrayCopy.Length;

            for (int i = 0; i < l - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < l; j++)
                {
                    if (arrayCopy[minIndex].CompareTo(arrayCopy[j]) > 0)
                    {
                        minIndex = j;
                    }
                }
                T temp = arrayCopy[minIndex];
                arrayCopy[minIndex] = arrayCopy[i];
                arrayCopy[i] = temp;
            }

            return arrayCopy;
        }

        public static T[] InsertionSort<T>(T[] array) where T : IComparable<T>
        {
            if (array.Length == 0)
            {
                throw new Exception("В массиве нет элементов");
            }

            T[] arrayCopy = new T[array.Length];
            Array.Copy(array, arrayCopy, array.Length);

            T temp;
            for (int i = 1; i < arrayCopy.Length; i++)
            {
                T keyElem = arrayCopy[i];
                int j = i;
                while ((j > 0) && (arrayCopy[j - 1].CompareTo(keyElem) > 0)) 
                {
                    temp = arrayCopy[j - 1];
                    arrayCopy[j - 1] = arrayCopy[j];
                    arrayCopy[j] = temp;
                    j--;
                }
            }

            return arrayCopy;
        }

        public static T[] MergeSort<T>(T[] array) where T : IComparable<T>
        {
            void Merge(T[] targetArray, int lowIndex, int middleIndex, int highIndex)
            {
                int left = lowIndex;
                int right = middleIndex + 1;
                T[] tempArray = new T[highIndex - lowIndex + 1];
                int index = 0;

                while ((left <= middleIndex) && (right <= highIndex))
                {
                    if (targetArray[left].CompareTo(targetArray[right]) < 0)
                    {
                        tempArray[index] = targetArray[left];
                        left++;
                    }
                    else
                    {
                        tempArray[index] = targetArray[right];
                        right++;
                    }

                    index++;
                }

                for (int i = left; i <= middleIndex; i++)
                {
                    tempArray[index] = targetArray[i];
                    index++;
                }

                for (int i = right; i <= highIndex; i++)
                {
                    tempArray[index] = targetArray[i];
                    index++;
                }

                for (int i = 0; i < tempArray.Length; i++)
                {
                    targetArray[lowIndex + i] = tempArray[i];
                }
            }

            T[] MergeRecursive(T[] targetArray, int lowIndex, int highIndex)
            {
                if (lowIndex < highIndex)
                {
                    int middleIndex = (lowIndex + highIndex) / 2;
                    MergeRecursive(targetArray, lowIndex, middleIndex);
                    MergeRecursive(targetArray, middleIndex + 1, highIndex);
                    Merge(targetArray, lowIndex, middleIndex, highIndex);
                }
                return targetArray;
            }

            if (array.Length == 0)
            {
                throw new Exception("В массиве нет элементов");
            }

            T[] arrayCopy = new T[array.Length];
            Array.Copy(array, arrayCopy, array.Length);

            return MergeRecursive(arrayCopy, 0, arrayCopy.Length - 1);
        }

        public static T[] QuickSort<T>(T[] array) where T : IComparable<T>
        {
            void QuickSortRecursive(T[] targetArray, int low, int high)
            {
                if (low < high)
                {
                    int partitionIndex = Partition(targetArray, low, high);
                    QuickSortRecursive(targetArray, low, partitionIndex - 1);
                    QuickSortRecursive(targetArray, partitionIndex + 1, high);
                }
            }

            int Partition(T[] targetArray, int low, int high)
            {
                T pivot = targetArray[high];
                int i = low - 1;
                T temp;

                for (int j = low; j < high; j++)
                {
                    if (targetArray[j].CompareTo(pivot) <= 0)
                    {
                        i++;
                        temp = targetArray[i];
                        targetArray[i] = targetArray[j];
                        targetArray[j] = temp;
                    }
                }

                temp = targetArray[i + 1];
                targetArray[i + 1] = targetArray[high];
                targetArray[high] = temp;

                return i + 1;
            }

            if (array.Length == 0)
            {
                throw new Exception("В массиве нет элементов");
            }

            T[] arrayCopy = new T[array.Length];
            Array.Copy(array, arrayCopy, array.Length);

            QuickSortRecursive(arrayCopy, 0, arrayCopy.Length - 1);
            return arrayCopy;
        }

        public static T[] HeapSort<T>(T[] array) where T : IComparable<T>
        {
            void Heapify(T[] targetArray, int size, int i)
            {
                int largest = i;
                int left = 2 * i + 1;
                int right = 2 * i + 2;

                if (left < size && targetArray[left].CompareTo(targetArray[largest]) > 0)
                    largest = left;

                if (right < size && targetArray[right].CompareTo(targetArray[largest]) > 0)
                    largest = right;

                if (largest != i)
                {
                    T temp = targetArray[i];
                    targetArray[i] = targetArray[largest];
                    targetArray[largest] = temp;

                    Heapify(targetArray, size, largest);
                }
            }

            if (array.Length == 0)
            {
                throw new Exception("В массиве нет элементов");
            }

            T[] arrayCopy = new T[array.Length];
            Array.Copy(array, arrayCopy, array.Length);

            int l = arrayCopy.Length;

            for (int i = l / 2 - 1; i >= 0; i--)
                Heapify(arrayCopy, l, i);

            for (int i = l - 1; i >= 0; i--)
            {
                T temp = arrayCopy[0];
                arrayCopy[0] = arrayCopy[i];
                arrayCopy[i] = temp;

                Heapify(arrayCopy, i, 0);
            }

            return arrayCopy;
        }

        public static int[] CountingSort(int[] array)
        {
            if (array.Length == 0)
            {
                throw new Exception("В массиве нет элементов");
            }

            int min = array.Min();
            int max = array.Max();

            int correctionFactor = min != 0 ? -min : 0;
            max += correctionFactor;

            int[] count = new int[max + 1];

            int[] output = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                count[array[i] + correctionFactor]++;
            }

            int index = 0;
            for (int i = 0; i < count.Length; i++)
            {
                for (int j = 0; j < count[i]; j++)
                {
                    output[index] = i - correctionFactor;
                    index++;
                }
            }

            return output;
        }   
    }
}