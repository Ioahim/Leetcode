// Last updated: 07/08/2025, 18:38:48
public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string prefix = "";

        for(int i = 0; i < strs[0].Length; i++){
            char c = strs[0][i];
            for(int j = 1; j < strs.Length; j++){
                if(i >= strs[j].Length || strs[j][i] != c){
                    return prefix;
                }
            }
            prefix += c;
        }

        return prefix;
    }
}