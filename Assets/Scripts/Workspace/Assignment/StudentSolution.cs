using UnityEngine;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using Mono.Cecil.Cil;
using System;

namespace Assignment
{
    public class StudentSolution : IAssignment
    {
        #region Lecture
        public int[] LCT01_SelectionSortAscending(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;   
                for (int j = i;j<n;j++)
                {
                    if (numbers[i] < numbers[minIndex])
                    {
                        minIndex = j;
                    }
                }
                (numbers[i], numbers[minIndex]) = (numbers[minIndex], numbers[i]);
            }
            return numbers;
        }

        public int[] LCT02_BubbleSortAscending(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0;j < n-1;j++)
                {
                    if (numbers[i] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j+1];
                        numbers[j+1] = temp;
                    }
                }

            }
            foreach (var n_ in numbers)
            {
                Debug.Log(n_);
            }
            return numbers;
        }

        public int[] LCT03_InsertionSortAscending(int[] numbers)
        {
           int n = numbers.Length;
            for (int i = 0; i < n; i++)
            {
                int key = numbers[i];
                int j = i - 1;
                while (j >= 0 && numbers[j] > key)
                {
                    numbers[j + 1] = numbers[j];
                    j++;
                }

            }
            return numbers;
        }

        #endregion

        #region Assignment

        public int[] AS01_SelectionSortDescending(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int maxIndex = i;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] > numbers[maxIndex])
                    {
                        maxIndex = j;
                    }
                }

                int temp = numbers[maxIndex];
                numbers[maxIndex] = numbers[i];
                numbers[i] = temp;
            }
            foreach (var n_ in numbers)
            {
                Debug.Log(n_);
            }
            return numbers;
        }

        public int[] AS02_BubbleSortDescending(int[] numbers)
        {
            {
                int n = numbers.Length;
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (numbers[j] < numbers[j + 1])
                        {

                            int temp = numbers[j];
                            numbers[j] = numbers[j + 1];
                            numbers[j + 1] = temp;
                            // (numbers[j], numbers[j + 1]) = (numbers[j + 1], numbers[j]);
                        }
                    }
                }
                foreach (var n_ in numbers)
                {
                    Debug.Log(n_);
                }
                return numbers;
            }
        }

        public int[] AS03_InsertionSortDescending(int[] numbers)
        {
                int n = numbers.Length;
                for (int i = 1; i < n; ++i)
                {
                    int key = numbers[i];
                    int j = i - 1;


                    while (j >= 0 && numbers[j] < key)
                    {
                        numbers[j + 1] = numbers[j];
                        j--;
                    }
                    numbers[j + 1] = key;
                }
                foreach (var n_ in numbers)
                {
                    Debug.Log(n_);
                }
                return numbers;
            }

        public int AS04_FindTheSecondLargestNumber(int[] numbers)
        {
            Array.Sort(numbers);
            Array.Reverse(numbers);

            int largest = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < largest)
                {
                    Debug.Log(numbers[i]);
                    return numbers[i];
                }
            }

            Debug.Log(largest);
            return largest;
        }

        #endregion

        #region Extra

        public int EX01_FindLongestConsecutiveSequence(int[] numbers)
        {
            Array.Sort(numbers);

            int longest = 1;
            int currentStreak = 1;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    continue;
                }

                if (numbers[i] == numbers[i - 1] + 1)
                {
                    currentStreak++;
                }
                else
                {
                    currentStreak = 1;
                }

                if (currentStreak > longest)
                {
                    longest = currentStreak;
                }
            }

            Debug.Log($"The longest consecutive sequence is: {longest}");
            return longest;
        }
    }

    #endregion
}
}
