using System.Numerics;

ListNode AddTwoNumbers(ListNode l1, ListNode l2)
{
    ListNode resultNode = new ListNode();
    ListNode l1_copy = l1;
    ListNode l2_copy = l2;
    ListNode currentNode = resultNode;
    int carry = 0;

    while (l1_copy != null || l2_copy != null)
    {
        int x = (l1_copy != null) ? l1_copy.val : 0;
        int y = (l2_copy != null) ? l2_copy.val : 0;
        int sum = carry + x + y;
        carry = sum / 10;
        currentNode.next = new ListNode(sum % 10);
        currentNode = currentNode.next;
        if (l1_copy != null) l1_copy = l1_copy.next;
        if (l2_copy != null) l2_copy = l2_copy.next;
    }

    if (carry > 0)
    {
        currentNode.next = new ListNode(carry);
    }

    return resultNode.next;
}


ListNode l1 = new(9);
ListNode l2 = new ListNode(1);
l2.next = new ListNode(9);
l2.next.next = new ListNode(9);
l2.next.next.next = new ListNode(9);
l2.next.next.next.next = new ListNode(9);
l2.next.next.next.next.next = new ListNode(9);
l2.next.next.next.next.next.next = new ListNode(9);
l2.next.next.next.next.next.next.next = new ListNode(9);
l2.next.next.next.next.next.next.next.next = new ListNode(9);
l2.next.next.next.next.next.next.next.next.next = new ListNode(9);

ListNode result = AddTwoNumbers(l1, l2);

while (result != null)
{
    Console.Write(result.val + " ");
    result = result.next;
}