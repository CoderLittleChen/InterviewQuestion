using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.逆序数组
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            nums = ReverseArray(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i]+"  ");
            }

            Console.ReadKey();

        }

        public static int[] ReverseArray(int[] nums)
        {
            int temp = 0;
            int i = 0, j = nums.Length - 1;
            while (i < j)
            {
                temp = nums[j];
                nums[j] = nums[i];
                nums[i] = temp;
                i++;
                j--;
            }
            return nums;
        }

    }
}
