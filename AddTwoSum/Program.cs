using System.Numerics;

ListNode AddTwoNumbers(ListNode l1, ListNode l2)
{
    BigInteger totalValue = GetListNodeValue(l1) + GetListNodeValue(l2);
    string total_string = totalValue.ToString();

    ListNode newNode = new (0);
    ListNode currNode = newNode;

    for (int i = total_string.Length - 1; i >= 0; i--)
    {
        int digit = int.Parse(total_string[i].ToString());
        currNode.next = new ListNode(digit);
        currNode = currNode.next;
    }

    return newNode.next;
}

BigInteger GetListNodeValue(ListNode listNode)
{
    ListNode node = listNode;
    string str_node = "";

    while (node != null)
    {
        str_node = node.val.ToString() + str_node;
        node = node.next;
    }

    return BigInteger.Parse(str_node);
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