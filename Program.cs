/*Zahady vesmiru
 * shellSort - nejsou chlupate zavorky - proc?
 * Jak uzavrit do metody Readline?
 * Proc nejde switch
 * 
 */

using System;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

namespace HelloWorld
{
    class Program
    {

        public static void Main(string[] args)
        {
<<<<<<< Updated upstream
            // comment


            //Console.WriteLine(Convert.ToChar(myString));
=======
            

            Notifications notifications = new Notifications();

            SortingAlg sortingAlg = new SortingAlg();
>>>>>>> Stashed changes









            
            Console.WriteLine("Enter the count of numbers to be sorted:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Write {i + 1}. number:");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            


            Console.WriteLine("Unsorted array is:");

            notifications.printArrayNoSort(array);

            notifications.printAnnInfoChoose();

            int choose = Convert.ToInt32(Console.ReadLine());


            switch (choose)
            {
                case 1:
                    sortingAlg.bubbleSort(array);
                    notifications.printBubbleSorted(array);
                    break;

                case 2:
                    sortingAlg.shellSort(array);
                    notifications.printShellSorted(array);
                    break;

                case 3:
                    sortingAlg.selectSort(array);
                    notifications.printSelectSorted(array);
                    break;

                default:
                    Console.WriteLine("Random bullshit");
                    break;

            }
        }
    }
}
