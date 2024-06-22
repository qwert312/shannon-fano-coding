using System;
using System.Collections.Generic;

namespace SortSearchAlgs
{
    public static class SearchingAlgorithms 
    {
        public static List<int> LinearSearch<T>(T[] array, T value) where T : IComparable<T>
        {
            if (array.Length == 0)
            {
                throw new Exception("В массиве нет элементов");
            }

            List<int> indices = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].CompareTo(value) == 0)
                {
                    indices.Add(i);  
                }
            }

            if (indices.Count == 0)
            {
                indices.Add(-1);
            }

            return indices;  
        }
        public static List<int> BinarySearch<T>(T[] array, T value) where T : IComparable<T>
        {
            if (array.Length == 0)
            {
                throw new Exception("В массиве нет элементов");
            }

            List<int> indices = new List<int>();

            if (!TestingAlgorithmMethods.IsSorted(array))
            {
                Console.WriteLine("Массив не отсортирован");
                indices.Add(-1);
                return indices;
            }

            int left = 0;
            int right = array.Length - 1;

            int resultIndex = -1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                int comparisonResult = array[mid].CompareTo(value);

                if (comparisonResult == 0)
                {
                    resultIndex = mid;
                    indices.Add(mid);

                    int temp = mid - 1;
                    while (temp >= left && array[temp].CompareTo(value) == 0)
                    {
                        indices.Add(temp);
                        temp--;
                    }

                    temp = mid + 1;
                    while (temp <= right && array[temp].CompareTo(value) == 0)
                    {
                        indices.Add(temp);
                        temp++;
                    }

                    break;
                }
                else if (comparisonResult < 0)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            if (indices.Count == 0)
            {
                indices.Add(resultIndex);
            }

            return indices;
        }

        public static List<int> JumpSearch<T>(T[] array, T value) where T : IComparable<T>
        {
            if (array.Length == 0)
            {
                throw new Exception("В массиве нет элементов");
            }

            List<int> indices = new List<int>();

            if (!TestingAlgorithmMethods.IsSorted(array))
            {
                Console.WriteLine("Массив не отсортирован");
                indices.Add(-1);
                return indices;
            }

            int l = array.Length - 1;
            int jump = (int)Math.Floor(Math.Sqrt(l));
            int left = 0;
            int right = 0;

            while (right < l)
            {
                left = right;
                right = Math.Min(right + jump, l);
                if (array[right].CompareTo(value) >= 0)
                {
                    for (int i = left; i < right; i++)
                    {
                        if (array[i].CompareTo(value) == 0)
                        {
                            indices.Add(i);
                        }
                    }
                }
            }

            if (indices.Count == 0)
            {
                indices.Add(-1);
            }

            return indices;
        }

        public static List<int> InterpolationSearch<T>(T[] array, T value) where T : IComparable<T>
        {
            if (array.Length == 0)
            {
                throw new Exception("В массиве нет элементов");
            }

            List<int> indices = new List<int>();

            if (!TestingAlgorithmMethods.IsSorted(array))
            {
                Console.WriteLine("Массив не отсортирован");
                indices.Add(-1);
                return indices; 
            }

            int left = 0;
            int right = array.Length - 1;

            int resultIndex = -1;

            while (left <= right)
            {
                int position = left + (int)(((double)(right - left) / (array[right].CompareTo(array[left]))) * (value.CompareTo(array[left])));
                int comparisonResult = array[position].CompareTo(value);

                if (comparisonResult == 0)
                {
                    resultIndex = position;
                    indices.Add(position);

                    int temp = position - 1;
                    while (temp >= left && array[temp].CompareTo(value) == 0)
                    {
                        indices.Add(temp);
                        temp--;
                    }

                    temp = position + 1;
                    while (temp <= right && array[temp].CompareTo(value) == 0)
                    {
                        indices.Add(temp);
                        temp++;
                    }

                    break;
                }
                else if (comparisonResult < 0)
                {
                    left = position + 1;
                }
                else
                {
                    right = position - 1;
                }
            }

            if (indices.Count == 0)
            {
                indices.Add(resultIndex);
            }

            return indices;
        }
    }
}
