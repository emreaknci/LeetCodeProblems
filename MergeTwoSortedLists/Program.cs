﻿// Problem: https://leetcode.com/problems/merge-two-sorted-lists/



ListNode MergeTwoLists(ListNode list1, ListNode list2)
{

    if (list1 == null) return list2;
    if (list2 == null) return list1;

    ListNode head;
    if (list1.val < list2.val)
    {
        head = list1;
        list1 = list1.next;
    }
    else
    {
        head = list2;
        list2 = list2.next;
    }

    ListNode current = head;

    while (list1 != null && list2 != null)
    {
        if (list1.val <= list2.val)
        {
            current.next = list1;
            list1 = list1.next;
        }
        else
        {
            current.next = list2;
            list2 = list2.next;
        }
        current = current.next;
    }

    if (list1 != null)
        current.next = list1;
    else if (list2 != null)
        current.next = list2;


    return head;
}


ListNode list1 = new ListNode(1);
list1.next = new ListNode(2);
list1.next.next = new ListNode(4);


ListNode list2 = new ListNode(1);
list2.next = new ListNode(3);
list2.next.next = new ListNode(5);
list2.next.next.next = new ListNode(6);


var result = MergeTwoLists(list1, list2);

Console.ReadLine();
