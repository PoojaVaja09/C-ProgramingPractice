using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Array_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read and Print elements of an array
            Console.WriteLine("-----Read and Print elements of an array----");
            Console.WriteLine("Enter the size of an Array:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int[] arr2 = new int[n];
            List<int> arr3 = new List<int>();
            for (int i = 0; i < n; i++)
            {
                Console.Write("Element -"+i +":");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Elements in Array are:"+arr[i]);
            }

            //values in an array and display it in reverse order:
            Console.WriteLine("---Reverse Order----");
            for (int i=n-1; i>= 0; i--)
            {
                Console.WriteLine("Elements in Array in reverse order:" + arr[i]);
            }

            //sum of all elements of the array
            Console.WriteLine("----Sum of All elements in Array----");
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum = sum + arr[i];               
            }
            Console.WriteLine("Sum of Array Elements is:" + sum);

            //copy the elements one array into another array
            for (int i = 0; i < n; i++)
            {
                arr2[i] = arr[i];
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Array2 Elements are:" + arr2[i]);
            }
            //Count a total number of duplicate elements in an array
            //int p = 0;
            for (int m = 0; m < n-1; m++)
            {
                if(arr[m]==arr2[m+1])
                {
                    //arr3[p] = arr[m];
                    arr3.Add(arr[m]);
                    //p++;
                }
                
            }
            Console.WriteLine(arr3.Count);

            Console.ReadLine();
        
        
        }
    }
}
