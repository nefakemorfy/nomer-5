﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //сортировка одномерного массива
            int[] array = { -5, -8, 0, 1, 3 };
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int p = array[i];
                        array[i] = array[j];
                        array[j] = p;
                    }
                }
            }
             foreach (int elem in array)
            {
                Console.WriteLine($"{elem}");
            }
            Console.Read();
        }
    }
}
