using System;

namespace LeetcodeSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 2, 5, 5, 11 };
            var target = 10;
            foreach (var num in TwoSum(nums, target))
            {
                Console.WriteLine(num);
            }
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new[] { i, j };
                    }
                }
            }
            throw new ArgumentException("No two sum solution");
        }
    }
}
