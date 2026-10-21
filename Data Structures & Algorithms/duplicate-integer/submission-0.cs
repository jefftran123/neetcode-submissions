public class Solution {
    public bool hasDuplicate(int[] nums) {
        int numsLength = nums.Length;
        int[] tempArray = new int[numsLength];
        int tempArrayLength = 0;

        for (int i = 0; i < numsLength; i++) {
            for (int j = 0; j < tempArrayLength; j++) {
                if (tempArray[j] == nums[i]) return true;
            }
            tempArray[tempArrayLength] = nums[i];
            tempArrayLength++;
        }

        return false;
    }
}