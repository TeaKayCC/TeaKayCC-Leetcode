public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        // brute force method?
        // that is, calculate the sum of every combination of number within the input array nums
        int result;
        int[] resultArray = new int[2];

        for (int i = 0; i < nums.Length; i++)
        {
            // brute force comparison
            for (int x = 0; x < nums.Length; x++) 
            {
                if (i == x) // in the event the indices are the same, continue
                {
                    continue;
                }
                else // compare and see if they match the target 
                {
                    result = nums[i] + nums[x];
                    if (result == target) {

                        resultArray[0] = i;
                        resultArray[1] = x;
                        return resultArray;        
                    }
                }
            }
        }
        return null;
    }
}