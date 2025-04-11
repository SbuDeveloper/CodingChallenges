/*https://medium.com/@arifimran5/fast-and-slow-pointer-pattern-in-linked-list-43647869ac99*/


 //Definition for singly-linked list.
 public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
 }
 
public class Solution
{
    //looping over all the nodes and finding length. Then run the next loop half the length of the list.
     public ListNode MiddleNode(ListNode head) {
        ListNode temp = head;
        var length = 0;
        while(temp!=null)
        {
            temp = head.next;
            length++;
        }

        ListNode mid = head;
        for (int i = 0; i < length/2; i++)
        {
            mid = mid.next;
        }

        return mid;
    }

    //Using fast and slow pointer
     public ListNode MiddleNodeFastSlowPointers(ListNode head) {
        ListNode fast = head;
        ListNode slow = head;

        while (fast!=null && fast.next!=null)
        {
            fast = fast.next.next;
            slow = slow.next;
        }

        return slow;
    }
}