using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class SortingAlg
    {
        
        public void bubbleSort(int[] array)
        {
            
            int temp;
            for (int j=0; j <= array.Length; j++)
            {
                for (int i=0; i < array.Length; i++)
                {
                    if (array[i] >array[i++])
                    {
                        temp = array[i+1];
                        array[i + 1] = array[i];
                        array[i] = temp; 

                    }
                }
            }
        }


        public void shellSort(int[] array)
        {
            int n = array.Length;
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i += 1)
                {
                    int temp = array[i];
                    int j;
                    for (j = i; j >= gap && array[j - gap] > temp; j -= gap)
                        array[j] = array[j - gap];
                    array[j] = temp;

                }
            }
        }

        public void selectSort(int[] array)
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


    }
}
