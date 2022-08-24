# Leetcode_Practice

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
                            lIndex = mIndex + 1;
                        }
                        else if (mElement== nums[mIndex - 1] && mElement < rElement)
                        {
                            rIndex = mIndex - 1;
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
