
public class Solution1
{
    public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
 }  

    public ListNode getNodeFromEnd(ListNode head, int n) 
    {
        ListNode fast = head;
        ListNode slow = head;

        //moving fast ahead by n, to make gap
        for(int i=0;i<n;i++){
            fast = fast.next; 
        }
        // when the fast reaches end, slow will be the nth node from end
        while(fast.next!=null){
            fast = fast.next;
            slow = slow.next;
        }
        return slow; 
    }

    public ListNode DeletetheMiddleNode(ListNode head) {
        ListNode dummy = new ListNode(0, head);
        ListNode slow = dummy, 
        fast = head;
        while (fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }
        slow.next = slow.next.next;
        return dummy.next;
    }

    public ListNode RemoveLinkedListElements(ListNode head, int val) {
        ListNode newHead = null;
        ListNode newTail = null;
        var current = head;
        while (current != null)
        {
            if (current.val != val)
            {
                if (newHead == null)
                {
                    newHead = newTail = current;
                }
                else
                {
                    newTail.next = current;
                    newTail = current;
                }
            }
            current = current.next;
        }
        if (newTail != null) newTail.next = null;
        return newHead;
    }


}

