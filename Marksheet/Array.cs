using System;
using System.Collections.Generic;
using System.Text;

namespace Marksheet
{
    class Array
    {
        public void firstarray()
        {
            string[] my_array1 = new string[4];
            my_array1[0] = "Sanjay";
            my_array1[1] = "Amit";
            my_array1[2] = "sumit";
            my_array1[3] = "rohan";
            Console.WriteLine(my_array1[0]);
            Console.WriteLine(my_array1[1]);
            Console.WriteLine(my_array1[2]);
            Console.WriteLine(my_array1[3]);
        }
        public void secondArray()
        {
            string[] my_array2 = new string[] { "arun","varun","pawan","mayank"};
            string[] my_array3 = {"sameer","simran","sunil","dheeraj"};
            Console.WriteLine("-----my array 2------");
            Console.WriteLine(my_array2[0]);
            Console.WriteLine(my_array2[1]);
            Console.WriteLine(my_array2[2]);
            Console.WriteLine(my_array2[3]);
            Console.WriteLine("-----my array 3----");
            Console.WriteLine(my_array3[0]);
            Console.WriteLine(my_array3[1]);
            Console.WriteLine(my_array3[2]);
            Console.WriteLine(my_array3[3]);

        }
    }
    class arrayloop
    {
        public void forarray()
        {
            Console.WriteLine("-----using array for loop-----");
            int[] numbers = new int[4];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 5;
            numbers[3] = 8;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        public void eacharray()
        {
            string[] name = new string[4];
            name[0] = "sanjay";
            name[1] = "dheeraj";
            name[2] = "arun";
            name[3] = "varun";
            foreach(string item in name)
            {
                Console.WriteLine(item);
            }
        }
        
    }
    class multiarray
    {
        public void multiRecAry()
        {
            int[,] my_array = new int[3, 4]
            {
                {12,15,14,16 },
                {45,58,98,77},
                {65,54,33,88}
            };
            Console.WriteLine(my_array[2,3]);
        }
        public void multAryfor()
        {
            int[,] my_array = new int[3, 4] 
            {
            {12,13,14,55},
            {18,19,20,66},
            {22,25,24,77}
            };
            for (int i = 0; i <my_array.GetLength(0); i++)
            {
                for (int j = 0; j < my_array.GetLength(1); j++)
                {
                    Console.Write(my_array[i,j]+" ");
                   
                    
                }
                Console.Write("\n");

            }

        }
        public void multAryEach()
        {
            int[,] my_array = new int[3, 4]
                {
                {12,15,16,17},
                {25,26,27,28},
                {57,58,59,60}
                };
            foreach (var item in my_array)
            {
                Console.Write(item+" ");
                

            }
           
          

        }
        public void jaggedary()
        {
            int[][] my_array = new int[3][];
            my_array[0] = new[] { 16, 14, 25, 58, 98, 78, 88, 87, 89 };
            my_array[1] = new[] { 18, 56, 65, 75, 53 };
            my_array[2] = new[] { 26, 545, 78, 546, 231, 458, 65, 654, 632 };
            for (int i = 0; i < my_array.GetLength(0); i++)
            {
                for (int j = 0; j < my_array[i].Length; j++)
                {
                    Console.Write(my_array[i][j]+" ");
                }
                Console.WriteLine();
            }
        }
        //public void forEJugged()
        //{
        //    long[][] my_array = new long[3][];
        //    my_array[0] = (new[] { 16, 14, 25, 58, 98, 78, 88, 87, 89 });
        //    my_array[1] = new[] { 18, 56, 65, 75, 53 };
        //    my_array[2] = new[] { 26, 545, 78, 546, 231, 458, 65, 654, 632 };
        //    foreach (var item in my_array)
        //    {
        //        Console.Write(item + " ");
        //    }
        //}
    }
}
