#nullable disable
namespace TopInterview150;

public class RemoveDuplicatesFromSortedListII
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        if (head == null)
            return null;

        ListNode current = head;
        ListNode next = head.next;

        while (next != null)
        {
            if (current.val != next.val && next.val != next.next?.val)
            {
                current = next;
                next = current.next;
            }
            else
            {
                int oldVal = next.val;
                next = FindNewNext(next);

                if (current.val != oldVal)
                {
                    current.next = next;
                }
                else
                {
                    head = next;
                    current = head;
                    next = next?.next;
                }
            }
        }

        return head;
    }

    private ListNode FindNewNext(ListNode node)
    {
        ListNode next = node.next;

        while (next?.val == node.val)
            next = next.next;

        return next;
    }
}

public class ListNode
{
    public int val;

    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
