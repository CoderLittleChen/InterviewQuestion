using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.数组中两数之和为指定值
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 4, 5, 5, 6, 7, 8, 10 };
            int target = 8;
            Dictionary<int, int> dic = TwoSum2(nums, target);
            foreach (KeyValuePair<int, int> item in dic)
            {
                Console.WriteLine(item.Key + "--" + item.Value);
            }
            Console.ReadKey();

        }

        /// <summary>
        /// 双层循环 时间复杂度  O(n2)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static Dictionary<int, int> TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = nums.Length - 1; i < j; j--)
                {
                    if (nums[i] + nums[j] == target && !dic.ContainsKey(i) && !dic.ContainsKey(j))
                    {
                        dic.Add(i, j);
                    }
                }
            }
            return dic;
        }


        /// <summary>
        /// 前期是数组不能有重复元素
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static Dictionary<int, int> TwoSum1(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (Array.IndexOf(nums, complement) > 0 && complement != nums[i]
                    && !dic.ContainsKey(nums[i]) && !dic.ContainsValue(nums[i]))
                {
                    dic.Add(i, Array.IndexOf(nums, complement));
                }
            }

            return dic;
        }

        /// <summary>
        /// 数组中有重复元素 
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static Dictionary<int, int> TwoSum2(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (Array.IndexOf(nums, complement) > 0 && Array.LastIndexOf(nums, complement) != i
                    && !dic.ContainsKey(nums[i]) && !dic.ContainsValue(nums[i]))
                {
                    dic.Add(i, Array.IndexOf(nums, complement));
                }
            }

            return dic;
        }


    }
}
