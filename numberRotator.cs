using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_rotater
{
    class numberRotator
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
            int k = 3;

            int length = nums.Length;
            int[] array = new int[length];

            int counter = 0;
            for (int i = length - k; i <= length - 1; i++)
            {
                array[counter] = nums[i];
                counter++;

            }
            int counter1 = k;
            for (int i = 0; i <= k; i++)
            {
                array[counter1] = nums[i];
                counter1++;

            }

             foreach(var item in array)
             {
              Console.Write(item.ToString() + " ");
          
              
             }

            Console.ReadKey();



        }
    }
    
}
