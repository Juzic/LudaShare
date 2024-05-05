/*Zahady vesmiru
 * shellSort - nejsou chlupate zavorky - proc?
 * Jak uzavrit do metody Readline?
 * Proc nejde switch
 * 
 */

using System;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {


            //Console.WriteLine(Convert.ToChar(myString));

            /*
            Console.WriteLine("Write age:");
            int hostAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is " +  hostAge);
            */




            string[] cars = { "Volvo", "BMW", "Audi" };

            Console.WriteLine(cars[0]);

            cars[0] = "Skoda";

            Console.WriteLine(cars[0]);

            Console.WriteLine(cars.Length);


            /*
            string name1 = string.Concat(firstName, lastName);


            Console.WriteLine(name);


            if (string.IsNullOrEmpty(firstName))
            {
                Console.WriteLine("srz bro");
            }

            */








            /*
            //Dont know how to seal it in a method
            Console.WriteLine("Enter the number of numbers to be sorted:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Write {i + 1}. number:");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }


            Console.WriteLine("Unsorted array is:");

            printArrayNoSort(array);

            printAnnInfoChoose();

            int choose = Convert.ToInt32(Console.ReadLine());

            if (choose == 1)
            {
                printBubbleSorted(array);
            }
            else if (choose == 2)
            {
                printShellSorted(array);
            } 

            else if(choose == 3)
            {
                printSelectSorted(array);

            }    

            /*
            switch (choose)
            {
                case == 1:
                        printBubbleSorted(array);
                    break;
                  
            }
            */



            /*
        }


        static void printArrayNoSort(int[] array)
        {
            foreach (int i in array)
                Console.Write(i + ", ");
            Console.WriteLine();
            Console.WriteLine();
        }

        // Sorting Algoritmus

        static void bubbleSort(int[] array)
        {


            for (int j = 0; j < array.Length - 1; j++)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp;
                        temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;

                    }
                }
            }
        }

        static void shellSort(int[] array)
        {
            int n = array.Length;
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i += 1)
                {
                    int temp = array[i];
                    int j;
                    for (j = i; j >= gap && array[j - gap] > temp; j -= gap) 
                        array[j] = array[j - gap];                                   //proc zde nejsou chlupate zavorky???
                        array[j] = temp;

                }
            }

        }

        static void selectSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[min_idx])
                        min_idx = j;

                    int temp = array[min_idx];
                    array[min_idx] = array[i];
                    array[i] = temp;
                }
            }
        }


        // Announcements - Sorted Algorithms

        static void printAnnInfoChoose()
        {
            Console.WriteLine("Please choose your sorting algorithm:");
            Console.WriteLine("1 - Bubble Sort");
            Console.WriteLine("2 - Shell Sort");
            Console.WriteLine("3 - Select Sort");
            Console.WriteLine("Press  1, 2 or 3");
            //int choose = Convert.ToInt32(Console.ReadLine());                 musel jsem vlozit do Main - jak to uzavrit do metody
        }

        static void printBubbleSorted(int[] array)
        {
            Console.WriteLine("Sorted numbers using algorithm Bubble sort:");
            bubbleSort(array);
            foreach (int i in array)
                Console.Write(i + ", ");
                Console.WriteLine();
        }

        static void printShellSorted(int[] array)
        {
            Console.WriteLine("Sorted numbers using algorithm Shell sort:");
            shellSort(array);
            foreach (int i in array)
                Console.Write(i + ", ");
            Console.WriteLine();
        }

        static void printSelectSorted(int[] array)
        {
            Console.WriteLine("Sorted numbers using algorithm Select sort:");
            selectSort(array);
            foreach (int i in array)
                Console.Write(i + ", ");
            Console.WriteLine();


            */


        }
    }
}