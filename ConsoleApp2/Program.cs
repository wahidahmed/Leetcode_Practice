using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 120. Triangle

            int[][] triangleArr = new int[][]
            {
    new int[] { 1,3,4},
    new int[] { 4,5,1},
    new int[] { 7,23,2},
    new int[] { 1,9,9},
            };
            //LeetCode.MinimumTotal(triangleArr);
            #endregion 120. Triangle

            #region 35. Search Insert Position
            //int[] nums = { 3, 5, 7, 12, 13, 45, 78 };
            //int[] nums = { 1, 3, 5, 6 };
            //Console.WriteLine(LeetCode.SearchInsert(nums, 7));
            #endregion 35. Search Insert Position

            #region 804. Unique Morse Code Words

            string[] words = { "gin", "zen", "gig", "msg" };
            //LeetCode.UniqueMorseRepresentations(words);

            #endregion 804. Unique Morse Code Words

            #region 33. Search in Rotated Sorted Array

            //int[] numsPivot = {5,1,3 };
            //Console.WriteLine(LeetCode.SearchInRotatedSortedArray(numsPivot, 5));

            #endregion  33. Search in Rotated Sorted Array

            #region 34. Find First and Last Position of Element in Sorted Array

            //int[] nums = { 5, 7, 7, 8, 8, 10 };
            //Console.WriteLine(LeetCode.SearchRange(nums, 8));

            #endregion  34. Find First and Last Position of Element in Sorted Array


            #region #region 153. Find Minimum in Rotated Sorted Array
            //int[] nums = { 4, 5, 6, 7, 0, 1, 2 };
            //Console.WriteLine(LeetCode.FindMin_153(nums));
            #endregion #region 153. Find Minimum in Rotated Sorted Array

            #region 154. Find Minimum in Rotated Sorted Array II
            //int[] nums = { 4, 5, 6, 7, 0, 1, 2 };
            //Console.WriteLine(LeetCode.FindMin_154(nums));
            #endregion 154. Find Minimum in Rotated Sorted Array II

            #region 1281. Subtract the Product and Sum of Digits of an Integer
            //LeetCode.SubtractProductAndSum(600);
            #endregion 1281. Subtract the Product and Sum of Digits of an Integer

            #region 1822. Sign of the Product of an Array

            //int[] nums = { 41, 65, 14, 80, 20, 10, 55, 58, 24, 56, 28, 86, 96, 10, 3, 84, 4, 41, 13, 32, 42, 43, 83, 78, 82, 70, 15, -41 };
            //Console.WriteLine(LeetCode.ArraySign(nums));

            #endregion 1822. Sign of the Product of an Array

            #region 976. Largest Perimeter Triangle
            //int[] nums = { 3, 6, 2, 3 };

            //Console.WriteLine(LeetCode.LargestPerimeter(nums));
            #endregion 976. Largest Perimeter Triangle

        



        }

    }

    public static class LeetCode
    {
        #region 120. Triangle
        public static int MinimumTotal(int[][] triangleArr)
        {
            foreach (var item in triangleArr)
            {
                foreach (var el in item)
                {

                }
            }
            return 0;
        }
        #endregion 120. Triangle

        #region 35. Search Insert Position
        public static int SearchInsert(int[] nums, int target)
        {
            //3,5,7,12,13,45,78
            int left = 0;
            int right = nums.Length - 1;
            int i = 0;
            while (left <= right)
            {
                int min = (left + right) / 2;
                int midValue = nums[min];
                if (target == midValue)
                {
                    return min;
                }
                if (target > midValue)
                {
                    left = min + 1;
                    i = left;
                }
                else
                {
                    right = min - 1;
                    i = min;
                }
            }

            return i;
        }

        #endregion 35. Search Insert Position

        #region 804. Unique Morse Code Words
        public static int UniqueMorseRepresentations(string[] words)
        {
            string[] codes = new string[] { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };


            List<string> newWords = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                string nw = string.Empty;
                for (int j = 0; j < word.Length; j++)
                {
                    int charIndex = word[j] - 'a';
                    nw += codes[charIndex];
                }

                bool test = true;
                for (int j = 0; j < newWords.Count; j++)
                {
                    if (nw == newWords[j])
                    {
                        test = false;
                        break;
                    }
                }

                if (test)
                {
                    newWords.Add(nw);
                }

                //newWords[i] = nw;
            }


            return newWords.Count;
        }

        #endregion 804. Unique Morse Code Words

        #region 33. Search in Rotated Sorted Array
        public static int SearchInRotatedSortedArray(int[] nums, int target)
        {

            int lI = 0;
            int rI = nums.Length - 1;
            while (lI <= rI)
            {
                int mI = (lI + rI) / 2;
                if (target == nums[mI])
                {
                    return mI;
                }
                else if (nums[mI] >= nums[lI])
                {
                    if (target <= nums[mI] && target >= nums[lI])
                    {
                        rI = mI - 1;
                    }
                    else
                    {
                        lI = mI + 1;
                    }
                }
                else
                {

                    if (target >= nums[mI] && target <= nums[rI])
                    {
                        lI = mI + 1;
                    }
                    else
                    {
                        rI = mI - 1;
                    }
                }
            }
            return -1;
        }

        #endregion 33. Search in Rotated Sorted Array


        #region 34. Find First and Last Position of Element in Sorted Array

        public static int[] SearchRange(int[] nums, int target)
        {
            int[] arr = new int[2];
            arr[0] = SearchRangeFirstIndex(nums, target);
            arr[1] = SearchRangeLastIndex(nums, target);
            return arr;
        }

        private static int SearchRangeFirstIndex(int[] nums, int target)
        {
            int index = -1;
            int lIndex = 0;
            int rIndex = nums.Length - 1;

            while (lIndex <= rIndex)
            {
                int mIndex = lIndex + (rIndex - lIndex) / 2;
                if (target == nums[mIndex])
                {
                    index = mIndex;
                }

                if (target <= nums[mIndex])
                {
                    rIndex = mIndex - 1;
                }
                else
                {
                    lIndex = mIndex + 1;
                }
            }
            return index;
        }

        private static int SearchRangeLastIndex(int[] nums, int target)
        {
            int index = -1;
            int lIndex = 0;
            int rIndex = nums.Length - 1;

            while (lIndex <= rIndex)
            {
                int mIndex = lIndex + (rIndex - lIndex) / 2;
                if (target == nums[mIndex])
                {
                    index = mIndex;
                }

                if (target >= nums[mIndex])
                {
                    lIndex = mIndex + 1;
                }
                else
                {
                    rIndex = mIndex - 1;
                }
            }
            return index;
        }

        #endregion 34. Find First and Last Position of Element in Sorted Array

        #region 153. Find Minimum in Rotated Sorted Array

        public static int FindMin_153(int[] nums)
        {
            int lIndex = 0;
            int rIndex = nums.Length - 1;
            bool nTimeRoteted = true;
            if (nums.Length == 0) return nums[0];
            if (nums[0] > nums[nums.Length - 1])
            {
                nTimeRoteted = false;
            }

            if (!nTimeRoteted)
            {
                while (lIndex <= rIndex)
                {
                    int mIndex = lIndex + (rIndex - lIndex) / 2;
                    if (mIndex > 0 && mIndex < (nums.Length - 1))
                    {
                        if (nums[mIndex] < nums[mIndex - 1] && nums[mIndex] < nums[mIndex + 1])
                        {
                            return nums[mIndex];
                        }
                        else if (nums[mIndex] > nums[mIndex - 1] && nums[mIndex] > nums[mIndex + 1])
                        {
                            return nums[mIndex + 1];
                        }
                        else
                        {
                            if (nums[mIndex] >= nums[lIndex] && nums[mIndex] > nums[rIndex])
                            {
                                lIndex = mIndex + 1;
                            }
                            else if (nums[mIndex] >= nums[lIndex] && nums[mIndex] < nums[rIndex])
                            {
                                rIndex = mIndex - 1;
                            }
                            else if (nums[mIndex] < nums[lIndex] && nums[mIndex] < nums[rIndex])
                            {
                                rIndex = mIndex - 1;
                            }
                        }
                    }
                    else
                    {
                        if (mIndex == nums.Length - 1)
                        {
                            return nums[mIndex];
                        }
                        else if (mIndex == 0)
                        {
                            return nums[1];
                        }
                    }

                }
            }
            else
            {
                return nums[0];
            }

            return 0;
        }
        #endregion 153. Find Minimum in Rotated Sorted Array

        #region 154. Find Minimum in Rotated Sorted Array II

        //1.if the array is pivoted (n-1) times then the end value must be less or equal to start value.
        //2.if the array is pivoted n times then the start value must be the minimum value.In that case,the start value must be less than end value
        //3. *//
        public static int FindMin_154(int[] nums)
        {
            int lIndex = 0;
            int lElement = nums[lIndex];
            int rIndex = nums.Length - 1;
            int rElement = nums[rIndex];
            bool nTimeRoteted = true;
            if (nums.Length == 0) return nums[0];
            if (nums[0] >= nums[nums.Length - 1])
            {
                nTimeRoteted = false;
            }

            if (!nTimeRoteted)
            {
                while (lIndex <= rIndex)
                {
                    int mIndex = lIndex + (rIndex - lIndex) / 2;
                    int mElement = nums[mIndex];
                    if (mIndex > 0 && mIndex < nums.Length - 1)
                    {
                        if (mElement < nums[mIndex - 1] && mElement < nums[mIndex + 1])
                        {
                            return nums[mIndex];
                        }
                        else if (mElement < nums[mIndex - 1] && mElement < rElement)
                        {
                            if (mElement == nums[mIndex + 1])
                            {
                                lIndex = mIndex + 1;
                            }
                            else
                            {
                                rIndex = mIndex - 1;
                            }
                        }
                    }

                }
                return 0;
            }
            else
            {
                return nums[0];
            }


        }
        #endregion 154. Find Minimum in Rotated Sorted Array II


        #region 1523. Count Odd Numbers in an Interval Range
        public static int CountOdds(int low, int high)
        {
            bool lowEven = low % 2 == 0 ? true : false;
            bool highEven = high % 2 == 0 ? true : false;
            int totalDigit = ((high - low) + 1);
            int oddNum = 0;
            if (lowEven && highEven)
            {
                oddNum = totalDigit / 2;
            }
            else if (lowEven && !highEven)
            {
                oddNum = totalDigit / 2;
            }
            else if (!lowEven && !highEven)
            {
                oddNum = (totalDigit / 2) + 1;
            }
            else if (!lowEven && highEven)
            {
                oddNum = totalDigit / 2;
            }

            return oddNum;
        }
        #endregion 1523. Count Odd Numbers in an Interval Range

        #region 1281. Subtract the Product and Sum of Digits of an Integer
        public static int SubtractProductAndSum(int n)
        {
            int result = 0;
            int rest = 0;
            int product = 1;
            int sum = 0;
            while (n / 10 > 0)
            {
                rest = n % 10;
                product *= rest;
                sum += rest;
                n = n / 10;
            }
            product *= n;
            sum += n;
            result = product - sum;
            return result;
        }
        #endregion 1281. Subtract the Product and Sum of Digits of an Integer

        #region 1822. Sign of the Product of an Array
        public static int ArraySign(int[] nums)
        {
            int result = 0;
            double product = 1;
            foreach (var item in nums)
            {
                product *= item;
            }
            if (product < 0)
                result = -1;
            else
                result = product > 0 ? 1 : 0;
            return result;
        }
        #endregion 1822. Sign of the Product of an Array

        #region 976. Largest Perimeter Triangle
        public static int LargestPerimeter(int[] nums)
        {
            int a = nums[0];
            int b = nums[1];
            int c = nums[2];
            int maxPerimetr = 0;
            if (nums.Length == 3)
            {
                if (a + b > c && b + c > a && a + c > b)
                {
                    maxPerimetr = a + b + c;
                }
            }
            else  //3, 6, 2, 3 
            {
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    int max = i;
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[j] > nums[max])
                        {
                            max = j;
                        }
                    }
                    if (max != i)
                    {
                        int temp = nums[i];
                        nums[i] = nums[max];
                        nums[max] = temp;
                    }
                }

                int k = 0;
                while (nums.Length - k >= 3)
                {
                    a = nums[k];
                    b = nums[k + 1];
                    c = nums[k + 2];
                    if (a + b > c && b + c > a && a + c > b)
                    {
                        maxPerimetr = a + b + c;
                        break;
                    }
                    else
                    {
                        k++;
                    }

                }

            }
            return maxPerimetr;
        }
        #endregion 976. Largest Perimeter Triangle

    }
}
