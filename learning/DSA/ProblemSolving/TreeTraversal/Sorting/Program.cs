﻿using System;
using System.Collections.Generic;

namespace Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sorting!");
            //NobleNumber cs1 = new NobleNumber();
            ////  var input = new List<int> { -4, 7, 5, 3, 5, -4, 2, -1, -9, -8, -3, 0, 9, -7, -4, -10, -4, 2, 6, 1, -2, -3, -1, -8, 0, -8, -7, -3, 5, -1, -8, -8, 8, -1, -3, 3, 6, 1, -8, -1, 3, -9, 9, -6, 7, 8, -6, 5, 0, 3, -4, 1, -10, 6, 3, -8, 0, 6, -9, -5, -5, -6, -3, 6, -5, -4, -1, 3, 7, -6, 5, -8, -5, 4, -3, 4, -6, -7, 0, -3, -2, 6, 8, -2, -6, -7, 1, 4, 9, 2, -10, 6, -2, 9, 2, -4, -4, 4, 9, 5, 0, 4, 8, -3, -9, 7, -8, 7, 2, 2, 6, -9, -10, -4, -9, -5, -1, -6, 9, -10, -1, 1, 7, 7, 1, -9, 5, -1, -3, -3, 6, 7, 3, -4, -5, -4, -7, 9, -6, -2, 1, 2, -1, -7, 9, 0, -2, -2, 5, -10, -1, 6, -7, 8, -5, -4, 1, -9, 5, 9, -2, -6, -2, -9, 0, 3, -10, 4, -6, -6, 4, -3, 6, -7, 1, -3, -5, 9, 6, 2, 1, 7, -2, 5 };
            //var input = new List<int> { 5, 6, 2 };
            //Console.WriteLine(cs1.solve(input));

            // Selection Sort
            //Console.WriteLine("Selection Sorting!");
            //var input = new List<int> {2, 5, 2,1,6 };
            //SelectionSort selectionSort = new SelectionSort();
            //selectionSort.Solve(input);

            // Bubble Sort
            //Console.WriteLine("Bubble Sorting!");
            //var input = new List<int> { 2, 5, 2, 1, 6 };
            // expected o/p 1, 2,2,5,6
            // stable 
            // inplace
            //BubbleSort bubbleSort = new BubbleSort();
            //bubbleSort.Solve(input);

            //Console.WriteLine("Merge Two array");
            /////   A = 1 3 5 4 6
            /////   B = 2 4 7 8 9 10 11
            //var inputA = new List<int>() { 1, 3, 5, 4, 6 };
            //var inputB = new List<int>() { 2, 4, 7, 8, 9, 10, 11 };
            //MergeTwoArray mergeTwoArray = new MergeTwoArray();
            //var result = mergeTwoArray.Solve(inputA, inputB);
            //foreach (var item in result)
            //{
            //    Console.Write(item + " ");
            //}

            QuickSorting quickSorting = new QuickSorting();
            var input = new List<int>() {3 ,4,3,1,5,7,3,1,10 };
            quickSorting.Solve(input);
            Console.ReadLine();
        }
    }
}
