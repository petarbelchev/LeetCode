namespace Tests;

internal class RemoveDuplicatesFromSortedListIITests
{
    [Test]
    [TestCase(new int[] { 1, 2, 3, 3, 4, 4, 5 }, new int[] { 1, 2, 5 })]
    [TestCase(new int[] { 1, 1, 1, 2, 3 }, new int[] { 2, 3 })]
    [TestCase(new int[] { 1, 1 }, null)]
    public void Tests(int[] input, int[] expected)
    {
        // Arrange
        var instance = new RemoveDuplicatesFromSortedListII();
        ListNode? head = GetHead(input);
        ListNode? expectedHead = GetHead(expected);

        // Act
        ListNode actual = instance.DeleteDuplicates(head);

        // Assert
        Assert.Multiple(() =>
        {
            while (actual != null && expectedHead != null)
            {
                Assert.That(actual.val, Is.EqualTo(expectedHead.val));
                actual = actual.next;
                expectedHead = expectedHead.next;
            }

            Assert.That(actual, Is.Null);
            Assert.That(expectedHead, Is.Null);
        });
    }

    private ListNode? GetHead(int[] input)
    {
        if (input == null)
            return null;

        ListNode head = new(input[0]);
        ListNode current = head;

        for (int i = 1; i < input.Length; i++)
        {
            current.next = new ListNode(input[i]);
            current = current.next;
        }

        return head;
    }
}
