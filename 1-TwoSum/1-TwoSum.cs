// Last updated: 29/07/2025, 15:55:09
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for(int i = 0; i < nums.Count() - 1; i++){
            for(int j = i + 1; j < nums.Count(); j++){
                if(nums[i] + nums[j] == target){
                    return [i,j];
                }
            }
        }
        return null;
    }
}