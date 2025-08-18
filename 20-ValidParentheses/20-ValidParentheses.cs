// Last updated: 18/08/2025, 20:22:14
public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
         Dictionary<char, char> hashMap = new Dictionary<char, char>()
        {
            {')', '('},
            {'}', '{'},
            {']', '['},
        };
        for(int i = 0; i < s.Length; i++){
            if (hashMap.ContainsKey(s[i])) {
                if (stack.Count == 0 || stack.Pop() != hashMap[s[i]]) {
                    return false;
                }
            } else {
                stack.Push(s[i]);
            }
        }

        return stack.Count == 0;
    }
}