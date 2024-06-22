using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace SortSearchAlgs
{
    public static class TestingAlgorithmMethods
    {
        public static bool IsSorted<T>(T[] array) where T : IComparable<T>
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i].CompareTo(array[i + 1]) > 0)
                    return false;
            }
            return true;
        }

        private static double Orderliness<T>(T[] array) where T : IComparable<T>
        {
            if (array.Length == 1) return 100;

            int n = array.Length;
            int orderedPairs = 0;

            for (int i = 0; i < n - 1; i++)
            {
                if (array[i].CompareTo(array[i + 1]) <= 0)
                {
                    orderedPairs++;
                }
            }

            double orderliness = (double)orderedPairs / (n - 1) * 100;

            return Math.Round(orderliness, 0);
        }

        private static Dictionary<T, int> ElementsAndOccurrences<T>(T[] array) where T : IComparable<T>
        {
            Dictionary<T, int> occurrences = new Dictionary<T, int>();

            foreach (T element in array)
            {
                if (occurrences.ContainsKey(element))
                {
                    occurrences[element]++;
                }
                else
                {
                    occurrences[element] = 1;
                }
            }

            return occurrences;
        }

        private static TimeSpan MeasureExecutionTime<T>(Func<T[], T[]> sortingAlgorithm, T[] array) where T : IComparable<T>
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            sortingAlgorithm(array);
            stopwatch.Stop();

            return stopwatch.Elapsed;
        }
        private static TimeSpan MeasureExecutionTime<T>(Func<T[], T, List<int>> searchAlgorithm, T[] array, T value) where T : IComparable<T>
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            searchAlgorithm(array, value);
            stopwatch.Stop();

            return stopwatch.Elapsed;
        }

        public static void TestingAlgorithm<T>(Func<T[], T[]> sortAlgorithm, T[] array) where T : IComparable<T>
        {
            Console.WriteLine("\n\nТЕСТИРОВАНИЕ АЛГОРИТМА СОРТИРОВКИ\n");

            Console.WriteLine($"Тестируемый алгоритм сортировки: {sortAlgorithm.Method.Name}");

            Console.WriteLine("\nИСХОДНАЯ ИНФОРМАЦИЯ\n");
            Console.WriteLine($"Длина тестируемого массива: {array.Length}");
            Console.WriteLine($"Тип данных тестируемого массива: {array.GetType().GetElementType()}");
            Console.WriteLine($"Степень упорядоченности элементов тестируемого массива: {Orderliness(array)}%");
            Console.Write("Элементы массива: ");
            foreach (T elem in array)
            {
                Console.Write($"{elem} ");
            }
            Console.Write("\nЭлемент | Встречаемость:  ");
            foreach (KeyValuePair<T, int> pair in ElementsAndOccurrences(array))
            {
                Console.Write($"{pair.Key} | {pair.Value}  ");
            }


            Console.WriteLine("\n\nРЕЗУЛЬТАТЫ ТЕСТИРОВАНИЯ\n");

            T[] sortedArray = sortAlgorithm(array);
            Console.Write("Элементы массива после применения алгоритма: ");
            foreach (var element in sortedArray)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine($"\nСтепень упорядоченности элементов тестируемого массива после сортировки: {Orderliness(sortedArray)}%");
            Console.WriteLine($"Скорость выполнения алгоритма: {MeasureExecutionTime(sortAlgorithm, array)}");
        }

        public static void TestingAlgorithm<T>(Func<T[], T, List<int>> searchAlgorithm, T[] array, T value) where T : IComparable<T>
        {
            Console.WriteLine("\n\nТЕСТИРОВАНИЕ АЛГОРИТМА ПОИСКА\n");

            Console.WriteLine($"Тестируемый алгоритм поиска: {searchAlgorithm.Method.Name}");

            Console.WriteLine("\nИСХОДНАЯ ИНФОРМАЦИЯ\n");
            Console.WriteLine($"Длина тестируемого массива: {array.Length}");
            Console.WriteLine($"Тип данных тестируемого массива: {array.GetType().GetElementType()}");
            Console.Write("Отсортирован ли массив: ");
            if (!IsSorted(array))
                Console.WriteLine("нет");
            else
                Console.WriteLine("да");
            Console.Write("Элементы массива: ");
            foreach (T elem in array)
            {
                Console.Write($"{elem} ");
            }
            Console.Write("\nЭлемент | Встречаемость:  ");
            foreach (var pair in ElementsAndOccurrences(array))
            {
                Console.Write($"{pair.Key} | {pair.Value}  ");
            }
            Console.WriteLine($"\nИскомое значение: {value}");


            Console.WriteLine("\nРЕЗУЛЬТАТЫ ТЕСТИРОВАНИЯ\n");

            List<int> indices = searchAlgorithm(array, value);
            if (indices.Contains(-1))
            {
                Console.WriteLine($"Элемент {value} не найден в массиве");
            }
            else
            {
                Console.Write($"Индексы элемента {value}: ");
                foreach (int index in indices)
                {
                    Console.Write($"{index} ");
                }
            }
            Console.WriteLine($"\nСкорость выполнения алгоритма: {MeasureExecutionTime(searchAlgorithm, array, value)}");
        }
    }
}
