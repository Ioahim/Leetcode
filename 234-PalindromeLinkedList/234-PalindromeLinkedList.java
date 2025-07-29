// Last updated: 29/07/2025, 15:55:10
class Solution {
    public boolean isPalindrome(ListNode head) {
        // Edge case: if the list is empty or has only one element, it is a palindrome
        if (head == null || head.next == null) {
            return true;
        }

        // Find the middle of the list
        ListNode slow = head;
        ListNode fast = head;
        while (fast.next != null && fast.next.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }

        // Reverse the second half of the list
        ListNode prev = null;
        ListNode curr = slow.next;
        while (curr != null) {
            ListNode temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;
        }
        slow.next = prev;

        // Compare the first and second halves of the list
        ListNode l1 = head;
        ListNode l2 = slow.next;
        while (l2 != null) {
            if (l1.val != l2.val) {
                return false;
            }
            l1 = l1.next;
            l2 = l2.next;
        }

        return true;
    }
}