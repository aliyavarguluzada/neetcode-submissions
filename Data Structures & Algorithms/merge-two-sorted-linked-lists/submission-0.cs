/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
 
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
         ListNode k = new();

 ListNode l = k;


 while (list1 is not null && list2 is not null)
 {
     if (list1.val < list2.val)
     {
         l.next = list1;
         list1 = list1.next;
     }
     else
     {
         l.next = list2;
         list2 = list2.next;

     }
                 l = l.next;

 }


 if (list1 is not null)
 {
     l.next = list1;
 }
 else
 {
     l.next = list2;
 }

 return k.next;
    }
}