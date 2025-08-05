// Last updated: 05/08/2025, 17:30:03
public class Solution {
    public int RomanToInt(string s) {
        
        Dictionary<char, int> hashMap = new Dictionary<char, int>()
        {
            {'M', 1000},
            {'D', 500},
            {'C', 100},
            {'L', 50},
            {'X', 10},
            {'V', 5},
            {'I', 1}
        };

        int total = 0;

        for(int i = 0; i < s.Length; i++){
            if (i + 1 < s.Length && hashMap[s[i]] < hashMap[s[i + 1]]) {
                total += hashMap[s[i + 1]] - hashMap[s[i]];
                i++;
            } else {
                total += hashMap[s[i]];
            }
        }

        return total;
    }
}