///
/*
Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.

You must write an algorithm with O(log n) runtime complexity.

Example 1:

Input: nums = [1,3,5,6], target = 5
Output: 2
Example 2:

Input: nums = [1,3,5,6], target = 2
Output: 1
Example 3:

Input: nums = [1,3,5,6], target = 7
Output: 4
Example 4:

Input: nums = [1,3,5,6], target = 0
Output: 0
Example 5:

Input: nums = [1], target = 0
Output: 0
*/
///





using System;

namespace SearchInsertPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 3, 5, 6 };
            int target = 7;

            Solution s = new Solution();
            int ret = s.SearchInsert(nums, target);

            Console.WriteLine(ret);
        }
    }


    public class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {
            //Search if the target exists

            int firstPos = 0;
            int lastPos = nums.Length - 1;

            int mid = -1;
            while( firstPos <= lastPos)
            {
                mid = firstPos + (lastPos - firstPos) / 2;

                if (nums[mid] == target)
                    return mid;
                else if (nums[mid] > target)
                    lastPos = mid - 1;
                else
                    firstPos = mid + 1;
            }

            return firstPos;
            
        }
    }

}
