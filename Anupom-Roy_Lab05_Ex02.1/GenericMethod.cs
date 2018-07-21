﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anupom_Roy_Lab05_Ex02._1
{
    class GenericMethod
    {
        public static void Main(string[] args)
        {
            // create arrays of int, double and char
            int[] intArray = { 1, 2, 3, 4, 5, 6 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };

            Console.Write("Array intArray contains: ");
            DisplayArray(intArray); // pass an int array argument
            Console.Write("Array intArray index 1 to 4: ");
            DisplayArray(intArray,1,4); // pass an int array argument
            Console.Write("Array doubleArray contains: ");
            DisplayArray(doubleArray); // pass a double array argument
            Console.Write("Array charArray contains: ");
            DisplayArray(charArray); // pass a char array argument
        }

        // output array of all types                           
        private static void DisplayArray<T>(T[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine();
        }
        // Overload generic method                           
        private static void DisplayArray<T>(T[] inputArray, int lowIndex, int highIndex)
        {
            T[] newArray=new T[highIndex];           
            int i = 0;            
            while (lowIndex <= highIndex )
            {              
                newArray[i] = inputArray[lowIndex];
                i++;
                lowIndex++;
            }
            foreach (var element in newArray)
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine();
        }


    }
}
