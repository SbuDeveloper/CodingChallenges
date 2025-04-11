

public class Solution2 {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode fast = head;
        ListNode slow = head;
        
        // if there is only one node in list, then we can only delete that
        if(head.next==null) return null;

        //move fast ptr forward by n
        for(int i=0;i<n;i++){
            fast = fast.next;
        }

        // if fast becomes null, means we want to delete head
        if(fast == null) return head.next;

        while(fast.next!=null){
          fast = fast.next;
          slow = slow.next;
        }

        // break link from next
        slow.next = slow.next.next;
            
        // return head
        return head;
    }

     
}