// Last updated: 29/07/2025, 17:44:01
public class Solution {
    public bool IsPalindrome(int x) {
        int original = x;
        int mirrored = 0;
            for (; x > 0; x /= 10) {
                int digit = x % 10;
                mirrored = mirrored * 10 + digit;
            }
            return original == mirrored;
    }
}