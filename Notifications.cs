using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Notifications
    {


        public void printAnnInfoChoose()
        {
            Console.WriteLine("Please choose your sorting algorithm:");
            Console.WriteLine("1 - Bubble Sort");
            Console.WriteLine("2 - Shell Sort");
            Console.WriteLine("3 - Select Sort");
            Console.WriteLine("Press  1, 2 or 3");
        }


        public void printArrayNoSort(int[] array)
        {
            foreach (int i in array)
            Console.Write(i + ", ");
            Console.WriteLine();
            Console.WriteLine();
        }


        public void printBubbleSorted(int[] array)
        {
            Console.WriteLine("Sorted numbers using algorithm Bubble sort:");
            //bubbleSort(array);
            foreach (int i in array)
                Console.Write(i + ", ");
            Console.WriteLine();
        }

        public void printShellSorted(int[] array)
        {
            Console.WriteLine("Sorted numbers using algorithm Shell sort:");
            //shellSort(array);
            foreach (int i in array)
                Console.Write(i + ", ");
            Console.WriteLine();
        }

        public void printSelectSorted(int[] array)
        {
            Console.WriteLine("Sorted numbers using algorithm Select sort:");
            //selectSort(array);
            foreach (int i in array)
                Console.Write(i + ", ");
            Console.WriteLine();
        }

    }
}
