public class Solution {
    public bool hasDuplicate(int[] nums) {
        int numsLength = nums.Length;
        HashSet<int> set = new HashSet<int>(nums);

        if (set.Count != numsLength) return true;

        return false;
    }
}