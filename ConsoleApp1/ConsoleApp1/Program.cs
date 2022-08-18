// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, Leet Code !");


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
int[] nums = { 1, 3, 5, 6 };
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
        int rI = nums.Length-1;
        while (lI<=rI)
        {
            int mI = (lI + rI) / 2;
            if (target == nums[mI])
            {
                return mI;
            }
            else if (nums[mI] >= nums[lI])
            {
                if (target <= nums[mI]&& target >= nums[lI])
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
        int[] result = { -1, -1 };




        return result;
    }

    #endregion 34. Find First and Last Position of Element in Sorted Array
}

