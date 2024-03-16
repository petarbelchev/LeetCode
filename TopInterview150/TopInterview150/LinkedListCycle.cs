namespace TopInterview150;

public class LinkedListCycle
{
    public bool HasCycle(ListNode head)
    {
        if (head is null) return false;

        ListNode first = head;
        ListNode second = head;

        while (first.next is not null
            && second.next?.next is not null)
        {
            first = first.next;
            second = second.next.next;

            if (first == second) return true;
        }

        return false;
    }

    public class ListNode
    {
        public int val;
        public ListNode? next;

        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }
}
