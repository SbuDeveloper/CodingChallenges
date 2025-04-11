
public class solution4
{
    public ListNode detectCycle(ListNode head, int n) 
    {
        ListNode slow = head;
        ListNode fast = head;

        while(fast!=null && fast.next!=null){
            slow = slow.next;
            fast = fast.next.next;

            if(slow==fast){
                slow = head; //moved slow to head

            // moving fast and slow pointer by 1 step until they meet again
                while(fast!=slow){
                    slow = slow.next;
                    fast = fast.next;
                }
                return slow;
            }
     }
     return null;
    }
}