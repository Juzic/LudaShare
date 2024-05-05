using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class SortingAlg
    {
        


        int[] array = { 5, 10, 55 };
        
        static void bubbleSort(int[] array)
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
    }
}
